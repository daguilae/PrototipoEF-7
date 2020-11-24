namespace Capa_Vista.Vista_Reclutamiento
{
    partial class frmMostrarReclutas
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
            this.dgvMostrarReclutas = new System.Windows.Forms.DataGridView();
            this.lblReclutas = new System.Windows.Forms.Label();
            this.pnlDatosFiltro = new System.Windows.Forms.Panel();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.gbxFiltrado = new System.Windows.Forms.GroupBox();
            this.rbtnFiltradoProfesion = new System.Windows.Forms.RadioButton();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.rbtnFiltradoDepto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoPuesto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoApellido1 = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoNombre1 = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoId = new System.Windows.Forms.RadioButton();
            this.txtIdRecluta = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReclutas)).BeginInit();
            this.pnlDatosFiltro.SuspendLayout();
            this.gbxFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarReclutas
            // 
            this.dgvMostrarReclutas.AllowUserToAddRows = false;
            this.dgvMostrarReclutas.AllowUserToDeleteRows = false;
            this.dgvMostrarReclutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarReclutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReclutas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarReclutas.Location = new System.Drawing.Point(0, 167);
            this.dgvMostrarReclutas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarReclutas.Name = "dgvMostrarReclutas";
            this.dgvMostrarReclutas.RowHeadersVisible = false;
            this.dgvMostrarReclutas.RowHeadersWidth = 51;
            this.dgvMostrarReclutas.RowTemplate.Height = 24;
            this.dgvMostrarReclutas.Size = new System.Drawing.Size(799, 288);
            this.dgvMostrarReclutas.TabIndex = 0;
            // 
            // lblReclutas
            // 
            this.lblReclutas.AutoSize = true;
            this.lblReclutas.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclutas.Location = new System.Drawing.Point(321, 21);
            this.lblReclutas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReclutas.Name = "lblReclutas";
            this.lblReclutas.Size = new System.Drawing.Size(217, 21);
            this.lblReclutas.TabIndex = 3;
            this.lblReclutas.Text = "Reclutas sin Entrevistar";
            // 
            // pnlDatosFiltro
            // 
            this.pnlDatosFiltro.Controls.Add(this.btnMostrarTodo);
            this.pnlDatosFiltro.Controls.Add(this.lblReclutas);
            this.pnlDatosFiltro.Controls.Add(this.gbxFiltrado);
            this.pnlDatosFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDatosFiltro.Name = "pnlDatosFiltro";
            this.pnlDatosFiltro.Size = new System.Drawing.Size(799, 167);
            this.pnlDatosFiltro.TabIndex = 11;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(656, 9);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(138, 50);
            this.btnMostrarTodo.TabIndex = 11;
            this.btnMostrarTodo.Text = "Mostrar Todos los Datos";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // gbxFiltrado
            // 
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoProfesion);
            this.gbxFiltrado.Controls.Add(this.txtProfesion);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoDepto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoPuesto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoApellido1);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoNombre1);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoId);
            this.gbxFiltrado.Controls.Add(this.txtIdRecluta);
            this.gbxFiltrado.Controls.Add(this.txtPrimerNombre);
            this.gbxFiltrado.Controls.Add(this.txtDepartamento);
            this.gbxFiltrado.Controls.Add(this.txtPrimerApellido);
            this.gbxFiltrado.Controls.Add(this.txtPuesto);
            this.gbxFiltrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxFiltrado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltrado.Location = new System.Drawing.Point(0, 56);
            this.gbxFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFiltrado.Name = "gbxFiltrado";
            this.gbxFiltrado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFiltrado.Size = new System.Drawing.Size(799, 111);
            this.gbxFiltrado.TabIndex = 10;
            this.gbxFiltrado.TabStop = false;
            this.gbxFiltrado.Text = "Filtrado De Datos";
            // 
            // rbtnFiltradoProfesion
            // 
            this.rbtnFiltradoProfesion.AutoSize = true;
            this.rbtnFiltradoProfesion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoProfesion.Location = new System.Drawing.Point(688, 41);
            this.rbtnFiltradoProfesion.Name = "rbtnFiltradoProfesion";
            this.rbtnFiltradoProfesion.Size = new System.Drawing.Size(112, 21);
            this.rbtnFiltradoProfesion.TabIndex = 16;
            this.rbtnFiltradoProfesion.TabStop = true;
            this.rbtnFiltradoProfesion.Text = "Por Profesion";
            this.rbtnFiltradoProfesion.UseVisualStyleBackColor = true;
            this.rbtnFiltradoProfesion.CheckedChanged += new System.EventHandler(this.rbtnFiltradoProfesion_CheckedChanged);
            // 
            // txtProfesion
            // 
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesion.Location = new System.Drawing.Point(695, 74);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(96, 23);
            this.txtProfesion.TabIndex = 15;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtProfesion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProfesion_KeyUp);
            // 
            // rbtnFiltradoDepto
            // 
            this.rbtnFiltradoDepto.AutoSize = true;
            this.rbtnFiltradoDepto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoDepto.Location = new System.Drawing.Point(543, 41);
            this.rbtnFiltradoDepto.Name = "rbtnFiltradoDepto";
            this.rbtnFiltradoDepto.Size = new System.Drawing.Size(143, 21);
            this.rbtnFiltradoDepto.TabIndex = 14;
            this.rbtnFiltradoDepto.TabStop = true;
            this.rbtnFiltradoDepto.Text = "Por Departamento";
            this.rbtnFiltradoDepto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoDepto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoDepto_CheckedChanged);
            // 
            // rbtnFiltradoPuesto
            // 
            this.rbtnFiltradoPuesto.AutoSize = true;
            this.rbtnFiltradoPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoPuesto.Location = new System.Drawing.Point(439, 41);
            this.rbtnFiltradoPuesto.Name = "rbtnFiltradoPuesto";
            this.rbtnFiltradoPuesto.Size = new System.Drawing.Size(94, 21);
            this.rbtnFiltradoPuesto.TabIndex = 13;
            this.rbtnFiltradoPuesto.TabStop = true;
            this.rbtnFiltradoPuesto.Text = "Por Puesto";
            this.rbtnFiltradoPuesto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoPuesto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoPuesto_CheckedChanged);
            // 
            // rbtnFiltradoApellido1
            // 
            this.rbtnFiltradoApellido1.AutoSize = true;
            this.rbtnFiltradoApellido1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoApellido1.Location = new System.Drawing.Point(281, 41);
            this.rbtnFiltradoApellido1.Name = "rbtnFiltradoApellido1";
            this.rbtnFiltradoApellido1.Size = new System.Drawing.Size(156, 21);
            this.rbtnFiltradoApellido1.TabIndex = 12;
            this.rbtnFiltradoApellido1.TabStop = true;
            this.rbtnFiltradoApellido1.Text = "Por Primer Apellido";
            this.rbtnFiltradoApellido1.UseVisualStyleBackColor = true;
            this.rbtnFiltradoApellido1.CheckedChanged += new System.EventHandler(this.rbtnFiltradoApellido1_CheckedChanged);
            // 
            // rbtnFiltradoNombre1
            // 
            this.rbtnFiltradoNombre1.AutoSize = true;
            this.rbtnFiltradoNombre1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoNombre1.Location = new System.Drawing.Point(130, 41);
            this.rbtnFiltradoNombre1.Name = "rbtnFiltradoNombre1";
            this.rbtnFiltradoNombre1.Size = new System.Drawing.Size(153, 21);
            this.rbtnFiltradoNombre1.TabIndex = 11;
            this.rbtnFiltradoNombre1.TabStop = true;
            this.rbtnFiltradoNombre1.Text = "Por Primer Nombre";
            this.rbtnFiltradoNombre1.UseVisualStyleBackColor = true;
            this.rbtnFiltradoNombre1.CheckedChanged += new System.EventHandler(this.rbtnFiltradoNombre1_CheckedChanged);
            // 
            // rbtnFiltradoId
            // 
            this.rbtnFiltradoId.AutoSize = true;
            this.rbtnFiltradoId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoId.Location = new System.Drawing.Point(38, 41);
            this.rbtnFiltradoId.Name = "rbtnFiltradoId";
            this.rbtnFiltradoId.Size = new System.Drawing.Size(65, 21);
            this.rbtnFiltradoId.TabIndex = 10;
            this.rbtnFiltradoId.TabStop = true;
            this.rbtnFiltradoId.Text = "Por Id";
            this.rbtnFiltradoId.UseVisualStyleBackColor = true;
            this.rbtnFiltradoId.CheckedChanged += new System.EventHandler(this.rbtnFiltradoId_CheckedChanged);
            // 
            // txtIdRecluta
            // 
            this.txtIdRecluta.Enabled = false;
            this.txtIdRecluta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRecluta.Location = new System.Drawing.Point(20, 74);
            this.txtIdRecluta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdRecluta.Name = "txtIdRecluta";
            this.txtIdRecluta.Size = new System.Drawing.Size(96, 23);
            this.txtIdRecluta.TabIndex = 9;
            this.txtIdRecluta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            this.txtIdRecluta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdEmpleado_KeyUp);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(152, 74);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(96, 23);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerNombre_KeyUp);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(562, 74);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(96, 23);
            this.txtDepartamento.TabIndex = 8;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtDepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDepartamento_KeyUp);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(306, 74);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(96, 23);
            this.txtPrimerApellido.TabIndex = 6;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerApellido_KeyUp);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(439, 74);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(96, 23);
            this.txtPuesto.TabIndex = 7;
            this.txtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPuesto_KeyUp);
            // 
            // frmMostrarReclutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(799, 455);
            this.Controls.Add(this.pnlDatosFiltro);
            this.Controls.Add(this.dgvMostrarReclutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarReclutas";
            this.Text = "321 - Reclutas";
            this.Load += new System.EventHandler(this.frmMostrarReclutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReclutas)).EndInit();
            this.pnlDatosFiltro.ResumeLayout(false);
            this.pnlDatosFiltro.PerformLayout();
            this.gbxFiltrado.ResumeLayout(false);
            this.gbxFiltrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarReclutas;
        private System.Windows.Forms.Label lblReclutas;
        private System.Windows.Forms.Panel pnlDatosFiltro;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.GroupBox gbxFiltrado;
        private System.Windows.Forms.RadioButton rbtnFiltradoDepto;
        private System.Windows.Forms.RadioButton rbtnFiltradoPuesto;
        private System.Windows.Forms.RadioButton rbtnFiltradoApellido1;
        private System.Windows.Forms.RadioButton rbtnFiltradoNombre1;
        private System.Windows.Forms.RadioButton rbtnFiltradoId;
        private System.Windows.Forms.TextBox txtIdRecluta;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.RadioButton rbtnFiltradoProfesion;
        private System.Windows.Forms.TextBox txtProfesion;
    }
}