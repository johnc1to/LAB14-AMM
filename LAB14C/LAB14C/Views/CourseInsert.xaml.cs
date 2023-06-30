using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

public partial class CourseInsert : ContentPage
{
    
    public CourseInsert()
    {
        InitializeComponent();

        BindingContext = new CourseInsertviewModel();
    }
}