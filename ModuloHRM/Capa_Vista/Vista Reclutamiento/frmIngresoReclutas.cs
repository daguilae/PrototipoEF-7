using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador.Controlador_Reclutamiento;


namespace Capa_Vista.Vista_Reclutamiento
{
    public partial class frmIngresoReclutas : Form
    {

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();

        public frmIngresoReclutas()
        {
            InitializeComponent();
            funcLlenarPuesto();
            funcLlnearDepto();
            cmbDepartamentoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            funcItemsLicencia();
            funcItemsEstadoCivil();
            funcItemsNivelEstudio();
        }

        //Declaración de variables Entidad Reclutamiento
        string PrimerNom, SegundoNom, PrimerAp, SegundoAp, FechaNac, Email, NombreProf, IdRecluta;
        int NivelEstudio, Genero, EstadoCivil, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, EstadoRecluta,Dpi;

        private void btnReclutas_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarReclutas MostrarReclu = new frmMostrarReclutas();
            MostrarReclu.ShowDialog();
        }

        //Declaración variables Entidad Dirección
        string Residencia, Zona, Municipio, Depto;

        private void btnModificar_Click(object sender, EventArgs e)
        {
            




        }

        
            

        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e){

            if (rbtnFemenino.Checked == true)
            {
                Genero = 2;
            }

        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMasculino.Checked == true)
            {
                Genero = 1;
            }
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
        //metodo para llenar el combo nivel de estudio
        public void funcItemsNivelEstudio()
        {
            

        }


        

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            
           
          
        }


        private void funcfrmIngreso_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 8;
            txtTelefono.MaxLength = 8;
            txtNumeroIgss.MaxLength = 8;
            txtZona.MaxLength = 3;
            txtResidencia.MaxLength = 5;
            txtIdRecluta.MaxLength = 8;
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           


        }
        //Función de Limpieza
        private void funcLimpieza()
        {


            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreoElectronico.Text = "";
            txtProfesion.Text = "";
            dtpFechaNacimiento.Value= DateTime.Now;
            txtTelefono.Text = "";
            txtNumeroIgss.Text = "";
            txtDpi.Text = "";
            cmbNivelEstudios.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamentoTrabajo.Text = "";

            txtResidencia.Text = "";
            txtZona.Text = "";
            txtMunicipio.Text = "";
            txtDepartamento.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            txtIdRecluta.Text = "";

        }
        //Función Bloqueo
        private void funcBloqueo()
        {
            gbxSexo.Enabled = true;
            btnIngreso.Enabled = true;
            btnModificar.Enabled = true;
            gbxFormacionAcademica.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtDpi.Enabled = true;
            btnModificar.Enabled = false;
            btnIngreso.Enabled = true;
        }


    }
}
