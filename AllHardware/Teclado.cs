using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Teclado
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public string TipoSwitch { get; set; }
        public string Cableado { get; set; }

        public Teclado(string marca, string modelo, string tipo, string tiposwitch, string cableado)
        {
            Marca = marca;
            Modelo = modelo;
            Tipo = tipo;
            TipoSwitch = tiposwitch;
            Cableado = cableado;
        }
    }
}
