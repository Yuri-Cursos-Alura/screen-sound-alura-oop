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


            Console.WriteLine(musica.Resumo);
            Console.WriteLine($"Duração em segundos: {musica.Segundos}");
        }
    }
}
