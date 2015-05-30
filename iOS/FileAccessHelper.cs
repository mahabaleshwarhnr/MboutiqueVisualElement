using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.IO;

namespace MboutiqueVisualElement.iOS
{
	public static class FileAccessHelper
	{
		public static string GetLocalFilePath (string dbFileName)
		{
			string docFolder = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine (docFolder, "..", "Library", "Databases");

			if (!Directory.Exists (libFolder)) {
				Directory.CreateDirectory (libFolder);
			}

			string dbPath = Path.Combine (libFolder, dbFileName);

			CopyDatabaseIfNotExists (dbPath);

			return dbPath;

		}

		private static void CopyDatabaseIfNotExists (string dbPath)
		{
			if (!File.Exists (dbPath)) {
				var existingDb = NSBundle.MainBundle.PathForResource ("Mboutiquedatabse", "db3");
				File.Copy (existingDb, dbPath);
			}
		}
	}
	

}

