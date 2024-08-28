using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module02Exercise01.Model;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;


namespace Module02Exercise01.ViewModel
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {

        private Employee _employee;
        private string _fullName;


      

        private ObservableCollection<Employee> _employees;
        
        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set
            {
                _employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }


        private Employee _selectedEmployee;

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }



        public ICommand LoadEmployeeCommand { get; }



        private async Task LoadEmployeeDataAsync()
        {
            await Task.Delay(1000);
            FullName = $"{_employee.FirstName} {_employee.LastName}";
        }

        public EmployeeViewModel()
        {

            Employees = new ObservableCollection<Employee>();
            LoadEmployeeCommand = new Command(LoadEmployees);
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            Employees.Add(new Employee
            {
                FirstName = "Cristan Josh",
                LastName = "Nuguid",
                Position = "Manager",
                Dpt = "HR",
                IsActive = 0
            });

            Employees.Add(new Employee
            {
                FirstName = "Lorenzo",
                LastName = "Sangalang",
                Position = "SQA",
                Dpt = "IT",
                IsActive = 1
            });

            Employees.Add(new Employee
            {
                FirstName = "Richard",
                LastName = "Sy",
                Position = "Developer",
                Dpt = "IT",
                IsActive = 1
            });
        }





        public event PropertyChangedEventHandler PropertyChanged;
        
        protected async void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
