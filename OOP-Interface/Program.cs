//1 Driver:IRunnable
//2.Gunner:IFireable
//3.Tank:
//  3.1 IFireable
//  3.2 IRunnable
//SuperTank+HeavyTank 
//

namespace OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperTank st = new SuperTank();
            HeavyTank ht = new HeavyTank();

            Driver driver = new Driver(ht);
            Gunner gunner = new Gunner(ht);

            gunner.Fire();
            gunner.MultiFire();
            driver.Drive();

            Console.WriteLine("天有不测风云");
            Car car = new Car();
            Rocket rocket = new Rocket();

            driver.Runnable = car;
            gunner.Fireable = rocket;

            driver.Drive();
            gunner.Fire();
            gunner.MultiFire();
        }
    }
}
