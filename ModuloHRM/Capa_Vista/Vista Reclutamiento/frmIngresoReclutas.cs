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
        int NivelEstudio, Genero, EstadoCivil, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, EstadoRecluta, Dpi;

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
            //Mensaje de Validación

            if (txtIdRecluta.Text == "" || txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtNumeroIgss.Text == "" || txtZona.Text == "" || txtResidencia.Text == "" || txtDepartamento.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {


                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea Modificar el Recluta del Banco de Talento ?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
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
                    NumIgss = Convert.ToInt32(txtNumeroIgss.Text);
                    EstadoCivil = cmbEstadoCivil.SelectedIndex + 1;
                    TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;
                    Puesto = cmbPuesto.SelectedIndex + 1;
                    Departamento = cmbDepartamentoTrabajo.SelectedIndex + 1;
                    IdRecluta = txtIdRecluta.Text;
                    //EstadoRecluta = 0;

                    //datos entidad Direccion

                    Residencia = txtResidencia.Text;
                    Zona = txtZona.Text;
                    Municipio = txtMunicipio.Text;
                    Depto = txtDepartamento.Text;

                    //envío de datos hacia capa Controlador

                    Cont_R.funcModificarRecluta(PrimerNom, SegundoNom, PrimerAp, SegundoAp,
                       EstadoCivil, Email, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, Residencia, Zona
                       , Municipio, Depto, IdRecluta);
                    MessageBox.Show("Se han modificado los datos del Recluta con Éxito", "FORMULARIO RECLUTAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();




                }//fin elseif Pregunta

            }//fin elseif txt




        }




        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {

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
            DataTable Datos = Cont_R.funcItemsPuesto();
            cmbPuesto.DataSource = Datos;
            cmbPuesto.DisplayMember = "NOMBRE_PUESTO";
            cmbPuesto.ResetText();
        }
        //metodo para llenar el combo departamento
        public void funcLlnearDepto()
        {
            DataTable Datos = Cont_R.funcItemsDepto();
            cmbDepartamentoTrabajo.DataSource = Datos;
            cmbDepartamentoTrabajo.DisplayMember = "NOMBRE_DEPARTAMENTO_EMPRESARIAL";
            cmbDepartamentoTrabajo.ResetText();
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
        //metodo para llenar el combo nivel de estudio
        public void funcItemsNivelEstudio()
        {
            DataTable Datos = Cont_R.funcItemsNivelEstudio();
            cmbNivelEstudios.DataSource = Datos;
            cmbNivelEstudios.DisplayMember = "NOMBRE_FORMACION_ACADEMICA";
            cmbNivelEstudios.ResetText();

        }




        private void btnIngreso_Click(object sender, EventArgs e)
        {

            //primera verificación de datos de radiobuttons vacios
            if (rbtnMasculino.Checked == false && rbtnFemenino.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un sexo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //segunda verificación de datos de cajas de texto vacias
                if (txtPrimerNombre.Text == "" || txtSegundoNombre.Text == "" || txtPrimerApellido.Text == "" || txtSegundoApellido.Text == "" || txtDpi.Text == "" || txtNumeroIgss.Text == "" || txtZona.Text == "" || txtResidencia.Text == "" || txtDepartamento.Text == "" || txtMunicipio.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtProfesion.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    //Se declara variable de DateTime para realizar validación de fecha nacimiento
                    DateTime FecharNac = dtpFechaNacimiento.Value.Date;
                    var DiasNac = (DateTime.Now - FecharNac).TotalDays;

                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea agregar un nuevo Recluta al Banco de Talento ?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {
                        //tercera verificación de datos, fecha de nacimiento mayor a 100 años
                        if (DiasNac > 36500)
                        {
                            MessageBox.Show("ADVERTENCIA: Edad errónea, no puede ingresar una edad mayor a 100 años.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                        }//fin if validación fecha nac


                        //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                        //datos Reclutamiento
                        PrimerNom = txtPrimerNombre.Text;
                        SegundoNom = txtSegundoNombre.Text;
                        PrimerAp = txtPrimerApellido.Text;
                        SegundoAp = txtSegundoApellido.Text;
                        Email = txtCorreoElectronico.Text;
                        NombreProf = txtProfesion.Text;
                        FechaNac = dtpFechaNacimiento.Value.Date.ToShortDateString();
                        Telefono = Convert.ToInt32(txtTelefono.Text);
                        NumIgss = Convert.ToInt32(txtNumeroIgss.Text);
                        Dpi = int.Parse(txtDpi.Text);
                        NivelEstudio = cmbNivelEstudios.SelectedIndex + 1;
                        EstadoCivil = cmbEstadoCivil.SelectedIndex + 1;
                        TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;
                        Puesto = cmbPuesto.SelectedIndex + 1;
                        Departamento = cmbDepartamentoTrabajo.SelectedIndex + 1;
                        EstadoRecluta = 0;

                        //datos entidad Direccion

                        Residencia = txtResidencia.Text;
                        Zona = txtZona.Text;
                        Municipio = txtMunicipio.Text;
                        Depto = txtDepartamento.Text;

                        //envío de datos hacia capa Controlador

                        Cont_R.funcInsertarRecluta(NivelEstudio, PrimerNom, SegundoNom, PrimerAp, SegundoAp, FechaNac, Dpi, Genero,
                           EstadoCivil, Email, Telefono, NumIgss, TipoLicencia, Puesto, EstadoRecluta, NombreProf, Departamento, Residencia, Zona
                           , Municipio, Depto);
                        MessageBox.Show("Se ha ingresado al Banco de Talento con Éxito", "FORMULARIO RECLUTAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        funcLimpieza();



                    }//fin elseif Pregunta

                }//fin elseif txt

            }//fin elseif rbtn

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
            //Mensaje de Validación
            if (txtIdRecluta.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //se desbloquean los componentes en los que se puede agregar/cambiar información
                IdRecluta = txtIdRecluta.Text;
                //Se desactivan campos que no se deben de modificar
                gbxSexo.Enabled = false;
                btnIngreso.Enabled = false;
                btnModificar.Enabled = true;
                gbxFormacionAcademica.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                txtDpi.Enabled = false;

                //Inicio para modificacion
                OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtIdRecluta.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento
                        cmbNivelEstudios.Text = Lector.GetString(0);
                        txtPrimerNombre.Text = Lector.GetString(1);
                        txtSegundoNombre.Text = Lector.GetString(2);
                        txtPrimerApellido.Text = Lector.GetString(3);
                        txtSegundoApellido.Text = Lector.GetString(4);
                        dtpFechaNacimiento.Text = Lector.GetString(5);
                        txtDpi.Text = Lector.GetString(6);
                        //Condición para obtener la opción a cambiar de Genero
                        Genero = int.Parse(Lector.GetString(7));
                        if (Genero == 1)
                        {
                            rbtnFemenino.Checked = false;
                            rbtnMasculino.Checked = true;
                        }
                        else
                        {
                            rbtnMasculino.Checked = false;
                            rbtnFemenino.Checked = true;
                        }

                        cmbEstadoCivil.Text = Lector.GetString(8);
                        txtCorreoElectronico.Text = Lector.GetString(9);
                        txtTelefono.Text = Lector.GetString(10);
                        txtNumeroIgss.Text = Lector.GetString(11);
                        cmbTipoLicencia.Text = Lector.GetString(12);
                        cmbPuesto.Text = Lector.GetString(13);

                        cmbDepartamentoTrabajo.Text = Lector.GetString(14);
                        txtProfesion.Text = Lector.GetString(15);
                        //Tabla Direccion
                        txtDepartamento.Text = Lector.GetString(16);
                        txtZona.Text = Lector.GetString(17);
                        txtMunicipio.Text = Lector.GetString(18);
                        txtResidencia.Text = Lector.GetString(19);




                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El Id del Recluta ingresado no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    funcBloqueo();
                    funcLimpieza();


                }//fin elseif lector

            }//fin elseif mensaje


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
            dtpFechaNacimiento.Value = DateTime.Now;
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
