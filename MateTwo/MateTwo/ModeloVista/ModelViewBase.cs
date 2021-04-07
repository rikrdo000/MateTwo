using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Annotations;
using MateTwo.DependencyServices;
using MateTwo.Modelo;
using MateTwo.Vista;
using Newtonsoft.Json;

namespace MateTwo.ModeloVista
{
    public class ModelViewBase : ObjectModify
    {
        public ITextToSpeech service;

        private IEnumerable<Definicion> def;

        public IEnumerable<Definicion> Def
        {
            get { return def; }
            set { def = value; OnPropertyChanged(); }
        }

        private IEnumerable<Proposicion> prop;

        public IEnumerable<Proposicion> Prop
        {
            get { return prop; }
            set { prop = value; OnPropertyChanged(); }
        }
        public ModelViewBase()
        {
            
        }

        public async Task GetData(string url)
        {
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();

            if (url.Contains("Definicion"))
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<Definicion>>(jsonResult);
                Def = result;
            }

            if (url.Contains("Proposicion"))
            {
                var result = JsonConvert.DeserializeObject<IEnumerable<Proposicion>>(jsonResult);
                Prop = result;
            }
        }

    }
}
