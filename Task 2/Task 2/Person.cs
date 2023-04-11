using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    internal class Student : Person
    {
        public bool IsOnline;
        public Student(string name, string surname, int age, bool isOnline) : base(name, surname, age)
        {
            IsOnline = isOnline;
        }

        internal class Group
        {
            public string GroupName;
            Student[] Students = new Student[0];

            public Group(string groupName, Student[] students)
            {
                GroupName = groupName;
                Students = students;
            }
            public void AddStudent(Student student)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            public void GetAll()
            {
                if (Students.Length > 0)
                {
                    foreach (var item in Students)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("telebe Yoxdur");
                }
            }
            public void GetOnlineStudents()
            {
                Console.WriteLine("Qrupdaki Online telebeler: ");
                foreach (Student student in Students)
                {
                    if (student.IsOnline)
                    {
                        Console.WriteLine($"{student.Name} {student.Surname}");
                    }
                }
            }
            public void GetOfflineStudents()
            {
                Console.WriteLine("Qrupdaki Offline telebeler: ");
                foreach (Student student in Students)
                {
                    if (!student.IsOnline)
                    {
                        Console.WriteLine($"{student.Name} {student.Surname}");
                    }
                }
            }

        }
    }
}