using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo.Vista
{
    public partial class VistaProposiciones : ContentPage
    {
        public VistaProposiciones()
        {
            InitializeComponent();
        }

        private void ListaProposiciones_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((bool)IrA.GetValue(IsVisibleProperty) == false)
                IrA.SetValue(IsVisibleProperty, true);
        }

        private async void IrA_OnClicked(object sender, EventArgs e)
        {
            new Animation {
                    { 0, 0.5, new Animation (v => this.TranslationY = v, 0, -30) },
                    { 0.5, 1.0, new Animation (v => this.TranslationY = v, -30, 0, easing: Easing.CubicInOut) },
                    { 0, 0.5, new Animation (h => this.TranslationX = h, 0, -30) },
                    { 0.5, 1.0, new Animation (h => this.TranslationX = h, -30, 0, easing: Easing.CubicInOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);

            var selectedItem = this.ListaProposiciones.SelectedItem;
            await Navigation.PushAsync(new DynamicText((Proposicion)selectedItem));
            //throw new NotImplementedException();
        }

        private void VistaProposiciones_OnAppearing(object sender, EventArgs e)
        {
            new Animation {
                    { 0.0, 1.0, new Animation (h => this.TranslationX = h, 30, 0, easing: Easing.SpringOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
        }
    }
}