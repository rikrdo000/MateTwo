using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentPageBase : ContentPage
	{

        
		public ContentPageBase ()
		{
			InitializeComponent ();
		}


        public void AnimateTransition()
        {
            new Animation {
                    { 0, 0.5, new Animation (v => this.TranslationY = v, 0, -30) },
                    { 0.5, 1.0, new Animation (v => this.TranslationY = v, -30, 0, easing: Easing.CubicInOut) },
                    { 0, 0.5, new Animation (h => this.TranslationX = h, 0, -30) },
                    { 0.5, 1.0, new Animation (h => this.TranslationX = h, -30, 0, easing: Easing.CubicInOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
        }

        public void AnimateTransitionPage()
        {
            new Animation {
                    //{ 0, 0.5, new Animation (v => this.TranslationY = v, 30, 0) },
                    //{ 0.0, 1.0, new Animation (v => this.TranslationY = v, 30, 0, easing: Easing.CubicIn) },
                    //{ 0, 0.5, new Animation (h => this.TranslationX = h, 30, 0) },
                    { 0.0, 1.0, new Animation (h => this.TranslationX = h, 30, 0, easing: Easing.SpringOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
        }
    }
}