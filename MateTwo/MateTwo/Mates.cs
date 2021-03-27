using System;
using System.Collections.Generic;
using System.Text;

namespace MateTwo
{

    public class Mates
    {
        public string definicion { get; set; }
        public string subelemento { get; set; }
        public string imagen { get; set; }
        public string titulo { get; set; }
        public string enunciado { get; set; }
        public string lectura { get; set; }


        public Mates()
        {

        }

        public Mates(string def, string sub, string img, string title, string enunc, string reading)
        {
            definicion = def;
            subelemento = sub;
            imagen = img;
            titulo = title;
            enunciado = enunc;
            lectura = reading;
        }

        public override string ToString()
        {
            return titulo;
            return base.ToString();
        }

        public Mates(bool verdad)
        {

        }

        public void ManualGets1()
        {
            definicion = CadenasDeTexto.definicion1_1;
            subelemento = CadenasDeTexto.subelemento1_1;
            imagen = CadenasDeTexto.imagen1_1;
            titulo = CadenasDeTexto.titulo1_1;
            enunciado = CadenasDeTexto.enunciado1_1;
            lectura = CadenasDeTexto.lectura1_1;
        }




    }

    public class MatesTitutlos
    {
        //public string[11] definicion { get; set; }

        public string[] definicion = new string[20];
        public MatesTitutlos()
        {
            for (int i = 0; i<10; i++)
            {
                definicion[i] = "Definicion" + "1." + i.ToString();
            }
        }


    }


    



}
