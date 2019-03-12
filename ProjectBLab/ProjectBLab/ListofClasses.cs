using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBLab
{
    class ListofClasses
    {
        public static List<StudentClass> studentList = new List<StudentClass>();

        internal List<StudentClass> StudentList
        {
            get
            {
                return studentList;
            }

            set
            {
                studentList = value;
            }
        }
        public void addIntolist( StudentClass st)
        {
            studentList.Add(st);
        }
        public void remove(int id)
        {
            studentList.RemoveAt(id);
        }
    }
}
