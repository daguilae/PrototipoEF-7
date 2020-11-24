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
            DataTable Datos = Cont_R.funcItemsPuesto();
            cmbPuestoNuevo.DataSource = Datos;
            cmbPuestoNuevo.DisplayMember = "NOMBRE_PUESTO";
            cmbPuestoNuevo.ResetText();
        }
        //función para llenar el contenido de la tabla hacia el combo
        public void funcLlnearDeptoNuevo()
        {
            DataTable Datos = Cont_R.funcItemsDepto();
            cmbDepartamentoNuevo.DataSource = Datos;
            cmbDepartamentoNuevo.DisplayMember = "NOMBRE_DEPARTAMENTO_EMPRESARIAL";
            cmbDepartamentoNuevo.ResetText();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                btnAscender.Enabled = true;
                gbxNuevoCargo.Enabled = true;


                IdEmpleado = txtIdEmpleado.Text;
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarEmpleado(txtIdEmpleado.Text, Estado);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {

                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        txtPrimerNombre.Text = Lector.GetString(0);
                        txtSegundoNombre.Text = Lector.GetString(1);
                        txtPrimerApellido.Text = Lector.GetString(2);
                        txtSegundoApellido.Text = Lector.GetString(3);
                        cmbPuestoAnterior.Text = Lector.GetString(12);
                        cmbDepartamentoAnterior.Text = Lector.GetString(14);

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id de ese Empleado no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();
                }

            }//fin ifelse

        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo del Id no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de pregunta para verificar la acción
                if (MessageBox.Show("¿Desea Ascender a este Empleado?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Reclutamiento
                    PuestoN = cmbPuestoNuevo.SelectedIndex + 1;
                    DeptoN = cmbDepartamentoNuevo.SelectedIndex + 1;

                    //envío de datos hacia capa Controlador

                    Cont_R.funcAscenderEmpleado(PuestoN, DeptoN, IdEmpleado);

                    MessageBox.Show("Se ha ascendido con Éxito", "FORMULARIO ASCENSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funcLimpieza();
                    funcBloqueo();

                }//fin elseif Pregunta
            }

        }
        //Funcion de Limpieza
        private void funcLimpieza()
        {
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
