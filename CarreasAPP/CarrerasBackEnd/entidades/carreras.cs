using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.entidades
{
    public class carreras
    {
        public string nombre { get; set; }
        public int titulo { get; set; }
        public List<detalleCarreras> detallesCarreras { get; set; }
    }
}
