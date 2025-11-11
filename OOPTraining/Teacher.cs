using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraining
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public void SayNames(Student[] students,int count)
        {
            //foreach (Student student in students)
            //{
            //    student.SayHere();
            //}
            for (int i = 0; i < count; i++)
            {
                students[i].SayHere();
            }
        }
    }
}
