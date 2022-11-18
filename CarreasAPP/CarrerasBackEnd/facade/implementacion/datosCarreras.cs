using CarrerasBackEnd.datos;
using CarrerasBackEnd.datos.implementacion;
using CarrerasBackEnd.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.facade
{
    public class datosCarreras : Idatos
    {
        private IcarrerasDAO datos;
        public datosCarreras()
        {
            datos= new  carrerasDAO();
        }
        public List<materias> GetMaterias()
        {
            return  datos.getMaterias();
        }

        public List<titulo> GetTitulos()
        {
            return datos.getTitulos();
        }

        public bool PostCarrera(carreras oCarrera)
        {
            return  datos.crearCarrera(oCarrera);
        }
    }
}
