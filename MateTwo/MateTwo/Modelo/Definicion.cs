using System;
using System.Collections.Generic;
using System.Text;

namespace MateTwo.Modelo
{


    public class Definiciones
    {
        public Definicion[] Definicion { get; set; }
    }

    public class Definicion
    {
        public int definicionId { get; set; }
        public int capitulo { get; set; }
        public string subelemento { get; set; }
        public string titulo { get; set; }
        public string enunciado { get; set; }
        public string lectura { get; set; }
        public DateTime fecha { get; set; }
        public Imagenes[] imagenes { get; set; }
    }

    public class Imagenes
    {
        public int imagenID { get; set; }
        public string source { get; set; }
        public string size { get; set; }
        public int definicionId { get; set; }
    }

}
