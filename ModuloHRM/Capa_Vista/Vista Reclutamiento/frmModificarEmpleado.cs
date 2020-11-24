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
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();
            funcLlenarPuesto();
            funcLlnearDepto();
            funcItemsLicencia();
            funcItemsEstadoCivil();
            cmbTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();

        //Declaración de variables Entidad Reclutamiento
        string PrimerNom, SegundoNom, PrimerAp, SegundoAp, Email, IdEmpleado;
        int  Genero, EstadoCivil, Telefono, TipoLicencia, Puesto, Departamento, CuentaBanc;
        int Estado = 1;
        //Declaración variables Entidad Dirección
        string Residencia, Zona, Municipio, Depto;

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarEmpleado MostrarEmp = new frmMostrarEmpleado();
            MostrarEmp.ShowDialog();
        }

        //metodo para llenar el combo puesto
        public void funcLlenarPuesto()
        {
            
        }
        //metodo para llenar el combo departamento
        public void funcLlnearDepto()
        {
           
        }
        
        //metodo para llenar el combo licencia
        public void funcItemsLicencia()
        {
            
        }
        //metodo para llenar el combo estado civil
        public void funcItemsEstadoCivil()
        {
           
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            




        }

        private void funcfrmEmpleado_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
            txtNumeroIgss.MaxLength = 8;
            txtResidencia.MaxLength = 8;
            txtZona.MaxLength = 8;
            txtCuentaBanc.MaxLength = 8;
            txtIdEmpleado.MaxLength = 8;
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           




        }

        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdEmpleado.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtDpi.Text = "";
            txtNumeroIgss.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtGenero.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamento.Text = "";
            txtResidencia.Text = "";
            txtZona.Text = "";
            txtMunicipio.Text = "";
            txtDepartamento.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCuentaBanc.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            



        }

        //Funcion de Bloqueo
        private void funcBloqueo()
        {
            btnModificar.Enabled = false;
            pnlDatosGenerales.Enabled = false;
            gbxDomicilio.Enabled = false;
            pnlPuesto.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbTipoLicencia.Enabled = false;
            txtCuentaBanc.Enabled = false;
        }
    }
}
