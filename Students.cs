using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Generics
{
    internal class Students
    {
        public Students(string name, string surname, double point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }
        private static int _idCounter = 1;
        public int Id { get; } 

        public Students()
        {
            Id = _idCounter++; 
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public double Point { get; set; }
        public int Age { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}\n Name: {Name} \n Surname: {Surname}\n Age: {Age}\n Point: {Point}");
        }
    }
}
