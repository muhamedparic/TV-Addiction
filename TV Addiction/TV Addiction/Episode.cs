using System;

namespace TV_Addiction
{
    class Episode : IComparable
    {
        public string Path { get; set; }
        public string SubtitlePath { get; set; }
        int season, episodeNumber;

        public Episode(string path, int season, int episodeNumber)
        {
            Path = path;
            this.season = season;
            this.episodeNumber = episodeNumber;
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
    }
}