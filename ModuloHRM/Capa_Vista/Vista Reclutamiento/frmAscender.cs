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
    public partial class frmAscender : Form
    {

        
        clsControladorReclutamiento Cont_R = new clsControladorReclutamiento();

        public frmAscender()
        {
            InitializeComponent();
            funcLlenarPuestoNuevo();
            funcLlnearDeptoNuevo();
            cmbPuestoNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentoNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        String IdEmpleado;
        int PuestoN, DeptoN;
        int Estado = 1;

        //función para llenar el contenido de la tabla hacia el combo
        public void funcLlenarPuestoNuevo()
        {
            
           
        }
        //función para llenar el contenido de la tabla hacia el combo
        public void funcLlnearDeptoNuevo()
        {
            
            
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
           

        }
        //Funcion de Limpieza
        private void funcLimpieza(){
            txtIdEmpleado.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            cmbDepartamentoAnterior.Text = "";
            cmbDepartamentoNuevo.Text = "";
            cmbPuestoAnterior.Text = "";
            cmbPuestoNuevo.Text = "";



        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void frmAscender_Load(object sender, EventArgs e)
        {
            txtIdEmpleado.MaxLength = 8;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarEmpleado MostrarEmp = new frmMostrarEmpleado();
            MostrarEmp.ShowDialog();
        }

        //Función de Bloqueo
        private void funcBloqueo()
        {
            pnlDatosGenerales.Enabled = false;
            gbxNuevoCargo.Enabled = false;
        }




    }
}
