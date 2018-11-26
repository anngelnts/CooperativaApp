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
            MYSQLParameter[] parameters = new MYSQLParameter[6];
            parameters[0] = new MYSQLParameter("@Descripcion", obj.Descripcion, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Observacion", obj.Observacion, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Monto", obj.Monto, MySqlDbType.Decimal);
            parameters[3] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Id_Usuario", obj.Estado, MySqlDbType.Int32);
            parameters[5] = new MYSQLParameter("@Fecha_De_Registro", obj.Id_Usuario, MySqlDbType.Date);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Egreso", parameters);
            return Response;
        }

        public List<Egreso> Listar()
        {
            List<Egreso> List = new List<Egreso>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Egresos");
                foreach (DataRow row in data.Rows)
                {
                    Egreso be = new Egreso
                    {

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

        public Egreso Seleccionar(int Identificador)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Tipo_Documento", Identificador, MySqlDbType.Int32);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Egreso", parameters).Rows[0];
                Egreso be = new Egreso
                {
                };
                return be;
            }
            catch
            {
                Egreso be = new Egreso();
                return be;
            }
        }
    }
}
