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
        string IdEmpleado, FechaBaja, Razones, TiempoLabo;
        int TipoBaja, EstadoEmp;
        double Prestaciones;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //función para llenar el contenido de la tabla hacia el combo
            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Se activan los componentes correspondientes para agregar/modificar datos
                rbtnDespido.Enabled = true;
                rbtnRenuncia.Enabled = true;
                gbxPrestacionesDespido.Enabled = true;

                //se obtiene el valor del Id
                IdEmpleado = txtIdEmpleado.Text;
                //Inicio para la busqueda
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
                        cmbPuesto.Text = Lector.GetString(12);
                        cmbDepartamento.Text = Lector.GetString(14);

                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El Id de este Empleado no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();
                }



            }//fin ifelse

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
            //Mensaje de Validación
            if (rbtnDespido.Checked == false && rbtnRenuncia.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado el tipo de Baja que se va a Realizar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //condición para verificar que los componentes no esten vacios dependiendo el radiobutton seleccionado
                if ((rbtnDespido.Checked == true && (txtIdEmpleado.Text == "" || txtMontoPrestaciones.Text == "" || txtTiempoLaborado.Text == "" || rtxtCausaDespido.Text == "")) || (rbtnRenuncia.Checked == true && (txtIdEmpleado.Text == "" || txtMontoPrestaciones.Text == "" || txtTiempoLaborado.Text == ""))) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {


                    //Condicion para despedir un empleado
                    if (rbtnDespido.Checked == true)
                    {

                        //Mensaje de Pregunta
                        if (MessageBox.Show("¿Desea Despedir a este Empleado ?", "Despido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                        else
                        {

                            //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                            Prestaciones = Convert.ToDouble(txtMontoPrestaciones.Text);
                            TiempoLabo = txtTiempoLaborado.Text;
                            FechaBaja = dtpFecha.Value.Date.ToShortDateString();
                            Razones = rtxtCausaDespido.Text;
                            //Se envía el estado correspondiente del despido
                            EstadoEmp = 3;
                            //Se envía la función con los datos anteriores a la siguiente capa

                            Cont_R.funcDespidoEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, Razones, EstadoEmp);
                            MessageBox.Show("Se ha dado de Baja al Empleado con Éxito", "FORMULARIO BAJAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            funcLimpieza();
                            funcBloqueo();
                        }//fin elseif Pregunta

                        //Condición para renuncia empleado
                    }
                    else
                    {

                        //Mensaje de Pregunta
                        if (MessageBox.Show("¿Desea Realizar la Renuncia de este Empleado ?", "Renuncia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                        else
                        {
                            //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                            Prestaciones = Convert.ToDouble(txtMontoPrestaciones.Text);
                            TiempoLabo = txtTiempoLaborado.Text;
                            FechaBaja = dtpFecha.Value.Date.ToShortDateString();
                            //Se envía el estado correspondiente de la renuncia
                            EstadoEmp = 4;
                            //Se envía la función con los datos anteriores a la siguiente capa
                            Cont_R.funcRenunciaEmp(IdEmpleado, TipoBaja, Prestaciones, TiempoLabo, FechaBaja, EstadoEmp);
                            MessageBox.Show("Se ha dado de Baja al Empleado con Éxito", "FORMULARIO BAJAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            funcLimpieza();
                            funcBloqueo();


                        }//fin elseif Pregunta



                    }




                }//fin elseif txt
            }//fin elseif rbtn

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
