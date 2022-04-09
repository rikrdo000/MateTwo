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
    public class ModelViewProposicion : ModelViewBase
    { 
      
        private Proposicion proposicion;

        public Proposicion Proposicion
        {
            get { return proposicion; }
            set { proposicion = value; OnPropertyChanged(); }
        }


        public async void LoadTitulos()
        {
            await GetData("https://calculoiv.azurewebsites.net/api/Proposicion");
        }

        public ModelViewProposicion()
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
