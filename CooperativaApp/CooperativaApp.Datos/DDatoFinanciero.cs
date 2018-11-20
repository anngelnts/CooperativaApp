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
            parameters[0] = new MYSQLParameter("@TEA", obj.TEA, MySqlDbType.Decimal);
            parameters[1] = new MYSQLParameter("@TEM", obj.TEM, MySqlDbType.Decimal);
            parameters[2] = new MYSQLParameter("@TED", obj.TED, MySqlDbType.Decimal);
            parameters[3] = new MYSQLParameter("@Seguro_Desgravamen", obj.SeguroDesgravamen, MySqlDbType.Decimal);
            parameters[4] = new MYSQLParameter("@ITF", obj.ITF, MySqlDbType.Decimal);
            parameters[5] = new MYSQLParameter("@Otros", obj.Otros, MySqlDbType.Decimal);
            parameters[6] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Datos_Financieros", parameters);
            return Response;
        }
        public bool Modificar(DatoFinanciero obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[8];
            parameters[0] = new MYSQLParameter("@ID", obj.ID, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@TEA", obj.TEA, MySqlDbType.Decimal);
            parameters[2] = new MYSQLParameter("@TEM", obj.TEM, MySqlDbType.Decimal);
            parameters[3] = new MYSQLParameter("@TED", obj.TED, MySqlDbType.Decimal);
            parameters[4] = new MYSQLParameter("@Seguro_Desgravamen", obj.SeguroDesgravamen, MySqlDbType.Decimal);
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
                        ID = Convert.ToInt32(row["Id_Dato_Financiero"]),
                        TEA = Convert.ToDouble(row["TEA"]),
                        TEM = Convert.ToDouble(row["TEM"]),
                        TED = Convert.ToDouble(row["TED"]),
                        SeguroDesgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                        ITF = Convert.ToDouble(row["ITF"]),
                        Otros = Convert.ToDouble(row["Otros"]),
                        FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                        Estado = Convert.ToInt32(row["Estado"])
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
                parameters[0] = new SQLParameter("@ID", Codigo, SqlDbType.VarChar);
                DataRow row = Conexion.ExecuteProcedureData("USP_Select_Datos_Financieros", parameters).Rows[0];
                DatoFinanciero be = new DatoFinanciero
                {
                    ID = Convert.ToInt32(row["Id_Dato_Financiero"]),
                    TEA = Convert.ToDouble(row["TEA"]),
                    TEM = Convert.ToDouble(row["TEM"]),
                    TED = Convert.ToDouble(row["TED"]),
                    SeguroDesgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                    ITF = Convert.ToDouble(row["ITF"]),
                    Otros = Convert.ToDouble(row["Otros"]),
                    FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                    Estado = Convert.ToInt32(row["Estado"])
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
                int cantidad = Convert.ToInt32(data[0]);
                Response = cantidad == 0 ? true : false;
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
                        ID = Convert.ToInt32(row["Id_Dato_Financiero"]),
                        TEA = Convert.ToDouble(row["TEA"]),
                        TEM = Convert.ToDouble(row["TEM"]),
                        TED = Convert.ToDouble(row["TED"]),
                        SeguroDesgravamen = Convert.ToDouble(row["Seguro_Desgravamen"]),
                        ITF = Convert.ToDouble(row["ITF"]),
                        Otros = Convert.ToDouble(row["Otros"]),
                        FechaRegistro = Convert.ToDateTime(row["Fecha_Registro"]),
                        Estado = Convert.ToInt32(row["Estado"])
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
