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
  public  class Auto
    {
      public DataTable Listar(VIEW_AUTOS obj)
      {
          DataSet ds = new DataSet();
          ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_AUTO_L_AUTO", obj.MARCA, obj.NUMERO_PLACA);
          return ds.Tables[0];
      }
      public static DataTable Carga()
      {
          DataSet ds = new DataSet();
          ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_AUTOS_PROC_C_AUTOS");
          return ds.Tables[0];
      }
      public int Editar(VIEW_AUTOS objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AUTO_A_AUTO", objE.ID, objE.COLOR, objE.NUM_LLANTAS, objE.NUM_ANNIO, objE.MARCA, objE.NUMERO_PLACA, objE.PESO_VEHICULAR);
          //if (i > 0)
          //{

          //    mensaje = "Actualizado correctamente";
          //}
          //else
          //{

          //    mensaje = "error al actualizar";
          //}
          return i;
      }
      public int Insertar(VIEW_AUTOS objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AUTO_I_AUTO", objE.COLOR, objE.NUM_LLANTAS, objE.NUM_ANNIO, objE.MARCA, objE.NUMERO_PLACA, objE.PESO_VEHICULAR);
          //if (i > 0)
          //{

          //    mensaje = "Registro insertado correctamente";
          //}
          //else
          //{

          //    mensaje = "error al insertar";
          //}
          return i;
      }
      public string Eliminar(VIEW_AUTOS objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AUTO_E_AUTO", objE.ID);
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


      public DataTable Obtener(VIEW_AUTOS objE)
      {

          DataSet ds = new DataSet();
          ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_AUTO_O_AUTO", objE.ID);
          return ds.Tables[0];
      }



    }
}
