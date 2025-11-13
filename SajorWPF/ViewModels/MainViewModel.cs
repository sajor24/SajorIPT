using SajorIPT101Solution.SajorWPF.Models;
using System.Collections.ObjectModel;

namespace SajorIPT101Solution.SajorWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> Employees { get; } = new ObservableCollection<Employee>();

        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (SetProperty(ref _selectedEmployee, value))
                {
                    if (_selectedEmployee != null && !IsEditing)
                    {
                        FirstName = _selectedEmployee.FirstName;
                        LastName = _selectedEmployee.LastName;
                        Position = _selectedEmployee.Position;
                        Age = _selectedEmployee.Age.ToString();
                    }
                    RaiseCanExecChanged();
                }
            }
        }

        private string _firstName;
        public string FirstName { get => _firstName; set { if (SetProperty(ref _firstName, value)) RaiseCanExecChanged(); } }

        private string _lastName;
        public string LastName { get => _lastName; set { if (SetProperty(ref _lastName, value)) RaiseCanExecChanged(); } }

        private string _position;
        public string Position { get => _position; set { if (SetProperty(ref _position, value)) RaiseCanExecChanged(); } }

        private string _age;
        public string Age { get => _age; set { if (SetProperty(ref _age, value)) RaiseCanExecChanged(); } }

        private bool _isEditing;
        public bool IsEditing { get => _isEditing; private set { if (SetProperty(ref _isEditing, value)) RaiseCanExecChanged(); } }

        public RelayCommand AddCommand { get; }
        public RelayCommand EditCommand { get; }
        public RelayCommand UpdateCommand { get; }
        public RelayCommand CancelCommand { get; }
        public RelayCommand DeleteCommand { get; }

        public MainViewModel()
        {

            AddCommand = new RelayCommand(_ => Add(), _ => CanAdd());
            EditCommand = new RelayCommand(_ => BeginEdit(), _ => CanBeginEdit());
            UpdateCommand = new RelayCommand(_ => Update(), _ => CanUpdate());
            CancelCommand = new RelayCommand(_ => Cancel(), _ => CanCancel());
            DeleteCommand = new RelayCommand(_ => Delete(), _ => CanDelete());
        }

        private void Add()
        {
            if (!int.TryParse(Age, out var parsedAge)) return;

            var emp = new Employee
            {
                FirstName = FirstName?.Trim(),
                LastName = LastName?.Trim(),
                Position = Position?.Trim(),
                Age = parsedAge
            };

            Employees.Add(emp);
            ClearFields();
        }

        private bool CanAdd()
        {
            if (IsEditing) return false;
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Position)) return false;
            return int.TryParse(Age, out var a) && a >= 0;
        }

        private void BeginEdit()
        {
            if (SelectedEmployee == null) return;
            IsEditing = true;
            // fields already set from SelectedEmployee setter
        }

        private bool CanBeginEdit() => SelectedEmployee != null && !IsEditing;

        private void Update()
        {
            if (SelectedEmployee == null) return;
            if (!int.TryParse(Age, out var parsedAge)) return;

            SelectedEmployee.FirstName = FirstName?.Trim();
            SelectedEmployee.LastName = LastName?.Trim();
            SelectedEmployee.Position = Position?.Trim();
            SelectedEmployee.Age = parsedAge;

            IsEditing = false;
        }

        private bool CanUpdate() => IsEditing && SelectedEmployee != null && !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(Position) && int.TryParse(Age, out var a) && a >= 0;

        private void Cancel()
        {
            IsEditing = false;
            if (SelectedEmployee != null)
            {
                FirstName = SelectedEmployee.FirstName;
                LastName = SelectedEmployee.LastName;
                Position = SelectedEmployee.Position;
                Age = SelectedEmployee.Age.ToString();
            }
            else
            {
                ClearFields();
            }
        }

        private bool CanCancel() => IsEditing;

        private void Delete()
        {
            if (SelectedEmployee == null) return;
            var toRemove = SelectedEmployee;
            SelectedEmployee = null;
            Employees.Remove(toRemove);
            ClearFields();
        }

        private bool CanDelete() => SelectedEmployee != null && !IsEditing;

        private void ClearFields()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Position = string.Empty;
            Age = string.Empty;
        }

        private void RaiseCanExecChanged()
        {
            AddCommand.RaiseCanExecuteChanged();
            EditCommand.RaiseCanExecuteChanged();
            UpdateCommand.RaiseCanExecuteChanged();
            CancelCommand.RaiseCanExecuteChanged();
            DeleteCommand.RaiseCanExecuteChanged();
        }
    }
}