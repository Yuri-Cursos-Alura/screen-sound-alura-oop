using System.Xml.Linq;

namespace screen_sound_alura_oop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var episode = new Episode(title: "Um meteoro", duration: 120, order: 1);
            episode.Add(["João", "Maria", "José", "Pedro", "Mateus", "James", "ipi", "Luth", "TK", "Paulinha"]);

            Console.WriteLine(episode.Summary);

        }
    }
}
