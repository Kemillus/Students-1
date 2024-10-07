using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class StudentGroup : Group
    {
        public List<string> Students { get; set; }    
        public StudentGroup(int id,string name): base(id,name) 
        {
            Students = new List<string>();
        }

        public void AddStudent(string studentsName)
        {
            Students.Add(studentsName);
        }

    }
    
}
