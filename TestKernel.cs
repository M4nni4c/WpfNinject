using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNinject
{
    interface IModule
    {
        void Print();
    }


    class Module : IModule
    {
        private string _name;

        public Module(string name)
        {
            _name = name;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + _name);
        }
    }

    class TestKernel
    {
        IModule[] _modules;

        public TestKernel(params IModule[] modules)
        {
            _modules = modules;
        }

        public void PrintAll()
        {
            foreach (var item in _modules)
            {
                item.Print();
            }
        }
    }
}
