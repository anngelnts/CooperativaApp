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
    public class DTipoUsuario
    {
        protected bool Response = false;
        public bool Agregar(TipoUsuario obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[2];
            parameters[0] = new MYSQLParameter("@Nombre_", obj.Nombre, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_TipoUsuario", parameters);
            return Response;
        }

        public bool Modificar(TipoUsuario obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[3];
            parameters[0] = new MYSQLParameter("@Id_Tipo_De_Usuario_", obj.Id_Tipo_De_Usuario, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Nombre_", obj.Nombre, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Modify_TipoUsuario", parameters);
            return Response;
        }

        public List<TipoUsuario> Listar()
        {
            List<TipoUsuario> List = new List<TipoUsuario>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_TiposUsuarios");
                foreach (DataRow row in data.Rows)
                {
                    TipoUsuario be = new TipoUsuario
                    {
                        Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                        Nombre = row["Nombre"].ToString(),
                        Estado = row["Estado"].ToString(),
                        Fecha_registro = Convert.ToDateTime(row["Fecha_registro"])
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

        public TipoUsuario Seleccionar(int Identificador)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@ID", Identificador, MySqlDbType.Int32);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_TipoUsuario", parameters).Rows[0];
                TipoUsuario be = new TipoUsuario
                {
                    Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                    Nombre = row["Nombre"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Fecha_registro = Convert.ToDateTime(row["Fecha_registro"])
                };
                return be;
            }
            catch
            {
                TipoUsuario be = new TipoUsuario();
                return be;
            }
        }

        public List<TipoUsuario> Buscar(string Nombre)
        {
            List<TipoUsuario> List = new List<TipoUsuario>();
            try
            {
                DataTable data = new DataTable();
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Nombre_", Nombre, MySqlDbType.VarChar);
                data = ConexionMySql.ExecuteProcedureData("USP_Search_TiposUsuarios", parameters);
                foreach (DataRow row in data.Rows)
                {
                    TipoUsuario be = new TipoUsuario
                    {
                        Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                        Nombre = row["Nombre"].ToString(),
                        Estado = row["Estado"].ToString(),
                        Fecha_registro = Convert.ToDateTime(row["Fecha_registro"])
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

        public bool CambiarEstado(int id, string estado)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[2];
            parameters[0] = new MYSQLParameter("@Id_Tipo_De_Usuario_", id, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Estado_", estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Cambiar_Estado_TipoUsuario", parameters);
            return Response;
        }

        public Dictionary<int, string> CuadroCombinado()
        {
            Dictionary<int, string> Lista = new Dictionary<int, string>();
            if (Listar().Count > 0)
            {
                foreach (TipoUsuario item in Listar())
                {
                    Lista.Add(item.Id_Tipo_De_Usuario, item.Nombre);
                }
                return Lista;
            }
            return Lista;
        }
    }
}
