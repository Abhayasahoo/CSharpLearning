using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructApplication
{
  public struct Employee
 {
        public string Name;
        public int Age;
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
 }

  public class TestApplication
    {
        public static void Main_1()
        {
            Employee p1 = new Employee("Wallace", 75);
            Employee p2;
            p2.Name = "Wallace";
            p2.Age = 75;
            if (p2.Equals(p1))
                Console.WriteLine("p2 and p1 have the same values.");
        }
    }
    
        // Output: p2 and p1 have the same values.
    
}


