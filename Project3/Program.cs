using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            var project2 = new Project2.Project2();

            project2.Project1.Observer.OnNext("test");
        }
    }
}
