using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student : Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public int Rating { get; set; }
        public int Attedance { get; set; }

        public Student(string speciality, string group, int rating, int attedance, string lastName, string firstName, int age)
            : base(lastName, firstName, age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attedance = attedance;
            Console.WriteLine($"SConstructor:{GetHashCode()}");
        }

        ~Student()
        {
            Console.WriteLine($"SDestructor:{GetHashCode()}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{Speciality} {Group} {Rating} {Attedance}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Group} {Rating} {Attedance}";
        }
    }
}
