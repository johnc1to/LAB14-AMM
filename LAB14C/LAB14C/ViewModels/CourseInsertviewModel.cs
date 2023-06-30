using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LAB14C.ViewModels
{
    public class CourseInsertViewModel : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private decimal credit;
        private DateTime startDate;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public decimal Credit
        {
            get => credit;
            set
            {
                credit = value;
                OnPropertyChanged();
            }
        }

        public DateTime StartDate
        {
            get => startDate;
            set
            {
                startDate = value;
                OnPropertyChanged();
            }
        }

        public ICommand InsertCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CourseInsertViewModel()
        {
            InsertCommand = new Command(InsertCourse);
        }

        private void InsertCourse()
        {
            // Lógica para insertar el curso en la base de datos
            // Utiliza los valores de las propiedades Name, Description, Credit y StartDate
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
