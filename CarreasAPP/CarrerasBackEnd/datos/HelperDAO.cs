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
        private static HelperDAO instancia;
        private string cadenaConexion;

        public HelperDAO()
        {
            cadenaConexion = @"Data Source=DESKTOP-EU00IF5;Initial Catalog=DB_Carreras1;Integrated Security=True";
        }

        public static HelperDAO obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public  DataTable get(string SP)
        {
            SqlConnection cnn=new SqlConnection(cadenaConexion);
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP,cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;
        }

        public bool maestroDetalle(string SPmaestro,string spDetalle,carreras oCarreras)
        {
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlTransaction tr = null;
            bool ok = true;
            try
            {
                cnn.Open();
                tr = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(SPmaestro, cnn,tr);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_carrera", oCarreras.nombre);
                cmd.Parameters.AddWithValue("@id_titulo", oCarreras.titulos.id);

                SqlParameter param =new SqlParameter();
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Output;
                param.ParameterName = "@id_carrera";
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                int idCarrera= Convert.ToInt32(param.Value);

                foreach (detalleCarreras item in oCarreras.detallesCarreras)
                {
                    SqlCommand  command =   new SqlCommand(spDetalle,cnn,tr);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@año_cursado",item.añoCursado);
                    command.Parameters.AddWithValue("@cuatrimestre",item.cuatrimestre);
                    command.Parameters.AddWithValue("@id_carrera",idCarrera);

                    command.ExecuteNonQuery();
                }
                tr.Commit();
            }
            catch (Exception)
            {
                if (tr != null)
                    tr.Rollback();
                ok=false;
            }
            finally
            {
                if (cnn!=null&&cnn.State==ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }


    }
}
