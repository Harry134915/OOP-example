//继承中的构造方法

//1.当实例化一个子类对象时，父类的构造方法会被自动调用，再调用子类的构造方法。
//2.当实例化一个子类对象时，如果父类只拥有带参构造方法，则子类的构造方法必须通过base关键字手动调用父类的带参构造方法，否则会报错。

//tip：1.子类构造方法如果显式调用父类构造方法，则遵从其选择。
//     2.子类构造方法如果不显式调用父类构造方法，则遵从默认调用父类的无参构造方法。

namespace OOP_Inherit
{
    class Father
    {
        public int age = 0;

        //方法重载
        public Father()
        {
            Console.WriteLine("Father's NoneArgs constructor called");
        }
        public Father(int age)
        {
            this.age = age;
            Console.WriteLine("Father's constructor called");
        }
    }

    class Son:Father
    {
        
        public Son():base(50)
        {
            Console.WriteLine("Son's constructor called");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {





            //Son son = new Son();
            //Console.WriteLine("Son's age is: " + son.age);
            ////如果手动构造方法，则调用默认无参构造方法
            //Father father = new Father(30);

            //Console.WriteLine("\n");
            //Console.WriteLine("\n");

            ////如果手动构造方法，则调用默认无参构造方法
            //Son son = new Son();
        }
    }
}
