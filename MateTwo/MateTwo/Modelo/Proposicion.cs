using System;
using System.Collections.Generic;
using System.Text;

namespace MateTwo.Modelo
{
    public class Proposiciones
    {
        public Proposicion[] Proposicion { get; set; }
    }

    public class Proposicion
    {
        public int proposicionId { get; set; }
        public int capitulo { get; set; }
        public string subelemento { get; set; }
        public string titulo { get; set; }
        public string enunciado { get; set; }
        public string lectura { get; set; }
        public DateTime fecha { get; set; }
        public ImagenesProposicion[] imagenes { get; set; }
    }

    public class ImagenesProposicion
    {
        public int imagenID { get; set; }
        public string source { get; set; }
        public string size { get; set; }
        public int proposicionId { get; set; }
    }


}
