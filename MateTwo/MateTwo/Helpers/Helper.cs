using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Modelo;
using Newtonsoft.Json;

namespace MateTwo.Helpers
{
    public class Helper
    {
        private Definiciones titulos;

        public Definiciones Titulos
        {
            get { return titulos; }
            set { titulos = value; }
        }

        private List<Definiciones> titulosDynamic;


        private static IEnumerable<Definicion> t2;

        public static IEnumerable<Definicion> T2
        {
            get { return T2; }
            set { T2 = value; }
        }


        //public Definiciones TitulosDynamic
        //{
        //    get { return titulosDynamic; }
        //    set { titulosDynamic = value; }
        //}
        public List<Definiciones> TitulosDynamic
        {
            get { return titulosDynamic; }
            set { titulosDynamic = value; }
        }
        public Helper()
        {
            LoadTitulos();
        }

        public async void LoadTitulos()
        {
            await GetData($"https://unamcalculoiv20210404224051.azurewebsites.net/api/Definicion");
        }

        private async Task GetData(string url)
        {
            HttpClient http = new HttpClient();

            var response = await http.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<IEnumerable<Definicion>>(jsonResult);

            T2 = result;
            //Titulos = titulosDynamic[0];
        }


    }
}
