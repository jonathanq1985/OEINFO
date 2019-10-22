using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using BE;
using Conexion;
using Microsoft.ApplicationBlocks.Data;

namespace DA
{
    public class Chofer
    {
        private ComBD conn = new ComBD();
        public int Insertar(VIEW_CHOFER objE)
        {

            int i = 0;
            string rpta = "";

            i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_CHOFER_I_CHOFER", objE.NOMBRE, objE.APELLIDO_PATERNO, objE.APELLIDO_MATERNO, objE.DNI, objE.DIRECCION, objE.NRO_LICENCIA);
                
           //if (i > 0)
           // {
           //     rpta = "Registro Insertado correctamente";
           // }

           // else
           // {
           //     rpta = "ERROR al Insertar";

           // }
            return i;
        }
        //PACK_PERSONAL_PROC_M_PERSONAL

        public string Editar(VIEW_CHOFER objE)
        {

            int i = 0;
            string mensaje;
            i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_CHOFER_A_CHOFER", objE.ID, objE.NOMBRE, objE.APELLIDO_PATERNO, objE.APELLIDO_MATERNO, objE.DNI, objE.DIRECCION, objE.NRO_LICENCIA);
                  if (i > 0)
            {

                mensaje = "Actualizado correctamente";

            }
            else
            {

                mensaje = "error al actualizar";
            }
            return mensaje;
        }

        public string Eliminar(VIEW_CHOFER objE)
        {

            int i = 0;
            string mensaje;
            i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_CHOFER_E_CHOFER", objE.ID);
            if (i > 0)
            {

                mensaje = "Registro eliminado correctamente";
            }
            else
            {

                mensaje = "error al eliminar";
            }
            return mensaje;
        }

        public DataTable Listar(VIEW_CHOFER objE)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_CHOFER_PROC_L_CHOFER", objE.CHOFER);
            return ds.Tables[0];
        }
        public static DataTable Carga()
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_CHOFER_PROC_C_CHOFER");
            return ds.Tables[0];
        }
        public DataTable Obtener(VIEW_CHOFER objE)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_CHOFER_O_CHOFER", objE.ID);
            return ds.Tables[0];
        }
    }
}
