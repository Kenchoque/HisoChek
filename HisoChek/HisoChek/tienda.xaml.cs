using HisoChek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HisoChek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tienda : ContentPage
    {
        public Tienda()
        {
            InitializeComponent();
            BindingContext = new VMcompras(Navigation);
        }
    }
}