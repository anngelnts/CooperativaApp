using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace CooperativaApp.Datos
{
    public class DPrestamo
    {
        protected bool Response = false;
        public bool Agregar(Prestamo obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[9];
            parameters[0] = new MYSQLParameter("@Id_Socio", obj.Id_Socio, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Monto", obj.Monto, MySqlDbType.Int32);
            parameters[2] = new MYSQLParameter("@Num_De_Cuotas", obj.Num_De_Cuotas, MySqlDbType.Int32);
            parameters[3] = new MYSQLParameter("@Observaciones", obj.Observaciones, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Anexos", obj.Anexos, MySqlDbType.VarChar);
            parameters[5] = new MYSQLParameter("@Id_Dato_Financiero", obj.Id_Dato_Financiero, MySqlDbType.Int32);            
            parameters[6] = new MYSQLParameter("@Usuario_Sol", obj.Usuario_Sol, MySqlDbType.Int32);
            parameters[7] = new MYSQLParameter("@Usuario_Val", obj.Usuario_Val, MySqlDbType.Int32);
            parameters[8] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Prestamo", parameters);
            return Response;
        }


        public bool Actualizar(Prestamo obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[15];
            parameters[0] = new MYSQLParameter("@Id_Prestamo_", obj.Id_Prestamo, MySqlDbType.Int32);
            parameters[1] = new MYSQLParameter("@Monto_", obj.Monto, MySqlDbType.Decimal);
            parameters[2] = new MYSQLParameter("@Num_De_Cuotas_", obj.Num_De_Cuotas, MySqlDbType.Int32);
            parameters[3] = new MYSQLParameter("@Observaciones_", obj.Observaciones, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Anexos_", obj.Anexos, MySqlDbType.VarChar);
            parameters[5] = new MYSQLParameter("@Fecha_De_Desembolso_", obj.Fecha_De_Desembolso, MySqlDbType.Date);
            parameters[6] = new MYSQLParameter("@Dias_De_Gracia_", obj.Dias_De_Gracia, MySqlDbType.Int32);
            parameters[7] = new MYSQLParameter("@Fecha_De_Pago_", obj.Fecha_De_Pago, MySqlDbType.Date);
            parameters[8] = new MYSQLParameter("@Cuota_Base_", obj.Cuota_Base, MySqlDbType.Decimal);
            parameters[9] = new MYSQLParameter("@Interes_", obj.Interes, MySqlDbType.Decimal);
            parameters[10] = new MYSQLParameter("@Interes_Diferido_", obj.Interes_Diferido, MySqlDbType.Decimal);
            parameters[11] = new MYSQLParameter("@Cuota_Fija_", obj.Cuota_Fija, MySqlDbType.Decimal);
            parameters[12] = new MYSQLParameter("@Saldo_Capital_", obj.Saldo_Capital, MySqlDbType.Decimal);
            parameters[13] = new MYSQLParameter("@Usuario_Val_", obj.Usuario_Val, MySqlDbType.Int32);
            parameters[14] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Update_Prestamo", parameters);
            return Response;
        }


        public DataTable Seleccionar(int Codigo)
        {
            DataTable data = new DataTable();
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Id_Prestamo", Codigo, MySqlDbType.Int32);
                data = ConexionMySql.ExecuteProcedureData("USP_Select_Prestamo", parameters);
               
                return data;
            }
            catch
            {
                return data;
            }
        }

        public DataTable Listar()
        {
            DataTable data = new DataTable();
            try
            {
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Prestamos");
            }
            catch
            {
                Console.WriteLine("No se encontro Procedimiento Almacenado");
            }
            return data;

        }
        //public Prestamo Buscar_Prestamo_Por_Num_Documento(string Tipo_Documento, string Num_Documento)
        //{
        //    try
        //    {
        //        MYSQLParameter[] parameters = new MYSQLParameter[2];
        //        parameters[0] = new MYSQLParameter("@Tipo_Documento", Tipo_Documento, MySqlDbType.VarChar);
        //        parameters[1] = new MYSQLParameter("@Num_Documento", Num_Documento, MySqlDbType.VarChar);
        //        DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Prestamo_Por_Num_Documento", parameters).Rows[0];
        //        Prestamo be = new Prestamo
        //        {
        //            Id_Prestamo = Convert.ToInt32(row["Id_Prestamo"]),
        //            Apellidos = row["Apellidos"].ToString(),
        //            Nombres = row["Nombres"].ToString(),
        //            Tipo_De_Documento = row["Tipo_De_Documento"].ToString(),
        //            Num_Documento = row["Num_Documento"].ToString(),
        //            Celular = row["Celular"].ToString(),
        //            Email = row["Email"].ToString(),
        //            Direccion = row["Direccion"].ToString(),
        //            Estado = row["Estado"].ToString()
        //        };
        //        return be;
        //    }
        //    catch
        //    {
        //        Prestamo be = new Prestamo();
        //        return be;
        //    }
        //}
    }
}
