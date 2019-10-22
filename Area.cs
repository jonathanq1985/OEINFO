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
  public  class Area
    {
      public DataTable Listar(VIEW_AREA obj)
      {
          DataSet ds = new DataSet();
          ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_AREA_PROC_L_AREA",obj.CODIGO,obj.AREA);
          return ds.Tables[0];
      }
      public string Editar(VIEW_AREA objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AREA_PROC_M_AREA", objE.ID, objE.CODIGO, objE.AREA);
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
      public string Insertar(VIEW_AREA objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AREA_PROC_I_AREA", objE.CODIGO, objE.AREA);
          if (i > 0)
          {

              mensaje = "Registro insertado correctamente";
          }
          else
          {

              mensaje = "error al insertar";
          }
          return mensaje;
      }
      public string Eliminar(VIEW_AREA objE)
      {

          int i = 0;
          string mensaje;
          i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_AREA_PROC_E_AREA", objE.ID);
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


      public DataTable Obtener(VIEW_AREA objE)
      {

          DataSet ds = new DataSet();
          ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_AREA_PROC_O_AREA", objE.ID);
          return ds.Tables[0];
      }



    }
}
