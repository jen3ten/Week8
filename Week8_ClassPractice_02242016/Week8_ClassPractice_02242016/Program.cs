using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02242016
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "David";
            student.PrintStudentInfo(student.Name);

            Student student2 = new Student("Jen", "Story Telling");
            student2.PhoneNumber = 216455677;
            student2.PrintStudentInfov2();
            Console.WriteLine(student2.Subject);
        }
    }
}
