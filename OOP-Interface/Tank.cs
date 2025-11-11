using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{

    internal abstract class Tank : IRunnable, IFireable
    {
        public abstract void Fire();
        public abstract void MultiFire();
        public abstract void Run();
    }
    class SuperTank : Tank
    {
        override public void Fire()
        {
            Console.WriteLine("SuperTank Fire");
        }

        override public void MultiFire()
        {
            Console.WriteLine("SuperTank MultiFire");
        }

        override public void Run()
        {
            Console.WriteLine("SuperTank Run");
        }
    }

        class HeavyTank : Tank
        {
            override public void Fire()
            {
                Console.WriteLine("HeavyTank Fire");
            }

            override public void MultiFire()
            {
                Console.WriteLine("HeavyTank MultiFire");
            }

            override public void Run()
            {
                Console.WriteLine("HeavyTank Run");
            }
        }
    }


        

