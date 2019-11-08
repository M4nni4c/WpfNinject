using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNinject.Model.Interface
{
    public interface IStorage
    {
        IEnumerable<string> GetData();
        void SetData(string data);
    }
}
