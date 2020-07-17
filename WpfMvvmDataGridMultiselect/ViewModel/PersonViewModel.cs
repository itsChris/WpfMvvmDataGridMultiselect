using System;
using System.Collections.ObjectModel;

namespace WpfMvvmDataGridMultiselect
{
    public class PersonViewModel : ViewModelBase
    {
        private ObservableCollection<Person> people;
        string _summary;
        private ObservableCollection<Person> _selectedItems = new ObservableCollection<Person>();
        public ObservableCollection<Person> PeopleList
        {
            get { return people ?? (people = new ObservableCollection<Person>()); }
            set
            {
                people = value;
                OnPropertyChanged("PeopleList");
            }
        }

        public string Summary
        {
            get
            {
                return _summary;
            }
            private set
            {
                _summary = value;
                OnPropertyChanged("Summary");
            }
        }

        public ObservableCollection<Person> SelectedItems
        { get { return _selectedItems; } }
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

            _selectedItems.CollectionChanged += (sender, e) => UpdateSummary();
        }

        private void UpdateSummary()
        {
            Summary = string.Format("{0} items are selected.", SelectedItems.Count);
        }
    }
}
