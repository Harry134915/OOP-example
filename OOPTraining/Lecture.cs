using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraining
{
    internal class Lecture
    {
        //构造方法
        public Lecture(int maxCount)
        {
            MaxStudentCount = maxCount;

            //students数组初始化，留下了MAX_COUNT个位置，当前数组内部每个元素都是null
             students= new Student[MaxStudentCount];
        }

        //当前课堂的主讲老师对象，null代表还没有给老师对象分配内存
        private Teacher teacher = null;

        //设置当前哪个老师来上课
        public void SetTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
        //当前课堂要有学生
        //1.课堂容量（int）
        //get：需要提供，让外界可以知道当前课堂有多少座位
        //set:不需要提供，让外界不能随便更改课堂容量
        private int MaxStudentCount = 0;

        //2.当前学生数量（int）
        //get:需要提供，让外界可以知道当前有多少学生来上课
        //set：不需要提供，让外界不能随便更改当前学生数量
        private int CurrentCount = 0;
        public int currentCount
        {
            get { return CurrentCount; }
            //这里写成了get { return currentCount; }，导致堆栈溢出异常
        }

        //3.学生数组，用于存放当前来上课的学生
        private Student[] students = null;
        public bool AddStudent(Student student)
        {
            if (currentCount >= MaxStudentCount)
            {
                return false;
            }

            students[CurrentCount] = student;
            CurrentCount++;

            return true;
            //Console.WriteLine($"这是新学生{student.Name}！");
            //Console.WriteLine($"当前学生数量为{currentCount}.");
        }

        public void StartLecture()
        {
            //老师开始上课点名
            teacher.SayNames(students,currentCount);
        }


    }
}
