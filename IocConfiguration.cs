using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfNinject.Model;
using WpfNinject.Model.Interface;

namespace WpfNinject
{
    public class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            Bind<IStorage>().To<Storage>().InSingletonScope();
        }
    }
}
