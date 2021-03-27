using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MateTwo.DependencyServices;
using Xamarin.Forms;

namespace MateTwo
{
    public class ModelViewMate : ObjectModify
    { 
        public Mates hoja1 = new Mates();
        public Mates hoja2 = new Mates();

        public MatesTitutlos matetitulos = new MatesTitutlos();


        ITextToSpeech service;



        public ObservableCollection<MatesTitutlos> collection = new ObservableCollection<MatesTitutlos>();


        private ObservableCollection<Mates> titulosCollection;


        

        public ObservableCollection<Mates> TitulosCollection
        {
            get { return titulosCollection; }
            set { titulosCollection = value; OnPropertyChanged(); }
        }

        private Mates definicionSeleccionada;

        public Mates DefinicionSeleccionada
        {
            get { return definicionSeleccionada; }
            set { definicionSeleccionada = value; OnPropertyChanged(); }
        }



        public ModelViewMate()
        {
            service = DependencyService.Get<ITextToSpeech>();

            DependencyService.Get<ITextToSpeech>();

            TitulosCollection = new ObservableCollection<Mates>();

            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_1, enunciado = CadenasDeTexto.enunciado1_1, imagen = CadenasDeTexto.imagen1_1, 
                lectura = CadenasDeTexto.lectura1_1, subelemento  = CadenasDeTexto.subelemento1_1, titulo = CadenasDeTexto.titulo1_1
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_2,
                enunciado = CadenasDeTexto.enunciado1_2,
                imagen = CadenasDeTexto.imagen1_2,
                lectura = CadenasDeTexto.lectura1_2,
                subelemento = CadenasDeTexto.subelemento1_2,
                titulo = CadenasDeTexto.titulo1_2
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_3,
                enunciado = CadenasDeTexto.enunciado1_3,
                imagen = CadenasDeTexto.imagen1_3,
                lectura = CadenasDeTexto.lectura1_3,
                subelemento = CadenasDeTexto.subelemento1_3,
                titulo = CadenasDeTexto.titulo1_3
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_4,
                enunciado = CadenasDeTexto.enunciado1_4,
                imagen = CadenasDeTexto.imagen1_4,
                lectura = CadenasDeTexto.lectura1_4,
                subelemento = CadenasDeTexto.subelemento1_4,
                titulo = CadenasDeTexto.titulo1_4
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_5,
                enunciado = CadenasDeTexto.enunciado1_5,
                imagen = CadenasDeTexto.imagen1_5,
                lectura = CadenasDeTexto.lectura1_5,
                subelemento = CadenasDeTexto.subelemento1_5,
                titulo = CadenasDeTexto.titulo1_5
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_6,
                enunciado = CadenasDeTexto.enunciado1_6,
                imagen = CadenasDeTexto.imagen1_6,
                lectura = CadenasDeTexto.lectura1_6,
                subelemento = CadenasDeTexto.subelemento1_6,
                titulo = CadenasDeTexto.titulo1_6
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_7,
                enunciado = CadenasDeTexto.enunciado1_7,
                imagen = CadenasDeTexto.imagen1_7,
                lectura = CadenasDeTexto.lectura1_7,
                subelemento = CadenasDeTexto.subelemento1_7,
                titulo = CadenasDeTexto.titulo1_7
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_8,
                enunciado = CadenasDeTexto.enunciado1_8,
                imagen = CadenasDeTexto.imagen1_8,
                lectura = CadenasDeTexto.lectura1_8,
                subelemento = CadenasDeTexto.subelemento1_8,
                titulo = CadenasDeTexto.titulo1_8
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_9,
                enunciado = CadenasDeTexto.enunciado1_9,
                imagen = CadenasDeTexto.imagen1_9,
                lectura = CadenasDeTexto.lectura1_9,
                subelemento = CadenasDeTexto.subelemento1_9,
                titulo = CadenasDeTexto.titulo1_9
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_10,
                enunciado = CadenasDeTexto.enunciado1_10,
                imagen = CadenasDeTexto.imagen1_10,
                lectura = CadenasDeTexto.lectura1_10,
                subelemento = CadenasDeTexto.subelemento1_10,
                titulo = CadenasDeTexto.titulo1_10
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_11,
                enunciado = CadenasDeTexto.enunciado1_11,
                imagen = CadenasDeTexto.imagen1_11,
                lectura = CadenasDeTexto.lectura1_11,
                subelemento = CadenasDeTexto.subelemento1_11,
                titulo = CadenasDeTexto.titulo1_11
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_12,
                enunciado = CadenasDeTexto.enunciado1_12,
                imagen = CadenasDeTexto.imagen1_12,
                lectura = CadenasDeTexto.lectura1_12,
                subelemento = CadenasDeTexto.subelemento1_12,
                titulo = CadenasDeTexto.titulo1_12
            });

            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_13,
                enunciado = CadenasDeTexto.enunciado1_13,
                imagen = CadenasDeTexto.imagen1_13,
                lectura = CadenasDeTexto.lectura1_13,
                subelemento = CadenasDeTexto.subelemento1_13,
                titulo = CadenasDeTexto.titulo1_13
            });

            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_14,
                enunciado = CadenasDeTexto.enunciado1_14,
                imagen = CadenasDeTexto.imagen1_14,
                lectura = CadenasDeTexto.lectura1_14,
                subelemento = CadenasDeTexto.subelemento1_14,
                titulo = CadenasDeTexto.titulo1_14
            });

            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_15,
                enunciado = CadenasDeTexto.enunciado1_15,
                imagen = CadenasDeTexto.imagen1_15,
                lectura = CadenasDeTexto.lectura1_15,
                subelemento = CadenasDeTexto.subelemento1_15,
                titulo = CadenasDeTexto.titulo1_15
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_16,
                enunciado = CadenasDeTexto.enunciado1_16,
                imagen = CadenasDeTexto.imagen1_16,
                lectura = CadenasDeTexto.lectura1_16,
                subelemento = CadenasDeTexto.subelemento1_16,
                titulo = CadenasDeTexto.titulo1_16
            });
            titulosCollection.Add(new Mates()
            {
                definicion = CadenasDeTexto.definicion1_17,
                enunciado = CadenasDeTexto.enunciado1_17,
                imagen = CadenasDeTexto.imagen1_17,
                lectura = CadenasDeTexto.lectura1_17,
                subelemento = CadenasDeTexto.subelemento1_17,
                titulo = CadenasDeTexto.titulo1_17
            });

            //TitulosCollection.Add(new Mates() { definicion = "HOLABB", enunciado = "", subelemento = "", titulo = "", imagen = "", lectura = ""});
            //TitulosCollection.Add(new Mates() { definicion = "HOLABB1", enunciado = "", subelemento = "", titulo = "", imagen = "", lectura = "" });
            //TitulosCollection.Add(new Mates() { definicion = "HOLABB2", enunciado = "", subelemento = "", titulo = "", imagen = "", lectura = "" });
            //TitulosCollection.Add(new Mates() { definicion = "HOLABB3", enunciado = "", subelemento = "", titulo = "", imagen = "", lectura = "" });
            //TitulosCollection.Add(new Mates() { definicion = "HOLABB4", enunciado = "", subelemento = "", titulo = "", imagen = "", lectura = "" });
            //TitulosCollection.Add(new Mates() { definicion = "HOLABB5", enunciado = "", subelemento = "", titulo = "", imagen = "" });


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
