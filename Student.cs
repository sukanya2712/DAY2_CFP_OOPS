using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsprogramday2
{
    internal class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'M going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("my age is : ", age);
        }
    }
}
