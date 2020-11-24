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
        int NivelEstudio, Genero, EstadoCivil, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, EstadoEmp, EstadoRecluta, Dpi, CuentaBanc;

        private void btnBancoTalento_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarBancoTalento MostrarBancoT = new frmMostrarBancoTalento();
            MostrarBancoT.ShowDialog();
        }

        //Declaración variables Entidad Dirección
        string Residencia, Zona, Municipio, Depto;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //se desbloquean los componentes en los que se puede agregar/cambiar información
                btnContratar.Enabled = true;
                txtCuentaBanc.Enabled = true;
                IdRecluta = txtIdBancoTalento.Text;


                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtIdBancoTalento.Text);
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

                        Genero = int.Parse(Lector.GetString(7));
                        //Condición para obtener el texto a mostrar en el txt de Genero
                        if (Genero == 1)
                        {
                            txtGenero.Text = "Masculino";

                        }
                        else
                        {
                            txtGenero.Text = "Femenino";
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

                }
                //Segunda Busqueda para obtener el Id de los combos
                OdbcDataReader Lector2 = Cont_R.funcBusquedaCombos(txtIdBancoTalento.Text);
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
                    MessageBox.Show("ERROR: El Id del Recluta no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    funcBloqueo();
                    funcLimpieza();
                }

            }//fin ifelse

        }


        private void btnContratar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "" || txtCuentaBanc.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacios.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea Contratar a este Recluta ?", "Contratación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {
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
                    CuentaBanc = Convert.ToInt32(txtCuentaBanc.Text);
                    EstadoEmp = 1;
                    EstadoRecluta = 4;
                    IdRecluta = txtIdBancoTalento.Text;


                    // datos entidad Direccion
                    Residencia = txtResidencia.Text;
                    Zona = txtZona.Text;
                    Municipio = txtMunicipio.Text;
                    Depto = txtDepartamento.Text;

                    //envío de datos hacia capa Controlador

                    Cont_R.funcContratar(PrimerNom, SegundoNom, PrimerAp, SegundoAp, FechaNac, Dpi, Genero,
                    EstadoCivil, Email, Telefono, NumIgss, TipoLicencia, Puesto, CuentaBanc, EstadoEmp,
                    Departamento, EstadoRecluta, IdRecluta, Residencia, Zona, Municipio, Depto);
                    MessageBox.Show("Se ha contratado con Éxito al Empleado", "FORMULARIO CONTRATACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();



                }//fin elseif Pregunta

            }

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
