using CarrerasBackEnd.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.datos.implementacion
{
    public class carrerasDAO : IcarrerasDAO
    {
        public bool crearCarrera(carreras oCarrera)
        {
            return HelperDAO.obtenerInstancia().maestroDetalle("SP_Crear_Carrera", "SP_Crear_Detalle", oCarrera);          
        }

        public List<materias> getMaterias()
        {
            List<materias>  lst = new List<materias>();
            
            DataTable tabla = HelperDAO.obtenerInstancia().get("SP_Consultar_Materias");

            foreach (DataRow r in tabla.Rows)
            {
                materias m =new materias();

                m.id =Convert.ToInt32(r["id_materias"]);
                m.nombre =Convert.ToString(r["descricion"]);

                lst.Add(m);
            }

            return lst;
        }

        public List<titulo> getTitulos()
        {
            List<titulo> lst = new List<titulo>();

            DataTable tabla = HelperDAO.obtenerInstancia().get("SP_Consultar_titulos");

            foreach (DataRow r in tabla.Rows)
            {
                titulo t = new titulo();

                t.id = Convert.ToInt32(r["id_titulo"]);
                t.nombre = r["descripcion"].ToString();

                lst.Add(t);
            }

            return lst;
        }
    }
}
