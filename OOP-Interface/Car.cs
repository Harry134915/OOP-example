using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Car : IRunnable
    {


        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
}
