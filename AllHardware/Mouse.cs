using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Mouse
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cableado { get; set; }
        public string Tracking { get; set; }
        public int DPI { get; set; }

        public Mouse(string marca, string modelo, string cableado, string tracking, string dpi)
        {
            Marca = marca;
            Modelo = modelo;
            Cableado = cableado;
            Tracking = tracking;
            DPI = dpi;
        }

    }
}
