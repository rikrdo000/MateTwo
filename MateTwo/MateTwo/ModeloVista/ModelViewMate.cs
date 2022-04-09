using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MateTwo.DependencyServices;
using MateTwo.Helpers;
using MateTwo.Modelo;
using MateTwo.ModeloVista;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MateTwo
{
    public class ModelViewMate : ModelViewBase
    { 

        private Definicion definicionSeleccionada2;

        public Definicion DefinicionSeleccionada2
        {
            get { return definicionSeleccionada2; }
            set { definicionSeleccionada2 = value; OnPropertyChanged(); }
        }


        public async void LoadTitulos()
        {
            await GetData("https://calculoiv.azurewebsites.net/api/Definicion");
        }

        public ModelViewMate()
        {
            LoadTitulos();

            service = DependencyService.Get<ITextToSpeech>();
            DependencyService.Get<ITextToSpeech>();
            
        }

        public async Task Leer(string texto)
        { 
            if (service == null)
                service = DependencyService.Get<ITextToSpeech>();
            else
            {
                service.Speak(texto);
            }
            
        }

    }
}
