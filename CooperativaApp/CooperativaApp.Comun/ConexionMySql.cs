using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CooperativaApp.Comun
{
    public class ConexionMySql
    {
        public static MySqlConnection Connection;
        public static MySqlConnection Open()
        {
            try
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=bd_cooperativa_app;Uid=root;Pwd=admin123;SslMode=none;Allow Zero Datetime=False;Convert Zero Datetime=True;");
                if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    return Connection;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la Conexion", e);
               
            }
            return Connection;
        }
        public static void Close()
        {
            try
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la Conexion", e);
            }

        }
        public static DataTable ExecuteProcedureData(string procedure, MYSQLParameter[] parameters = null)
        {
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            try
            {
                cmd.Connection = Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                data.Fill(ds, "DataTable");
                Close();
                return ds.Tables[0];
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return ds.Tables[0];
            }
        }
        public static bool ExecuteProcedureNonQuery(string procedure, MYSQLParameter[] parameters = null)
        {
            bool Response = false;
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            try
            {
                cmd.Connection = Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedure;
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.Add(parameters[i].Name, parameters[i].Type).Value = parameters[i].Value;
                    }
                }
                Response = cmd.ExecuteNonQuery() > 0 ? true : false;
                Close();
                return Response;
            }
            catch
            {
                return false;
            }
        }
    }
}
