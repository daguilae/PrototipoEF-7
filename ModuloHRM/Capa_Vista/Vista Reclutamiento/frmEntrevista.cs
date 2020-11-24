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
    public partial class frmEntrevista : Form
    {

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();

        public frmEntrevista()
        {
            InitializeComponent();
            funcLlenarTipoEntrevista();
            cmbTipoEntrevista.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Declaración de variables Entidad Reclutamiento
        string IdEmpleado, IdRecluta,Comentarios;
        int Resultado,TipoEntrevista;

        

      
        //Se agrega el codigo a la variable resultado de reprobado
        private void rbtnReprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReprobado.Checked == true)
            {
                Resultado = 3;
                pnlOpciones.Enabled = false;
                rbtnPrimeraOp.Checked = false;
                rbtnSegOpcion.Checked = false;
            }
        }
        //Se agrega el codigo a la variable resultado de aprobado
        private void rbtnAprobado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAprobado.Checked == true)
            {
                pnlOpciones.Enabled = true;
            }
        }

        //funcion para llenar el combo
        public void funcLlenarTipoEntrevista()
        {
           
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void frmEntrevista_Load(object sender, EventArgs e)
        {
            txtIdEmpleado.MaxLength = 8;
            txtIdBancoTalento.MaxLength = 8;
        }

        private void btnReclutas_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarReclutas MostrarReclu = new frmMostrarReclutas();
            MostrarReclu.ShowDialog();
        }

        private void rbtnPrimeraOp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPrimeraOp.Checked == true)
            {
                Resultado = 1;
            }
        }

        private void rbtnSegOpcion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSegOpcion.Checked == true)
            {
                Resultado = 2;
            }
        }

        private void btnIngresoEntrevista_Click(object sender, EventArgs e)
        {
            

        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbPuestoTrabajo.Text = "";
            cmbTipoEntrevista.Text = "";
            txtIdEmpleado.Text = "";
            rbtnAprobado.Checked = false;
            rbtnReprobado.Checked = false;
            rtxtComentarios.Text = "";
            rbtnPrimeraOp.Checked = false;
            rbtnSegOpcion.Checked = false;


        }
        //Función de Bloqueo
        private void funcBloqueo()
        {
            gbxDatosEntrevista.Enabled = false;
        }


    }
}
