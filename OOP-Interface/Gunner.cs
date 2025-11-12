using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Gunner
    {
        public IFireable?Equipment { get; set; }
        internal void Equip(IFireable equipment)
        {
            this.Equipment = equipment;
        }
        public void Fire()
        {
            Equipment?.Fire();
        }
        public void MultiFire()
        {
            Equipment?.MultiFire();
        }
    }
}
