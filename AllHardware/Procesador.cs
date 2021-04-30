using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    class Procesador
    {
        public string Modelo { get; set; }
        public string Socket { get; set; }
        public string Nucleo { get; set; }
        public string Frecuencia { get; set; }
        public string FrecuenciaMaxima { get; set; }
        public int NumeroNucleos { get; set; }
        public int NumeroHilos { get; set; }

        public Procesador(string modelo, string socket, string nucleo, string frecuencia, string frecuenciamaxima, int numeronucleos, int numerohilos)
        {
            Modelo = modelo;
            Socket = socket;
            Nucleo = nucleo;
            Frecuencia = frecuencia;
            FrecuenciaMaxima = frecuenciamaxima;
            NumeroNucleos = numeronucleos;
            NumeroHilos = numerohilos;
        }

    }
}
