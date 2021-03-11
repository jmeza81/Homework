using System;

namespace MilitaryUnit
{
    public abstract class Vehicle
    {
        public int Tires { get; set; }
        public string Name { get; set; }
        public Vehicle(string vModel, int wheels)
        {
            this.Name = vModel;
            this.Tires = wheels;
        }


        public virtual void StartEngine(int wheels)
        {
            Console.WriteLine("Vroom");
        }
        
        public virtual void Accelerate()
        {
            Console.WriteLine("The vehicle speeds up.");
        }
        
        public virtual void Brake()
        {
            Console.WriteLine("The vehicle slows down and stops.");
        }
        
        public virtual void Mount()
        {
            Console.WriteLine("The mount of the vehicle.");
        }
    }
    public class VampMarkII : Vehicle
    {
        public VampMarkII(string vModel, int wheels) : base(vModel, wheels)
        {
            Console.WriteLine($"The {vModel} is a kick-ass all terrain vehicle. \n");
        }

        public override void StartEngine(int wheels)
        {
            Console.WriteLine("V v v v vroom.");
            Console.WriteLine($"This vehicle has {wheels} tires");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The Vamp Mark II is speeding up.");
        }

        public override void Brake()
        {
            Console.WriteLine("The Vamp Mark II is slowing down to a stop.");
        }

        public override void Mount()
        {
            Console.WriteLine("The Vamp MArk II has a four barrel rocket launcher mounted on the bed.");
        }
    }
}
