//namespace example1
//{
//    class Student
//    {

//        public string Name { get; private set; }
//        public int Id { get; private set; }
//        public Student(string Name, int Id)
//        {
//            this.Name = Name;
//            this.Id = Id;
//        }

//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Student student = new Student("Harry",0001);

//            Console.WriteLine(student.Name);
//            Console.WriteLine(student.Id);
//        }
//    }
//}

//namespace example1 
//{ 
//    class Student 
//    { 
//        private string Name; 
//        private int Id; 
//        public Student(string Name, int Id) 
//        { 
//            this.Name = Name; 
//            this.Id = Id; 
//        } 

//        public string GetName() 
//        { 
//            return Name; 
//        } 
//        public int GetId() 
//        { 
//            return Id; 
//        } 
//    } 
//    internal class Program 
//    { 
//        static void Main(string[] args) 
//        { 
//            Student student = new Student("Harry", 0001); 
//            int getId = student.GetId(); 
//            string getName = student.GetName(); 
//            Console.WriteLine(getId); 
//            Console.WriteLine(getName); 
//        } 
//    } 
//}

namespace example1
{
    class Student
    {
        private int _id; //下划线表示内部字段
        public string Name { get; private set; }
        public int Id 
        {   
           get { return _id; }
            //set 
            // {
            //     if (value < 1)
            //     {
            //         Console.WriteLine("Id不可小于1！");
            //         return;
            //     }
            //     _id = value;
            // } 
            set
            {
                if (value < 1)
                    throw new ArgumentException("Id不可小于1！");
                _id = value;
            }

        }
        public Student(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Harry", 0); // 会触发异常
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Id);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"错误：{ex.Message}");
            }
        }
    }
}
