using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Gunner
    {
        private IFireable ? fireable = null;

        public IFireable Fireable
        {
            set { fireable = value; }
        }
        public Gunner() { }
        public Gunner(IFireable fireable) 
        {
            this.fireable = fireable;
        }

        public void Fire()
        {
            fireable?.Fire();
        }
        public void MultiFire()
        {
            fireable?.MultiFire();
        }
    }
}
