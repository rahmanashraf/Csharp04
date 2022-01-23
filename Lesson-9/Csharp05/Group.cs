using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    class Group
    {
        public string Name;
        public GroupType type;
        public List<Student> students = new List<Student>();

        public Group(GroupType typeGroup, string nm)
        {
            type = typeGroup;
            Name = nm;
        }
        public  void AddStudent(Student student)
        {
            students.Add(student);
        } 

        public void FindStudentByName(string name)
        {
            foreach (var item in students)
            {
                if (item.Name==name)
                {
                    Console.WriteLine(item.Name +" "+ item.Surname);
                }
            }
        }
    }

    public enum GroupType
    {
        Programming,
        Design,
        System
    }
}
