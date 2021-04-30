using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Disipador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoDisipador { get; set; }
        public string TipoVentilador { get; set; }

        public Disipador(string marca, string modelo, string tipodisipador, string tipoventilador)
        {
            Marca = marca;
            Modelo = modelo;
            TipoDisipador = tipodisipador;
            TipoVentilador = tipoventilador;
        }
    }
}
