using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Annotations;
using MateTwo.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DynamicText : ContentPage
	{

        private static string _overText;
        private static string _definicion;
        private static string _subelemento;
        private static string _imagen;
        private static string _titulo;
        private static string _enunciado;
        private static string _lectura;

        public static string Definicion
        {
            get => _definicion;
            set => _definicion = value;
        }

        public static string Subelemento
        {
            get => _subelemento;
            set => _subelemento = value;
        }

        public static string Imagen
        {
            get => _imagen;
            set => _imagen = value;
        }

        public static string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public static string Enunciado
        {
            get => _enunciado;
            set => _enunciado = value;
        }

        public static string Lectura
        {
            get => _lectura;
            set => _lectura = value;
        }


        public static string OverText
        {
            get => _overText;
            set => _overText = value;
        }



		public DynamicText (Definicion obj)
		{
            //over = "HOLA BEBECITO";

            //var o = (Definicion)obj;

            var o = obj;

            Definicion = o.capitulo.ToString() +"."+ o.definicionId.ToString();
            Enunciado = o.enunciado;
            Lectura = o.lectura;
            Titulo = o.titulo;

            if (o.imagenes.Length > 0 )
                Imagen = o.imagenes[0].source;
            Subelemento = o.subelemento;
            
            InitializeComponent ();
		}

        public DynamicText(Proposicion obj)
        {
            var o = obj;

            Definicion = o.capitulo.ToString() + "." + o.proposicionId.ToString();
            Enunciado = o.enunciado;
            Lectura = o.lectura;
            Titulo = o.titulo;

            if (o.imagenes.Length > 0)
                Imagen = o.imagenes[0].source;

                
            Subelemento = o.subelemento;

            InitializeComponent();
        }

        private async void  Button_OnClicked(object sender, EventArgs e)
        {
            await MainPage.myMate.Leer(Lectura);
            //throw new NotImplementedException();
        }

        private void DynamicText_OnAppearing(object sender, EventArgs e)
        {
            //new Animation {
            //        { 0, 0.25, new Animation (v => this.TranslationY = v, 30, 0) },
            //        { 0.25, .5, new Animation (v => this.TranslationY = v, 30, 0, easing: Easing.CubicIn) },
            //        { 0, 0.25, new Animation (h => this.TranslationX = h, -30, 0) },
            //        { 0.25, .5, new Animation (h => this.TranslationX = h, 30, 0, easing: Easing.CubicIn) }
            //    }
            //    .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);
            //throw new NotImplementedException();
        }
    }
}