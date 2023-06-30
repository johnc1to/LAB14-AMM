using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LAB14C.Views
{
    public partial class CourseListPage : ContentPage
    {
        public CourseListPage()
        {
            InitializeComponent();

            BindingContext = new CourseListViewModel();
        }
    }