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
    public class Division : INotifyPropertyChanged
    {
        private string name;
        private List<Employee> employers;

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
        public List<Employee> Employers
        {
            get { return employers; }
            set
            {
                employers = value;
                OnPropertyChanged("Employers");
            }
        }

        public Division()
        {
            employers = new List<Employee>();
            PropertyChanged += new PropertyChangedEventHandler(Message_PropertyChanged);
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

        public override string ToString()
        {
            return name;
        }
    }
}
