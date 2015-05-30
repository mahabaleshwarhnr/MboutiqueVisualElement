using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;


namespace MboutiqueVisualElement.Droid
{
	public static class FileAccessHelper
	{
		public static string GetLocalFilePath (string dbFileName)
		{
			string docFolder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
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
				using (var br = new BinaryReader (Application.Context.Assets.Open ("Mboutiquedatabse.db3"))) {
					using (var bw = new BinaryWriter (new FileStream (dbPath, FileMode.Create))) {
						byte[] buffer = new byte[2048];
						int length = 0;
						while ((length = br.Read (buffer, 0, buffer.Length)) > 0) {
							bw.Write (buffer, 0, length);
						}
					}
				}
			}
		}
	}

}

