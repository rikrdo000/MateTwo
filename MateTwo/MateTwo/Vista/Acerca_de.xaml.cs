using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo.Vista
{
    
    public partial class Acerca_de : ContentPage
    {
        public Acerca_de()
        {
            InitializeComponent();
        }


        private void Acerca_de_OnAppearing(object sender, EventArgs e)
        {
            new Animation {
                    { 0.0, 1.0, new Animation (h => this.TranslationX = h, 30, 0, easing: Easing.SpringOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
        }
    }
}