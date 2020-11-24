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
        int Genero, EstadoCivil, Telefono, TipoLicencia, Puesto, Departamento, CuentaBanc;
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
            DataTable Datos = Cont_R.funcItemsPuesto();
            cmbPuesto.DataSource = Datos;
            cmbPuesto.DisplayMember = "NOMBRE_PUESTO";
            cmbPuesto.ResetText();
        }
        //metodo para llenar el combo departamento
        public void funcLlnearDepto()
        {
            DataTable Datos = Cont_R.funcItemsDepto();
            cmbDepartamento.DataSource = Datos;
            cmbDepartamento.DisplayMember = "NOMBRE_DEPARTAMENTO_EMPRESARIAL";
            cmbDepartamento.ResetText();
        }

        //metodo para llenar el combo licencia
        public void funcItemsLicencia()
        {
            DataTable Datos = Cont_R.funcItemsLicencia();
            cmbTipoLicencia.DataSource = Datos;
            cmbTipoLicencia.DisplayMember = "TIPO_LICENCIA_CONDUCCION";
            cmbTipoLicencia.ResetText();
        }
        //metodo para llenar el combo estado civil
        public void funcItemsEstadoCivil()
        {
            DataTable Datos = Cont_R.funcItemsEstadoCivil();
            cmbEstadoCivil.DataSource = Datos;
            cmbEstadoCivil.DisplayMember = "NOMBRE_ESTADO_CIVIL";
            cmbEstadoCivil.ResetText();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "" || txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtZona.Text == "" || txtResidencia.Text == "" || txtDepartamento.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtCuentaBanc.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea modificar este Empleado?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {

                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Reclutamiento
                    PrimerNom = txtPrimerNombre.Text;
                    SegundoNom = txtSegundoNombre.Text;
                    PrimerAp = txtPrimerApellido.Text;
                    SegundoAp = txtSegundoApellido.Text;
                    Email = txtCorreoElectronico.Text;
                    Telefono = Convert.ToInt32(txtTelefono.Text);
                    EstadoCivil = cmbEstadoCivil.SelectedIndex + 1;
                    TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;
                    Puesto = cmbPuesto.SelectedIndex + 1;
                    CuentaBanc = int.Parse(txtCuentaBanc.Text);
                    Departamento = cmbDepartamento.SelectedIndex + 1;
                    IdEmpleado = txtIdEmpleado.Text;
                    //EstadoRecluta = 0;

                    //datos entidad Direccion

                    Residencia = txtResidencia.Text;
                    Zona = txtZona.Text;
                    Municipio = txtMunicipio.Text;
                    Depto = txtDepartamento.Text;

                    //envío de datos hacia capa Controlador

                    Cont_R.funcModificarEmpleado(PrimerNom, SegundoNom, PrimerAp, SegundoAp,
                       EstadoCivil, Email, Telefono, TipoLicencia, Puesto, CuentaBanc, Departamento, Residencia, Zona
                       , Municipio, Depto, IdEmpleado);
                    MessageBox.Show("Se han modificado los datos del Empleado con Éxito", "FORMULARIO MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();


                }//fin elseif Pregunta

            }//fin elseif txt




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
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                btnModificar.Enabled = true;
                pnlDatosGenerales.Enabled = true;
                gbxDomicilio.Enabled = true;
                pnlPuesto.Enabled = true;
                cmbEstadoCivil.Enabled = true;
                cmbTipoLicencia.Enabled = true;
                txtCuentaBanc.Enabled = true;

                IdEmpleado = txtIdEmpleado.Text;
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarEmpleado(txtIdEmpleado.Text, Estado);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento

                        txtPrimerNombre.Text = Lector.GetString(0);
                        txtSegundoNombre.Text = Lector.GetString(1);
                        txtPrimerApellido.Text = Lector.GetString(2);
                        txtSegundoApellido.Text = Lector.GetString(3);
                        dtpFechaNacimiento.Text = Lector.GetString(4);
                        txtDpi.Text = Lector.GetString(5);

                        Genero = int.Parse(Lector.GetString(6));
                        //Condición para obtener el texto a mostrar en el txt de Genero
                        if (Genero == 1)
                        {
                            txtGenero.Text = "Masculino";

                        }
                        else
                        {
                            txtGenero.Text = "Femenino";
                        }

                        cmbEstadoCivil.Text = Lector.GetString(7);
                        txtCorreoElectronico.Text = Lector.GetString(8);
                        txtTelefono.Text = Lector.GetString(9);
                        txtNumeroIgss.Text = Lector.GetString(10);
                        cmbTipoLicencia.Text = Lector.GetString(11);
                        cmbPuesto.Text = Lector.GetString(12);
                        txtCuentaBanc.Text = Lector.GetString(13);
                        cmbDepartamento.Text = Lector.GetString(14);

                        //Tabla Direccion
                        txtDepartamento.Text = Lector.GetString(15);
                        txtZona.Text = Lector.GetString(16);
                        txtMunicipio.Text = Lector.GetString(17);
                        txtResidencia.Text = Lector.GetString(18);


                    }
                }
                else
                {

                }
                //Segunda Busqueda para obtener el Id de los combos
                OdbcDataReader Lector2 = Cont_R.funcBusquedaCombosEmp(txtIdEmpleado.Text);
                if (Lector2.HasRows == true)
                {
                    while (Lector2.Read())
                    {

                        EstadoCivil = int.Parse(Lector2.GetString(0));
                        TipoLicencia = int.Parse(Lector2.GetString(1));
                        Puesto = int.Parse(Lector2.GetString(2));
                        Departamento = int.Parse(Lector2.GetString(3));

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
