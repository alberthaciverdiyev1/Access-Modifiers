using System.Text.RegularExpressions;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            
            Student student = new Student("Albert", "Haciverdiyev", 20, false);
            Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age + " " + student.IsOnline);
        }
    }
}