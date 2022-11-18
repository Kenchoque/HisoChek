using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace HisoChek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nosotros : ContentPage
    {
        ObservableCollection<NosotrosInfo> nosotros;
        public Nosotros()
        {
            InitializeComponent();
            inicioList = new ObservableCollection<NosotrosInfo>
            {
                new NosotrosInfo{ Title="Quienes Somos?",
                    Estado=" somos una empresa que que vende productos artisticos y procura la satisfacción total de las necesidades y expectativas de nuestros clientes, brindándoles productos de primera calidad, pero lo más importante prestándoles un excelente servicio",
                    ImagenBB="https://i.ibb.co/dgX2twJ/empresa.png"},
                new NosotrosInfo{ Title="Que queremos lograr?",
                    Estado="Nuestra visión es ser los más grandes líderes de venta de productos artísticos, ofrecer los productos más innovadores en el mercado y que sean de buena calidad, adelantándonos a las necesidades de todas las personas.",
                    ImagenBB="https://i.ibb.co/2ZrqG4r/vision.png"},

            };
            ItemsSource = inicioList;
        }
        private async void OpenWhatsApp(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+51936837340", "Hola, Necesito ayuda");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
        ObservableCollection<NosotrosInfo> inicioList;

        internal ObservableCollection<NosotrosInfo> ItemsSource { get; }

        
    }
}