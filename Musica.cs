using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen_sound_alura_oop
{
    public class Musica
    {
        public required string Name { get; set; }
        public required string Artist { get; set; }
        public required TimeSpan Duration { get; set; }
        public required bool Available { get; set; }
        public int Segundos => Duration.Seconds + (Duration.Minutes * 60);
        public string Resumo => $"{Name} do artista {Artist}";
    }
}
