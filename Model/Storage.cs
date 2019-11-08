using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfNinject.Model.Interface;

namespace WpfNinject.Model
{
    public class Storage : IStorage
    {
        private List<string> _data = new List<string>();

        public IEnumerable<string> GetData()
        {
            return _data;
        }

        public void SetData(string dataStr)
        {
            _data.Add(dataStr);
            Console.WriteLine($"Save: {dataStr}");
        }
    }
}
