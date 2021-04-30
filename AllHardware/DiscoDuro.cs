using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class DiscoDuro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string Capacidad { get; set; }
        public int RPM { get; set; }

        public DiscoDuro(string marca, string modelo, string tipo, string capacidad, int rpm)
        {
            Marca = marca;
            Modelo = modelo;
            Tipo = tipo;
            Capacidad = capacidad;
            RPM = rpm;
        }
    }
}
