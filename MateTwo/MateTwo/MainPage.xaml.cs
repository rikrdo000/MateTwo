using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MateTwo
{
    public partial class MainPage : ContentPage
    {
        public static ModelViewMate myMate = new ModelViewMate();

        public MainPage()
        {
            InitializeComponent();
            //BindingContext = new ModelViewMate();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            //DynamicText dynamicView = new DynamicText("HOLA MI AMOR");

            //Navigation.PopAsync(dynamicView);

            await Navigation.PushAsync(new DynamicText(myMate.hoja1));
            //throw new NotImplementedException();
        }

        private async void Definicion1_2_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicText(myMate.hoja2));
        }

        private async void IrA_OnClicked(object sender, EventArgs e)
        {
            //var select_item = Resources["Modelo.DefinicionSeleccionada"] as Mates;

            /*if (this.ListaDefiniciones.SelectedItem == null)
            {
                DisplayAlert("Seleccionar", "Por favor elija el concepto que desea desplegar", "Aceptar", null);
            } */

            var selectedItem =  this.ListaDefiniciones.SelectedItem;
            //Mates mat = ListaDefiniciones.SelectedItem();
            await Navigation.PushAsync(new DynamicText(selectedItem));

           
        }


        private void ListaDefiniciones_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((bool)IrA.GetValue(IsVisibleProperty) == false)
            IrA.SetValue(IsVisibleProperty,true);
        }
    }


}
