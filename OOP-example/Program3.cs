using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    class Fridge
    {
        public void Open()
        {
            Console.WriteLine("打开冰箱");
        }
        public void Push(string animal)
        {
            Console.WriteLine("装入" + animal);
        }
        public void Close()
        {
            Console.WriteLine("关闭冰箱");
        }

        public void PutIn(string animal)
        {
            Push("大象");
            Open();
            Close();
        }

        internal class Program3
        {
            static void Main(string[] args)
            {
                Fridge fridge = new Fridge();
                //fridge.Push("大象");
                //fridge.Open();
                //fridge.Close();
                fridge.PutIn("大象");
            }          
        }
    }
}

