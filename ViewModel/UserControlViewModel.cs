using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfNinject.Model.Interface;

namespace WpfNinject.ViewModel
{
    public class UserControlViewModel : ViewModelBase
    {
        private IStorage _storage;
        private string _textData;

        public ICommand GetDataCommand { get; private set; }
        public ICommand SetDataCommand { get; private set; }        

        public UserControlViewModel(IStorage storage)
        {
            _storage = storage;

            GetDataCommand = new RelayCommand(GetData);
            SetDataCommand = new RelayCommand(SetData);
        }

        public string TextData
        { 
            get
            {
                return _textData;
            }
            set
            {
                _textData = value;
                RaisePropertyChanged("TextData");
            }
        }

        private void GetData()
        {
            TextData = string.Empty;
            foreach (var str in _storage.GetData())
            {
                TextData += str;
            }    
        }

        private void SetData()
        {
            _storage.SetData(TextData);
            TextData = string.Empty;
        }
    }
}
