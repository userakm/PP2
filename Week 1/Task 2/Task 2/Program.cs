using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student // creating new class
    {
        public string name; // name of a student
        public string id; // id of a student
        public int yos; // year of study

        public Student(string name, string id) // creating constructor with 2 parameters
        {
            this.name = name;
            this.id = id;
        }

        public void Increment() // creating method to print info about student
        {
            yos++; // incrementing year of study
            Console.WriteLine(name + " " + id + " " + yos);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student userakm = new Student("Assem Kalbayeva", "18BD111013"); // declaring new object in Student class
            userakm.yos = 1; // info about yos
            userakm.Increment(); // calling a method that increments yos
            Console.ReadKey(); // holds terminal open, until pressing any key to close it
        }
    }
}
