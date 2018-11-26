using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
