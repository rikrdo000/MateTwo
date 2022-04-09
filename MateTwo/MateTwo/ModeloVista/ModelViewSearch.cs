using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MateTwo.DependencyServices;
using MateTwo.Modelo;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MateTwo.ModeloVista
{
    public class ModelViewSearch : ModelViewBase
    {
        private Busqueda busqueda;

        public Busqueda Busqueda
        {
            get { return busqueda; }
            set { busqueda = value; OnPropertyChanged(); }
        }

        private IEnumerable<Busqueda> find;

        public IEnumerable<Busqueda> Find
        {
            get { return find; }
            set { find = value; OnPropertyChanged(); }
        }

        private IEnumerable<Busqueda> find2;

        public IEnumerable<Busqueda> Find2
        {
            get { return find2; }
            set { find2 = value; /*OnPropertyChanged();*/ }
        }

        private Busqueda titulo_a_buscar;

        public Busqueda Titulo_a_buscar
        {
            get { return titulo_a_buscar; }
            set { titulo_a_buscar = value;
                Console.WriteLine("value {0}", value.ToString());
                OnPropertyChanged(); }
        }


        public async void LoadTitulos()
        {
            Find = new List<Busqueda>();
            await GetData("https://calculoiv.azurewebsites.net/api/Proposicion");
            await GetData("https://calculoiv.azurewebsites.net/api/Definicion");
            RellenaListaDeBusqueda();
        }


        private void RellenaListaDeBusqueda()
        {
            List<Busqueda> getItems = new List<Busqueda>();// Find;
            //var get = from d in Def
            //    from p in Prop
            //    select (d.titulo);

            var get = from d in Def
                select (d.titulo);

            Console.WriteLine("Definiciones count:{0} ", get.Count());
            var get2=
                from p in Prop
                select (p.titulo);
            Console.WriteLine("proposiciones count:{0} ", get2.Count());
            get = get.Concat(get2);
            Console.WriteLine("SUMATOTAL count:{0} ", get.Count());
            Console.WriteLine(" SUMA items_get:{0} items_get2:{1}", get.Count(), get2.Count() );

            //var see = get as IEnumerable<Busqueda>;
            foreach (var VARIABLE in get.ToList())
            {
                Console.WriteLine("titulos {0}",VARIABLE);
                Busqueda f = new Busqueda();
                f.titulo = VARIABLE;
                Console.WriteLine("titulos {0}", f.titulo);
                getItems.Add(f);
                //Find.(f);
            }

            Find = getItems;
            Find2 = getItems;
            OnPropertyChanged();
            //            var li = get as IEnumerable<Busqueda>;
            //= from d in Def
            //   from p in Prop
            //   select (d.titulo, p.titulo);

            //var see = Find as ICollection<Busqueda>;

            //see.Add(get => );


            //Busqueda.titulo.Where(c => c.IsValid).ToList().SetValue(c => c.CreditLimit = 1000);


            //var query = Find.Select(x =>
            //{
            //    x.titulo = "foo";
            //    return x;
            //});

            // = from d in Def
            //    from p in Prop
            //    select (d.titulo, p.titulo);
            ////Find = (Busqueda.titulo)salida2.Concat(salida);
            //join p in Prop where  select d.titulo, p.titulo;

            //IEnumerable<string> concatenationQuery = (List)Def.Concat(Prop);
            //var all = from a in Def
            //    join b in Prop 
            //    select new { a, b };


            //var items = from d in Def select d.titulo && from p in Prop select p.titulo;

            //foreach (var VARIABLE in Def)
            //{

            //}
        }

        public ModelViewSearch()
        {
            LoadTitulos();
        }
    }
}
