﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Addiction
{
    class Series
    {
        public string Path { get; set; }
        public string Name { get; set; }

        List<Episode> episodes;
        int nextEpisodeIdx;

        public Series()
        {

        }

        public void AdvanceEpisode()
        {
            if (nextEpisodeIdx < episodes.Count - 1)
                nextEpisodeIdx++;
            else
                throw new IndexOutOfRangeException("No episodes remaining");
        }

        public void ResetEpisodeCounter()
        {
            nextEpisodeIdx = 0;
        }

        public int GetNextEpisode()
        {
            return episodes[nextEpisodeIdx].EpisodeNumber;
        }

        public int GetNextEpisodeSeason()
        {
            return episodes[nextEpisodeIdx].Season;
        }

        public string GetPath(int season, int episode)
        {
            foreach (Episode ep in episodes)
            {
                if (ep.Season == season && ep.EpisodeNumber == episode)
                    return ep.Path;
            }

            throw new ArgumentOutOfRangeException("season or episode", "Season or episode index out of range");
        }
    }
}
