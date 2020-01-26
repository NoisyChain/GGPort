﻿using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace GGPort {
	public static class LogUtil {
		public static event SessionCallbacks.LogDelegate LogCallback;

		private static FileStream logFileStream;
		private static long start;

		public static void Log(string msg) {
#if UNITY_EDITOR
			Debug.Log(msg);
#elif DEBUG || DEVELOPMENT_BUILD
			if (!Platform.GetConfigBool("ggpo.log") || Platform.GetConfigBool("ggpo.log.ignore")) {
				return;
			}
			
			if (logFileStream == null) {
				string filePath = $"log-{Platform.GetProcessID()}.log";

				FileMode fileMode = File.Exists(filePath)
					? FileMode.Append
					: FileMode.OpenOrCreate;
				
				logFileStream = File.Open(filePath, fileMode);
			}
			
			LogToFile(ref logFileStream, msg);
#endif
		}

		public static void LogFailedAssertToFile(
			string msg,
			string callerFilePath,
			string callerName,
			int callerLineNumber
		) {
			if (!string.IsNullOrEmpty(callerFilePath)) {
				string[] callerFilePathSplit = callerFilePath.Split('/', '\\');
				string fileName = callerFilePathSplit[callerFilePathSplit.Length - 1];
				
				msg += $"{Environment.NewLine}{Environment.NewLine}\t\t{nameof(Platform.AssertFailed)} call {(callerLineNumber == -1 ? "In" : "@")} {fileName}";

				if (callerLineNumber != -1) {
					msg += $":{callerLineNumber}";
				}

				if (!string.IsNullOrEmpty(callerName)) {
					msg += $",{Environment.NewLine}\t\tCaller: {callerName}{Environment.NewLine}{Environment.NewLine}";
				}
			}

			Log($"{Environment.NewLine}{msg}");
		}

		public static void LogException(Exception exception) {
			Log($"{Environment.NewLine}{Environment.NewLine}"
			    + $"{exception}"
			    + $"{Environment.NewLine}{Environment.NewLine}");
		}

		private static void LogToFile(ref FileStream fp, string msg) {
			string toWrite = "";

			if (Platform.GetConfigBool("ggpo.log.timestamps")) {
				long t = 0;
				if (start == 0) {
					start = Platform.GetCurrentTimeMS();
				} else {
					t = Platform.GetCurrentTimeMS() - start;
				}
				
				toWrite = $"[{t / 1000}.{t % 1000:000}]: ";
			}

			toWrite += msg;
			LogCallback?.Invoke(toWrite);
			byte[] buffer = Encoding.UTF8.GetBytes(toWrite);

			fp.Write(buffer, 0, buffer.Length);
			fp.Flush();
			fp.Close();
			fp = null;
		}
	}
}