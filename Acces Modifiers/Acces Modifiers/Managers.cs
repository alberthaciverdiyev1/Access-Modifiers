using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_Modifiers
{
    public class Employee
    {
        public string Name;
        public int Salary;
        public bool IsSuccesfull;

    }
    internal class Managers : Employee
    {
        protected internal void GetPromotion(Employee employee)
        {
            Console.WriteLine($"Iscinin Evvelki Maasi: {employee.Salary}");

            Name = employee.Name;
            employee.Salary += 100;
            Console.WriteLine($"Iscinin Yeni Maasi: {employee.Salary}");
        }

    }
   
    class Assistant:Employee    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccesfull==true)
            {
                var newmanager = new Managers();
                newmanager.GetPromotion(employee);
            }
            else { Console.WriteLine("Teessuf Ki, Maas Artimi Olmadi"); }

        }
    }
}
