using System.Collections.Generic;
using System.IO;

namespace TV_Addiction
{
    static class Settings
    {
        public static string VlcPath { get; set; }
        public static string UserDataFile { get; set; }
        public static List<string> VideoExtensions { get; set; }
        public static List<string> SubtitleExtensions { get; set; }

        public static void Load(string file = "config.xml")
        {
            VideoExtensions = new List<string> { ".mkv", ".avi", ".mp4" };
            SubtitleExtensions = new List<string> { ".srt", ".sub" };
            UserDataFile = "userdata.xml";
            string[] possibleVlcPaths = new string[] { @"C:\Program Files\VideoLAN\VLC\vlc.exe", @"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe" };
            
            foreach (string path in possibleVlcPaths)
            {
                if (File.Exists(path))
                {
                    VlcPath = path;
                    break;
                }
            }

            if (VlcPath == null)
                throw new FileNotFoundException("VLC not found!");
        }
    }
}
