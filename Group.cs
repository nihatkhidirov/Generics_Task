using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Generics
{
    internal class Group:Students
    {
        private static int _No = 101;

        public string No { get; }
        public Group()
        {
            No = "AP" + _No.ToString();
            _No++;
        }

        private List<Students> students;
        public Group()
        {
            students = new List<Students>(); 
        }
        public List<Students> GetAllStudents()
        {
            return students;
        }


    }
}
