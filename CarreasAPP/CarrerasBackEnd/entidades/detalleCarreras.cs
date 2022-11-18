using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.entidades
{
    public class detalleCarreras
    {
        public string añoCursado { get; set; }
        public bool cuatrimestre { get; set; }
        public materias materias { get; set; }
    }
}
