using System;
using System.Data;
using System.Data.SqlClient;

namespace CooperativaApp.Comun
{
    public class Conexion
    {
        public static SqlConnection Connection;
        public static SqlConnection Open()
        {
            try
            {
                Connection = new SqlConnection("Data Source=(local);initial Catalog=CooperativaApp;integrated Security=true");
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
        
        public static DataTable ExecuteProcedureData(string procedure, SQLParameter[] parameters = null)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
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
            catch
            {
                return ds.Tables[0];
            }
        }
        public static bool ExecuteProcedureNonQuery(string procedure, SQLParameter[] parameters = null)
        {
            bool Response = false;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
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
