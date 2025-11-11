using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class Driver
    {
        //?表示后面使用的时候会初始化对象，IRunnable是一个对象
        private IRunnable ? runnable = null;

        public IRunnable Runnable
        {
            set { runnable = value; }
        }
        public Driver(){ }
        public Driver(IRunnable runnable) 
        { 
            this.runnable = runnable;
        }

        public void Drive()
        {
            runnable?.Run();
        }

    }
}
