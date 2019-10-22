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
    public class Boleta
    {
        public DataTable Listar(VIEW_LISTADO_BOLE_PAGO obj)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_BOLETA_PAGO_PROC_L_BOLETA_PAGO", obj.ID_PERS, obj.NU_ANNO);
            return ds.Tables[0];
        }
        public DataTable Filtra(VIEW_LISTADO_BOLE_PAGO obj)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_BOLETA_PAGO_PROC_LF_BOLETA_PAGO", obj.NOMBRES, obj.PE_PDNI);
            return ds.Tables[0];
        }
        public DataTable Filtrar(string periodo, string mes)
        {
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_LISTADO_BOLE_PAGO_PROC_LISTADO_BOLE_PAGO", periodo, mes);
            return ds.Tables[0];
        }
        public string Editar(VIEW_LISTADO_BOLE_PAGO objE)
        {

            int i = 0;
            string mensaje;
            i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_PAGO_PROC_M_PAGO", objE.ID, objE.ID_PERS, objE.NU_ANNO, objE.NU_MESE, objE.BP_DCTO, objE.IMPORTE, objE.ONP, objE.FONDO, objE.COMISION, objE.SEGURO, objE.CATEGORIA, objE.DEDUCCION, objE.BP_ESSA, objE.VALOR_NETO, objE.VA_HONO, objE.GRATIFICACION, objE.DESC_SEGU, objE.JO_SUBS, objE.BP_CUCA, objE.EPS1, objE.EPS2, objE.OTROS_DESCUENTOS1, objE.OTROS_INGRESOS1);
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
        public string Insertar(VIEW_LISTADO_BOLE_PAGO objE)
        {

            int i = 0;
            string mensaje;
            i = SqlHelper.ExecuteNonQuery(ComBD.cadena, "PACK_PAGO_PROC_I_PAGO", objE.ID_PERS, objE.NU_ANNO, objE.NU_MESE, objE.FECHAPAGO, objE.BP_DCTO, objE.IMPORTE, objE.ONP, objE.FONDO, objE.COMISION, objE.SEGURO, objE.CATEGORIA, objE.DEDUCCION, objE.BP_ESSA, objE.VALOR_NETO, objE.VA_HONO, objE.GRATIFICACION, objE.DESC_SEGU, objE.JO_SUBS, objE.BP_CUCA, objE.EPS1, objE.EPS2, objE.OTROS_DESCUENTOS1, objE.OTROS_INGRESOS1);
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


        public DataTable Obtener(VIEW_JORNADA objE)
        {

            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_JORNADA_PROC_O_JORNADA", objE.ID, objE.PERIODO);
            return ds.Tables[0];
        }
        public DataTable Obtener_2(VIEW_LISTADO_BOLE_PAGO objE)
        {

            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(ComBD.cadena, "PACK_PAGO_PROC_O_PAGO", objE.ID);
            return ds.Tables[0];
        }



    }
}
