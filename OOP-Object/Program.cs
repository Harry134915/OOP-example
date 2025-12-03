namespace OOP_Object
{
    class Student
    {
        public int ID
        {                                                                                                                                                               
            get; set;
        }
        public string?Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public override bool Equals(object? obj)
        {
            //1.尝试将obj转换为Student类型
            Student other = obj as Student;

            //2.如果转换失败，返回false
            if (other == null)
                return false;
            //3.如果转化成功，比较各个属性值是否相等
            return Name == other.Name && ID == other.ID && Age == other.Age;
        }

        //public override string? ToString()
        //{
        //    string result = "";

        //    result += $"学号:{ID}\n";
        //    result += $"姓名:{Name}\n";
        //    result += $"年龄:{Age}\n";

        //    return result;
        //}

    }

    class Cat()
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = 1;
            s1.Name = "张三";
            s1.Age = 18;

            Student s2 = new Student();
            s2.ID = 1;
            s2.Name = "张三";
            s2.Age = 18;

            Cat cat = new Cat();
            Console.WriteLine(s1.Equals(cat));

            

            ShowType(cat);

            Console.WriteLine(cat.ToString());

            Func(2.7f);

        }

        static void ShowType(object o)
        {
           Type type = o.GetType();
            Console.WriteLine(type.FullName);
        }

        static public void Func(object o)
        {
            Type t = o.GetType();

            if(t == typeof(int))
            {
                Console.WriteLine("int");
            }
            else if(t == typeof(float))
            {
                Console.WriteLine("float");
            }
            else if(t == typeof(string))
            {
                Console.WriteLine("string");
            }
        }
    }
}
