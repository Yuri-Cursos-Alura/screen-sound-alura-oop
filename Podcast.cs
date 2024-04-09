using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Podcast(Artist host, string name)
    {
        public Artist Host { get; set; } = host;
        public string Name { get; set; } = name;
        public List<Episode> Episodes { get; set; } = [];

        public void Add(Episode episode) => Episodes.Add(episode);
        public void Add(List<Episode> episodes) => episodes.ForEach(Episodes.Add);
        public void Remove(Episode episode) => Episodes.Add(episode);
        public void Remove(List<Episode> episodes) => episodes.ForEach(e => Episodes.Remove(e));
    }
}
