using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace LAB14C.ViewModels
{
    public class CourseListViewModel : INotifyPropertyChanged
    {
        private string searchQuery;
        private ObservableCollection<Course> courses;


        public string SearchQuery
        {
            get => searchQuery;
            set
            {
                searchQuery = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Course> Courses
        {
            get => courses;
            set
            {
                courses = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public CourseListViewModel()
        {
            Courses = new ObservableCollection<Course>(); // Inicializa la colección vacía

            SearchCommand = new Command(SearchCourses);
        }

        private void SearchCourses()
        {
            // Lógica para buscar cursos en la base de datos según el SearchQuery
            // Actualiza la colección Courses con los resultados de la búsqueda
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
