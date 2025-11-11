//using System.Globalization;

//namespace OOP_example
//{

//    class Employee
//    {
//        //1.创建类的属性
//        public string CompanyName = "";
//        public string EmployeeName = "";
//        public int EmployeeID;


//        //2.创建类的方法
//        public void IntroduceYourself()
//        {
//            Console.WriteLine("我是{0}的{1}，工号是{2}.",CompanyName,EmployeeName,EmployeeID);
//        }

//        public void Call(string Number)
//        {
//            Console.WriteLine("请给{0}打电话,我是{1}的{2},工号为{3}.",Number, CompanyName, EmployeeName, EmployeeID);
//        }

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //3.创建类的实例
//            Employee E1 = new Employee();
//            E1.CompanyName = "微软";
//            E1.EmployeeName = "马斯克";
//            E1.EmployeeID = 1001;

//            //4.使用类的属性和方法
//            Employee E2 = new Employee();
//            E2.CompanyName = "谷歌";
//            E2.EmployeeName = "扎克伯格";
//            E2.EmployeeID = 1002;

//            E1.IntroduceYourself();
//            E1.Call("123456789");

//            E2.IntroduceYourself();
//            E2.Call("987654321");
//        }
//    }

//}

//using System.Globalization;

//namespace OOP_example
//{

//    class Employee
//    {
//        //1.创建类的属性
//        public string CompanyName { get; set; }
//        public string EmployeeName { get; set; }
//        public int EmployeeID { get; set; }


//        public Employee(string companyName, string employeeName, int employeeID)
//        {
//            CompanyName = companyName;
//            EmployeeName = employeeName;
//            EmployeeID = employeeID;
//        }

//        //2.创建类的方法
//        public void IntroduceYourself()
//        {
//            Console.WriteLine($"我是{CompanyName}的{EmployeeName}，工号是{EmployeeID}.");
//        }

//        public void Call(string Number)
//        {
//            Console.WriteLine($"请给{Number}打电话,我是{CompanyName}的{EmployeeName},工号为{EmployeeID}.");
//        }

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //3.创建类的实例
//            Employee E1 = new Employee("微软", "马斯克", 1001);


//            Employee E2 = new Employee("谷歌", "扎克伯格", 1002);

//            E1.IntroduceYourself();
//            E1.Call("123456789");

//            E2.IntroduceYourself();
//            E2.Call("987654321");
//        }
//    }

//}




