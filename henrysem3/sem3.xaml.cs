using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace henrysem3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class sem3 : ContentPage
    {
        public sem3(string usuario, string contraseña)
        {
            InitializeComponent();
           // DisplayAlert("Datos que llegan", "el Usuario es: " + usuario ,"la contraseña es: " + contraseña, "cerrar");
                  
        }
    }
}