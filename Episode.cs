using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Episode(string title, int duration, int order)
    {
        public List<string> Guests { get; private set; } = [];
        public int Duration { get; set; } = duration;
        public string Title { get; set; } = title;
        public int Order { get; set; } = order;
        public string Summary => $"{Order}. {Title} ({Duration} minutes)\n{string.Join(", ", Guests)}.";

        public void Add(string guestName) => Guests.Add(guestName);
        public void Add(List<string> guestName) => guestName.ForEach(Guests.Add);
        public void Remove(string guestName) => Guests.Remove(guestName);
        public void Remove(List<string> guestName) => guestName.ForEach(g => Guests.Remove(g));
    }
}
