using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Divisions
{
    public class Employee : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private DateTime hireDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                hireDate = value;
                OnPropertyChanged("HireDate"); 
            }
        }

        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void Message_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show($"Свойство {e.PropertyName} у {name} изменилось");
        }

        public Employee()
        {
            PropertyChanged += new PropertyChangedEventHandler(Message_PropertyChanged);
        }
    }
}
