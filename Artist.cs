using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Artist(string name)
    {
        public List<Musica> Musics { get; set; } = [];
        public List<Album> Albums { get; set; } = [];
        public string Name { get; set; } = name;

        public void Add(Musica musica) => Musics.Add(musica);
        public void Remove(Musica musica) => Musics.Remove(musica);
        public void Add(Album album) => Albums.Add(album);
        public void Remove(Album album) => Albums.Remove(album);
        public void ShowAll()
        {
            Console.WriteLine("***************************");
            Console.WriteLine($"Banda: {Name}");

            Console.WriteLine("\nAlbums:\n");
            foreach (var album in Albums)
                album.ShowAllMusics();

            Console.WriteLine("\nAll Musics:\n");

            foreach (var music in Musics)
                music.Show();
        }
    }
}
