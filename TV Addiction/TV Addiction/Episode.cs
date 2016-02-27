using System;
using System.Xml;

namespace TV_Addiction
{
    class Episode : IComparable
    {
        public string Path { get; set; }
        public string SubtitlePath { get; set; }
        int season, episodeNumber;

        public Episode(string path)
        {
            Path = path;
            season = ExtractSeason(path);
            episodeNumber = ExtractEpisodeNumber(path);
        }

        public static int ExtractSeason(string path)
        {
            for (int i = 0; i < path.Length - 2; i++)
            {
                if (path[i].ToString().ToUpper() == "S")
                {
                    if (path[i + 1] >= '0' && path[i + 1] <= '9' && path[i + 2] >= '0' && path[i + 2] <= '9')
                        return 10 * (Convert.ToInt32(path[i + 1]) - 48) + (Convert.ToInt32(path[i + 2]) - 48);
                }
            }

            throw new ArgumentException("Improper path");
        }

        public static int ExtractEpisodeNumber(string path)
        {
            for (int i = 0; i < path.Length - 2; i++)
            {
                if (path[i].ToString().ToUpper() == "E")
                {
                    if (path[i + 1] >= '0' && path[i + 1] <= '9' && path[i + 2] >= '0' && path[i + 2] <= '9')
                        return 10 * (Convert.ToInt32(path[i + 1]) - 48) + (Convert.ToInt32(path[i + 2]) - 48);
                }
            }

            throw new ArgumentException("Improper path");
        }

        public int CompareTo(object obj)
        {
            Episode other = obj as Episode;
            if (season == other.season && episodeNumber == other.episodeNumber)
                return 0;
            else if (season < other.season || season == other.season && episodeNumber < other.episodeNumber)
                return -1;
            else
                return 1;
        }

        public int Season
        {
            get
            {
                return season;
            }
        }

        public int EpisodeNumber
        {
            get
            {
                return episodeNumber;
            }
        }

        public void WriteToXml(XmlTextWriter writer)
        {
            writer.WriteStartElement("episode");
            writer.WriteElementString("path", Path);
            if (SubtitlePath != null)
                writer.WriteElementString("subtitle", SubtitlePath);
            writer.WriteElementString("season", Season.ToString());
            writer.WriteElementString("episode-number", EpisodeNumber.ToString());
            writer.WriteEndElement();
        }
    }
}