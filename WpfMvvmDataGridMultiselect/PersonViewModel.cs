using System;
using System.Collections.ObjectModel;

namespace WpfMvvmDataGridMultiselect
{
    public class PersonViewModel : ViewModelBase
    {
        private ObservableCollection<Person> people;

        public ObservableCollection<Person> PeopleList
        {
            get { return people ?? (people = new ObservableCollection<Person>()); }
            set
            {
                people =value;
                OnPropertyChanged("PeopleList");
            }
        }
        public PersonViewModel() : base()
        {
            PeopleList = new ObservableCollection<Person>();
            PeopleList.Add(new Person
            {
                Name = "Christian",
                Zip = 8127,
                Birthdate = DateTime.Now.AddDays(-5000)
            });

            PeopleList.Add(new Person
            {
                Name = "Mirela",
                Zip = 03001,
                Birthdate = DateTime.Now.AddDays(-4000)
            });
        }
    }
}
