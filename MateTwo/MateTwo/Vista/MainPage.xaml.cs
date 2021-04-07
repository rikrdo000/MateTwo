using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Helpers;
using MateTwo.Modelo;
using MateTwo.Vista;
using Xamarin.Forms;

namespace MateTwo
{
    public partial class MainPage : ContentPage
    {
        private ContentPageBase contentpage = new ContentPageBase();
        public static ModelViewMate myMate = new ModelViewMate();
        

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            //NavigationPage.BarBackgroundColor = Color.Transparent;

            //var mdPage = Application.Current.MainPage as MasterDetailPage;
            //var navPage = mdPage.Detail as NavigationPage;
            //navPage.BarBackgroundColor = Color.Transparent;

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

            var selectedItem =  this.ListaDefiniciones.SelectedItem;
            await Navigation.PushAsync(new DynamicText((Definicion)selectedItem));

           
        }




        private void ListaDefiniciones_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((bool)IrA.GetValue(IsVisibleProperty) == false)
            IrA.SetValue(IsVisibleProperty,true);
        }

        private void MainPage_OnAppearing(object sender, EventArgs e)
        {
            new Animation {
                    { 0.0, 1.0, new Animation (h => this.TranslationX = h, 30, 0, easing: Easing.SpringOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
        }
    }


}
