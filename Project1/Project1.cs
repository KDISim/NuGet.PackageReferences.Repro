using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Project1
    {
        private readonly IObserver<string> _observer;
        public Project1()
        {
            _observer = System.Reactive.Observer.Create<string>(x=> Console.WriteLine(x));
        }

        public IObserver<string> Observer => _observer;
    }
}
