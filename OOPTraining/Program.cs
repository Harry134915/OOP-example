namespace OOPTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "蒋老师";
            teacher.Subject = "面向对象程序设计";

            Student student1 = new Student();
            student1.Name = "Harry";
            student1.ID = "0001";

            Student student2 = new Student();
            student2.Name = "Curry";
            student2.ID = "0002";

            //数组的声明
            //Student[] students = new Student[2] {student1, student2 };
            //teacher.SayNames(students);

            Lecture lecture = new Lecture(100);
            lecture.SetTeacher(teacher);
 
            //lecture.AddStudent(student1);
            //lecture.AddStudent(student2);

            if (!lecture.AddStudent(student1))
            {
                Console.WriteLine("添加学生失败，课堂已满！");
            }

            if (!lecture.AddStudent(student2))
            {
                Console.WriteLine("添加学生失败，课堂已满！");
            }

            //开始上课
            lecture.StartLecture();

        }
    }
}
