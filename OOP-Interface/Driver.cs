using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Driver
    {
        public IRunnable?Vehicle
        {
            get;
            private set;
        }

        public void SetVehicle(IRunnable vehicle)
        {
            Vehicle = vehicle;
        }

        public void Drive()
        {
            Vehicle?.Run();
        }
    }
}
