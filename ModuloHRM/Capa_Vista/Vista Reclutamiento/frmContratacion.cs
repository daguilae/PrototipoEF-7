using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador.Controlador_Reclutamiento;


namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmContratacion : Form
    {

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();


        public frmContratacion()
        {
            InitializeComponent();
        }

        //Declaración de variables Entidad Reclutamiento
        string PrimerNom, SegundoNom, PrimerAp, SegundoAp, FechaNac, Email, NombreProf, IdRecluta;
        int NivelEstudio, Genero, EstadoCivil, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, EstadoEmp,EstadoRecluta, Dpi,CuentaBanc;

        private void btnBancoTalento_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarBancoTalento MostrarBancoT = new frmMostrarBancoTalento();
            MostrarBancoT.ShowDialog();
        }

        //Declaración variables Entidad Dirección
        string Residencia, Zona, Municipio, Depto;

        private void btnBuscar_Click(object sender, EventArgs e){
            

        }

       
        private void btnContratar_Click(object sender, EventArgs e)
        {
            

        }


        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcfrmContratacion_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 11;
            txtTelefono.MaxLength = 8;
            txtCuentaBanc.MaxLength = 8;
            txtIdBancoTalento.MaxLength = 8;
        }
        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDpi.Text = "";
            txtNumeroIgss.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtGenero.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            txtResidencia.Text = "";
            txtZona.Text = "";
            txtMunicipio.Text = "";
            txtDepartamento.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCuentaBanc.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            cmbNivelEstudios.Text = "";
            txtProfesion.Text = "";

            

        }
        //Funcion de Bloqueo
        private void funcBloqueo()
        {

            txtCuentaBanc.Enabled = false;
            btnContratar.Enabled = false;

        }



    }
}
