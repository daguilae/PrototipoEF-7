namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmBajasEmpleado
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
            this.tbcDatosBajaEmpleado = new System.Windows.Forms.TabControl();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblIngreseIdEmpleado = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.tbpDespido_Renuncia = new System.Windows.Forms.TabPage();
            this.rbtnRenuncia = new System.Windows.Forms.RadioButton();
            this.rbtnDespido = new System.Windows.Forms.RadioButton();
            this.lblTipoBaja = new System.Windows.Forms.Label();
            this.gbxPrestacionesDespido = new System.Windows.Forms.GroupBox();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.rtxtCausaDespido = new System.Windows.Forms.RichTextBox();
            this.lblCausaDespido = new System.Windows.Forms.Label();
            this.txtTiempoLaborado = new System.Windows.Forms.TextBox();
            this.txtMontoPrestaciones = new System.Windows.Forms.TextBox();
            this.lblPrestaciones = new System.Windows.Forms.Label();
            this.lblTiempoLaborado = new System.Windows.Forms.Label();
            this.tbcDatosBajaEmpleado.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDespido_Renuncia.SuspendLayout();
            this.gbxPrestacionesDespido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDatosBajaEmpleado
            // 
            this.tbcDatosBajaEmpleado.Controls.Add(this.tbpDatosGenerales);
            this.tbcDatosBajaEmpleado.Controls.Add(this.tbpDespido_Renuncia);
            this.tbcDatosBajaEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDatosBajaEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDatosBajaEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tbcDatosBajaEmpleado.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbcDatosBajaEmpleado.Name = "tbcDatosBajaEmpleado";
            this.tbcDatosBajaEmpleado.SelectedIndex = 0;
            this.tbcDatosBajaEmpleado.Size = new System.Drawing.Size(944, 530);
            this.tbcDatosBajaEmpleado.TabIndex = 22;
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosGenerales.Controls.Add(this.btnEmpleados);
            this.tbpDatosGenerales.Controls.Add(this.lblIngreseIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.txtIdEmpleado);
            this.tbpDatosGenerales.Controls.Add(this.btnBuscar);
            this.tbpDatosGenerales.Controls.Add(this.pnlPuesto);
            this.tbpDatosGenerales.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosGenerales.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(936, 500);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(50, 412);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(173, 68);
            this.btnEmpleados.TabIndex = 33;
            this.btnEmpleados.Text = "Ver Lista Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // lblIngreseIdEmpleado
            // 
            this.lblIngreseIdEmpleado.AutoSize = true;
            this.lblIngreseIdEmpleado.Location = new System.Drawing.Point(185, 99);
            this.lblIngreseIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdEmpleado.Name = "lblIngreseIdEmpleado";
            this.lblIngreseIdEmpleado.Size = new System.Drawing.Size(186, 17);
            this.lblIngreseIdEmpleado.TabIndex = 27;
            this.lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmpleado.Location = new System.Drawing.Point(429, 96);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(184, 23);
            this.txtIdEmpleado.TabIndex = 26;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(646, 90);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.cmbDepartamento);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbPuesto);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Enabled = false;
            this.pnlPuesto.Location = new System.Drawing.Point(597, 190);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(235, 191);
            this.pnlPuesto.TabIndex = 25;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamento.Enabled = false;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(9, 136);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(218, 25);
            this.cmbDepartamento.TabIndex = 30;
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
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuesto.Enabled = false;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(9, 58);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(218, 25);
            this.cmbPuesto.TabIndex = 29;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(4, 96);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(99, 17);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento";
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerApellido);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoApellido);
            this.pnlDatosGenerales.Controls.Add(this.txtPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.txtSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblSegundoNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerNombre);
            this.pnlDatosGenerales.Controls.Add(this.lblPrimerApellido);
            this.pnlDatosGenerales.Enabled = false;
            this.pnlDatosGenerales.Location = new System.Drawing.Point(50, 168);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(492, 226);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(250, 128);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 23);
            this.txtPrimerApellido.TabIndex = 7;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(16, 186);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(125, 17);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(250, 181);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(229, 23);
            this.txtSegundoApellido.TabIndex = 8;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(250, 20);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 23);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(250, 76);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(229, 23);
            this.txtSegundoNombre.TabIndex = 6;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(16, 80);
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
            this.lblPrimerNombre.Location = new System.Drawing.Point(16, 22);
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
            this.lblPrimerApellido.Location = new System.Drawing.Point(16, 131);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(116, 17);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbpDespido_Renuncia
            // 
            this.tbpDespido_Renuncia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDespido_Renuncia.Controls.Add(this.rbtnRenuncia);
            this.tbpDespido_Renuncia.Controls.Add(this.rbtnDespido);
            this.tbpDespido_Renuncia.Controls.Add(this.lblTipoBaja);
            this.tbpDespido_Renuncia.Controls.Add(this.gbxPrestacionesDespido);
            this.tbpDespido_Renuncia.Location = new System.Drawing.Point(4, 26);
            this.tbpDespido_Renuncia.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDespido_Renuncia.Name = "tbpDespido_Renuncia";
            this.tbpDespido_Renuncia.Size = new System.Drawing.Size(936, 500);
            this.tbpDespido_Renuncia.TabIndex = 3;
            this.tbpDespido_Renuncia.Text = "Despidos/Renuncias";
            // 
            // rbtnRenuncia
            // 
            this.rbtnRenuncia.AutoSize = true;
            this.rbtnRenuncia.Enabled = false;
            this.rbtnRenuncia.Location = new System.Drawing.Point(199, 58);
            this.rbtnRenuncia.Name = "rbtnRenuncia";
            this.rbtnRenuncia.Size = new System.Drawing.Size(84, 21);
            this.rbtnRenuncia.TabIndex = 10;
            this.rbtnRenuncia.TabStop = true;
            this.rbtnRenuncia.Text = "Renuncia";
            this.rbtnRenuncia.UseVisualStyleBackColor = true;
            this.rbtnRenuncia.CheckedChanged += new System.EventHandler(this.rbtnRenuncia_CheckedChanged);
            // 
            // rbtnDespido
            // 
            this.rbtnDespido.AutoSize = true;
            this.rbtnDespido.Enabled = false;
            this.rbtnDespido.Location = new System.Drawing.Point(45, 58);
            this.rbtnDespido.Name = "rbtnDespido";
            this.rbtnDespido.Size = new System.Drawing.Size(80, 21);
            this.rbtnDespido.TabIndex = 9;
            this.rbtnDespido.TabStop = true;
            this.rbtnDespido.Text = "Despido";
            this.rbtnDespido.UseVisualStyleBackColor = true;
            this.rbtnDespido.CheckedChanged += new System.EventHandler(this.rbtnDespido_CheckedChanged);
            // 
            // lblTipoBaja
            // 
            this.lblTipoBaja.AutoSize = true;
            this.lblTipoBaja.Location = new System.Drawing.Point(9, 22);
            this.lblTipoBaja.Name = "lblTipoBaja";
            this.lblTipoBaja.Size = new System.Drawing.Size(271, 17);
            this.lblTipoBaja.TabIndex = 8;
            this.lblTipoBaja.Text = "Indique el tipo de Baja que va a Realizar:";
            // 
            // gbxPrestacionesDespido
            // 
            this.gbxPrestacionesDespido.Controls.Add(this.BtnBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.dtpFecha);
            this.gbxPrestacionesDespido.Controls.Add(this.lblFechaBaja);
            this.gbxPrestacionesDespido.Controls.Add(this.rtxtCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.lblCausaDespido);
            this.gbxPrestacionesDespido.Controls.Add(this.txtTiempoLaborado);
            this.gbxPrestacionesDespido.Controls.Add(this.txtMontoPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblPrestaciones);
            this.gbxPrestacionesDespido.Controls.Add(this.lblTiempoLaborado);
            this.gbxPrestacionesDespido.Enabled = false;
            this.gbxPrestacionesDespido.Location = new System.Drawing.Point(13, 113);
            this.gbxPrestacionesDespido.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Name = "gbxPrestacionesDespido";
            this.gbxPrestacionesDespido.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPrestacionesDespido.Size = new System.Drawing.Size(914, 380);
            this.gbxPrestacionesDespido.TabIndex = 7;
            this.gbxPrestacionesDespido.TabStop = false;
            this.gbxPrestacionesDespido.Text = "Prestaciones";
            // 
            // BtnBaja
            // 
            this.BtnBaja.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaja.Location = new System.Drawing.Point(698, 26);
            this.BtnBaja.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(194, 50);
            this.BtnBaja.TabIndex = 22;
            this.BtnBaja.Text = "Realizar Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dtpFecha.Location = new System.Drawing.Point(294, 122);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(429, 23);
            this.dtpFecha.TabIndex = 24;
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.Location = new System.Drawing.Point(10, 122);
            this.lblFechaBaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(97, 17);
            this.lblFechaBaja.TabIndex = 23;
            this.lblFechaBaja.Text = "Fecha de Baja";
            // 
            // rtxtCausaDespido
            // 
            this.rtxtCausaDespido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtCausaDespido.Location = new System.Drawing.Point(8, 182);
            this.rtxtCausaDespido.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtCausaDespido.Name = "rtxtCausaDespido";
            this.rtxtCausaDespido.Size = new System.Drawing.Size(884, 190);
            this.rtxtCausaDespido.TabIndex = 12;
            this.rtxtCausaDespido.Text = "";
            // 
            // lblCausaDespido
            // 
            this.lblCausaDespido.AutoSize = true;
            this.lblCausaDespido.Location = new System.Drawing.Point(9, 158);
            this.lblCausaDespido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCausaDespido.Name = "lblCausaDespido";
            this.lblCausaDespido.Size = new System.Drawing.Size(105, 17);
            this.lblCausaDespido.TabIndex = 11;
            this.lblCausaDespido.Text = "Causa Despido";
            // 
            // txtTiempoLaborado
            // 
            this.txtTiempoLaborado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTiempoLaborado.Location = new System.Drawing.Point(294, 71);
            this.txtTiempoLaborado.Margin = new System.Windows.Forms.Padding(4);
            this.txtTiempoLaborado.Name = "txtTiempoLaborado";
            this.txtTiempoLaborado.Size = new System.Drawing.Size(300, 23);
            this.txtTiempoLaborado.TabIndex = 9;
            // 
            // txtMontoPrestaciones
            // 
            this.txtMontoPrestaciones.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMontoPrestaciones.Location = new System.Drawing.Point(294, 27);
            this.txtMontoPrestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPrestaciones.Name = "txtMontoPrestaciones";
            this.txtMontoPrestaciones.Size = new System.Drawing.Size(200, 23);
            this.txtMontoPrestaciones.TabIndex = 7;
            // 
            // lblPrestaciones
            // 
            this.lblPrestaciones.AutoSize = true;
            this.lblPrestaciones.Location = new System.Drawing.Point(9, 34);
            this.lblPrestaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestaciones.Name = "lblPrestaciones";
            this.lblPrestaciones.Size = new System.Drawing.Size(188, 17);
            this.lblPrestaciones.TabIndex = 0;
            this.lblPrestaciones.Text = "Monto Prestaciones  a Pagar";
            // 
            // lblTiempoLaborado
            // 
            this.lblTiempoLaborado.AutoSize = true;
            this.lblTiempoLaborado.Location = new System.Drawing.Point(9, 78);
            this.lblTiempoLaborado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoLaborado.Name = "lblTiempoLaborado";
            this.lblTiempoLaborado.Size = new System.Drawing.Size(218, 17);
            this.lblTiempoLaborado.TabIndex = 2;
            this.lblTiempoLaborado.Text = "Tiempo Laborado en la Empresa";
            // 
            // frmBajasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.tbcDatosBajaEmpleado);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBajasEmpleado";
            this.Text = "318 - Bajas Del Empleado";
            this.Load += new System.EventHandler(this.frmBajasEmpleado_Load);
            this.tbcDatosBajaEmpleado.ResumeLayout(false);
            this.tbpDatosGenerales.ResumeLayout(false);
            this.tbpDatosGenerales.PerformLayout();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDespido_Renuncia.ResumeLayout(false);
            this.tbpDespido_Renuncia.PerformLayout();
            this.gbxPrestacionesDespido.ResumeLayout(false);
            this.gbxPrestacionesDespido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDatosBajaEmpleado;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblIngreseIdEmpleado;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TabPage tbpDespido_Renuncia;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.GroupBox gbxPrestacionesDespido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.RichTextBox rtxtCausaDespido;
        private System.Windows.Forms.Label lblCausaDespido;
        private System.Windows.Forms.TextBox txtTiempoLaborado;
        private System.Windows.Forms.TextBox txtMontoPrestaciones;
        private System.Windows.Forms.Label lblPrestaciones;
        private System.Windows.Forms.Label lblTiempoLaborado;
        private System.Windows.Forms.RadioButton rbtnRenuncia;
        private System.Windows.Forms.RadioButton rbtnDespido;
        private System.Windows.Forms.Label lblTipoBaja;
        private System.Windows.Forms.Button btnEmpleados;
    }
}