using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CooperativaApp.Datos
{
    public class DDatoFinanciero
    {
        protected bool Response = false;
        public bool Agregar(DatoFinanciero obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[7];
            parameters[0] = new MYSQLParameter("@TEA", obj.TEA, MySqlDbType.Double);
            parameters[1] = new MYSQLParameter("@TEM", obj.TEM, MySqlDbType.Double);
            parameters[2] = new MYSQLParameter("@TED", obj.TED, MySqlDbType.Double);
            parameters[3] = new MYSQLParameter("@Seguro_Desgravamen", obj.Seguro_Desgravamen, MySqlDbType.Double);
            parameters[4] = new MYSQLParameter("@ITF", obj.ITF, MySqlDbType.Double);
            parameters[5] = new MYSQLParameter("@Otros", obj.Otros, MySqlDbType.Double);
            parameters[5] = new MYSQLParameter("@Seguro_Multiriesgo", obj.Seguro_Multiriesgo, MySqlDbType.Double);
            parameters[6] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Datos_Financieros", parameters);
            return Response;
        }
        public bool Modificar(DatoFinanciero obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[8];
            parameters[0] = new MYSQLParameter("@Id_Dato_Financiero", obj.Id_Dato_Financiero, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@TEA", obj.TEA, MySqlDbType.Decimal);
            parameters[2] = new MYSQLParameter("@TEM", obj.TEM, MySqlDbType.Decimal);
            parameters[3] = new MYSQLParameter("@TED", obj.TED, MySqlDbType.Decimal);
            parameters[4] = new MYSQLParameter("@Seguro_Desgravamen", obj.Seguro_Desgravamen, MySqlDbType.Decimal);
            parameters[5] = new MYSQLParameter("@ITF", obj.ITF, MySqlDbType.Decimal);
            parameters[6] = new MYSQLParameter("@Otros", obj.Otros, MySqlDbType.Decimal);
            parameters[7] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Modify_Datos_Financieros", parameters);
            return Response;
        }
        public List<DatoFinanciero> Listar()
        {
            List<DatoFinanciero> List = new List<DatoFinanciero>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Datos_Financieros");
                foreach (DataRow row in data.Rows)
                {
                    DatoFinanciero be = new DatoFinanciero
                    {
                        Id_Dato_Financiero = Convert.ToInt32(row["Id_Dato_Financiero_Dato_Financiero"]),
                        TEA = Convert.ToDouble(row["TEA"]),
                        TEM = Convert.ToDouble(row["TEM"]),
                        TED = Convert.ToDouble(row["TED"]),
                        Seguro_Desgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                        Seguro_Multiriesgo = Convert.ToDouble(row["Seguro_Multiriesgo"]),
                        ITF = Convert.ToDouble(row["ITF"]),
                        Otros = Convert.ToDouble(row["Otros"]),
                        FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                        Estado = row["Estado"].ToString()
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
        public DatoFinanciero Seleccionar(string Codigo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Id_Dato_Financiero", Codigo, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureData("USP_Select_Datos_Financieros", parameters).Rows[0];
                DatoFinanciero be = new DatoFinanciero
                {
                    Id_Dato_Financiero = Convert.ToInt32(row["Id_Dato_Financiero_Dato_Financiero"]),
                    TEA = Convert.ToDouble(row["TEA"]),
                    TEM = Convert.ToDouble(row["TEM"]),
                    TED = Convert.ToDouble(row["TED"]),
                    Seguro_Desgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                    ITF = Convert.ToDouble(row["ITF"]),
                    Otros = Convert.ToDouble(row["Otros"]),
                    FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                    Estado = row["Estado"].ToString()
                };
                return be;
            }
            catch
            {
                DatoFinanciero be = new DatoFinanciero();
                return be;
            }
        }

        public bool VerificarCodigo(string Codigo)
        {
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@Codigo", Codigo, SqlDbType.VarChar);
                DataRow data = Conexion.ExecuteProcedureData("USP_S_VerificarCodigoDatoFinanciero", parameters).Rows[0];
                int cantId_Dato_Financieroad = Convert.ToInt32(data[0]);
                Response = cantId_Dato_Financieroad == 0 ? true : false;
            }
            catch
            {
                Response = false;
            }
            return Response;
        }

        public List<DatoFinanciero> Buscar(string KeyWoard)
        {
            List<DatoFinanciero> List = new List<DatoFinanciero>();
            try
            {
                SQLParameter[] parameters = new SQLParameter[1];
                parameters[0] = new SQLParameter("@KeyWoard", KeyWoard, SqlDbType.VarChar);
                DataTable data = new DataTable();
                data = Conexion.ExecuteProcedureData("USP_S_BuscarDatoFinanciero", parameters);
                foreach (DataRow row in data.Rows)
                {
                    DatoFinanciero be = new DatoFinanciero
                    {
                        Id_Dato_Financiero = Convert.ToInt32(row["Id_Dato_Financiero_Dato_Financiero"]),
                        TEA = Convert.ToDouble(row["TEA"]),
                        TEM = Convert.ToDouble(row["TEM"]),
                        TED = Convert.ToDouble(row["TED"]),
                        Seguro_Desgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                        ITF = Convert.ToDouble(row["ITF"]),
                        Otros = Convert.ToDouble(row["Otros"]),
                        FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                        Estado = row["Estado"].ToString()
                    };
                    List.Add(be);
                }
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return List;
        }
    }
}
