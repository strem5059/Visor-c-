using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visor
{
    [Serializable]
    internal class Controlador
    {
        public string Tipo { get; set; } 
        public int X { get; set; }      
        public int Y { get; set; }
        public string Tecla { get; set; } 
    }
}
