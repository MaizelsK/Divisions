using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Divisions
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> employers;
        public ObservableCollection<Division> divisions;

        public MainWindow()
        {
            InitializeComponent();

            employers = new ObservableCollection<Employee>
            {
                new Employee
                {
                    Name="Иван Иванов", Age=30, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Петр Петров", Age=27, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Маша Машевна", Age=32, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Лена Еленовна", Age=34, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Артем Артемов", Age=38, HireDate =DateTime.Now
                },
                new Employee
                {
                    Name="Григорий Григориев", Age=28, HireDate =DateTime.Now
                },
            };

            divisions = new ObservableCollection<Division>
            {
                new Division {Name = "Консультанты", Employers = { employers[0], employers[2] } },
                new Division {Name = "Менеджеры", Employers = { employers[1], employers[3] }},
                new Division {Name = "Программисты", Employers = { employers[4], employers[5] }},
            };

            divisionList.ItemsSource = divisions;

        }

        private void DivisionList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employeeData.ItemsSource = divisions[divisionList.SelectedIndex].Employers;
        }
    }
}
