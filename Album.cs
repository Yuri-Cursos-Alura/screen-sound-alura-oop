using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Album
    {
        public required List<Musica> Musics { get; set; }
        public required string Name { get; set; }
        public TimeSpan TotalDuration => new(Musics.Sum(u => u.Duration.Ticks));
        public int TotalSeconds => (int) TotalDuration.TotalSeconds;

        public void PrintAlbum()
        {
            Console.Write($"Músicas de '{Name}': ");

            for (int i = 0; i < Musics.Count; i++)
            {
                var music = Musics[i];

                if (Musics.Count - 1 != i)
                    Console.Write($"{music.Name}, ");
                else
                    Console.WriteLine($"{music.Name}.");
            }
        }
    }
}
