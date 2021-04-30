using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class gabinete
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Formato { get; set; }
        public string Puertos { get; set; }
        public string Color { get; set; }

        public gabinete(string marca, string modelo, string formato, string puertos, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Formato = formato;
            Puertos = puertos;
            Color = color;
        }
    }
}
