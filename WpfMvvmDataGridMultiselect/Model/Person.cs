using System;

namespace WpfMvvmDataGridMultiselect
{
    public class Person : ViewModelBase
    {
        private string _name;
        private int _zip;
        private DateTime _birthdate;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Zip
        {
            get => _zip;
            set
            {
                _zip = value;
                OnPropertyChanged("Zip");
            }
        }
        public DateTime Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged("Birthdate");
            }
        }
    }
}
