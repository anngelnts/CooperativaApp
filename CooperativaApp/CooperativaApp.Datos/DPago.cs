using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
namespace CooperativaApp.Datos
{
    public class DPago
    {
        protected bool Response = false;
        public bool Agregar(Pago obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[10];
        
            parameters[0] = new MYSQLParameter("@Num_Boleta_", obj.Num_Boleta, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Id_Cronograma_", obj.Id_Cronograma, MySqlDbType.Int32);
            parameters[2] = new MYSQLParameter("@Observacion_", obj.Observacion, MySqlDbType.VarChar);
            parameters[3] = new MYSQLParameter("@Tipo_De_Pago_", obj.Tipo_De_Pago, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Cuota_Fija_", obj.Cuota_Fija, MySqlDbType.Decimal);
            parameters[5] = new MYSQLParameter("@Dias_Morosidad_", obj.Dias_Morosidad, MySqlDbType.Int32);
            parameters[6] = new MYSQLParameter("@Monto_Morosidad_", obj.Monto_Morosidad, MySqlDbType.Decimal);
            parameters[7] = new MYSQLParameter("@Monto_Total_", obj.Monto_Total, MySqlDbType.Decimal);
            parameters[8] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            parameters[9] = new MYSQLParameter("@Id_Usuario_", obj.Id_Usuario, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Pago", parameters);
            return Response;
        }
        public DataTable Listar()
        {
            DataTable data = new DataTable();
            try
            {
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Pagos");
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;

        }


        public DataTable Seleccionar(int Id_Pago)
        {
            DataTable data = new DataTable();
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Id_Pago_", Id_Pago, MySqlDbType.Int32);
                data = ConexionMySql.ExecuteProcedureData("USP_Select_Pago", parameters);

                return data;
            }
            catch
            {
                return data;
            }
        }
    }
}
