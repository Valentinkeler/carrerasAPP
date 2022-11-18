using CarrerasBackEnd.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackEnd.datos
{
    public class HelperDAO
    {
        private HelperDAO instancia;
        public SqlConnection cnn;

        public HelperDAO()
        {
            cnn = new SqlConnection("");
        }

        public  HelperDAO obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public  DataTable get()
        {

        }



    }
}
