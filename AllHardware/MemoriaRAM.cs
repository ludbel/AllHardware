using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class MemoriaRAM
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Capacidad { get; set; }
        public string Formato { get; set; }
        public string Voltaje { get; set; }

        public MemoriaRAM(string marca, string modelo, string capacidad, string formato, string voltaje)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            Formato = formato;
            Voltaje = voltaje;
        }
    }
}
