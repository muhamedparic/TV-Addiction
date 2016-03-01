using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace TV_Addiction
{
    class Series
    {
        public string Name { get; set; }
        public Dictionary<int, int> EpisodeCount
        {
            get
            {
                return episodeCount;
            }
        }

        List<Episode> episodes;
        int nextEpisodeIdx;
        Dictionary<int, int> episodeCount;

        public List<Episode> Episodes
        {
            get
            {
                return episodes;
            }
        }

        public Series(string name, string path)
        {
            Name = name;
            nextEpisodeIdx = 0;
            episodes = new List<Episode>();
            episodeCount = new Dictionary<int, int>();
            FindVideos(path);
            FindSubtitles(path);

            episodes.Sort();
            CountEpisodes();
        }

        public Series(string name, int nextEpisode)
        {
            Name = name;
            nextEpisodeIdx = nextEpisode;
            episodes = new List<Episode>();
            episodeCount = new Dictionary<int, int>();
        }

        public void AddEpisode(string path, string subtitlePath, int season, int episodeNumber)
        {
            episodes.Add(new Episode(path, subtitlePath, season, episodeNumber));
            if (!episodeCount.ContainsKey(season))
                episodeCount[season] = 0;
            episodeCount[season]++;
        }

        private void FindVideos(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                foreach (string extension in Settings.VideoExtensions)
                {
                    if (file.EndsWith(extension))
                    {
                        try
                        {
                            episodes.Add(new Episode(file));
                            break;
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                }
            }

            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories)
                FindVideos(directory);
        }

        private void FindSubtitles(string path)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                foreach (string extension in Settings.SubtitleExtensions)
                {
                    if (file.EndsWith(extension))
                    {
                        try
                        {
                            int season = Episode.ExtractSeason(file);
                            int episode = Episode.ExtractEpisodeNumber(file);

                            foreach (Episode ep in episodes)
                            {
                                if (ep.Season == season && ep.EpisodeNumber == episode)
                                {
                                    ep.SubtitlePath = file;
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                }
            }

            string[] directories = Directory.GetDirectories(path);

            foreach (string directory in directories)
                FindSubtitles(directory);
        }

        public void AdvanceEpisode()
        {
            
            nextEpisodeIdx++;
            nextEpisodeIdx %= episodes.Count;
        }

        public void ResetEpisodeCounter()
        {
            nextEpisodeIdx = 0;
        }

        public int GetNextEpisode()
        {
            return episodes[nextEpisodeIdx].EpisodeNumber;
        }

        public Episode GetNextEpisodeObj()
        {
            return episodes[nextEpisodeIdx];
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

        public string GetNextEpisodePath()
        {
            return episodes[nextEpisodeIdx].Path;
        }

        public override string ToString()
        {
            return Name;
        }

        public void WriteToXml(XmlTextWriter writer)
        {
            writer.WriteStartElement("show");
            writer.WriteElementString("name", Name);
            writer.WriteElementString("next-episode", nextEpisodeIdx.ToString());
            foreach (Episode ep in episodes)
                ep.WriteToXml(writer);
            writer.WriteEndElement();
        }

        public void SetCounterTo(int season, int episode)
        {
            for (int i = 0; i < episodes.Count; i++)
            {
                if (episodes[i].Season == season && episodes[i].EpisodeNumber == episode)
                {
                    nextEpisodeIdx = i;
                    return;
                }
            }
            throw new ArgumentOutOfRangeException();
        }

        private void CountEpisodes()
        {
            foreach (Episode ep in episodes)
            {
                if (!episodeCount.ContainsKey(ep.Season))
                    episodeCount[ep.Season] = 0;
                episodeCount[ep.Season]++;
            }
        }
    }
}
