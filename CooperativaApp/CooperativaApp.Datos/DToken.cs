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
    public class DToken
    {
        protected bool Response = false;
        public bool Agregar(Token obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[2];
            parameters[0] = new MYSQLParameter("@Usuario_", obj.Usuario, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Token_", obj.Tokn, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Token", parameters);
            return Response;
        }

        public bool Modificar(Token obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[2];
            parameters[0] = new MYSQLParameter("@Usuario_", obj.Usuario, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Token_", obj.Tokn, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Modify_Token", parameters);
            return Response;
        }

        public List<Token> Listar()
        {
            List<Token> List = new List<Token>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Tokens");
                foreach (DataRow row in data.Rows)
                {
                    Token be = new Token
                    {
                        Id = Convert.ToInt32(row["Id_Token"]),
                        Usuario = row["Usuario"].ToString(),
                        Tokn = row["Token"].ToString()
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

        public Token Seleccionar(string Username)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Usuario_", Username, MySqlDbType.VarChar);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Token", parameters).Rows[0];
                Token be = new Token
                {
                    Id = Convert.ToInt32(row["Id_Token"]),
                    Usuario = row["Usuario"].ToString(),
                    Tokn = row["Token"].ToString()
                };
                return be;
            }
            catch
            {
                Token be = new Token();
                return be;
            }
        }

        public static string GenerateToken()
        {
            int longitud = 4;
            Guid miGuid = Guid.NewGuid();
            string token = Convert.ToBase64String(miGuid.ToByteArray());
            token = token.Replace("=", "").Replace("+", "");
            string result = token.Substring(0, longitud);
            Console.WriteLine(result);
            return result;
        }

        public bool ValidarToken(string Username, string Token)
        {
            Response = false;
            try
            {
                Token be = Seleccionar(Username);
                if (be.Tokn.Equals(Token))
                {
                    Response = true;
                }
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
            }
            return Response;
        }
    }
}
