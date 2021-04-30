using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Ventilador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Potencia { get; set; }
        public string VoltajeOperativo { get; set; }

        public Ventilador(string marca, string modelo, string potencia, string voltajeoperativo)
        {
            Marca = marca;
            Modelo = modelo;
            Potencia = potencia;
            VoltajeOperativo = voltajeoperativo;
        }
    }
}
