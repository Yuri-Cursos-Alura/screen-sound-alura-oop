namespace screen_sound_alura_oop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var musica = new Musica
            {
                Artist = "O gay",
                Name = "The incredibles",
                Duration = new TimeSpan(days: 0, hours: 0, minutes: 2, seconds: 30),
                Available = true,
            };

            var musica2 = new Musica
            {
                Artist = "Melanie Martinez",
                Name = "Fire Drill",
                Duration = new TimeSpan(days: 0, hours: 0, minutes: 4, seconds: 0),
                Available = true,
            };

            var musica3 = new Musica
            {
                Artist = "Marilyn Manson",
                Name = "This is Halloween",
                Duration = new TimeSpan(days: 0, hours: 0, minutes: 3, seconds: 23),
                Available = true,
            };

            var album = new Album
            {
                Musics = [musica, musica2, musica3],
                Name = "Um album muito bom."
            };


            album.PrintAlbum();
        }
    }
}
