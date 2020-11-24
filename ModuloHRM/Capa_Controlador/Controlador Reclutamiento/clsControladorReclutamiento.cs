using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo.Modelo_Reclutamiento;
using System.Data.Odbc;

namespace Capa_Controlador.Controlador_Reclutamiento
{
    public class clsControladorReclutamiento
    {
        clsConsultasReclutamiento sn = new clsConsultasReclutamiento();

        //Paso de datos comboPuesto
        public DataTable funcItemsPuesto()
        {
            DataTable Items = sn.funcCmbHPuesto();
            return Items;
        }

        //Paso de datos Horario
        public DataTable funcItemsDepto()
        {
            DataTable Items = sn.funcCmbHDepto();
            return Items;
        }
        //Paso de datos Licencia de Conducir

        public DataTable funcItemsLicencia()
        {
            DataTable Items = sn.funcCmbLicencia();
            return Items;
        }
        //Paso de datos Estado Civil
        public DataTable funcItemsEstadoCivil()
        {
            DataTable Items = sn.funcCmbEstadoCivil();
            return Items;
        }

        //Paso de datos Nivel Estudio
        public DataTable funcItemsNivelEstudio()
        {
            DataTable Items = sn.funcCmbNivelEstudio();
            return Items;
        }

        //Paso de datos combos en Entrevista
        public DataTable funcItemsEntrevista()
        {
            DataTable Items = sn.funcCmbEntrevista();
            return Items;
        }

        //Paso de Paramaetros en el controlador para ComboBox
        public DataTable funcItemsHorario()
        {

            DataTable Items = sn.funcCmbHorario();
            return Items;
        }


        //consulta para insertar a la entidad Reclutamiento
        public void funcInsertarRecluta(int NivelEstudio, string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
            int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Estado, string Profesion, int Depto,
            string Residencia, string Zona, string Municipio, string Departamento)
        {
            sn.funcInsertarRecluta(NivelEstudio, Nombre1, Nombre2, Apellido1, Apellido2, FechaNac, Dpi, Genero, EstadoCivil, Email,
                Tel, NumIgss, Licencia, Puesto, Estado, Profesion, Depto, Residencia, Zona, Municipio, Departamento);
        }


        //Paso de datos para consulta insertar en la entidad Entrevista
        public void funcInsertarEntrevista(string IdEmpleado, string IdRecluta, int Entrevista, int resultado, string Comentario)
        {
            sn.funcInsertarEntrevista(IdEmpleado, IdRecluta, Entrevista, resultado, Comentario);
        }

        //consulta de busqueda por id en la entidad Reclutamiento
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            OdbcDataReader Lector = sn.funcBuscarRecluta(IdRecluta);
            return Lector;
        }

        //Paso de datos para consulta modificar en la entidad Reclutamiento
        public void funcModificarRecluta(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdRecluta)
        {

            sn.funcModificarRecluta(Nombre1, Nombre2, Apellido1, Apellido2, EstadoCivil, Email, Tel, NumIgss, Licencia, Puesto, Depto,
                Residencia, Zona, Municipio, Departamento, IdRecluta);


        }

        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombre1, string Nombre2, string Apellido1, string Apellido2,
                int EstadoCivil, string Email, int Tel, int Licencia, int Puesto, int CuentaB, int Depto,
                 string Residencia, string Zona, string Municipio, string Departamento, string IdEmpleado)
        {

            sn.funcModificarEmpleado(Nombre1, Nombre2, Apellido1, Apellido2, EstadoCivil, Email, Tel, Licencia, Puesto, CuentaB, Depto,
                Residencia, Zona, Municipio, Departamento, IdEmpleado);


        }

        //Paso de datos para consulta ascender(modificar puesto, depto) en la entidad Empleado
        public void funcAscenderEmpleado(int PuestoN, int DeptoN, string IdEmpleado)
        {

            sn.funcAscenderEmpleado(PuestoN, DeptoN, IdEmpleado);


        }
        //Paso de datos para consulta ingresar en la entidad empleado
        public void funcContratar(string Nombre1, string Nombre2, string Apellido1, string Apellido2, string FechaNac,
          int Dpi, int Genero, int EstadoCivil, string Email, int Tel, int NumIgss, int Licencia, int Puesto, int CuentaB, int Estado, int Depto,
          int EstadoR, string IdRecluta, string Residencia, string Zona, string Municipio, string Departamento)
        {
            sn.funcContratar(Nombre1, Nombre2, Apellido1, Apellido2, FechaNac, Dpi, Genero, EstadoCivil, Email,
                Tel, NumIgss, Licencia, Puesto, CuentaB, Estado, Depto, EstadoR, IdRecluta, Residencia, Zona, Municipio, Departamento);
        }

        //Paso de datos para consulta buscar en la entidad Reclutamiento
        public OdbcDataReader funcBusquedaCombos(string IdRecluta)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombos(IdRecluta);
            return Lector2;
        }
        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosEmp(IdEmpleado);
            return Lector2;
        }
        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado)
        {
            OdbcDataReader Lector = sn.funcBuscarEmpleado(IdEmpleado, Estado);
            return Lector;
        }


        //Paso de datos para consulta ingresar en la entidad Baja
        public void funcDespidoEmp(string IdEmpleado, int TipoBaja, double Prestaciones, string TiempoLabo, string FechaBaja, string Razones, int EstadoEmp)
        {
            sn.funcDespidoEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, Razones, EstadoEmp);
        }

        //Paso de datos para consulta ingresar en la entidad Baja
        public void funcRenunciaEmp(string IdEmpleado, int TipoBaja, double Prestaciones, string TiempoLabo, string FechaBaja, int EstadoEmp)
        {
            sn.funcRenunciaEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, EstadoEmp);
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento
        public DataTable funcTablaBancoTalento(int PrOpcion, int SgOpcion)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalento(PrOpcion, SgOpcion);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad empleado
        public DataTable funcTablaEmpleado(int Estado)
        {
            OdbcDataAdapter dt = sn.funcTablaEmpleado(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Id
        public DataTable funcFiltradoIdEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoIdEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Nombre
        public DataTable funcFiltradoNombreEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoNombreEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Apellido
        public DataTable funcFiltradoApellidoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoApellidoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Puesto
        public DataTable funcFiltradoPuestoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoPuestoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Departamento
        public DataTable funcFiltradoDepartamentoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoDepartamentoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Id
        public DataTable funcTablaBancoTalentoId(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoId(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Primer Nombre
        public DataTable funcTablaBancoTalentoNombre(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoNombre(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Primer Apellido
        public DataTable funcTablaBancoTalentoApellido(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoApellido(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Puesto
        public DataTable funcTablaBancoTalentoPuesto(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoPuesto(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Departamento
        public DataTable funcTablaBancoTalentoDepartamento(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoDepartamento(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Profesion
        public DataTable funcTablaBancoTalentoProfesion(int PrOpcion, int SgOpcion, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoProfesion(PrOpcion, SgOpcion, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }



    }
}
