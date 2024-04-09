using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Album(string name)
    {
        public List<Musica> Musics { get; set; } = [];
        public string Name { get; set; } = name;
        public int? Duration => Musics.Sum(u => u.Duration);

        public void Add(Musica musica) => Musics.Add(musica);
        public void Remove(Musica musica) => Musics.Remove(musica);

        public void ShowAllMusics()
        {
            Console.WriteLine($"Album: {Name}\n");
            foreach (var musica in Musics)
            {
                musica.Show();
            }
        }
    }
}
