﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
#warning Method WIP
            VideoExtensions = new List<string> { ".mkv", ".avi", ".mp4" };
            SubtitleExtensions = new List<string> { ".srt", ".sub" };
            UserDataFile = "userdata.xml";
        }

        public static void Save()
        {
#warning Method WIP
        }
    }
}
