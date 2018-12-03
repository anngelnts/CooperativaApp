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
    public class DDatosDeCooperativa
    {
        protected bool Response = false;
        public bool Agregar(DatosDeCooperativa obj)
        {
                MYSQLParameter[] parameters = new MYSQLParameter[5];
                parameters[0] = new MYSQLParameter("@Fondo_De_Sepelio_", obj.Fondo_De_Sepelio, MySqlDbType.Decimal);
                parameters[1] = new MYSQLParameter("@Aportacion_", obj.Aportacion, MySqlDbType.Decimal);
                parameters[2] = new MYSQLParameter("@Sepelio_Titular_", obj.Sepelio_Titular, MySqlDbType.Decimal);
                parameters[3] = new MYSQLParameter("@Sepelio_Familiar_", obj.Sepelio_Familiar, MySqlDbType.Decimal);
                parameters[4] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Datos_Cooperativa", parameters);
                return Response;
        }

        //public List<DatoFinanciero> Listar()
        //{
        //    List<DatoFinanciero> List = new List<DatoFinanciero>();
        //    try
        //    {
        //        DataTable data = new DataTable();
        //        data = ConexionMySql.ExecuteProcedureData("USP_ToList_Datos_Financieros");
        //        foreach (DataRow row in data.Rows)
        //        {
        //            DatoFinanciero be = new DatoFinanciero
        //            {
        //                Id_Dato_Financiero = Convert.ToInt32(row["Id_Dato_Financiero"]),
        //                TEA = Convert.ToDouble(row["TEA"]),
        //                TEM = Convert.ToDouble(row["TEM"]),
        //                TED = Convert.ToDouble(row["TED"]),
        //                Seguro_Desgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
        //                Seguro_Multiriesgo = Convert.ToDouble(row["Seguro_Multiriesgo"]),
        //                ITF = Convert.ToDouble(row["ITF"]),
        //                Otros = Convert.ToDouble(row["Otros"]),
        //                FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
        //                Estado = row["Estado"].ToString()
        //            };
        //            List.Add(be);
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("No se encontro Procedimiento Almacenado");
        //    }
        //    return List;
        //}

        public DataTable Listar()
        {
            try
            {
                return ConexionMySql.ExecuteProcedureData("USP_ToList_Datos_Cooperativa");
            }
            catch (Exception)
            {
                Console.WriteLine("[Error al Ejecutar USP_ToList_Datos_Cooperativa]");
                return null;
            }
        }
        public bool Modificar(DatosDeCooperativa obj)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[6];

                parameters[0] = new MYSQLParameter("@Id_Dato_Cooperativa_", obj.Id_Dato_Cooperativa, MySqlDbType.Int32);
                parameters[1] = new MYSQLParameter("@Fondo_De_Sepelio_", obj.Fondo_De_Sepelio, MySqlDbType.Decimal);
                parameters[2] = new MYSQLParameter("@Aportacion_", obj.Aportacion, MySqlDbType.Decimal);
                parameters[3] = new MYSQLParameter("@Sepelio_Titular_", obj.Sepelio_Titular, MySqlDbType.Decimal);
                parameters[4] = new MYSQLParameter("@Sepelio_Familiar_", obj.Sepelio_Familiar, MySqlDbType.Decimal);
                parameters[5] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Update_Datos_Cooperativa", parameters);

            }
            catch (Exception)
            {

                Console.WriteLine("[ERROR MODIFICAR DAOS COOPERATIVA]");
            }
            return Response;
        }
    }
}
