namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmEntrevista
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
            this.tbcEntrevista = new System.Windows.Forms.TabControl();
            this.tbpDatosRecluta = new System.Windows.Forms.TabPage();
            this.btnReclutas = new System.Windows.Forms.Button();
            this.lblIngreseIdRecluta = new System.Windows.Forms.Label();
            this.txtIdBancoTalento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlPuesto = new System.Windows.Forms.Panel();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuestoTrabajo = new System.Windows.Forms.ComboBox();
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
            this.tbpDatosEntrevista = new System.Windows.Forms.TabPage();
            this.gbxDatosEntrevista = new System.Windows.Forms.GroupBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rbtnSegOpcion = new System.Windows.Forms.RadioButton();
            this.rbtnPrimeraOp = new System.Windows.Forms.RadioButton();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnReprobado = new System.Windows.Forms.RadioButton();
            this.rbtnAprobado = new System.Windows.Forms.RadioButton();
            this.btnIngresoEntrevista = new System.Windows.Forms.Button();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbTipoEntrevista = new System.Windows.Forms.ComboBox();
            this.lblResultadoEntrevista = new System.Windows.Forms.Label();
            this.lblTipoEntrevista = new System.Windows.Forms.Label();
            this.tbcEntrevista.SuspendLayout();
            this.tbpDatosRecluta.SuspendLayout();
            this.pnlPuesto.SuspendLayout();
            this.pnlDatosGenerales.SuspendLayout();
            this.tbpDatosEntrevista.SuspendLayout();
            this.gbxDatosEntrevista.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEntrevista
            // 
            this.tbcEntrevista.Controls.Add(this.tbpDatosRecluta);
            this.tbcEntrevista.Controls.Add(this.tbpDatosEntrevista);
            this.tbcEntrevista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEntrevista.Location = new System.Drawing.Point(0, 0);
            this.tbcEntrevista.Name = "tbcEntrevista";
            this.tbcEntrevista.SelectedIndex = 0;
            this.tbcEntrevista.Size = new System.Drawing.Size(1018, 436);
            this.tbcEntrevista.TabIndex = 0;
            // 
            // tbpDatosRecluta
            // 
            this.tbpDatosRecluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosRecluta.Controls.Add(this.btnReclutas);
            this.tbpDatosRecluta.Controls.Add(this.lblIngreseIdRecluta);
            this.tbpDatosRecluta.Controls.Add(this.txtIdBancoTalento);
            this.tbpDatosRecluta.Controls.Add(this.btnBuscar);
            this.tbpDatosRecluta.Controls.Add(this.pnlPuesto);
            this.tbpDatosRecluta.Controls.Add(this.pnlDatosGenerales);
            this.tbpDatosRecluta.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosRecluta.Name = "tbpDatosRecluta";
            this.tbpDatosRecluta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosRecluta.Size = new System.Drawing.Size(1010, 406);
            this.tbpDatosRecluta.TabIndex = 0;
            this.tbpDatosRecluta.Text = "Datos Recluta";
            // 
            // btnReclutas
            // 
            this.btnReclutas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclutas.Location = new System.Drawing.Point(807, 298);
            this.btnReclutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReclutas.Name = "btnReclutas";
            this.btnReclutas.Size = new System.Drawing.Size(184, 76);
            this.btnReclutas.TabIndex = 35;
            this.btnReclutas.Text = "Ver Lista Reclutas No Entrevistados";
            this.btnReclutas.UseVisualStyleBackColor = true;
            this.btnReclutas.Click += new System.EventHandler(this.btnReclutas_Click);
            // 
            // lblIngreseIdRecluta
            // 
            this.lblIngreseIdRecluta.AutoSize = true;
            this.lblIngreseIdRecluta.Location = new System.Drawing.Point(223, 38);
            this.lblIngreseIdRecluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdRecluta.Name = "lblIngreseIdRecluta";
            this.lblIngreseIdRecluta.Size = new System.Drawing.Size(166, 17);
            this.lblIngreseIdRecluta.TabIndex = 34;
            this.lblIngreseIdRecluta.Text = "Ingrese el ID del Recluta";
            // 
            // txtIdBancoTalento
            // 
            this.txtIdBancoTalento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdBancoTalento.Location = new System.Drawing.Point(467, 35);
            this.txtIdBancoTalento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBancoTalento.Name = "txtIdBancoTalento";
            this.txtIdBancoTalento.Size = new System.Drawing.Size(184, 23);
            this.txtIdBancoTalento.TabIndex = 33;
            this.txtIdBancoTalento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(684, 29);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlPuesto
            // 
            this.pnlPuesto.Controls.Add(this.cmbDepartamentoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblPuesto);
            this.pnlPuesto.Controls.Add(this.cmbPuestoTrabajo);
            this.pnlPuesto.Controls.Add(this.lblDepartamentoTrabajo);
            this.pnlPuesto.Enabled = false;
            this.pnlPuesto.Location = new System.Drawing.Point(469, 131);
            this.pnlPuesto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlPuesto.Name = "pnlPuesto";
            this.pnlPuesto.Size = new System.Drawing.Size(235, 202);
            this.pnlPuesto.TabIndex = 32;
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.Enabled = false;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(8, 136);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(218, 25);
            this.cmbDepartamentoTrabajo.TabIndex = 35;
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
            // cmbPuestoTrabajo
            // 
            this.cmbPuestoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoTrabajo.Enabled = false;
            this.cmbPuestoTrabajo.FormattingEnabled = true;
            this.cmbPuestoTrabajo.Location = new System.Drawing.Point(9, 58);
            this.cmbPuestoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo";
            this.cmbPuestoTrabajo.Size = new System.Drawing.Size(218, 25);
            this.cmbPuestoTrabajo.TabIndex = 29;
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
            this.pnlDatosGenerales.Location = new System.Drawing.Point(9, 131);
            this.pnlDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(441, 202);
            this.pnlDatosGenerales.TabIndex = 31;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(197, 118);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 23);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(16, 167);
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
            this.txtSegundoApellido.Location = new System.Drawing.Point(197, 164);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(229, 23);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(197, 22);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 23);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(197, 69);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(229, 23);
            this.txtSegundoNombre.TabIndex = 6;
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(16, 71);
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
            this.lblPrimerApellido.Location = new System.Drawing.Point(16, 119);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(116, 17);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido ";
            // 
            // tbpDatosEntrevista
            // 
            this.tbpDatosEntrevista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosEntrevista.Controls.Add(this.gbxDatosEntrevista);
            this.tbpDatosEntrevista.Location = new System.Drawing.Point(4, 26);
            this.tbpDatosEntrevista.Name = "tbpDatosEntrevista";
            this.tbpDatosEntrevista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosEntrevista.Size = new System.Drawing.Size(1010, 406);
            this.tbpDatosEntrevista.TabIndex = 1;
            this.tbpDatosEntrevista.Text = "Datos Entrevista";
            // 
            // gbxDatosEntrevista
            // 
            this.gbxDatosEntrevista.Controls.Add(this.pnlOpciones);
            this.gbxDatosEntrevista.Controls.Add(this.txtIdEmpleado);
            this.gbxDatosEntrevista.Controls.Add(this.label1);
            this.gbxDatosEntrevista.Controls.Add(this.rbtnReprobado);
            this.gbxDatosEntrevista.Controls.Add(this.rbtnAprobado);
            this.gbxDatosEntrevista.Controls.Add(this.btnIngresoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.rtxtComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.lblComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.cmbTipoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblResultadoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblTipoEntrevista);
            this.gbxDatosEntrevista.Enabled = false;
            this.gbxDatosEntrevista.Location = new System.Drawing.Point(8, 23);
            this.gbxDatosEntrevista.Name = "gbxDatosEntrevista";
            this.gbxDatosEntrevista.Size = new System.Drawing.Size(994, 367);
            this.gbxDatosEntrevista.TabIndex = 10;
            this.gbxDatosEntrevista.TabStop = false;
            this.gbxDatosEntrevista.Text = "Datos de Entrevista";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.rbtnSegOpcion);
            this.pnlOpciones.Controls.Add(this.rbtnPrimeraOp);
            this.pnlOpciones.Enabled = false;
            this.pnlOpciones.Location = new System.Drawing.Point(544, 88);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(259, 80);
            this.pnlOpciones.TabIndex = 13;
            // 
            // rbtnSegOpcion
            // 
            this.rbtnSegOpcion.AutoSize = true;
            this.rbtnSegOpcion.Location = new System.Drawing.Point(3, 47);
            this.rbtnSegOpcion.Name = "rbtnSegOpcion";
            this.rbtnSegOpcion.Size = new System.Drawing.Size(209, 21);
            this.rbtnSegOpcion.TabIndex = 1;
            this.rbtnSegOpcion.TabStop = true;
            this.rbtnSegOpcion.Text = "Segunda Opción a Contratar";
            this.rbtnSegOpcion.UseVisualStyleBackColor = true;
            this.rbtnSegOpcion.CheckedChanged += new System.EventHandler(this.rbtnSegOpcion_CheckedChanged);
            // 
            // rbtnPrimeraOp
            // 
            this.rbtnPrimeraOp.AutoSize = true;
            this.rbtnPrimeraOp.Location = new System.Drawing.Point(4, 12);
            this.rbtnPrimeraOp.Name = "rbtnPrimeraOp";
            this.rbtnPrimeraOp.Size = new System.Drawing.Size(204, 21);
            this.rbtnPrimeraOp.TabIndex = 0;
            this.rbtnPrimeraOp.TabStop = true;
            this.rbtnPrimeraOp.Text = "Primera Opción a Contratar";
            this.rbtnPrimeraOp.UseVisualStyleBackColor = true;
            this.rbtnPrimeraOp.CheckedChanged += new System.EventHandler(this.rbtnPrimeraOp_CheckedChanged);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmpleado.Location = new System.Drawing.Point(544, 24);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(125, 23);
            this.txtIdEmpleado.TabIndex = 12;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrese su Id";
            // 
            // rbtnReprobado
            // 
            this.rbtnReprobado.AutoSize = true;
            this.rbtnReprobado.Location = new System.Drawing.Point(391, 88);
            this.rbtnReprobado.Name = "rbtnReprobado";
            this.rbtnReprobado.Size = new System.Drawing.Size(98, 21);
            this.rbtnReprobado.TabIndex = 10;
            this.rbtnReprobado.TabStop = true;
            this.rbtnReprobado.Text = "Reprobado";
            this.rbtnReprobado.UseVisualStyleBackColor = true;
            this.rbtnReprobado.CheckedChanged += new System.EventHandler(this.rbtnReprobado_CheckedChanged);
            // 
            // rbtnAprobado
            // 
            this.rbtnAprobado.AutoSize = true;
            this.rbtnAprobado.Location = new System.Drawing.Point(248, 88);
            this.rbtnAprobado.Name = "rbtnAprobado";
            this.rbtnAprobado.Size = new System.Drawing.Size(92, 21);
            this.rbtnAprobado.TabIndex = 9;
            this.rbtnAprobado.TabStop = true;
            this.rbtnAprobado.Text = "Aprobado";
            this.rbtnAprobado.UseVisualStyleBackColor = true;
            this.rbtnAprobado.CheckedChanged += new System.EventHandler(this.rbtnAprobado_CheckedChanged);
            // 
            // btnIngresoEntrevista
            // 
            this.btnIngresoEntrevista.Location = new System.Drawing.Point(817, 21);
            this.btnIngresoEntrevista.Name = "btnIngresoEntrevista";
            this.btnIngresoEntrevista.Size = new System.Drawing.Size(171, 57);
            this.btnIngresoEntrevista.TabIndex = 8;
            this.btnIngresoEntrevista.Text = "Ingresar Entrevista";
            this.btnIngresoEntrevista.UseVisualStyleBackColor = true;
            this.btnIngresoEntrevista.Click += new System.EventHandler(this.btnIngresoEntrevista_Click);
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtComentarios.Location = new System.Drawing.Point(6, 174);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(982, 183);
            this.rtxtComentarios.TabIndex = 2;
            this.rtxtComentarios.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(6, 139);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(206, 17);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios del Entrevistador";
            // 
            // cmbTipoEntrevista
            // 
            this.cmbTipoEntrevista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoEntrevista.FormattingEnabled = true;
            this.cmbTipoEntrevista.Location = new System.Drawing.Point(248, 21);
            this.cmbTipoEntrevista.Name = "cmbTipoEntrevista";
            this.cmbTipoEntrevista.Size = new System.Drawing.Size(121, 25);
            this.cmbTipoEntrevista.TabIndex = 7;
            // 
            // lblResultadoEntrevista
            // 
            this.lblResultadoEntrevista.AutoSize = true;
            this.lblResultadoEntrevista.Location = new System.Drawing.Point(6, 86);
            this.lblResultadoEntrevista.Name = "lblResultadoEntrevista";
            this.lblResultadoEntrevista.Size = new System.Drawing.Size(174, 17);
            this.lblResultadoEntrevista.TabIndex = 4;
            this.lblResultadoEntrevista.Text = "Resultado de la Entrevista";
            // 
            // lblTipoEntrevista
            // 
            this.lblTipoEntrevista.AutoSize = true;
            this.lblTipoEntrevista.Location = new System.Drawing.Point(6, 34);
            this.lblTipoEntrevista.Name = "lblTipoEntrevista";
            this.lblTipoEntrevista.Size = new System.Drawing.Size(105, 17);
            this.lblTipoEntrevista.TabIndex = 6;
            this.lblTipoEntrevista.Text = "Tipo Entrevista";
            // 
            // frmEntrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1018, 436);
            this.Controls.Add(this.tbcEntrevista);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrevista";
            this.Text = "320 - Entrevista";
            this.Load += new System.EventHandler(this.frmEntrevista_Load);
            this.tbcEntrevista.ResumeLayout(false);
            this.tbpDatosRecluta.ResumeLayout(false);
            this.tbpDatosRecluta.PerformLayout();
            this.pnlPuesto.ResumeLayout(false);
            this.pnlPuesto.PerformLayout();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            this.tbpDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEntrevista;
        private System.Windows.Forms.TabPage tbpDatosRecluta;
        private System.Windows.Forms.TabPage tbpDatosEntrevista;
        private System.Windows.Forms.GroupBox gbxDatosEntrevista;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbTipoEntrevista;
        private System.Windows.Forms.Label lblResultadoEntrevista;
        private System.Windows.Forms.Label lblTipoEntrevista;
        private System.Windows.Forms.Label lblIngreseIdRecluta;
        private System.Windows.Forms.TextBox txtIdBancoTalento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuestoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.Panel pnlPuesto;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Button btnIngresoEntrevista;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.RadioButton rbtnReprobado;
        private System.Windows.Forms.RadioButton rbtnAprobado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReclutas;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.RadioButton rbtnSegOpcion;
        private System.Windows.Forms.RadioButton rbtnPrimeraOp;
    }
}