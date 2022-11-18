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
        public titulo titulos { get; set; }
        public List<detalleCarreras> detallesCarreras { get; set; }
        public carreras()
        {
            detallesCarreras = new List<detalleCarreras>();
        }
        public  void agregardetalle(detalleCarreras oDetalle)
        {
            detallesCarreras.Add(oDetalle);
        }
        public void quitardetalle(int id)
        {
            detallesCarreras.RemoveAt(id);
        }
    }
}
