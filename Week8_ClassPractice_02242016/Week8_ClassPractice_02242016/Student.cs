using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ClassPractice_02242016
{
    class Student
    {
        //Fields
        string name;
        string course;
        string subject;
        string university;
        string email;
        uint phoneNumber;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public string University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public uint PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        //Constructors
        public Student ()
        {
            this.name = "Joey";
            this.course = "LTN 101";
            this.subject = "Latin";
            this.university = "CCC";
            this.email = "joey@gmail.com";
            this.phoneNumber = 2161233344;
        }

        public Student (string name)
        {
            this.name = name;
            this.course = "ENG 345";
        }

        public Student (string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            this.university = "CCC";
            this.email = "joey2@gmail.com";
        }

        public Student (string name, string course, string subject)
        {
            this.name = name;
            this.course = course;
            this.subject = subject;
        }

        public Student (string name, uint phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.course = "MTH 535";
            this.subject = "Super Hard Math Class";
        }

        public void PrintStudentInfo(string name)
        {
            Console.WriteLine("Student Name: {0}\nPhone Number: {1}\nEmail: {2}", this.name, this.phoneNumber, this.email);
        }

        public void PrintStudentInfov2()
        {
            Console.WriteLine("Student Name: {0}\nPhone Number: {1}\nEmail: {2}", this.name, this.phoneNumber, this.email);
        }
    }
}
