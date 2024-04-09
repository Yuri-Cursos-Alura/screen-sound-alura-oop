using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Musica(string name, bool available, int duration)
    {
        public string Name { get; set; } = name;
        public bool Available { get; set; } = available;
        public int Duration { get; set; } = duration;

        public void Show()
        {
            Console.WriteLine($"- {Name} | {Duration} Seconds.");
        }
    }
}
