#region Usings

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.Mvc;

#endregion

namespace SilverlightUploadingMVC.Utils
{
	public static class UploadsManager
	{
		#region Props

		private const string FilesSubdir = "attachments";
		private const string TempExtension = "_temp";

		/// <summary>
		///     Upload directory physical server path
		/// </summary>
		public static string UploadFolderPhysicalPath { get; set; }

		/// <summary>
		///     Upload directory relative server path
		/// </summary>
		public static string UploadFolderRelativePath { get; set; }

		// dependencies (injected)

		#endregion

		#region Ctor

		static UploadsManager()
		{
			// get UploadFolder from web.config
			if (String.IsNullOrWhiteSpace(WebConfigurationManager.AppSettings["UploadFolder"]))
				UploadFolderRelativePath = @"~/upload";
			else
				UploadFolderRelativePath = WebConfigurationManager.AppSettings["UploadFolder"];

			UploadFolderPhysicalPath = HostingEnvironment.MapPath(UploadFolderRelativePath);

			if (!Directory.Exists(UploadFolderPhysicalPath))
				Directory.CreateDirectory(UploadFolderPhysicalPath);
		}

		#endregion

		#region Saving

		[SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
		public static bool SaveFile(Stream stream, string fileName, string parameters, bool firstChunk, bool lastChunk,
		                            long startByte)
		{
			string tempPath = string.Empty, targetPath = string.Empty;
			long fileLength = 0;

			try
			{
				string tempFileName = GetTempFilePath(fileName);

				// split up custom parameters for content type information
				// must match the format in initParams Silverlight control property 
				var fileOwnerParams = SplitParams(parameters);
				if (fileOwnerParams.Length > 0)
				{
					string contentType = fileOwnerParams[0];
					int contentId = int.Parse(fileOwnerParams[1]);

					tempPath = GetTempFilePath(tempFileName);
					targetPath = GetTargetFilePath(fileName, contentType, contentId, string.Empty, FilesSubdir);

					//Is it the first chunk? Prepare by deleting any existing files with the same name
					if (firstChunk)
					{
						//Delete temp file
						if (File.Exists(tempPath))
							File.Delete(tempPath);

						//Delete target file
						if (File.Exists(targetPath))
							File.Delete(targetPath);
					}

					// Prepare directory structure if non existant
					var file = new FileInfo(targetPath);
					if (file.Directory != null && !file.Directory.Exists)
						file.Directory.Create();

					using (FileStream fs = File.Open(tempPath, FileMode.Append))
					{
						if (stream.Length > 0)
						{
							fileLength = stream.Length;
							SaveFile(stream, fs);
						}
						fs.Close();
					}

					//Is it the last chunk? Then finish up...
					if (lastChunk)
					{
						//Rename file to original file
						File.Move(tempPath, targetPath);
					}
				}
			}
			catch (Exception)
			{
				// if something went wrong, remove the uploaded file to prevent inconsistent files buildup
				if (File.Exists(targetPath))
					File.Delete(targetPath);

				// remove the temp file to prevent temp files buildup
				if (File.Exists(tempPath))
					File.Delete(tempPath);

				return false;
			}
			finally
			{
				// remove the temp file to prevent temp files buildup
				if (lastChunk && File.Exists(tempPath))
					File.Delete(tempPath);
			}
			return true;
		}

		/// <summary>
		/// Returns a string array of parameters that were sent from the Silverlight upload control
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public static string[] SplitParams(string parameters)
		{
			return parameters.Split(';');
		}

		/// <summary>
		/// Save the contents of the Stream to a file
		/// </summary>
		/// <param name="stream"></param>
		/// <param name="fs"></param>
		public static void SaveFile(Stream stream, FileStream fs)
		{
			var buffer = new byte[4096];
			int bytesRead;
			while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
			{
				fs.Write(buffer, 0, bytesRead);
			}
		}

		#endregion

		#region Physical paths methods for IO operations

		public static string GetTempFilePath(string fileName)
		{
			fileName = fileName + TempExtension;
			return Path.Combine(@HostingEnvironment.ApplicationPhysicalPath, Path.Combine(UploadFolderPhysicalPath, fileName));
		}

		public static string GetTargetFilePath(string fileName, string contentType, int contentId, string culture = "",
		                                       string optionalSubdir = "")
		{
			return Path.Combine(UploadFolderPhysicalPath, contentType, culture, contentId.ToString(CultureInfo.InvariantCulture),
			                    optionalSubdir, fileName);
		}

		#region Deletions

		public static void DeleteFile(string path)
		{
			if (File.Exists(path))
				File.Delete(path);
		}

		#endregion

		#endregion
	}
}