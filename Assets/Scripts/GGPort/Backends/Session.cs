﻿using System;
using System.Net;

namespace GGPort {
	public abstract class Session {
		/*
		* Used to being a new GGPO.net session.  The ggpo object returned by ggpo_start_session
		* uniquely identifies the state for this session and should be passed to all other
		* functions.
		*
		* session - An out parameter to the new ggpo session object.
		*
		* cb - A GGPOSessionCallbacks structure which contains the callbacks you implement
		* to help GGPO.net synchronize the two games.  You must implement all functions in
		* cb, even if they do nothing but 'return true';
		*
		* game - The name of the game.  This is used internally for GGPO for logging purposes only.
		*
		* num_players - The number of players which will be in this game.  The number of players
		* per session is fixed.  If you need to change the number of players or any player
		* disconnects, you must start a new session.
		*
		* input_size - The size of the game inputs which will be passsed to ggpo_add_local_input.
		*
		* local_port - The port GGPO should bind to for UDP traffic.
		*/
		public static ErrorCode StartSession(out Session session, ref SessionCallbacks sessionCallbacks, string gameName, int numPlayers, int inputSize, ushort localPort) {
			session = new PeerToPeerBackend(ref sessionCallbacks, gameName, localPort, numPlayers, inputSize);
			return ErrorCode.Success;
		}

		/*
		* Used to being a new GGPO.net sync test session.  During a sync test, every
		* frame of execution is run twice: once in prediction mode and once again to
		* verify the result of the prediction.  If the checksums of your save states
		* do not match, the test is aborted.
		*
		* cb - A GGPOSessionCallbacks structure which contains the callbacks you implement
		* to help GGPO.net synchronize the two games.  You must implement all functions in
		* cb, even if they do nothing but 'return true';
		*
		* game - The name of the game.  This is used internally for GGPO for logging purposes only.
		*
		* num_players - The number of players which will be in this game.  The number of players
		* per session is fixed.  If you need to change the number of players or any player
		* disconnects, you must start a new session.
		*
		* input_size - The size of the game inputs which will be passsed to ggpo_add_local_input.
		*
		* frames - The number of frames to run before verifying the prediction.  The
		* recommended value is 1.
		*/
		public static ErrorCode StartSyncTest(
			out Session session,
			ref SessionCallbacks sessionCallbacks,
			string gameName,
			int numPlayers,
			int inputSize, // TODO remove?
			int frames
		) {
			session = new SyncTestBackend(ref sessionCallbacks, gameName, frames, numPlayers); // TODO was this in the C++?
			return ErrorCode.Success;
		}

		/*
		* Start a spectator session.
		*
		* cb - A GGPOSessionCallbacks structure which contains the callbacks you implement
		* to help GGPO.net synchronize the two games.  You must implement all functions in
		* cb, even if they do nothing but 'return true';
		*
		* game - The name of the game.  This is used internally for GGPO for logging purposes only.
		*
		* num_players - The number of players which will be in this game.  The number of players
		* per session is fixed.  If you need to change the number of players or any player
		* disconnects, you must start a new session.
		*
		* input_size - The size of the game inputs which will be passsed to ggpo_add_local_input.
		*
		* local_port - The port GGPO should bind to for UDP traffic.
		*
		* host_ip - The IP address of the host who will serve you the inputs for the game.  Any
		* player partcipating in the session can serve as a host.
		*
		* host_port - The port of the session on the host
		*/
		public static ErrorCode StartSpectating(
			out Session session,
			ref SessionCallbacks sessionCallbacks,
			string gameName,
			int numPlayers,
			int inputSize,
			ushort localPort,
			IPEndPoint hostEndPoint
		) {
			session = new SpectatorBackend(ref sessionCallbacks, gameName, localPort, numPlayers, inputSize, hostEndPoint);
			return ErrorCode.Success;
		}
		
		/*
		* Should be called periodically by your application to give GGPO.net
		* a chance to do some work.  Most packet transmissions and rollbacks occur
		* in ggpo_idle.
		*
		* timeout - The amount of time GGPO.net is allowed to spend in this function,
		* in milliseconds.
		*/
		public virtual ErrorCode Idle(int timeout) { return ErrorCode.Success; }
		
		/*
		* Must be called for each player in the session (e.g. in a 3 player session, must
		* be called 3 times).
		*
		* player - A GGPOPlayer struct used to describe the player.
		*
		* handle - An out parameter to a handle used to identify this player in the future.
		* (e.g. in the on_event callbacks).
		*/
		public abstract ErrorCode AddPlayer(ref Player player, out PlayerHandle handle);
		
		/*
		* Used to notify GGPO.net of inputs that should be trasmitted to remote
		* players.  ggpo_add_local_input must be called once every frame for
		* all player of type GGPO_PLAYERTYPE_LOCAL.
		*
		* player - The player handle returned for this player when you called
		* ggpo_add_local_player.
		*
		* values - The controller inputs for this player.
		*
		* size - The size of the controller inputs.  This must be exactly equal to the
		* size passed into ggpo_start_session.
		*/
		public abstract ErrorCode AddLocalInput(PlayerHandle player, byte[] value, int size);
		
		/*
		* You should call ggpo_synchronize_input before every frame of execution,
		* including those frames which happen during rollback.
		*
		* values - When the function returns, the values parameter will contain
		* inputs for this frame for all players.  The values array must be at
		* least (size * players) large.
		*
		* size - The size of the values array.
		*
		* disconnect_flags - Indicated whether the input in slot (1 << flag) is
		* valid.  If a player has disconnected, the input in the values array for
		* that player will be zeroed and the i-th flag will be set.  For example,
		* if only player 3 has disconnected, disconnect flags will be 8 (i.e. 1 << 3).
		*/
		public abstract ErrorCode SynchronizeInput(ref Array values, int size, ref int disconnectFlags);
		
		/*
		* You should call ggpo_advance_frame to notify GGPO.net that you have
		* advanced your gamestate by a single frame.  You should call this everytime
		* you advance the gamestate by a frame, even during rollbacks.  GGPO.net
		* may call your save_state callback before this function returns.
		*/
		public virtual ErrorCode AdvanceFrame() { return ErrorCode.Success; }
		public virtual ErrorCode Chat(string text) { return ErrorCode.Success; }
		
		/*
		* Disconnects a remote player from a game.  Will return GGPO_ERRORCODE_PLAYER_DISCONNECTED
		* if you try to disconnect a player who has already been disconnected.
		*/
		public virtual ErrorCode DisconnectPlayer(PlayerHandle handle) { return ErrorCode.Success; }

		/*
		* Used to fetch some statistics about the quality of the network connection.
		*
		* player - The player handle returned from the ggpo_add_player function you used
		* to add the remote player.
		*
		* stats - Out parameter to the network statistics.
		*/
		public virtual ErrorCode GetNetworkStats(out NetworkStats stats, PlayerHandle handle) {
			stats = default;
			return ErrorCode.Success;
		}

		/*
		* Change the amount of frames ggpo will delay local input.  Must be called
		* before the first call to ggpo_synchronize_input.
		*/
		public virtual ErrorCode SetFrameDelay(PlayerHandle player, int frameDelay) {
			return ErrorCode.Unsupported;
		}

		/*
		* Sets the disconnect timeout.  The session will automatically disconnect
		* from a remote peer if it has not received a packet in the timeout window.
		* You will be notified of the disconnect via a GGPO_EVENTCODE_DISCONNECTED_FROM_PEER
		* event.
		*
		* Setting a timeout value of 0 will disable automatic disconnects.
		*
		* timeout - The time in milliseconds to wait before disconnecting a peer.
		*/
		public virtual ErrorCode SetDisconnectTimeout(uint timeout) {
			return ErrorCode.Unsupported;
		}

		/*
		* The time to wait before the first GGPO_EVENTCODE_NETWORK_INTERRUPTED timeout
		* will be sent.
		*
		* timeout - The amount of time which needs to elapse without receiving a packet
		*           before the GGPO_EVENTCODE_NETWORK_INTERRUPTED event is sent.
		*/
		public virtual ErrorCode SetDisconnectNotifyStart(uint timeout) {
			return ErrorCode.Unsupported;
		}

		/*
		* Used to close a session.  You must call ggpo_close_session to
		* free the resources allocated in ggpo_start_session.
		*/
		public virtual ErrorCode CloseSession() {
			return ErrorCode.Success;
		}
	}
}