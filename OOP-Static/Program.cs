using System.Security.Cryptography.X509Certificates;

namespace OOP_Static
{
    class Student
    {
        static public int count;
        public int id;
        public int ID
        {
            get;
            set;
        }

        public Student()
        {
            count++;
        }

        static public void GetInfo()
        {
            Console.WriteLine("我爱C#！");
            Console.WriteLine(count);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;

            Student s0 = new Student();
            s0.id = 1001;
            //count++;

            Student s1 = new Student();
            s1.id = 1002;
            //count++;

            Student s2 = new Student();
            s2.id = 1003;

            //s0.GetInfo();
            //Student.GetInfo();
            Show();


            Console.WriteLine(s0.id);
            Console.WriteLine(s1.id);
            Console.WriteLine($"一共有{Student.count}个学生。");
        }

        static public void Show()
        {
            Student.GetInfo();  
        }
    }
}
