using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Reclutamiento
{
    public class clsConsultasReclutamiento
    {
        clsConexion Con = new clsConexion();

        //Muestra datos en combo Puesto
        public DataTable funcCmbHPuesto()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        //Muestra datos en combo Departamento
        public DataTable funcCmbHDepto()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM DEPARTAMENTO_EMPRESARIAL";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en comboHorario
        public DataTable funcCmbHorario()
        {
            //Declaración de DataTable para Datos
            DataTable Datos = new DataTable();
            try
            {
                //Consulta para Obtener Datos y pasarlos a un DataTable
                string CargaPuestos = "SELECT * FROM HORARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                //Mensaje en dado caso de Error la Consulta
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin


        //Muestra datos en combo Licencia
        public DataTable funcCmbLicencia()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM LICENCIA_CONDUCCION";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Estado Civil
        public DataTable funcCmbEstadoCivil()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM ESTADO_CIVIL";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Nivel Estudios
        public DataTable funcCmbNivelEstudio()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM FORMACION_ACADEMICA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Tipo Entrevista
        public DataTable funcCmbEntrevista()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPO_ENTREVISTA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 


        //Consulta para ingresar datos en la entidad reclutamiento
        public void funcInsertarRecluta(int NivelEstudio, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
            int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Estado, string Profesion, int Depto,
            string Residencia, string Zona, string Municipio, string Departamento)
        {
            try
            {
                int IdRecluta, IdDir;
                string CorrelativoReclu = "SELECT IFNULL(MAX(PK_ID_RECLUTAMIENTO),0) +1 FROM RECLUTAMIENTO";
                string CorrelativoDire = "SELECT IFNULL(MAX(PK_ID_DIRECCION),0) +1 FROM DIRECCION";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.funcconexion());
                OdbcCommand QueryIdDire = new OdbcCommand(CorrelativoDire, Con.funcconexion());
                IdRecluta = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                IdDir = Convert.ToInt32(QueryIdDire.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();
                OdbcDataReader Ejecucion2 = QueryIdDire.ExecuteReader();

                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO RECLUTAMIENTO (PK_ID_RECLUTAMIENTO, FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO, NOMBRE1_RECLUTAMIENTO, " +
                    "NOMBRE2_RECLUTAMIENTO, APELLIDO1_RECLUTAMIENTO, APELLIDO2_RECLUTAMIENTO, FECHA_NACIMIENTO_RECLUTAMIENTO, DPI_RECLUTAMIENTO," +
                    "FK_ID_GENERO_RECLUTAMIENTO, FK_ID_ESTADO_CIVIL_RECLUTAMIENTO, EMAIL_RECLUTAMIENTO,TELEFONO_RECLUTAMIENTO, NUMERO_IGSS_RECLUTAMIENTO," +
                    "FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO, FK_ID_PUESTO_RECLUTAMIENTO,ESTADO_RECLUTADO_ENTREVISTA,NOMBRE_PROFESION," +
                    "FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO) VALUES " + "('" + IdRecluta + "','" + NivelEstudio + "','" + Nombre1 + "','" + Nombre2 + "','"
                    + Apellido1 + "','" + Apellido2 + "','" + FechaNac + "','" + Dpi + "','" + Genero + "','" + EstadoCivil + "','" + Email + "','"
                    + Tel + "','" + NumIgss + "','" + Licencia + "','" + Puesto + "','" + Estado + "','" + Profesion + "','" + Depto + "')";

                //Sentencia para insertar datos a entidad Direccion
                string SentenciaDireccion = "INSERT INTO DIRECCION(PK_ID_DIRECCION, DEPARTAMENTO_DIRECCION,ZONA_DIRECCION, MUNICIPIO_DIRECCION, RESIDENCIA_DIRECCION, FK_RECLUTAMIENTO_DIRECCION) VALUES "
                    + "('" + IdDir + "','" + Departamento + "','" + Zona + "','" + Municipio + "','" + Residencia + "','" + IdRecluta + "')";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.funcconexion());
                OdbcCommand Query_IngresoDir = new OdbcCommand(SentenciaDireccion, Con.funcconexion());
                Query_IngresoRec.ExecuteNonQuery();
                Query_IngresoDir.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Consulta para buscar un recluta por el Id
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT FA.NOMBRE_FORMACION_ACADEMICA,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO,R.FECHA_NACIMIENTO_RECLUTAMIENTO, R.DPI_RECLUTAMIENTO, R.FK_ID_GENERO_RECLUTAMIENTO, EC.NOMBRE_ESTADO_CIVIL, R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, R.NUMERO_IGSS_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.NOMBRE_PROFESION, D.DEPARTAMENTO_DIRECCION, D.ZONA_DIRECCION, D.MUNICIPIO_DIRECCION, D.RESIDENCIA_DIRECCION FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND R.PK_ID_RECLUTAMIENTO = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para modificar en la entidad Reclutamiento
        public void funcModificarRecluta(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdRecluta)
        {
            try
            {
                string sentencia = "UPDATE RECLUTAMIENTO SET NOMBRE1_RECLUTAMIENTO='" + Nombre1 + "', NOMBRE2_RECLUTAMIENTO='" + Nombre2 +
                    "', APELLIDO1_RECLUTAMIENTO='" + Apellido1 + "', APELLIDO2_RECLUTAMIENTO='" + Apellido2 + "', FK_ID_ESTADO_CIVIL_RECLUTAMIENTO='" + EstadoCivil +
                    "', EMAIL_RECLUTAMIENTO='" + Email + "', 	TELEFONO_RECLUTAMIENTO='" + Tel + "', NUMERO_IGSS_RECLUTAMIENTO='" + NumIgss +
                    "', 	FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO='" + Licencia + "', FK_ID_PUESTO_RECLUTAMIENTO='" + Puesto +
                    "', 	FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO='" + Depto + "' WHERE PK_ID_RECLUTAMIENTO= '" + IdRecluta + "'";

                string sentencia2 = "UPDATE DIRECCION SET DEPARTAMENTO_DIRECCION ='" + Departamento + "',ZONA_DIRECCION='" + Zona +
                    "',MUNICIPIO_DIRECCION = '" + Municipio + "', RESIDENCIA_DIRECCION='" + Residencia + "' WHERE FK_RECLUTAMIENTO_DIRECCION='" + IdRecluta + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia2, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                Query_Validacion2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Consulta para ingresar Recluta
        public void funcInsertarEntrevista(string IdEmpleado, string IdRecluta, int Entrevista, int resultado, string Comentario)
        {
            try
            {
                int IdEntrevista;
                string CorrelativoReclu = "SELECT IFNULL(MAX(PK_ID_ENTREVISTA),0) +1 FROM ENTREVISTA";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.funcconexion());
                IdEntrevista = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO ENTREVISTA (PK_ID_ENTREVISTA, FK_ID_EMPLEADO_ENTREVISTA, FK_ID_RECLUTAMIENTO_ENTREVISTA, " +
                    "FK_ID_TIPO_ENTREVISTA, RESULTADO_ENTREVISTA, COMENTARIOS_ENTREVISTADOR_ENTREVISTA) VALUES " + "('" + IdEntrevista + "','" + IdEmpleado + "','" + IdRecluta + "','" + Entrevista + "','"
                    + resultado + "','" + Comentario + "')";

                string sentencia = "UPDATE RECLUTAMIENTO SET ESTADO_RECLUTADO_ENTREVISTA= '" + resultado + "'WHERE PK_ID_RECLUTAMIENTO='" + IdRecluta + "'";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.funcconexion());
                Query_IngresoRec.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //consulta para modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int Licencia, int Puesto, int CuentaB, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdEmpleado)
        {
            try
            {
                string sentencia = "UPDATE EMPLEADO SET NOMBRE1_EMPLEADO='" + Nombre1 + "', NOMBRE2_EMPLEADO='" + Nombre2 +
                    "', APELLIDO1_EMPLEADO='" + Apellido1 + "', APELLIDO2_EMPLEADO='" + Apellido2 + "', FK_ID_ESTADO_CIVIL_EMPLEADO='" + EstadoCivil +
                    "', EMAIL_EMPLEADO='" + Email + "', 	TELEFONO_EMPLEADO='" + Tel +
                    "', 	FK_ID_LICENCIA_CONDUCIR_EMPLEADO='" + Licencia + "', FK_ID_PUESTO_EMPLEADO='" + Puesto +
                    "', 	CUENTA_BANCARIA_EMPLEADO='" + CuentaB + "', FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO='" + Depto + "' WHERE PK_ID_EMPLEADO= '" + IdEmpleado + "'";

                string sentencia2 = "UPDATE DIRECCION SET DEPARTAMENTO_DIRECCION ='" + Departamento + "',ZONA_DIRECCION='" + Zona +
                    "',MUNICIPIO_DIRECCION = '" + Municipio + "', RESIDENCIA_DIRECCION='" + Residencia + "' WHERE FK_EMPLEADO_DIRECCION='" + IdEmpleado + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia2, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                Query_Validacion2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //consulta para ascender(modificar puesto, depto) en la entidad empleado
        public void funcAscenderEmpleado(int PuestoN, int DeptoN, string IdEmpleado)
        {
            try
            {
                string sentencia = "UPDATE EMPLEADO SET FK_ID_PUESTO_EMPLEADO='" + PuestoN + "', FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO='" + DeptoN +
                    "' WHERE PK_ID_EMPLEADO= '" + IdEmpleado + "'";


                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //sentencias para buscar y obtener el ID de los combo reclutas
        public OdbcDataReader funcBusquedaCombos(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO,R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO, R.FK_ID_PUESTO_RECLUTAMIENTO, R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO FROM RECLUTAMIENTO AS R WHERE R.PK_ID_RECLUTAMIENTO = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        //consulta para ingresar datos en la entidad empleado
        //Consulta para Contratar un Recluta
        public void funcContratar(string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
          int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int CuentaB, int Estado, int Depto,
          int EstadoR, string IdRecluta, string Residencia, string Zona, string Municipio, string Departamento)
        {
            try
            {
                int IdEmpleado, IdDir;
                string CorrelativoEmpleado = "SELECT IFNULL(MAX(PK_ID_EMPLEADO),0) +1 FROM EMPLEADO";
                string CorrelativoDire = "SELECT IFNULL(MAX(PK_ID_DIRECCION),0) +1 FROM DIRECCION";
                OdbcCommand QueryIdEmpleado = new OdbcCommand(CorrelativoEmpleado, Con.funcconexion());
                OdbcCommand QueryIdDire = new OdbcCommand(CorrelativoDire, Con.funcconexion());
                IdEmpleado = Convert.ToInt32(QueryIdEmpleado.ExecuteScalar());
                IdDir = Convert.ToInt32(QueryIdDire.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdEmpleado.ExecuteReader();
                OdbcDataReader Ejecucion2 = QueryIdDire.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaEmpleado = "INSERT INTO EMPLEADO(PK_ID_EMPLEADO, NOMBRE1_EMPLEADO,NOMBRE2_EMPLEADO, APELLIDO1_EMPLEADO," +
                    " APELLIDO2_EMPLEADO, FECHA_NACIMIENTO_EMPLEADO, DPI_EMPLEADO,FK_ID_GENERO_EMPLEADO, fk_id_estado_civil_empleado, " +
                    "EMAIL_EMPLEADO,TELEFONO_EMPLEADO, NUMERO_IGGS_EMPLEADO,FK_ID_LICENCIA_CONDUCIR_EMPLEADO, FK_ID_PUESTO_EMPLEADO," +
                    "CUENTA_BANCARIA_EMPLEADO, FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO,ESTADO_EMPLEADO) VALUES " + "('" + IdEmpleado + "','" + Nombre1 + "','" + Nombre2 + "','"
                    + Apellido1 + "','" + Apellido2 + "','" + FechaNac + "','" + Dpi + "','" + Genero + "','" + EstadoCivil + "','" + Email + "','"
                    + Tel + "','" + NumIgss + "','" + Licencia + "','" + Puesto + "','" + CuentaB + "','" + Depto + "','" + Estado + "')";

                string sentencia = "UPDATE RECLUTAMIENTO SET ESTADO_RECLUTADO_ENTREVISTA= '" + EstadoR + "'WHERE PK_ID_RECLUTAMIENTO='" + IdRecluta + "'";

                //Sentencia para insertar datos a entidad Direccion
                string SentenciaDireccion = "INSERT INTO DIRECCION(PK_ID_DIRECCION, DEPARTAMENTO_DIRECCION,ZONA_DIRECCION, MUNICIPIO_DIRECCION, RESIDENCIA_DIRECCION, FK_EMPLEADO_DIRECCION) VALUES " + "('" + IdDir + "','" + Departamento + "','" + Zona + "','" + Municipio + "','" + Residencia + "','" + IdEmpleado + "')";


                OdbcCommand Query_IngresoEmp = new OdbcCommand(SentenciaEmpleado, Con.funcconexion());
                Query_IngresoEmp.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();

                OdbcCommand Query_IngresoDir = new OdbcCommand(SentenciaDireccion, Con.funcconexion());
                Query_IngresoDir.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //consulta para buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO,E.FECHA_NACIMIENTO_EMPLEADO, E.DPI_EMPLEADO, E.FK_ID_GENERO_EMPLEADO, EC.NOMBRE_ESTADO_CIVIL, E.EMAIL_EMPLEADO, E.TELEFONO_EMPLEADO, E.NUMERO_IGGS_EMPLEADO, LC.TIPO_LICENCIA_CONDUCCION, P.NOMBRE_PUESTO,E.CUENTA_BANCARIA_EMPLEADO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL, D.DEPARTAMENTO_DIRECCION, D.ZONA_DIRECCION, D.MUNICIPIO_DIRECCION, D.RESIDENCIA_DIRECCION FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.PK_ID_EMPLEADO = '" + IdEmpleado + "' AND E.ESTADO_EMPLEADO = '" + Estado + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para buscar y obtener el valor Id de los combobox
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.fk_id_estado_civil_empleado, E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO, E.FK_ID_PUESTO_EMPLEADO, E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO FROM EMPLEADO AS E WHERE E.PK_ID_EMPLEADO = '" + IdEmpleado + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.funcconexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }



        //consulta para ingresar datos en la entidad Baja
        //Consulta para despidos
        public void funcDespidoEmp(string IdEmpleado, int TipoBaja, double Prestaciones, string TiempoLabo, string FechaBaja, string Razones, int EstadoEmp)
        {
            try
            {
                int IdBaja;
                string CorrelativoReclu = "SELECT IFNULL(MAX(PK_ID_BAJA),0) +1 FROM BAJA";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.funcconexion());
                IdBaja = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO BAJA(PK_ID_BAJA, FK_ID_EMPLEADO_BAJA, FK_ID_TIPO_BAJA, " +
                    "PRESTACIONES_BAJA, TIEMPO_LABORADO_BAJA, FECHA_DESPIDO_BAJA, CAUSA_BAJAS) VALUES " + "('" + IdBaja + "','" + IdEmpleado + "','" + TipoBaja + "','" + Prestaciones + "','"
                    + TiempoLabo + "','" + FechaBaja + "','" + Razones + "')";


                string sentencia = "UPDATE EMPLEADO SET ESTADO_EMPLEADO='" + EstadoEmp + "' WHERE PK_ID_EMPLEADO= '" + IdEmpleado + "'";

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.funcconexion());
                Query_IngresoRec.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //consulta para ingresar datos en la entidad Baja
        //Consulta para renuncias
        public void funcRenunciaEmp(string IdEmpleado, int TipoBaja, double Prestaciones, string TiempoLabo, string FechaBaja, int EstadoEmp)
        {
            try
            {
                int IdBaja;
                string CorrelativoReclu = "SELECT IFNULL(MAX(PK_ID_BAJA),0) +1 FROM BAJA";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.funcconexion());
                IdBaja = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO BAJA (PK_ID_BAJA, FK_ID_EMPLEADO_BAJA, FK_ID_TIPO_BAJA, " +
                    "PRESTACIONES_BAJA, TIEMPO_LABORADO_BAJA, FECHA_DESPIDO_BAJA) VALUES " + "('" + IdBaja + "','" + IdEmpleado + "','" + TipoBaja + "','" + Prestaciones + "','"
                    + TiempoLabo + "','" + FechaBaja + "')";


                string sentencia = "UPDATE EMPLEADO SET ESTADO_EMPLEADO='" + EstadoEmp + "' WHERE PK_ID_EMPLEADO= '" + IdEmpleado + "'";


                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();




                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.funcconexion());
                Query_IngresoRec.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //consulta para mostrar datos de la entidad reclutamiento

        public OdbcDataAdapter funcTablaBancoTalento(int PrOpcion, int SgOpcion)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Id
        public OdbcDataAdapter funcTablaBancoTalentoId(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND R.PK_ID_RECLUTAMIENTO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por primer nombre
        public OdbcDataAdapter funcTablaBancoTalentoNombre(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND R.NOMBRE1_RECLUTAMIENTO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por primer apellido
        public OdbcDataAdapter funcTablaBancoTalentoApellido(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND R.APELLIDO1_RECLUTAMIENTO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Puesto
        public OdbcDataAdapter funcTablaBancoTalentoPuesto(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND P.NOMBRE_PUESTO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Departamento
        public OdbcDataAdapter funcTablaBancoTalentoDepartamento(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Profesion
        public OdbcDataAdapter funcTablaBancoTalentoProfesion(int PrOpcion, int SgOpcion, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.PK_ID_RECLUTAMIENTO,R.NOMBRE1_RECLUTAMIENTO, R.NOMBRE2_RECLUTAMIENTO, R.APELLIDO1_RECLUTAMIENTO, R.APELLIDO2_RECLUTAMIENTO, P.NOMBRE_PUESTO,DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,R.EMAIL_RECLUTAMIENTO, R.TELEFONO_RECLUTAMIENTO, LC.TIPO_LICENCIA_CONDUCCION,  R.NOMBRE_PROFESION, FA.NOMBRE_FORMACION_ACADEMICA FROM RECLUTAMIENTO AS R, DIRECCION AS D, FORMACION_ACADEMICA AS FA, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE R.FK_ID_NIVEL_ESTUDIO_RECLUTAMIENTO = FA.PK_ID_FORMACION_ACADEMICA AND R.FK_ID_ESTADO_CIVIL_RECLUTAMIENTO = EC.PK_ID_ESTADO_CIVIL AND R.FK_ID_LICENCIA_CONDUCIR_RECLUTAMIENTO = LC.PK_ID_LICENCIA_CONDUCCION AND R.FK_ID_PUESTO_RECLUTAMIENTO = P.PK_ID_PUESTO AND R.FK_ID_DEPARTAMENTO_EMPRESARIAL_RECLUTAMIENTO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_RECLUTAMIENTO_DIRECCION = R.PK_ID_RECLUTAMIENTO AND (R.ESTADO_RECLUTADO_ENTREVISTA='" + PrOpcion + "' OR R.ESTADO_RECLUTADO_ENTREVISTA='" + SgOpcion + "') AND R.NOMBRE_PROFESION LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }






        //consulta para mostrar datos de la entidad empleado
        public OdbcDataAdapter funcTablaEmpleado(int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO,E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO,P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL,E.EMAIL_EMPLEADO, E.TELEFONO_EMPLEADO, E.NUMERO_IGGS_EMPLEADO, LC.TIPO_LICENCIA_CONDUCCION, E.CUENTA_BANCARIA_EMPLEADO FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Empleado por Id
        public OdbcDataAdapter funcFiltradoIdEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO, E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "' AND E.PK_ID_EMPLEADO LIKE ('" + Parametro + "%')";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        //consulta para mostrar datos de la entidad Empleado por Primer Nombre
        public OdbcDataAdapter funcFiltradoNombreEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO, E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "' AND E.NOMBRE1_EMPLEADO LIKE ('" + Parametro + "%')";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
        //consulta para mostrar datos de la entidad Empleado por Primer Apellido
        public OdbcDataAdapter funcFiltradoApellidoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO, E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "' AND E.APELLIDO1_EMPLEADO LIKE ('" + Parametro + "%')";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
        //consulta para mostrar datos de la entidad Empleado por Puesto
        public OdbcDataAdapter funcFiltradoPuestoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO, E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "' AND P.NOMBRE_PUESTO LIKE ('" + Parametro + "%')";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }



        //consulta para mostrar datos de la entidad Empleado por Departamento
        public OdbcDataAdapter funcFiltradoDepartamentoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.PK_ID_EMPLEADO, E.NOMBRE1_EMPLEADO, E.NOMBRE2_EMPLEADO, E.APELLIDO1_EMPLEADO, E.APELLIDO2_EMPLEADO, P.NOMBRE_PUESTO, DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL FROM EMPLEADO AS E, DIRECCION AS D, ESTADO_CIVIL AS EC, LICENCIA_CONDUCCION AS LC, PUESTO AS P, DEPARTAMENTO_EMPRESARIAL AS DE WHERE E.fk_id_estado_civil_empleado = EC.PK_ID_ESTADO_CIVIL AND E.FK_ID_LICENCIA_CONDUCIR_EMPLEADO = LC.PK_ID_LICENCIA_CONDUCCION AND E.FK_ID_PUESTO_EMPLEADO = P.PK_ID_PUESTO AND E.FK_ID_DEPARTAMENTO_EMPRESARIAL_EMPLEADO = DE.PK_ID__DEPARTAMENTO_EMPRESARIAL AND D.FK_EMPLEADO_DIRECCION = E.PK_ID_EMPLEADO AND E.ESTADO_EMPLEADO = '" + Estado + "' AND DE.NOMBRE_DEPARTAMENTO_EMPRESARIAL LIKE ('" + Parametro + "%')";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.funcconexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }


    }
}
