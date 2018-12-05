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
    public class DUsuario
    {
        protected bool Response = false;
        public bool Agregar(Usuario obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[7];
            parameters[0] = new MYSQLParameter("@Id_Tipo_De_Usuario_", obj.Id_Tipo_De_Usuario, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Usuario_", obj.Username, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Clave_", obj.Password, MySqlDbType.VarChar);
            parameters[3] = new MYSQLParameter("@Nombre_", obj.Nombre, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Apellido_", obj.Apellido, MySqlDbType.VarChar);
            parameters[5] = new MYSQLParameter("@Celular_", obj.Celular, MySqlDbType.VarChar);
            parameters[6] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Usuario", parameters);
            return Response;
        }

        public bool Modificar(Usuario obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[5];
            parameters[0] = new MYSQLParameter("@Id_Usuario_", obj.Id_Usuario, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Id_Tipo_De_Usuario_", obj.Id_Tipo_De_Usuario, MySqlDbType.Int32);
            parameters[2] = new MYSQLParameter("@Nombre_", obj.Nombre, MySqlDbType.VarChar);
            parameters[3] = new MYSQLParameter("@Apellido_", obj.Apellido, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Celular_", obj.Celular, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Modify_Usuario", parameters);
            return Response;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> List = new List<Usuario>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Usuarios");
                foreach (DataRow row in data.Rows)
                {
                    Usuario be = new Usuario
                    {
                        Id_Usuario = Convert.ToInt32(row["Id_Usuario"]),
                        Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                        TipoUsuario = row["TUNombre"].ToString(),
                        Username = row["Usuario"].ToString(),
                        Password = row["Clave"].ToString(),
                        Nombre = row["Nombre"].ToString(),
                        Apellido = row["Apellido"].ToString(),
                        Celular = row["Celular"].ToString(),
                        Estado = row["Estado"].ToString(),
                        Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
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

        public Usuario Seleccionar(int Identificador)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@ID", Identificador, MySqlDbType.Int32);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Usuario", parameters).Rows[0];
                Usuario be = new Usuario
                {
                    Id_Usuario = Convert.ToInt32(row["Id_Usuario"]),
                    Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                    TipoUsuario = row["TUNombre"].ToString(),
                    Username = row["Usuario"].ToString(),
                    Password = row["Clave"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Celular = row["Celular"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
                };
                return be;
            }
            catch
            {
                Usuario be = new Usuario();
                return be;
            }
        }

        public List<Usuario> Buscar(string Username)
        {
            List<Usuario> List = new List<Usuario>();
            try
            {
                DataTable data = new DataTable();
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Username", Username, MySqlDbType.VarChar);
                data = ConexionMySql.ExecuteProcedureData("USP_Search_Usuarios", parameters);
                foreach (DataRow row in data.Rows)
                {
                    Usuario be = new Usuario
                    {
                        Id_Usuario = Convert.ToInt32(row["Id_Usuario"]),
                        Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                        TipoUsuario = row["TUNombre"].ToString(),
                        Username = row["Usuario"].ToString(),
                        Password = row["Clave"].ToString(),
                        Nombre = row["Nombre"].ToString(),
                        Apellido = row["Apellido"].ToString(),
                        Celular = row["Celular"].ToString(),
                        Estado = row["Estado"].ToString(),
                        Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
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
            parameters[0] = new MYSQLParameter("@Id_Usuario_", id, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Estado_", estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Cambiar_Estado_Usuario", parameters);
            return Response;
        }

        public bool VerificarUsername(string Username)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Username", Username, MySqlDbType.VarChar);
                DataRow data = ConexionMySql.ExecuteProcedureData("USP_S_VerificarUsername", parameters).Rows[0];
                int cantidad = Convert.ToInt32(data[0]);
                if (cantidad == 0)
                {
                    Response = true;
                }
                else
                {
                    Response = false;
                }
            }
            catch
            {
                Response = false;
            }
            return Response;
        }

        public Usuario LoginUsuario(string Username, string Password)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[2];
                parameters[0] = new MYSQLParameter("@Username_", Username, MySqlDbType.VarChar);
                parameters[1] = new MYSQLParameter("@Password_", Password, MySqlDbType.VarChar);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_S_LoginUsuario", parameters).Rows[0];
                Usuario be = new Usuario
                {
                    Id_Usuario = Convert.ToInt32(row["Id_Usuario"]),
                    Id_Tipo_De_Usuario = Convert.ToInt32(row["Id_Tipo_De_Usuario"]),
                    Username = row["Usuario"].ToString(),
                    Password = row["Clave"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Celular = row["Celular"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"])
                };
                return be;
            }
            catch
            {
                Usuario be = new Usuario();
                return be;
            }
        }

        public bool ChangePassword(string password, string newpassword, string codigo)
        {
            try
            {
                Usuario be = LoginUsuario(codigo, password);
                if (be.Password != password)
                {
                    Response = false;
                }
                else
                {
                    MYSQLParameter[] parameters = new MYSQLParameter[2];
                    parameters[0] = new MYSQLParameter("@Username_", codigo, MySqlDbType.VarChar);
                    parameters[1] = new MYSQLParameter("@Password_", newpassword, MySqlDbType.VarChar);
                    Response = ConexionMySql.ExecuteProcedureNonQuery("USP_U_CambiarClaveUsuario", parameters);
                }
                return Response;
            }
            catch
            {
                return Response = false;
            }
        }
    }
}
