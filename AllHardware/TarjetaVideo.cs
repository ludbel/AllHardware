using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class TarjetaVideo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidad { get; set; }
        public string Memoria { get; set; }

        public TarjetaVideo(string marca, string modelo, string velocidad, string memoria)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidad = velocidad;
            Memoria = memoria;
        }

    }
}
