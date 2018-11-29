using CooperativaApp.Comun;
using CooperativaApp.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;


namespace CooperativaApp.Datos
{
    public class DSocio
    {
        protected bool Response = false;
        public bool Agregar(Socio obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[35];
            //parameters[0] = new MYSQLParameter("@Id_Socio", obj.Id_Socio, MySqlDbType.VarChar);
            parameters[0] = new MYSQLParameter("@Tipo_De_Documento", obj.Tipo_De_Documento, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Num_Documento", obj.Num_Documento, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Apellidos", obj.Apellidos, MySqlDbType.VarChar);
            parameters[3] = new MYSQLParameter("@Nombres", obj.Nombres, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Fecha_De_Nacimiento", obj.Fecha_De_Nacimiento, MySqlDbType.Date);
            parameters[5] = new MYSQLParameter("@Sexo", obj.Sexo, MySqlDbType.VarChar);
            parameters[6] = new MYSQLParameter("@Estado_Civil", obj.Estado_Civil, MySqlDbType.VarChar);
            parameters[7] = new MYSQLParameter("@Profesion", obj.Profesion, MySqlDbType.VarChar);
            parameters[8] = new MYSQLParameter("@Nivel_De_Instruccion", obj.Nivel_De_Instruccion, MySqlDbType.VarChar);
            parameters[9] = new MYSQLParameter("@Direccion", obj.Direccion, MySqlDbType.VarChar);
            parameters[10] = new MYSQLParameter("@Distrito", obj.Distrito, MySqlDbType.VarChar);
            parameters[11] = new MYSQLParameter("@Provincia", obj.Provincia, MySqlDbType.VarChar);
            parameters[12] = new MYSQLParameter("@Departamento", obj.Departamento, MySqlDbType.VarChar);
            parameters[13] = new MYSQLParameter("@Referencia", obj.Referencia, MySqlDbType.VarChar);
            parameters[14] = new MYSQLParameter("@Celular", obj.Celular, MySqlDbType.VarChar);
            parameters[15] = new MYSQLParameter("@Telefono", obj.Telefono, MySqlDbType.VarChar);
            parameters[16] = new MYSQLParameter("@Email", obj.Email, MySqlDbType.VarChar);
            parameters[17] = new MYSQLParameter("@Envio_De_Cronogramas_De_Pago", obj.Envio_De_Cronogramas_De_Pago, MySqlDbType.VarChar);
            parameters[18] = new MYSQLParameter("@Nombre_De_Empresa", obj.Nombre_De_Empresa, MySqlDbType.VarChar);
            parameters[19] = new MYSQLParameter("@Fecha_De_Ingreso", obj.Fecha_De_Ingreso, MySqlDbType.Date);
            parameters[20] = new MYSQLParameter("@Ingreso_Mensual_Neto", obj.Ingreso_Mensual_Neto, MySqlDbType.Decimal);
            parameters[21] = new MYSQLParameter("@Cargo", obj.Cargo, MySqlDbType.VarChar);
            parameters[22] = new MYSQLParameter("@Area_De_Trabajo", obj.Area_De_Trabajo, MySqlDbType.VarChar);
            parameters[23] = new MYSQLParameter("@Direccion_De_Empresa", obj.Direccion_De_Empresa, MySqlDbType.VarChar);
            parameters[24] = new MYSQLParameter("@Distrito_De_Empresa", obj.Distrito_De_Empresa, MySqlDbType.VarChar);
            parameters[25] = new MYSQLParameter("@Provincia_De_Empresa", obj.Provincia_De_Empresa, MySqlDbType.VarChar);
            parameters[26] = new MYSQLParameter("@Departamento_De_Empresa", obj.Departamento_De_Empresa, MySqlDbType.VarChar);
            parameters[27] = new MYSQLParameter("@Referencia_De_Empresa", obj.Referencia_De_Empresa, MySqlDbType.VarChar);
            parameters[28] = new MYSQLParameter("@Telefono_De_Empresa", obj.Telefono_De_Empresa, MySqlDbType.VarChar);
            parameters[29] = new MYSQLParameter("@Modalidad_De_Contratacion", obj.Modalidad_De_Contratacion, MySqlDbType.VarChar);
            parameters[30] = new MYSQLParameter("@Centro_De_Trabajo", obj.Centro_De_Trabajo, MySqlDbType.VarChar);
            parameters[31] = new MYSQLParameter("@Monto_Acumulado", obj.Monto_Acumulado, MySqlDbType.Decimal);
            parameters[32] = new MYSQLParameter("@Estado", obj.Estado, MySqlDbType.VarChar);
            parameters[33] = new MYSQLParameter("@Nivel", obj.Nivel, MySqlDbType.VarChar);
            parameters[34] = new MYSQLParameter("@Fecha_De_Registro", obj.Fecha_De_Registro, MySqlDbType.Date);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Add_Socio", parameters);
            return Response;
        }


        public List<Socio> Listar()
        {
            List<Socio> List = new List<Socio>();
            try
            {
                DataTable data = new DataTable();
                data = ConexionMySql.ExecuteProcedureData("USP_ToList_Socios");
                foreach (DataRow row in data.Rows)
                {
                    Socio be = new Socio
                    {
                        Id_Socio = Convert.ToInt32(row["Id_Socio"]),
                        Tipo_De_Documento = (row["Tipo_De_Documento"]).ToString(),
                        Num_Documento = (row["Num_Documento"]).ToString(),
                        Apellidos = (row["Apellidos"]).ToString(),
                        Nombres = (row["Nombres"]).ToString(),
                        Fecha_De_Nacimiento = Convert.ToDateTime(row["Fecha_De_Nacimiento"]),
                        Sexo = (row["Sexo"]).ToString(),
                        Estado_Civil = (row["Estado_Civil"]).ToString(),
                        Profesion = (row["Profesion"]).ToString(),
                        Nivel_De_Instruccion = (row["Nivel_De_Instruccion"]).ToString(),
                        Direccion = (row["Direccion"]).ToString(),
                        Distrito = (row["Distrito"]).ToString(),
                        Provincia = (row["Provincia"]).ToString(),
                        Departamento = (row["Departamento"]).ToString(),
                        Referencia = (row["Referencia"]).ToString(),
                        Celular = (row["Celular"]).ToString(),
                        Telefono = (row["Telefono"]).ToString(),
                        Email = (row["Email"]).ToString(),
                        Envio_De_Cronogramas_De_Pago = (row["Envio_De_Cronogramas_De_Pago"]).ToString(),
                        Nombre_De_Empresa = (row["Nombre_De_Empresa"]).ToString(),
                        Fecha_De_Ingreso = Convert.ToDateTime(row["Fecha_De_Ingreso"]),
                        Ingreso_Mensual_Neto = Convert.ToDecimal(row["Ingreso_Mensual_Neto"]),
                        Cargo = (row["Cargo"]).ToString(),
                        Area_De_Trabajo = (row["Area_De_Trabajo"]).ToString(),
                        Direccion_De_Empresa = (row["Direccion_De_Empresa"]).ToString(),
                        Distrito_De_Empresa = (row["Distrito_De_Empresa"]).ToString(),
                        Provincia_De_Empresa = (row["Provincia_De_Empresa"]).ToString(),
                        Departamento_De_Empresa = (row["Departamento_De_Empresa"]).ToString(),
                        Referencia_De_Empresa = (row["Referencia_De_Empresa"]).ToString(),
                        Telefono_De_Empresa = (row["Telefono_De_Empresa"]).ToString(),
                        Modalidad_De_Contratacion = (row["Modalidad_De_Contratacion"]).ToString(),
                        Centro_De_Trabajo = (row["Centro_De_Trabajo"]).ToString(),
                        Monto_Acumulado = Convert.ToDecimal(row["Monto_Acumulado"]),
                        Estado = (row["Estado"]).ToString(),
                        Nivel = (row["Nivel"]).ToString(),
                        Fecha_De_Registro = Convert.ToDateTime(row["Fecha_De_Registro"])


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
        public Socio Buscar_Socio_Por_Num_Documento(string Tipo_Documento, string Num_Documento)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[2];
                parameters[0] = new MYSQLParameter("@Tipo_Documento", Tipo_Documento, MySqlDbType.VarChar);
                parameters[1] = new MYSQLParameter("@Num_Documento", Num_Documento, MySqlDbType.VarChar);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Socio_Por_Num_Documento", parameters).Rows[0];
                Socio be = new Socio
                {
                    Id_Socio = Convert.ToInt32(row["Id_Socio"]),
                    Apellidos = row["Apellidos"].ToString(),
                    Nombres = row["Nombres"].ToString(),
                    Tipo_De_Documento = row["Tipo_De_Documento"].ToString(),
                    Num_Documento = row["Num_Documento"].ToString(),
                    Celular = row["Celular"].ToString(),
                    Email = row["Email"].ToString(),
                    Direccion = row["Direccion"].ToString(),
                    Estado = row["Estado"].ToString()
                };
                return be;
            }
            catch
            {
                Socio be = new Socio();
                return be;
            }
        }

        public List<Socio> Buscar_Socio(string Num_Documento)
        {
            List<Socio> List = new List<Socio>();
            try
            {
                DataTable data = new DataTable();
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Num_Documento_", Num_Documento, MySqlDbType.VarChar);
                data = ConexionMySql.ExecuteProcedureData("USP_Search_Socio_Num_Documento", parameters);
                foreach (DataRow row in data.Rows)
                {
                    Socio be = new Socio
                    {
                        Id_Socio = Convert.ToInt32(row["Id_Socio"]),
                        Tipo_De_Documento = (row["Tipo_De_Documento"]).ToString(),
                        Num_Documento = (row["Num_Documento"]).ToString(),
                        Apellidos = (row["Apellidos"]).ToString(),
                        Nombres = (row["Nombres"]).ToString(),
                        Fecha_De_Nacimiento = Convert.ToDateTime(row["Fecha_De_Nacimiento"]),
                        Sexo = (row["Sexo"]).ToString(),
                        Estado_Civil = (row["Estado_Civil"]).ToString(),
                        Profesion = (row["Profesion"]).ToString(),
                        Nivel_De_Instruccion = (row["Nivel_De_Instruccion"]).ToString(),
                        Direccion = (row["Direccion"]).ToString(),
                        Distrito = (row["Distrito"]).ToString(),
                        Provincia = (row["Provincia"]).ToString(),
                        Departamento = (row["Departamento"]).ToString(),
                        Referencia = (row["Referencia"]).ToString(),
                        Celular = (row["Celular"]).ToString(),
                        Telefono = (row["Telefono"]).ToString(),
                        Email = (row["Email"]).ToString(),
                        Envio_De_Cronogramas_De_Pago = (row["Envio_De_Cronogramas_De_Pago"]).ToString(),
                        Nombre_De_Empresa = (row["Nombre_De_Empresa"]).ToString(),
                        Fecha_De_Ingreso = Convert.ToDateTime(row["Fecha_De_Ingreso"]),
                        Ingreso_Mensual_Neto = Convert.ToDecimal(row["Ingreso_Mensual_Neto"]),
                        Cargo = (row["Cargo"]).ToString(),
                        Area_De_Trabajo = (row["Area_De_Trabajo"]).ToString(),
                        Direccion_De_Empresa = (row["Direccion_De_Empresa"]).ToString(),
                        Distrito_De_Empresa = (row["Distrito_De_Empresa"]).ToString(),
                        Provincia_De_Empresa = (row["Provincia_De_Empresa"]).ToString(),
                        Departamento_De_Empresa = (row["Departamento_De_Empresa"]).ToString(),
                        Referencia_De_Empresa = (row["Referencia_De_Empresa"]).ToString(),
                        Telefono_De_Empresa = (row["Telefono_De_Empresa"]).ToString(),
                        Modalidad_De_Contratacion = (row["Modalidad_De_Contratacion"]).ToString(),
                        Centro_De_Trabajo = (row["Centro_De_Trabajo"]).ToString(),
                        Monto_Acumulado = Convert.ToDecimal(row["Monto_Acumulado"]),
                        Estado = (row["Estado"]).ToString(),
                        Nivel = (row["Nivel"]).ToString(),
                        Fecha_De_Registro = Convert.ToDateTime(row["Fecha_De_Registro"])


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

   
        public Socio Obtener_Por_Id(int Id_Socio)
        {
            try
            {
                MYSQLParameter[] parameters = new MYSQLParameter[1];
                parameters[0] = new MYSQLParameter("@Id_Socio_", Id_Socio, MySqlDbType.Int32);
                DataRow row = ConexionMySql.ExecuteProcedureData("USP_Select_Socio", parameters).Rows[0];
                Socio be = new Socio
                {
                    Id_Socio = Convert.ToInt32(row["Id_Socio"]),
                    Tipo_De_Documento = (row["Tipo_De_Documento"]).ToString(),
                    Num_Documento = (row["Num_Documento"]).ToString(),
                    Apellidos = (row["Apellidos"]).ToString(),
                    Nombres = (row["Nombres"]).ToString(),
                    Fecha_De_Nacimiento = Convert.ToDateTime(row["Fecha_De_Nacimiento"]),
                    Sexo = (row["Sexo"]).ToString(),
                    Estado_Civil = (row["Estado_Civil"]).ToString(),
                    Profesion = (row["Profesion"]).ToString(),
                    Nivel_De_Instruccion = (row["Nivel_De_Instruccion"]).ToString(),
                    Direccion = (row["Direccion"]).ToString(),
                    Distrito = (row["Distrito"]).ToString(),
                    Provincia = (row["Provincia"]).ToString(),
                    Departamento = (row["Departamento"]).ToString(),
                    Referencia = (row["Referencia"]).ToString(),
                    Celular = (row["Celular"]).ToString(),
                    Telefono = (row["Telefono"]).ToString(),
                    Email = (row["Email"]).ToString(),
                    Envio_De_Cronogramas_De_Pago = (row["Envio_De_Cronogramas_De_Pago"]).ToString(),
                    Nombre_De_Empresa = (row["Nombre_De_Empresa"]).ToString(),
                    Fecha_De_Ingreso = Convert.ToDateTime(row["Fecha_De_Ingreso"]),
                    Ingreso_Mensual_Neto = Convert.ToDecimal(row["Ingreso_Mensual_Neto"]),
                    Cargo = (row["Cargo"]).ToString(),
                    Area_De_Trabajo = (row["Area_De_Trabajo"]).ToString(),
                    Direccion_De_Empresa = (row["Direccion_De_Empresa"]).ToString(),
                    Distrito_De_Empresa = (row["Distrito_De_Empresa"]).ToString(),
                    Provincia_De_Empresa = (row["Provincia_De_Empresa"]).ToString(),
                    Departamento_De_Empresa = (row["Departamento_De_Empresa"]).ToString(),
                    Referencia_De_Empresa = (row["Referencia_De_Empresa"]).ToString(),
                    Telefono_De_Empresa = (row["Telefono_De_Empresa"]).ToString(),
                    Modalidad_De_Contratacion = (row["Modalidad_De_Contratacion"]).ToString(),
                    Centro_De_Trabajo = (row["Centro_De_Trabajo"]).ToString(),
                    Monto_Acumulado = Convert.ToDecimal(row["Monto_Acumulado"]),
                    Estado = (row["Estado"]).ToString(),
                    Nivel = (row["Nivel"]).ToString(),
                    Fecha_De_Registro = Convert.ToDateTime(row["Fecha_De_Registro"])
                };
                return be;
            }
            catch
            {
                Socio be = new Socio();
                return be;
            }
        }


        public bool Actualizar(Socio obj)
        {
            MYSQLParameter[] parameters = new MYSQLParameter[36];

            parameters[0] = new MYSQLParameter("@Tipo_De_Documento_", obj.Tipo_De_Documento, MySqlDbType.VarChar);
            parameters[1] = new MYSQLParameter("@Num_Documento_", obj.Num_Documento, MySqlDbType.VarChar);
            parameters[2] = new MYSQLParameter("@Apellidos_", obj.Apellidos, MySqlDbType.VarChar);
            parameters[3] = new MYSQLParameter("@Nombres_", obj.Nombres, MySqlDbType.VarChar);
            parameters[4] = new MYSQLParameter("@Fecha_De_Nacimiento_", obj.Fecha_De_Nacimiento, MySqlDbType.Date);
            parameters[5] = new MYSQLParameter("@Sexo_", obj.Sexo, MySqlDbType.VarChar);
            parameters[6] = new MYSQLParameter("@Estado_Civil_", obj.Estado_Civil, MySqlDbType.VarChar);
            parameters[7] = new MYSQLParameter("@Profesion_", obj.Profesion, MySqlDbType.VarChar);
            parameters[8] = new MYSQLParameter("@Nivel_De_Instruccion_", obj.Nivel_De_Instruccion, MySqlDbType.VarChar);
            parameters[9] = new MYSQLParameter("@Direccion_", obj.Direccion, MySqlDbType.VarChar);
            parameters[10] = new MYSQLParameter("@Distrito_", obj.Distrito, MySqlDbType.VarChar);
            parameters[11] = new MYSQLParameter("@Provincia_", obj.Provincia, MySqlDbType.VarChar);
            parameters[12] = new MYSQLParameter("@Departamento_", obj.Departamento, MySqlDbType.VarChar);
            parameters[13] = new MYSQLParameter("@Referencia_", obj.Referencia, MySqlDbType.VarChar);
            parameters[14] = new MYSQLParameter("@Celular_", obj.Celular, MySqlDbType.VarChar);
            parameters[15] = new MYSQLParameter("@Telefono_", obj.Telefono, MySqlDbType.VarChar);
            parameters[16] = new MYSQLParameter("@Email_", obj.Email, MySqlDbType.VarChar);
            parameters[17] = new MYSQLParameter("@Envio_De_Cronogramas_De_Pago_", obj.Envio_De_Cronogramas_De_Pago, MySqlDbType.VarChar);
            parameters[18] = new MYSQLParameter("@Nombre_De_Empresa_", obj.Nombre_De_Empresa, MySqlDbType.VarChar);
            parameters[19] = new MYSQLParameter("@Fecha_De_Ingreso_", obj.Fecha_De_Ingreso, MySqlDbType.Date);
            parameters[20] = new MYSQLParameter("@Ingreso_Mensual_Neto_", obj.Ingreso_Mensual_Neto, MySqlDbType.Decimal);
            parameters[21] = new MYSQLParameter("@Cargo_", obj.Cargo, MySqlDbType.VarChar);
            parameters[22] = new MYSQLParameter("@Area_De_Trabajo_", obj.Area_De_Trabajo, MySqlDbType.VarChar);
            parameters[23] = new MYSQLParameter("@Direccion_De_Empresa_", obj.Direccion_De_Empresa, MySqlDbType.VarChar);
            parameters[24] = new MYSQLParameter("@Distrito_De_Empresa_", obj.Distrito_De_Empresa, MySqlDbType.VarChar);
            parameters[25] = new MYSQLParameter("@Provincia_De_Empresa_", obj.Provincia_De_Empresa, MySqlDbType.VarChar);
            parameters[26] = new MYSQLParameter("@Departamento_De_Empresa_", obj.Departamento_De_Empresa, MySqlDbType.VarChar);
            parameters[27] = new MYSQLParameter("@Referencia_De_Empresa_", obj.Referencia_De_Empresa, MySqlDbType.VarChar);
            parameters[28] = new MYSQLParameter("@Telefono_De_Empresa_", obj.Telefono_De_Empresa, MySqlDbType.VarChar);
            parameters[29] = new MYSQLParameter("@Modalidad_De_Contratacion_", obj.Modalidad_De_Contratacion, MySqlDbType.VarChar);
            parameters[30] = new MYSQLParameter("@Centro_De_Trabajo_", obj.Centro_De_Trabajo, MySqlDbType.VarChar);
            parameters[31] = new MYSQLParameter("@Monto_Acumulado_", obj.Monto_Acumulado, MySqlDbType.Decimal);
            parameters[32] = new MYSQLParameter("@Estado_", obj.Estado, MySqlDbType.VarChar);
            parameters[33] = new MYSQLParameter("@Nivel_", obj.Nivel, MySqlDbType.VarChar);
            parameters[34] = new MYSQLParameter("@Fecha_De_Registro_", obj.Fecha_De_Registro, MySqlDbType.Date);
            parameters[35] = new MYSQLParameter("@Id_Socio_", obj.Id_Socio, MySqlDbType.Int32);
            Response = ConexionMySql.ExecuteProcedureNonQuery("USP_Update_Socio", parameters);
            return Response;
        }
    }
}
