using System.Xml.Linq;

namespace screen_sound_alura_oop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var musica = new Musica
                (
                name: "The incredibles",
                duration: (int) new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 30).TotalSeconds,
                available: true
                );

            var musica2 = new Musica
                (
                    name: "Fire Drill",
                    duration: (int) new TimeSpan(days: 0, hours: 0, minutes: 4, seconds: 0).TotalSeconds,
                    available: true
                );

            var musica3 = new Musica
                (
                    name: "This is Halloween",
                    duration: (int)new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 23).TotalSeconds,
                    available: true
                );

            var album = new Album(name: "Um album muito bom.")
            {
                Musics = [musica, musica2, musica3]
            };

            var banda = new Banda(name: "Os cara foda");

            banda.Add(album);
            banda.Add(musica);
            banda.Add(musica2);
            banda.Add(musica3);

            banda.ShowAll();

        }
    }
}
