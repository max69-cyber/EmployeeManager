using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeManager
{
    public partial class EmployeeListPage : Page
    {
        public List<Employee> _employees { get; set; }

        public EmployeeListPage()
        {
            InitializeComponent();
            _employees = new List<Employee>
            {
                new Employee { Name = "Иван Иванов", Position = "Менеджер" },
                new Employee { Name = "Петр Петров", Position = "Разработчик" },
                new Employee { Name = "Сергей Сергеев", Position = "Директор" }
            };
            EmployeeDataGrid.ItemsSource = _employees;
        }

        private void EditEmployee(object sender, RoutedEventArgs e)
        {
            if (EmployeeDataGrid.SelectedItem is Employee selectedEmployee)
            {
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
            }
        }
    }
}

