namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmContratacion
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbcContratar = new System.Windows.Forms.TabControl();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.txtIdBancoTalento = new System.Windows.Forms.TextBox();
            this.lblIngreseIDRecluta = new System.Windows.Forms.Label();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
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
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.txtCuentaBanc = new System.Windows.Forms.TextBox();
            this.lblCuentaBanc = new System.Windows.Forms.Label();
            this.cmbTipoLicencia = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
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
            this.lblTipoLicencia = new System.Windows.Forms.Label();
            this.gbxFormacionAcademica = new System.Windows.Forms.GroupBox();
            this.cmbNivelEstudios = new System.Windows.Forms.ComboBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblNivelEstudios = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.btnContratar = new System.Windows.Forms.Button();
            this.btnBancoTalento = new System.Windows.Forms.Button();
            this.tbcContratar.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDatosPersonales.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxFormacionAcademica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(909, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 37);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbcContratar
            // 
            this.tbcContratar.Controls.Add(this.tbpDatosGenerales);
            this.tbcContratar.Controls.Add(this.tbpDatosPersonales);
            this.tbcContratar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcContratar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcContratar.Location = new System.Drawing.Point(0, 0);
            this.tbcContratar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbcContratar.Name = "tbcContratar";
            this.tbcContratar.SelectedIndex = 0;
            this.tbcContratar.Size = new System.Drawing.Size(1243, 525);
            this.tbcContratar.TabIndex = 19;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosGenerales.Controls.Add(this.btnBuscar);
            this.tbpDatosGenerales.Controls.Add(this.txtIdBancoTalento);
            this.tbpDatosGenerales.Controls.Add(this.lblIngreseIDRecluta);
            this.tbpDatosGenerales.Controls.Add(this.pnlPuesto);
            this.tbpDatosGenerales.Controls.Add(this.gbxSexo);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(1235, 495);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            // 
            // txtIdBancoTalento
            // 
            this.txtIdBancoTalento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdBancoTalento.Location = new System.Drawing.Point(676, 15);
            this.txtIdBancoTalento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBancoTalento.Name = "txtIdBancoTalento";
            this.txtIdBancoTalento.Size = new System.Drawing.Size(196, 23);
            this.txtIdBancoTalento.TabIndex = 26;
            this.txtIdBancoTalento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblIngreseIDRecluta
            // 
            this.lblIngreseIDRecluta.AutoSize = true;
            this.lblIngreseIDRecluta.Location = new System.Drawing.Point(159, 18);
            this.lblIngreseIDRecluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIDRecluta.Name = "lblIngreseIDRecluta";
            this.lblIngreseIDRecluta.Size = new System.Drawing.Size(316, 17);
            this.lblIngreseIDRecluta.TabIndex = 27;
            this.lblIngreseIDRecluta.Text = "Ingrese el ID del Recluta en el Banco de Talento";
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.cmbPuesto);
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Enabled = false;
            this.pnlPuesto.Location = new System.Drawing.Point(720, 199);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(251, 176);
            this.pnlPuesto.TabIndex = 25;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(9, 43);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(227, 25);
            this.cmbPuesto.TabIndex = 37;
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(9, 127);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(227, 25);
            this.cmbDepartamentoTrabajo.TabIndex = 36;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(4, 15);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(50, 17);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(4, 95);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(99, 17);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.txtGenero);
            this.gbxSexo.Enabled = false;
            this.gbxSexo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(720, 91);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbxSexo.Size = new System.Drawing.Size(251, 84);
            this.gbxSexo.TabIndex = 23;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(9, 34);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(227, 23);
            this.txtGenero.TabIndex = 1;
            this.txtGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
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
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(56, 66);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(556, 408);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(63, 366);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(413, 23);
            this.dtpFechaNacimiento.TabIndex = 24;
            // 
            // txtNumeroIgss
            // 
            this.txtNumeroIgss.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumeroIgss.Enabled = false;
            this.txtNumeroIgss.Location = new System.Drawing.Point(267, 277);
            this.txtNumeroIgss.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumeroIgss.Name = "txtNumeroIgss";
            this.txtNumeroIgss.Size = new System.Drawing.Size(171, 23);
            this.txtNumeroIgss.TabIndex = 23;
            this.txtNumeroIgss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.Location = new System.Drawing.Point(17, 230);
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
            this.lblFechaNacimiento.Location = new System.Drawing.Point(143, 330);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(143, 17);
            this.lblFechaNacimiento.TabIndex = 21;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtDpi
            // 
            this.txtDpi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDpi.Enabled = false;
            this.txtDpi.Location = new System.Drawing.Point(267, 226);
            this.txtDpi.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(171, 23);
            this.txtDpi.TabIndex = 12;
            this.txtDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(267, 126);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(244, 23);
            this.txtPrimerApellido.TabIndex = 7;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(17, 183);
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
            this.lblNumeroIgss.Location = new System.Drawing.Point(17, 282);
            this.lblNumeroIgss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroIgss.Name = "lblNumeroIgss";
            this.lblNumeroIgss.Size = new System.Drawing.Size(114, 17);
            this.lblNumeroIgss.TabIndex = 11;
            this.lblNumeroIgss.Text = "Número del Igss";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(267, 178);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(244, 23);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(267, 20);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(244, 23);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(267, 75);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(244, 23);
            this.txtSegundoNombre.TabIndex = 6;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(17, 79);
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
            this.lblPrimerNombre.Location = new System.Drawing.Point(17, 22);
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
            this.lblPrimerApellido.Location = new System.Drawing.Point(17, 129);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(116, 17);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosPersonales.Controls.Add(this.txtCuentaBanc);
            this.tbpDatosPersonales.Controls.Add(this.lblCuentaBanc);
            this.tbpDatosPersonales.Controls.Add(this.cmbTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.tbpDatosPersonales.Controls.Add(this.gbxDomicilio);
            this.tbpDatosPersonales.Controls.Add(this.lblTipoLicencia);
            this.tbpDatosPersonales.Controls.Add(this.gbxFormacionAcademica);
            this.tbpDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.tbpDatosPersonales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosPersonales.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosPersonales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Size = new System.Drawing.Size(1235, 495);
            this.tbpDatosPersonales.TabIndex = 3;
            this.tbpDatosPersonales.Text = "Datos Personales";
            // 
            // txtCuentaBanc
            // 
            this.txtCuentaBanc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCuentaBanc.Enabled = false;
            this.txtCuentaBanc.Location = new System.Drawing.Point(916, 181);
            this.txtCuentaBanc.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuentaBanc.Name = "txtCuentaBanc";
            this.txtCuentaBanc.Size = new System.Drawing.Size(287, 23);
            this.txtCuentaBanc.TabIndex = 36;
            this.txtCuentaBanc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblCuentaBanc
            // 
            this.lblCuentaBanc.AutoSize = true;
            this.lblCuentaBanc.Location = new System.Drawing.Point(593, 185);
            this.lblCuentaBanc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentaBanc.Name = "lblCuentaBanc";
            this.lblCuentaBanc.Size = new System.Drawing.Size(168, 17);
            this.lblCuentaBanc.TabIndex = 35;
            this.lblCuentaBanc.Text = "Número Cuenta Bancaria";
            // 
            // cmbTipoLicencia
            // 
            this.cmbTipoLicencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoLicencia.Enabled = false;
            this.cmbTipoLicencia.FormattingEnabled = true;
            this.cmbTipoLicencia.Location = new System.Drawing.Point(989, 116);
            this.cmbTipoLicencia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoLicencia.Name = "cmbTipoLicencia";
            this.cmbTipoLicencia.Size = new System.Drawing.Size(213, 25);
            this.cmbTipoLicencia.TabIndex = 34;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEstadoCivil.Enabled = false;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(989, 49);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(211, 25);
            this.cmbEstadoCivil.TabIndex = 33;
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
            this.gbxDomicilio.Enabled = false;
            this.gbxDomicilio.Location = new System.Drawing.Point(25, 43);
            this.gbxDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDomicilio.Size = new System.Drawing.Size(516, 362);
            this.gbxDomicilio.TabIndex = 32;
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
            // lblTipoLicencia
            // 
            this.lblTipoLicencia.AutoSize = true;
            this.lblTipoLicencia.Location = new System.Drawing.Point(593, 116);
            this.lblTipoLicencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoLicencia.Name = "lblTipoLicencia";
            this.lblTipoLicencia.Size = new System.Drawing.Size(158, 17);
            this.lblTipoLicencia.TabIndex = 29;
            this.lblTipoLicencia.Text = "Tipo Licencia Conducir";
            // 
            // gbxFormacionAcademica
            // 
            this.gbxFormacionAcademica.Controls.Add(this.cmbNivelEstudios);
            this.gbxFormacionAcademica.Controls.Add(this.txtProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblNivelEstudios);
            this.gbxFormacionAcademica.Enabled = false;
            this.gbxFormacionAcademica.Location = new System.Drawing.Point(585, 230);
            this.gbxFormacionAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFormacionAcademica.Name = "gbxFormacionAcademica";
            this.gbxFormacionAcademica.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFormacionAcademica.Size = new System.Drawing.Size(627, 159);
            this.gbxFormacionAcademica.TabIndex = 27;
            this.gbxFormacionAcademica.TabStop = false;
            this.gbxFormacionAcademica.Text = "Formación Académica";
            // 
            // cmbNivelEstudios
            // 
            this.cmbNivelEstudios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNivelEstudios.FormattingEnabled = true;
            this.cmbNivelEstudios.Location = new System.Drawing.Point(232, 50);
            this.cmbNivelEstudios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNivelEstudios.Name = "cmbNivelEstudios";
            this.cmbNivelEstudios.Size = new System.Drawing.Size(385, 25);
            this.cmbNivelEstudios.TabIndex = 14;
            // 
            // txtProfesion
            // 
            this.txtProfesion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Location = new System.Drawing.Point(232, 110);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(385, 23);
            this.txtProfesion.TabIndex = 13;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Location = new System.Drawing.Point(8, 112);
            this.lblProfesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(68, 17);
            this.lblProfesion.TabIndex = 1;
            this.lblProfesion.Text = "Profesión";
            // 
            // lblNivelEstudios
            // 
            this.lblNivelEstudios.AutoSize = true;
            this.lblNivelEstudios.Location = new System.Drawing.Point(8, 54);
            this.lblNivelEstudios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivelEstudios.Name = "lblNivelEstudios";
            this.lblNivelEstudios.Size = new System.Drawing.Size(121, 17);
            this.lblNivelEstudios.TabIndex = 0;
            this.lblNivelEstudios.Text = "Nivel de Estudios";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(593, 55);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(86, 17);
            this.lblEstadoCivil.TabIndex = 22;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // btnContratar
            // 
            this.btnContratar.Enabled = false;
            this.btnContratar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratar.Location = new System.Drawing.Point(1015, 540);
            this.btnContratar.Margin = new System.Windows.Forms.Padding(4);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(215, 62);
            this.btnContratar.TabIndex = 20;
            this.btnContratar.Text = "Contratar";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // btnBancoTalento
            // 
            this.btnBancoTalento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBancoTalento.Location = new System.Drawing.Point(4, 540);
            this.btnBancoTalento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBancoTalento.Name = "btnBancoTalento";
            this.btnBancoTalento.Size = new System.Drawing.Size(173, 68);
            this.btnBancoTalento.TabIndex = 36;
            this.btnBancoTalento.Text = "Ver Lista Banco Talento";
            this.btnBancoTalento.UseVisualStyleBackColor = true;
            this.btnBancoTalento.Click += new System.EventHandler(this.btnBancoTalento_Click);
            // 
            // frmContratacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1243, 619);
            this.Controls.Add(this.btnBancoTalento);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.tbcContratar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContratacion";
            this.Text = "319 - Contratacion";
            this.Load += new System.EventHandler(this.funcfrmContratacion_Load);
            this.tbcContratar.ResumeLayout(false);
            this.tbpDatosGenerales.ResumeLayout(false);
            this.tbpDatosGenerales.PerformLayout();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDatosPersonales.ResumeLayout(false);
            this.tbpDatosPersonales.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxFormacionAcademica.ResumeLayout(false);
            this.gbxFormacionAcademica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tbcContratar;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.TextBox txtIdBancoTalento;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.TextBox txtGenero;
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
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblIngreseIDRecluta;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.GroupBox gbxFormacionAcademica;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblNivelEstudios;
        private System.Windows.Forms.Label lblTipoLicencia;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtZona;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lbZona;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbTipoLicencia;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbNivelEstudios;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.TextBox txtCuentaBanc;
        private System.Windows.Forms.Label lblCuentaBanc;
        private System.Windows.Forms.Button btnBancoTalento;
    }
}