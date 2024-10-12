using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Graduate : Human
    {
        public string University { get; set; }
        public string Specialization { get; set; }
        public int GraduationYear { get; set; }

        public Graduate(string university, string specialization, int graduationYear, string lastName, string firstName, int age)
            : base(lastName, firstName, age)
        {
            University = university;
            Specialization = specialization;
            GraduationYear = graduationYear;
            Console.WriteLine($"GConstructor:{GetHashCode()}");
        }

        ~Graduate()
        {
            Console.WriteLine($"GDestructor:{GetHashCode()}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{University} {Specialization} {GraduationYear}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {University} {Specialization} {GraduationYear}";
        }
    }
}
