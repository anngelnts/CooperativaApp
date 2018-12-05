using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperativaApp.Datos
{
    public class DAportes
    {
        protected bool Response = false;
        public bool Agregar(Aporte obj)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[10];
                parameters[0] = new MYSQLParameter("@Num_Boleta_", obj.Num_Boleta, MySqlDbType.VarChar);
                parameters[1] = new MYSQLParameter("@Id_Socio_", obj.Id_Socio, MySqlDbType.Int32);
                parameters[2] = new MYSQLParameter("@Observacion_", obj.Observacion, MySqlDbType.VarChar);
                parameters[3] = new MYSQLParameter("@Id_Dato_Cooperativa_", obj.Id_Dato_Cooperativa, MySqlDbType.Int32);
                parameters[4] = new MYSQLParameter("@Monto_Aporte_", obj.Monto_Aporte, MySqlDbType.Decimal);
                parameters[5] = new MYSQLParameter("@Monto_Fondo_De_Sepelio_", obj.Monto_Fondo_De_Sepelio, MySqlDbType.Decimal);
                parameters[6] = new MYSQLParameter("@Otros_", obj.Otros, MySqlDbType.Decimal);
                parameters[7] = new MYSQLParameter("@Monto_Total_", obj.Monto_Total, MySqlDbType.Decimal);
                parameters[8] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                parameters[9] = new MYSQLParameter("@Id_Usuario_", obj.Id_Usuario, MySqlDbType.Int32);
                return ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Aporte", parameters);

            }
            catch (Exception e)
            {
                Console.WriteLine("[ INNER EXCEPTION ]" + e.InnerException);
                Console.WriteLine("[ INNER MESSAGE ]" + e.Message);
                Console.WriteLine("[ERROR AGREGAR Aporte]");
                return false;
            }
        }

        public bool Modificar(Aporte obj)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[11];
                parameters[0] = new MYSQLParameter("@Id_Aporte_", obj.Id_Aporte, MySqlDbType.Int32);
                parameters[1] = new MYSQLParameter("@Num_Boleta_", obj.Num_Boleta, MySqlDbType.VarChar);
                parameters[2] = new MYSQLParameter("@Id_Socio_", obj.Id_Socio, MySqlDbType.Int32);
                parameters[3] = new MYSQLParameter("@Observacion_", obj.Observacion, MySqlDbType.VarChar);
                parameters[4] = new MYSQLParameter("@Id_Dato_Cooperativa_", obj.Id_Dato_Cooperativa, MySqlDbType.Int32);
                parameters[5] = new MYSQLParameter("@Monto_Aporte_", obj.Monto_Aporte, MySqlDbType.Decimal);
                parameters[6] = new MYSQLParameter("@Monto_Fondo_De_Sepelio_", obj.Monto_Fondo_De_Sepelio, MySqlDbType.Decimal);
                parameters[7] = new MYSQLParameter("@Otros_", obj.Otros, MySqlDbType.Decimal);
                parameters[8] = new MYSQLParameter("@Monto_Total_", obj.Monto_Total, MySqlDbType.Decimal);
                parameters[9] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                parameters[10] = new MYSQLParameter("@Id_Usuario_", obj.Id_Usuario, MySqlDbType.Int32);
                return ConexionMySql.ExecuteProcedureNonQuery("USP_Update_Aporte", parameters);

            }
            catch (Exception e)
            {
                Console.WriteLine("[ INNER MESSAGE ]" + e.InnerException);
                Console.WriteLine("[ INNER MESSAGE ]" + e.Message);
                Console.WriteLine("[ERROR MODIFICAR Aporte]");
                return false;
            }
        }

        public DataTable Listar()
        {
            try
            {
                return ConexionMySql.ExecuteProcedureData("USP_ToList_Aporte");
            }
            catch (Exception)
            {
                Console.WriteLine("[Error al Ejecutar USP_ToList_Aporte]");
                return null;
            }
        }
        public DataTable BuscarAportesPorNumeroDocumento(string NumeroDocumento)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@NumeroDocumento", NumeroDocumento, MySqlDbType.VarChar);
                return ConexionMySql.ExecuteProcedureData("BuscarAportesDeSocioPorDocumento", parameters);
            }
            catch (Exception)
            {
                Console.WriteLine("[Error al Ejecutar USP_ToList_Aporte]");
                return null;
            }
        }
    }
}
