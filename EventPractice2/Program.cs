using System.Security.Cryptography.X509Certificates;

namespace EventPractice2
{
    //第一种写法
    //class FeedArgs
    //{
    //    public string food;
    //}

    //第二种写法
    class FeedArgs : EventArgs
    {
        public string ? food { get; }

        public FeedArgs(string food)
        {
            this.food = food;
        }
    }

    class Master
    {
        public event EventHandler<FeedArgs> ? OnFood;

        public void Feed(string food)
        {
            //触发事件
            //第一种写法
            OnFood?.Invoke(this, new FeedArgs(food));

            //第二种写法
            //if(OnFood != null)
            //{
            //    FeedArgs args = new FeedArgs();
            //    args.food = food;

            //    OnFood(this, args);
            //}
        }
    }

    class Dog
    {
        public void Eat(object sender,FeedArgs args)
        {
            if(args.food != "肉")
            {
                Console.WriteLine("狗狗我啊不吃这个！");
            }
            else
            {
                Console.WriteLine("dog：好吃！就是这个味！");
            }
        }
    }

    class Cat
    {
        public void Eat(object sender,FeedArgs args)
        {
            if(args.food != "鱼")
            {
                Console.WriteLine("猫猫我啊不吃这个！");
            }
            else
            {
                Console.WriteLine("cat：好吃！就是这个味！");
            }
        }
    }

    class Panda
    {
        public void Eat(object sender, FeedArgs args)
        {
            if (args.food != "竹子")
            {
                Console.WriteLine("潘达我啊不吃这个！");
            }
            else
            {
                Console.WriteLine("panda：好吃！就是这个味！");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Master master = new Master();
            Dog dog = new Dog();
            Cat cat = new Cat();
            Panda panda = new Panda();

            master.OnFood += dog.Eat;
            master.OnFood += cat.Eat;
            master.OnFood += panda.Eat;
            master.Feed("肉");
            master.Feed("鱼");
            master.Feed("竹子");
        }
    }
}
