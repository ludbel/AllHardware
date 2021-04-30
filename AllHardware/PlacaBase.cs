using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllHardware
{
    public class PlacaBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Formato { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string RanurasExpansion { get; set; }
        public string RanurasMemoriaRam { get; set; }
        public int PuertosSata { get; set; }
        public int PuertosUSB { get; set; }
        public int PuertosRed { get; set; }

        public PlacaBase(string marca, string modelo, string formato, string chipset, string socket, string ranurasexpansion, string ranurasmemoriaram, int puertossata, int puertosusb, int puertosred)
        {
            Marca = marca;
            Modelo = modelo;
            Formato = formato;
            Socket = socket;
            Chipset = chipset;
            RanurasExpansion = ranurasexpansion;
            RanurasMemoriaRam = ranurasmemoriaram;
            PuertosSata = puertossata;
            PuertosUSB = puertosusb;
            PuertosRed = puertosred;
        }
    }
}
