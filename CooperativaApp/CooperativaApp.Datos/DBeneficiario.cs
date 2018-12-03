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
    public class DBeneficiario
    {
        protected bool Response = false;
        public bool Agregar(Beneficiario obj)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[10];
                parameters[0] = new MYSQLParameter("@Id_Socio_", obj.Id_Socio, MySqlDbType.Int32);
                parameters[1] = new MYSQLParameter("@Tipo_De_Documento_", obj.Tipo_De_Documento, MySqlDbType.VarChar);
                parameters[2] = new MYSQLParameter("@Num_Documento_", obj.Num_Documento, MySqlDbType.VarChar);
                parameters[3] = new MYSQLParameter("@Apellidos_", obj.Apellidos, MySqlDbType.VarChar);
                parameters[4] = new MYSQLParameter("@Nombres_", obj.Nombres, MySqlDbType.VarChar);
                parameters[5] = new MYSQLParameter("@Celular_", obj.Celular, MySqlDbType.VarChar);
                parameters[6] = new MYSQLParameter("@Telefono_", obj.Telefono, MySqlDbType.VarChar);
                parameters[7] = new MYSQLParameter("@Tipo_De_Beneficiario_", obj.Tipo_De_Beneficiario, MySqlDbType.VarChar);
                parameters[8] = new MYSQLParameter("@Parentesco_", obj.Parentesco, MySqlDbType.VarChar);
                parameters[9] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                return ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Beneficiario", parameters);

            }
            catch (Exception e)
            {
                Console.WriteLine("[ INNER EXCEPTION ]" + e.InnerException );
                Console.WriteLine("[ INNER MESSAGE ]" + e.Message);
                Console.WriteLine("[ERROR AGREGAR BENEFICIARIO]");
                return false;
            }
        }

        public bool Modificar(Beneficiario obj)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[11];
                parameters[0] = new MYSQLParameter("@Id_Beneficiario_", obj.Id_Beneficiario, MySqlDbType.Int32);
                parameters[1] = new MYSQLParameter("@Id_Socio_", obj.Id_Socio, MySqlDbType.Int32);
                parameters[2] = new MYSQLParameter("@Tipo_De_Documento_", obj.Tipo_De_Documento, MySqlDbType.VarChar);
                parameters[3] = new MYSQLParameter("@Num_Documento_", obj.Num_Documento, MySqlDbType.VarChar);
                parameters[4] = new MYSQLParameter("@Apellidos_", obj.Apellidos, MySqlDbType.VarChar);
                parameters[5] = new MYSQLParameter("@Nombres_", obj.Nombres, MySqlDbType.VarChar);
                parameters[6] = new MYSQLParameter("@Celular_", obj.Celular, MySqlDbType.VarChar);
                parameters[7] = new MYSQLParameter("@Telefono_", obj.Telefono, MySqlDbType.VarChar);
                parameters[8] = new MYSQLParameter("@Tipo_De_Beneficiario_", obj.Tipo_De_Beneficiario, MySqlDbType.VarChar);
                parameters[9] = new MYSQLParameter("@Parentesco_", obj.Parentesco, MySqlDbType.VarChar);
                parameters[10] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
                return ConexionMySql.ExecuteProcedureNonQuery("USP_Update_Beneficiario", parameters);

            }
            catch (Exception e)
            {
                Console.WriteLine("[ INNER MESSAGE ]" + e.InnerException);
                Console.WriteLine("[ INNER MESSAGE ]" + e.Message);
                Console.WriteLine("[ERROR MODIFICAR BENEFICIARIO]");
                return false;
            }
        }

        public Socio ObtenerSocioAfiliado(string TipoDocumento , string NumeroDocumento)
        {
            try
            {
                string SqlQuery = "SELECT * FROM tbl_socios WHERE Num_Documento = '" + NumeroDocumento + "' AND Tipo_De_Documento = '" + TipoDocumento+"'" ;
                DataSet ds = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                cmd.Connection = ConexionMySql.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                data.Fill(ds, "DataTable");
                ConexionMySql.Close();
                DataRow Fila = ds.Tables[0].Rows[0];
                Socio be = new Socio
                {
                    Id_Socio = Convert.ToInt32(Fila["Id_Socio"]),
                    Apellidos = Fila["Apellidos"].ToString(),
                    Nombres = Fila["Nombres"].ToString(),
                    Tipo_De_Documento = Fila["Tipo_De_Documento"].ToString(),
                    Num_Documento = Fila["Num_Documento"].ToString(),
                    Celular = Fila["Celular"].ToString(),
                    Email = Fila["Email"].ToString(),
                    Direccion = Fila["Direccion"].ToString(),
                    Estado = Fila["Estado"].ToString()
                };
                return be;
            }
            catch (Exception e)
            {
                Console.WriteLine("[ "+e.Message+" ]");
                return null;
            }
        }

        public DataTable Listar()
        {
            try
            {
                return ConexionMySql.ExecuteProcedureData("USP_ToList_Beneficiario");
            }
            catch (Exception)
            {
                Console.WriteLine("[Error al Ejecutar USP_ToList_Beneficiario]");
                return null;
            }
        }
    }
}
