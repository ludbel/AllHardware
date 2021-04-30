using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class FuentePoder
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Potencia { get; set; }
        public string Corriente { get; set; }

        public FuentePoder(string marca, string modelo, string potencia, string corriente)
        {
            Marca = marca;
            Modelo = modelo;
            Potencia = potencia;
            Corriente = corriente;
        }
    }
}
