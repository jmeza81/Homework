using System;

namespace MilitaryUnit
{
    public abstract class Personnel
    {
        public string Rank { get; set; }
        public string Command { get; set; }
        public Personnel(string rank, string unit)
        {
            this.Rank = rank;
            this.Command = unit;
        }
        public virtual void Shoot()
        {
            Console.WriteLine("Pew Pew is the standard sound");
        }
    }
    public class Sergeant : Personnel
    {
        public Sergeant(string rank, string unit) : base(rank, unit)
        {
            Console.WriteLine($"The {rank} is the ultmate soldier in the Joes. \n");
            Console.WriteLine($"This troop belongs to the {unit}");
        }
        public override void Shoot()
        {
            Console.WriteLine("Inhale, exhale. Hold breath, Fire!");
        }
    }
}
