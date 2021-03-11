using System;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateUnit();
        }
        public static void CreateUnit()
        {
            try
            {
                Personnel mSergeant = new Sergeant("Sergeant", "GI Joe");
                mSergeant.Command = "Special Counter-Terrorism Unit Delta";
                mSergeant.Shoot();

                Console.WriteLine();

                Vehicle myAttackVehicle = new VampMarkII("VampMarkII", 5);
                myAttackVehicle.StartEngine(6);
                myAttackVehicle.Accelerate();
                myAttackVehicle.Brake();
                myAttackVehicle.Mount();

                Console.WriteLine();

                Weapon myRifle = new M4("M4", ".556", 0);
                myRifle.Fire(30);
                myRifle.Reload();
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                CreateUnit();
            }
            finally
            {
                Console.WriteLine("Yo Joe!");
            }
        }
    }
}
