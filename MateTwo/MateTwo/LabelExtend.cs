using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using Xamarin.Forms;

namespace MateTwo
{
    class LabelExtend : Label
    {
        private static string _overText;

        public static string OverText
        {
            get => _overText;
            set => _overText = value;
        }


        public LabelExtend(string over)
        {
            over = "HOLA BEBECITO";
            OverText = over;
        }
    }
}
