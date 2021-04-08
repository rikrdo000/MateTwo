using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MateTwo.Annotations;
using MateTwo.Modelo;
using MateTwo.ModeloVista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MateTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {

        private ListView lviewsListView;

        private string s_bar;

        public string S_bar
        {
            get { return s_bar; }
            set { s_bar = value; OnPropertyChanged(); }
        }



        //private IEnumerable<Busqueda> collecciondeElementos;

        //public string CollecciondeElementos
        //{
        //    get { return CollecciondeElementos; }
        //    set { CollecciondeElementos = value; }
        //}

        private readonly ModelViewSearch mvSearch;

        //public ModelViewSearch mvSearch2;

        public ModelViewSearch MVSearch
        {
            get { return mvSearch; }
            //set { mvSearch = value; OnPropertyChanged(); }
        }

        private readonly IEnumerable<Busqueda> local;

        public Search()
        {
            
            //Lviews = ListaBusqueda;
            InitializeComponent();

            //mvSearch2 = new ModelViewSearch();

            mvSearch = this.Resources["Modelo"] as ModelViewSearch;

            //Console.WriteLine("total {0}", mvSearch.Find2.Count());
        }

        private void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ListaBusqueda.IsVisible = false;
            //ListaBusqueda.BeginRefresh();

            //ItemLabel.TextColor = Color.CornflowerBlue;
            Console.WriteLine("totalinit {0}", mvSearch.Find2.Count());

            //var titulos  = this.Resources["Modelo"] as ModelViewSearch;

            //titulos = (List<Busqueda>) titulos.Find;

            try
            {
                Console.WriteLine("totalprev: {0}", mvSearch.Find2.Count());
                List<Busqueda> Bus = new List<Busqueda>();
                List<Busqueda> Bus2 = new List<Busqueda>(mvSearch.Find2);

                 //Bus2.AddRange(MVSearch.Find);// (List<Busqueda>)MVSearch.Find;
                 if (Bus2.Any())
                 {

                 
                    foreach (Busqueda VARIABLE in Bus2)
                    {
                    Console.WriteLine("total: {0}", mvSearch.Find2.Count());
                    Console.WriteLine("nextvalue{0}, oldvalue{1}", e.NewTextValue, e.OldTextValue);
                    if (VARIABLE.titulo.ToLower().Contains(e.NewTextValue.ToLower()))
                        Bus.Add(VARIABLE);
                    }
                    ListaBusqueda.ItemsSource = Bus;
                    ListaBusqueda.IsVisible = true;
                 }
                

//                var dataEmpty = MVSearch.Find.Where(i => i.titulo.ToLower().Contains(e.NewTextValue.ToLower()));

//                if (string.IsNullOrWhiteSpace(e.NewTextValue))
//                    ListaBusqueda.IsVisible = false;
////                else if (dataEmpty.Max().Length == 0)
//                else if (!dataEmpty.Any())
//                            ListaBusqueda.IsVisible = false;
//                else
//                {
//                    ListaBusqueda.ItemsSource = MVSearch.Find.Where(i => i.titulo.ToLower().Contains(e.NewTextValue.ToLower()));
//                    foreach (Busqueda VARIABLE in ListaBusqueda.ItemsSource)
//                    {
//                        Console.WriteLine("Encontre {0}",VARIABLE.titulo);
//                    }
                    
//                }
                    
                    
            }
            catch (Exception ex)
            {
                ListaBusqueda.IsVisible = false;
            }
            //ListaBusqueda.EndRefresh();

            //S_bar = ActualSearch.Text;
        }

        private void Search_OnAppearing(object sender, EventArgs e)
        {
            
        }

        private void ListaDefiniciones_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if ((bool)IrA.GetValue(IsVisibleProperty) == false)
                IrA.SetValue(IsVisibleProperty, true);

            Console.WriteLine("Titulo seleccionado {0}", mvSearch.Titulo_a_buscar.titulo);
        }

        private async void IrA_OnClicked(object sender, EventArgs e)
        {
            new Animation {
                    { 0, 0.5, new Animation (v => this.TranslationY = v, 0, -30) },
                    { 0.5, 1.0, new Animation (v => this.TranslationY = v, -30, 0, easing: Easing.CubicInOut) },
                    { 0, 0.5, new Animation (h => this.TranslationX = h, 0, -30) },
                    { 0.5, 1.0, new Animation (h => this.TranslationX = h, -30, 0, easing: Easing.CubicInOut) }
                }
                .Commit(this, "AppleIconBounceChildAnimations", length: 1000, repeat: () => false);

            //var selectedItem = mvSearch.Titulo_a_buscar;


            var definicion_seleccionada = from d in mvSearch.Def
                                          where d.titulo == mvSearch.Titulo_a_buscar.titulo
                                          select (d);

            

            var proposicion_seleccionada =
                from p in mvSearch.Prop
                where p.titulo == mvSearch.Titulo_a_buscar.titulo
                select (p);

            Definicion de = new Definicion();
            Proposicion pr = new Proposicion();


            foreach (var VARIABLE in definicion_seleccionada)
            {
                de = VARIABLE;
            }
            foreach (var VARIABLE in proposicion_seleccionada)
            {
                pr = VARIABLE;
            }

            
            if (!string.IsNullOrEmpty(de.titulo))
            {
                await Navigation.PushAsync(new DynamicText(de));
            }
            else
            {
                await Navigation.PushAsync(new DynamicText(pr));
            }

        }
    }
}