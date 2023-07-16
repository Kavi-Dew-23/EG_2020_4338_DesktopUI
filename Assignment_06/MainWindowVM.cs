using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Assignment_06
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<people> people;
        private people selectedPerson;
        
        public MainWindowVM()
        {
            people = new ObservableCollection<people>
            {
                //new Person { FirstName = "Tom", LastName = "Black", DateOfBirth(2000,04.05), GpaValue = 3.5},
                //new Person { FirstName = "Jerry", LastName = "Blue", DateOfBirth(2001,12.01), GpaValue = 3.02}

            };

            /*
            people = new ObservableCollection<Person>();
            people.Add(new Person("Tom", "Black", "12 / 04 / 1997", "1.png", 3.12));
            people.Add(new Person("Jim", "Blue", "25 / 01 / 2000", "2.png", 2.12));
            people.Add(new Person("Tommy", "Red", "10 / 03 / 1998", "3.png", 3.02));
            //people.Add(new Person("Anne", "Green", "02 / 07 / 2001", "4.png", 3.09));
            //people.Add(new Person("Bin", "Grey", "22 / 12 / 1999", "5.png", 3.19));
            //people.Add(new Person("Linda", "Yellow", "26 / 09 / 1998", "6.png", 3.82));
            */
            //AddPersonCommand = new RelayCommand(AddPerson);
            EditPersonCommand = new RelayCommand(EditPerson, CanEditPerson);
            DeletePersonCommand = new RelayCommand(DeletePerson, CanDeletePerson);
        }

        public ObservableCollection<people> Students
        {
            get { return people; }
            set
            {
                people = value;
                OnPropertyChanged(nameof(Students));
            }
        }
        
        public people SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                OnPropertyChanged(nameof(selectedPerson));
                //EditStudentCommand.RaiseCanExecuteChanged();
                //DeleteStudentCommand.RaiseCanExecuteChanged();
            }
        }
        

        public ICommand AddPersonCommand { get; private set; }
        public ICommand EditPersonCommand { get; private set; }
        public ICommand DeletePersonCommand { get; private set; }
        public bool IsPersonSelected => SelectedPerson != null;

        [RelayCommand]
        public void AddPerson()
        {
            
            var person = new Person("Jerry", "Brown", "26/05/1999", "6.png", 3.56);
            //People.Add(person);
           
            //To open a new window to add a new student
        }

        

        public void EditPerson()
        {
            //To open a window for editing the selected student
        }
        public bool CanEditPerson()
        {
            return IsPersonSelected;
        }
        public void DeletePerson()
        {
            
            if (selectedPerson != null)
            {
                string name = selectedPerson.FirstName;
                people.Remove(selectedPerson);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }
        }
        private bool CanDeletePerson()
        {
            return IsPersonSelected;
        }

       
        
        



    }

    public class people
    {
        public people(string v1, string v2, string v3, string v4, double v5)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
        }

        public string FirstName { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
        public double V5 { get; }
    }

}
