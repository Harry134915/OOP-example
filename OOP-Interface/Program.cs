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
            //创建驾驶员
            Driver driver = new Driver();

            //创建超级坦克
            SuperTank superTank = new SuperTank();
            //驾驶员载具切换为超级坦克
            driver.SetVehicle(superTank);
            //驾驶员驾驶载具
            driver.Drive();

            //创建重型坦克
            HeavyTank heavyTank = new HeavyTank();
            //驾驶员载具切换为重型坦克
            driver.SetVehicle(heavyTank);
            //驾驶员驾驶载具
            driver.Drive();

            //创建汽车
            Car car = new Car();
            //驾驶员载具切换为车
            driver.SetVehicle(car);
            //驾驶员驾驶载具
            driver.Drive();

            //1. 创建炮手对象
            Gunner gunner = new Gunner();

            //2. 创建火箭炮
            Rocket rocket = new Rocket();

            //3. 炮手装备火箭炮
            gunner.Equip(rocket);

            //4. 炮手使用火箭炮
            gunner.Fire();
            gunner.MultiFire();
        }
    }
}
