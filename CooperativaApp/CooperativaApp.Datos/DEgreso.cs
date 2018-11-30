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
    public class DEgreso
    {
        protected bool Response = false;
        public bool Agregar(Egreso obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[5];
            parameters[0] = new MYSQLParameter("@Descripcion_", obj.Descripcion, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Observacion_", obj.Observacion, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Monto_", obj.Monto, MySqlDbType.Decimal);
            parameters[3] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Id_Usuario_", obj.Estado, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Egreso", parameters);
            return Response;
        }

        public bool Modificar(Egreso obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[2];
            parameters[0] = new MYSQLParameter("@Observacion_", obj.Observacion, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Id_Usuario_", obj.Estado, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Modify_Egreso", parameters);
            return Response;
        }

        public DataTable Listar()
        {
            DataTable data = new DataTable();
            try
            {
                return data = ConexionMySql.ExecuteProcedureData("USP_ToList_Egresos");
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;
        }

        public Egreso Seleccionar(int Identificador)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Id_Usuario_", Identificador, MySqlDbType.Int32);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Egreso", parameters).Rows[0];
                Egreso be = new Egreso
                {
                    Id_Egreso = Convert.ToInt32(row["Id_Egreso"]),
                    Descripcion = row["Descripcion"].ToString(),
                    Observacion = row["Observacion"].ToString(),
                    Monto = Convert.ToDouble(row["Monto"]),
                    Estado = row["Estado"].ToString(),
                    Id_Usuario = Convert.ToInt32(row["Id_Usuario"]),
                    Fecha_De_Registro = Convert.ToDateTime(row["Fecha_De_Registro"])
                };
                return be;
            }
            catch
            {
                Egreso be = new Egreso();
                return be;
            }
        }

        public DataTable Buscar(int Identificador)
        {
            DataTable data = new DataTable();
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@ID", Identificador, MySqlDbType.Int32);
                return data = ConexionMySql.ExecuteProcedureData("USP_Search_Egresos", parameters);
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;
        }
    }
}
