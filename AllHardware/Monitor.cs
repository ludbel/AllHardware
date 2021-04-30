using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Monitor
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Resolucion { get; set; }
        public string TasaRefresco { get; set; }
        public string Contraste { get; set; }

        public Monitor(string marca, string modelo, string resolucion, string tasarefresco, string contraste)
        {
            Marca = marca;
            Modelo = modelo;
            Resolucion = resolucion;
            TasaRefresco = tasarefresco;
            Contraste = contraste;
        }
    }
}
