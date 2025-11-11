using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Rocket:IFireable
    {
        public void Fire()
        {
            Console.WriteLine("Rocket Fire");
        }
        public void MultiFire()
        {
            Console.WriteLine("Rocket MultiFire");
        }
    }
}
