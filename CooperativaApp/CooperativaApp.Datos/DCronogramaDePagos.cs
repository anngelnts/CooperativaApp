using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CooperativaApp.Datos
{
    public class DCronogramaDePagos
    {
        protected bool Response = false;
        public bool Agregar(CronogramaDePagos obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[18];
            parameters[0] = new MYSQLParameter("@Id_Prestamo_", obj.Id_Prestamo, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Num_Cuota_", obj.Num_Cuota, MySqlDbType.Int32);
            parameters[2] = new MYSQLParameter("@Fecha_De_Vencimiento_", obj.Fecha_De_Vencimiento, MySqlDbType.Date);
            parameters[3] = new MYSQLParameter("@Amortizacion_", obj.Amortizacion, MySqlDbType.Decimal);
            parameters[4] = new MYSQLParameter("@Interes_", obj.Interes, MySqlDbType.Decimal);
            parameters[5] = new MYSQLParameter("@Interes_Diferido_", obj.Interes_Diferido, MySqlDbType.Decimal);
            parameters[6] = new MYSQLParameter("@Seg_Desgravamen_", obj.Seg_Desgravamen, MySqlDbType.Decimal);
            parameters[7] = new MYSQLParameter("@Seg_Multiriesgo_", obj.Seg_Multiriesgo, MySqlDbType.Decimal);
            parameters[8] = new MYSQLParameter("@ITF_", obj.ITF, MySqlDbType.Decimal);
            parameters[9] = new MYSQLParameter("@Otros_", obj.Otros, MySqlDbType.Decimal);
            parameters[10] = new MYSQLParameter("@Saldo_Capital_", obj.Saldo_Capital, MySqlDbType.Decimal);
            parameters[11] = new MYSQLParameter("@Cuota_Fija_", obj.Cuota_Fija, MySqlDbType.Decimal);
            parameters[12] = new MYSQLParameter("@Dias_", obj.Dias, MySqlDbType.Int32);
            parameters[13] = new MYSQLParameter("@Dias_Acumulados_", obj.Dias_Acumulados, MySqlDbType.Int32);
            parameters[14] = new MYSQLParameter("@Dias_Morosidad_", obj.Dias_Morosidad, MySqlDbType.Int32);
            parameters[15] = new MYSQLParameter("@Monto_Morosidad_", obj.Monto_Morosidad, MySqlDbType.Decimal);
            parameters[16] = new MYSQLParameter("@Cuota_Total_", obj.Cuota_Total, MySqlDbType.Decimal);
            parameters[17] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Cronograma_De_Pago", parameters);
            return Response;
        }
        public DataTable ObtenerPagosPendientes(string Tipo_Documento, string Num_Documento)
        {
            DataTable data = new DataTable();
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[2];
                parameters[0] = new MYSQLParameter("@Tipo_Documento_", Tipo_Documento, MySqlDbType.VarChar);
                parameters[1] = new MYSQLParameter("@Num_Documento_", Num_Documento, MySqlDbType.VarChar);
                data = ConexionMySql.ExecuteProcedureData("UPS_ToList_Pagos_Pendientes", parameters);
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;
        }
            public DataTable Listar(int Id_Prestamo)
        {
            DataTable data = new DataTable();
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Id_Prestamo_", Id_Prestamo, MySqlDbType.Int32);
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Cronograma_De_Pagos", parameters);
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;

        }
    }
}
