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
    public partial class frmBajasEmpleado : Form
    {
        public frmBajasEmpleado()
        {
            InitializeComponent();

        }

        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();
        int Estado = 1;
        //declaración de variables
        string IdEmpleado,  FechaBaja, Razones, TiempoLabo;
        int TipoBaja, EstadoEmp;
        double Prestaciones;


        private void btnBuscar_Click(object sender, EventArgs e)
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


        //función para llenar el contenido de la tabla hacia el combo
        private void rbtnRenuncia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRenuncia.Checked == true)
            {
                rtxtCausaDespido.Enabled = false;
                TipoBaja = 1;

            }
        }

        private void frmBajasEmpleado_Load(object sender, EventArgs e)
        {
            txtMontoPrestaciones.MaxLength = 8;
            txtIdEmpleado.MaxLength = 8;

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarEmpleado MostrarEmp = new frmMostrarEmpleado();
            MostrarEmp.ShowDialog();
        }

        private void rbtnDespido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDespido.Checked == true)
            {
                rtxtCausaDespido.Enabled = true;
                TipoBaja = 2;

            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
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
            cmbDepartamento.Text = "";
            cmbPuesto.Text = "";
            rbtnDespido.Checked = false;
            rbtnRenuncia.Checked = false;
            txtMontoPrestaciones.Text = "";
            txtTiempoLaborado.Text = "";
            dtpFecha.Value = DateTime.Now;
            rtxtCausaDespido.Text = "";


        }
        //Funcion de Bloqueo
        private void funcBloqueo()
        {
            rbtnDespido.Enabled = false;
            rbtnRenuncia.Enabled = false;
            gbxPrestacionesDespido.Enabled = false;


        }


    }
}
