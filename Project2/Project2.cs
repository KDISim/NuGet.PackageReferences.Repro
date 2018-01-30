using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Project2
    {
        private readonly Project1.Project1 _project1;

        public Project2()
        {
            _project1 = new Project1.Project1();
        }

        public Project1.Project1 Project1 => _project1;
    }
}
