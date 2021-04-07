using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MateTwo.Helpers
{
    class ContentPageTransitions
    {
        public static Animation GlobalAnim (ContentPage cpage)
        {

            
            new Animation {
                    //{ 0, 0.5, new Animation (v => this.TranslationY = v, 30, 0) },
                    //{ 0.0, 1.0, new Animation (v => this.TranslationY = v, 30, 0, easing: Easing.CubicIn) },
                    //{ 0, 0.5, new Animation (h => this.TranslationX = h, 30, 0) },
                    { 0.0, 1.0, new Animation (h => cpage.TranslationX = h, 30, 0, easing: Easing.SpringOut) }
                }
                .Commit(cpage, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
            return null;
        }
    }
}
