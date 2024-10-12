using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Montana", "Antonio", 25);
            human.Print();
            Console.WriteLine(human);

            Student student = new Student("Chemistry", "WW_220", 95, 96, "Pinkman", "Jessie", 22);
            student.Print();
            Console.WriteLine(student);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            teacher.Print();
            Console.WriteLine(teacher);

            Human[] group = new Human[]
            {
                new Student("Chemistry", "WW_220", 95, 96, "Pinkman", "Jessie", 22),
                new Teacher("White", "Walter", 50, "Chemistry", 25),
                new Graduate("TopAcademy", "Programming", 1993, "Ivan", "Ivanov", 31)
            };

            foreach (Human humans in group)
            {
                humans.Print();
            }

            //Сохранить группу в файл
            StreamWriter sw = new StreamWriter("Group.txt");
            sw.WriteLine(group);
            sw.Close();

            //Загрузить группу из файла в массив
            string[] array = File.ReadAllLines("Group.txt");
        }

    }
}
