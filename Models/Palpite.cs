using System;

namespace API_Copa.Models
{
    public class Palpite
    {
        public Palpite() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public int PlacarA { get; set; }
        public int PlacarB { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
