namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmIngresoReclutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngreso = new System.Windows.Forms.Button();
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.cmbTipoLicencia = new System.Windows.Forms.ComboBox();
            this.lblTipoLicencia = new System.Windows.Forms.Label();
            this.gbxFormacionAcademica = new System.Windows.Forms.GroupBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.cmbNivelEstudios = new System.Windows.Forms.ComboBox();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblNivelEstudios = new System.Windows.Forms.Label();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtZona = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lbZona = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroIgss = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNumeroIgss = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.tbcIngresoRecluta = new System.Windows.Forms.TabControl();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdRecluta = new System.Windows.Forms.TextBox();
            this.lblIngreseIDRecluta = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnReclutas = new System.Windows.Forms.Button();
            this.tbpDatosPersonales.SuspendLayout();
            this.gbxFormacionAcademica.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbcIngresoRecluta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(789, 571);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(215, 62);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Ingresar a Banco de Talento";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosPersonales.Controls.Add(this.cmbTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.lblTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.gbxFormacionAcademica);
            this.tbpDatosPersonales.Controls.Add(this.gbxDomicilio);
            this.tbpDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.tbpDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.tbpDatosPersonales.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Size = new System.Drawing.Size(1233, 449);
            this.tbpDatosPersonales.TabIndex = 3;
            this.tbpDatosPersonales.Text = "Datos Personales";
            // 
            // cmbTipoLicencia
            // 
            this.cmbTipoLicencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoLicencia.FormattingEnabled = true;
            this.cmbTipoLicencia.Location = new System.Drawing.Point(871, 119);
            this.cmbTipoLicencia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoLicencia.Name = "cmbTipoLicencia";
            this.cmbTipoLicencia.Size = new System.Drawing.Size(160, 25);
            this.cmbTipoLicencia.TabIndex = 23;
            // 
            // lblTipoLicencia
            // 
            this.lblTipoLicencia.AutoSize = true;
            this.lblTipoLicencia.Location = new System.Drawing.Point(567, 127);
            this.lblTipoLicencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoLicencia.Name = "lblTipoLicencia";
            this.lblTipoLicencia.Size = new System.Drawing.Size(158, 17);
            this.lblTipoLicencia.TabIndex = 22;
            this.lblTipoLicencia.Text = "Tipo Licencia Conducir";
            // 
            // gbxFormacionAcademica
            // 
            this.gbxFormacionAcademica.Controls.Add(this.txtProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.cmbNivelEstudios);
            this.gbxFormacionAcademica.Controls.Add(this.lblProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblNivelEstudios);
            this.gbxFormacionAcademica.Location = new System.Drawing.Point(572, 224);
            this.gbxFormacionAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFormacionAcademica.Name = "gbxFormacionAcademica";
            this.gbxFormacionAcademica.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFormacionAcademica.Size = new System.Drawing.Size(628, 159);
            this.gbxFormacionAcademica.TabIndex = 21;
            this.gbxFormacionAcademica.TabStop = false;
            this.gbxFormacionAcademica.Text = "Formación Académica";
            // 
            // txtProfesion
            // 
            this.txtProfesion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProfesion.Location = new System.Drawing.Point(233, 110);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(387, 23);
            this.txtProfesion.TabIndex = 13;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // cmbNivelEstudios
            // 
            this.cmbNivelEstudios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNivelEstudios.FormattingEnabled = true;
            this.cmbNivelEstudios.Location = new System.Drawing.Point(233, 54);
            this.cmbNivelEstudios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNivelEstudios.Name = "cmbNivelEstudios";
            this.cmbNivelEstudios.Size = new System.Drawing.Size(227, 25);
            this.cmbNivelEstudios.TabIndex = 7;
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(9, 112);
            this.lblProfesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(68, 17);
            this.lblProfesion.TabIndex = 1;
            this.lblProfesion.Text = "Profesión";
            // 
            // lblNivelEstudios
            // 
            this.lblNivelEstudios.AutoSize = true;
            this.lblNivelEstudios.Location = new System.Drawing.Point(9, 54);
            this.lblNivelEstudios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivelEstudios.Name = "lblNivelEstudios";
            this.lblNivelEstudios.Size = new System.Drawing.Size(121, 17);
            this.lblNivelEstudios.TabIndex = 0;
            this.lblNivelEstudios.Text = "Nivel de Estudios";
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.txtTelefono);
            this.gbxDomicilio.Controls.Add(this.txtZona);
            this.gbxDomicilio.Controls.Add(this.lblCorreoElectronico);
            this.gbxDomicilio.Controls.Add(this.lblDepartamento);
            this.gbxDomicilio.Controls.Add(this.txtCorreoElectronico);
            this.gbxDomicilio.Controls.Add(this.txtMunicipio);
            this.gbxDomicilio.Controls.Add(this.lbZona);
            this.gbxDomicilio.Controls.Add(this.lblMunicipio);
            this.gbxDomicilio.Controls.Add(this.txtDepartamento);
            this.gbxDomicilio.Controls.Add(this.lblResidencia);
            this.gbxDomicilio.Controls.Add(this.txtResidencia);
            this.gbxDomicilio.Controls.Add(this.lblTelefono);
            this.gbxDomicilio.Location = new System.Drawing.Point(11, 21);
            this.gbxDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDomicilio.Size = new System.Drawing.Size(516, 362);
            this.gbxDomicilio.TabIndex = 20;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono.Location = new System.Drawing.Point(249, 304);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 23);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtZona
            // 
            this.txtZona.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtZona.Location = new System.Drawing.Point(249, 85);
            this.txtZona.Margin = new System.Windows.Forms.Padding(4);
            this.txtZona.Name = "txtZona";
            this.txtZona.Size = new System.Drawing.Size(243, 23);
            this.txtZona.TabIndex = 8;
            this.txtZona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(9, 254);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(132, 17);
            this.lblCorreoElectronico.TabIndex = 22;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(9, 203);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(99, 17);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(249, 245);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(243, 23);
            this.txtCorreoElectronico.TabIndex = 11;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMunicipio.Location = new System.Drawing.Point(249, 138);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(243, 23);
            this.txtMunicipio.TabIndex = 9;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lbZona
            // 
            this.lbZona.AutoSize = true;
            this.lbZona.Location = new System.Drawing.Point(11, 92);
            this.lbZona.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbZona.Name = "lbZona";
            this.lbZona.Size = new System.Drawing.Size(116, 17);
            this.lbZona.TabIndex = 1;
            this.lbZona.Text = "Número de Zona";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(9, 146);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(72, 17);
            this.lblMunicipio.TabIndex = 4;
            this.lblMunicipio.Text = "Municipio";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDepartamento.Location = new System.Drawing.Point(249, 194);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(243, 23);
            this.txtDepartamento.TabIndex = 10;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(9, 42);
            this.lblResidencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(133, 17);
            this.lblResidencia.TabIndex = 2;
            this.lblResidencia.Text = "Número Residencia";
            // 
            // txtResidencia
            // 
            this.txtResidencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResidencia.Location = new System.Drawing.Point(249, 33);
            this.txtResidencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(243, 23);
            this.txtResidencia.TabIndex = 7;
            this.txtResidencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 313);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(567, 53);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 17);
            this.lblEstadoCivil.TabIndex = 3;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(868, 53);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(160, 25);
            this.cmbEstadoCivil.TabIndex = 5;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosGenerales.Controls.Add(this.pnlPuesto);
            this.tbpDatosGenerales.Controls.Add(this.gbxSexo);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(1233, 449);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbPuesto);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Location = new System.Drawing.Point(883, 66);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(297, 187);
            this.pnlPuesto.TabIndex = 21;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(12, 18);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(124, 17);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto que Aplica";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(15, 49);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(216, 25);
            this.cmbPuesto.TabIndex = 14;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(15, 105);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(173, 17);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento que Aplica";
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(15, 133);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(216, 25);
            this.cmbDepartamentoTrabajo.TabIndex = 9;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFemenino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(617, 94);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSexo.Size = new System.Drawing.Size(232, 148);
            this.gbxSexo.TabIndex = 17;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(15, 95);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(90, 21);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            this.rbtnFemenino.CheckedChanged += new System.EventHandler(this.rbtnFemenino_CheckedChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(15, 42);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(90, 21);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.dtpFechaNacimiento);
            this.pnlDatosGenerales.Controls.Add(this.txtNumeroIgss);
            this.pnlDatosGenerales.Controls.Add(this.lblDpi);
            this.pnlDatosGenerales.Controls.Add(this.lblFechaNacimiento);
            this.pnlDatosGenerales.Controls.Add(this.txtDpi);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblNumeroIgss);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Location = new System.Drawing.Point(23, 25);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(556, 407);
            this.pnlDatosGenerales.TabIndex = 15;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(79, 370);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(413, 23);
            this.dtpFechaNacimiento.TabIndex = 24;
            // 
            // txtNumeroIgss
            // 
            this.txtNumeroIgss.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumeroIgss.Location = new System.Drawing.Point(276, 282);
            this.txtNumeroIgss.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroIgss.Name = "txtNumeroIgss";
            this.txtNumeroIgss.Size = new System.Drawing.Size(171, 23);
            this.txtNumeroIgss.TabIndex = 6;
            this.txtNumeroIgss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.Location = new System.Drawing.Point(20, 230);
            this.lblDpi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(30, 17);
            this.lblDpi.TabIndex = 22;
            this.lblDpi.Text = "DPI";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(128, 335);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(143, 17);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtDpi
            // 
            this.txtDpi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDpi.Location = new System.Drawing.Point(276, 230);
            this.txtDpi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(171, 23);
            this.txtDpi.TabIndex = 5;
            this.txtDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Location = new System.Drawing.Point(276, 129);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(243, 23);
            this.txtPrimerApellido.TabIndex = 3;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(20, 183);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(125, 17);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNumeroIgss
            // 
            this.lblNumeroIgss.AutoSize = true;
            this.lblNumeroIgss.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIgss.Location = new System.Drawing.Point(20, 282);
            this.lblNumeroIgss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroIgss.Name = "lblNumeroIgss";
            this.lblNumeroIgss.Size = new System.Drawing.Size(114, 17);
            this.lblNumeroIgss.TabIndex = 11;
            this.lblNumeroIgss.Text = "Número del Igss";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoApellido.Location = new System.Drawing.Point(276, 183);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(243, 23);
            this.txtSegundoApellido.TabIndex = 4;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Location = new System.Drawing.Point(276, 23);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(243, 23);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Location = new System.Drawing.Point(276, 79);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(243, 23);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(20, 79);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(122, 17);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(20, 23);
            this.lblPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(109, 17);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(20, 129);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(116, 17);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbcIngresoRecluta
            // 
            this.tbcIngresoRecluta.Controls.Add(this.tbpDatosGenerales);
            this.tbcIngresoRecluta.Controls.Add(this.tbpDatosPersonales);
            this.tbcIngresoRecluta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcIngresoRecluta.Location = new System.Drawing.Point(-4, 84);
            this.tbcIngresoRecluta.Margin = new System.Windows.Forms.Padding(4);
            this.tbcIngresoRecluta.Name = "tbcIngresoRecluta";
            this.tbcIngresoRecluta.SelectedIndex = 0;
            this.tbcIngresoRecluta.Size = new System.Drawing.Size(1241, 479);
            this.tbcIngresoRecluta.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(763, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 43);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdRecluta
            // 
            this.txtIdRecluta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdRecluta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRecluta.Location = new System.Drawing.Point(570, 44);
            this.txtIdRecluta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdRecluta.Name = "txtIdRecluta";
            this.txtIdRecluta.Size = new System.Drawing.Size(157, 23);
            this.txtIdRecluta.TabIndex = 14;
            this.txtIdRecluta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblIngreseIDRecluta
            // 
            this.lblIngreseIDRecluta.AutoSize = true;
            this.lblIngreseIDRecluta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseIDRecluta.Location = new System.Drawing.Point(266, 44);
            this.lblIngreseIDRecluta.Name = "lblIngreseIDRecluta";
            this.lblIngreseIDRecluta.Size = new System.Drawing.Size(170, 17);
            this.lblIngreseIDRecluta.TabIndex = 33;
            this.lblIngreseIDRecluta.Text = "Ingrese el ID del Recluta ";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1010, 571);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(215, 62);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Realizar Modificación";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReclutas
            // 
            this.btnReclutas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclutas.Location = new System.Drawing.Point(5, 565);
            this.btnReclutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReclutas.Name = "btnReclutas";
            this.btnReclutas.Size = new System.Drawing.Size(184, 76);
            this.btnReclutas.TabIndex = 36;
            this.btnReclutas.Text = "Ver Lista Reclutas No Entrevistados";
            this.btnReclutas.UseVisualStyleBackColor = true;
            this.btnReclutas.Click += new System.EventHandler(this.btnReclutas_Click);
            // 
            // frmIngresoReclutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1233, 645);
            this.Controls.Add(this.btnReclutas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdRecluta);
            this.Controls.Add(this.lblIngreseIDRecluta);
            this.Controls.Add(this.tbcIngresoRecluta);
            this.Controls.Add(this.btnIngreso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresoReclutas";
            this.Text = "315 - Ingreso/Modificacion Reclutas";
            this.Load += new System.EventHandler(this.funcfrmIngreso_Load);
            this.tbpDatosPersonales.ResumeLayout(false);
            this.tbpDatosPersonales.PerformLayout();
            this.gbxFormacionAcademica.ResumeLayout(false);
            this.gbxFormacionAcademica.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.tbpDatosGenerales.ResumeLayout(false);
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbcIngresoRecluta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.GroupBox gbxFormacionAcademica;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.ComboBox cmbNivelEstudios;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblNivelEstudios;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lbZona;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNumeroIgss;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNumeroIgss;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TabControl tbcIngresoRecluta;
        private System.Windows.Forms.ComboBox cmbTipoLicencia;
        private System.Windows.Forms.Label lblTipoLicencia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdRecluta;
        private System.Windows.Forms.Label lblIngreseIDRecluta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnReclutas;
    }
}