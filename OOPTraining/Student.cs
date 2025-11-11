using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraining
{
    internal class Student
    {
        //属性
        public string Name { get; set; }
        public string ID { get; set; }

        //行为
        public void SayHere()
        {
            Console.WriteLine($"我的名字是{Name},学号是{ID},到！");
        }

    }
}
