#region Header
// -----------------------------------------------------------------------
// SongScreenerMvc-SongScreenerMvc-Unity.cs 
// clijiac  2013-01-01
// -----------------------------------------------------------------------
#endregion

using System;
using System.IO;

namespace SongScreenerMvc.Utility
{
    public  static class VUtility
    {
        static readonly string[] MediaExtensions = {
        //".PNG", ".JPG", ".JPEG", ".BMP", ".GIF", //etc
        ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA", //etc
        //".AVI", ".MP4", ".DIVX", ".WMV", //etc
    };

        public static bool IsAudioFile(string path)
        {
            return -1 != Array.IndexOf(MediaExtensions, Path.GetExtension(path).ToUpperInvariant());
        }
    }
}