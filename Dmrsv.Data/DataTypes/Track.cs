﻿namespace Dmrsv.Data
{
    [Obsolete]
    public class Track
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public Dictionary<string, int> Patterns { get; set; }
            = new Dictionary<string, int>();

        public IEnumerable<Music> GetMusicList()
        {
            var musicList = from p in Patterns
                            select new Music()
                            {
                                Title = Title,
                                Style = p.Key,
                                Level = p.Value.ToString()
                            };

            return musicList;
        }
    }
}
