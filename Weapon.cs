using System;

namespace MilitaryUnit
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public string Caliber { get; set; }
        public int NumberOfRounds { get; set; }
        public Weapon(string wName, string caliber, int bullets)
        {
            this.Name = wName;
            this.Caliber = caliber;
            this.NumberOfRounds = bullets;
        }


        public virtual void Fire(int bullets)
        {
            Console.WriteLine("Pew, Pew");
        }

        public virtual void Reload()
        {
            Console.WriteLine("Weapon is Reloading.");
        }
    }

    public class M4 : Weapon
    {
        public M4(string wName, string caliber, int bullets) : base(wName, caliber, bullets)
        {
            Console.WriteLine($"The {wName} is the standard GI Joe rifle. \n" +
                $"and it fires {caliber} caliber bullets");
        }

        public override void Fire(int bullets)
        {
            Console.WriteLine("Pew pew pew");
            Console.WriteLine($"This rifle can house {bullets} bullets per magazine.");
        }

        public override void Reload()
        {
            Console.WriteLine("Insert magazine to reload!");
        }
    }
}
