using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace SilverlightUploadingMVC.Utils
{
	/// <summary>
	/// 	This class allows access to the internal MimeMapping-Class in System.Web
	/// </summary>
	public class MimeMappingWrapper
	{
		private static readonly string[] ImageTypes =
			{
				"image/png", "image/pjpeg", "image/jpeg", "image/jpg", "image/gif", "image/bmp"
				, "image/tiff"
			};

		private static readonly MethodInfo GetMimeMappingMethod;

		static MimeMappingWrapper()
		{
			// dirty trick - Assembly.LoadWIthPartialName has been deprecated        
			//Assembly ass = Assembly.LoadWithPartialName("System.Web");
			Assembly ass = Assembly.GetAssembly(typeof(HttpApplication));
			Type mimeMappingType = ass.GetType("System.Web.MimeMapping");

			// PNG is missing from the list, try to add it
			// for some reason this doesn't work!!
			//AddMimeMapping("png", "image/png", ref mimeMappingType);
			//MethodInfo method = mimeMappingType.GetMethod("AddMimeMapping", BindingFlags.NonPublic | BindingFlags.Static);
			//method.Invoke(null, new object[] { "png", "image/png" });
			GetMimeMappingMethod = mimeMappingType.GetMethod("GetMimeMapping",
																											 BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance |
																											 BindingFlags.Public | BindingFlags.FlattenHierarchy);
		}

		/// <summary>
		/// 	Returns a MIME type depending on the passed files extension
		/// </summary>
		/// <param name = "filename">File to get a MIME type for</param>
		/// <returns>MIME type according to the files extension</returns>
		public static string GetMimeMapping(string filename)
		{
			// UGLY!! REFACTOR LATER!!
			if (filename.Trim().EndsWith(".png", StringComparison.OrdinalIgnoreCase))
				return "image/png";

			return (string)GetMimeMappingMethod.Invoke(null, new object[] { filename });
		}

		public static bool IsImage(string filename)
		{
			return ImageTypes.Contains(GetMimeMapping(filename), StringComparer.OrdinalIgnoreCase);
		}
	}
}