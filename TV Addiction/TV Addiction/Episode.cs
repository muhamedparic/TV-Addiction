using System;

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

        private int ExtractSeason(string path)
        {
            throw new NotImplementedException();
        }

        private int ExtractEpisodeNumber(string path)
        {
            throw new NotImplementedException();
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