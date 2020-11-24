namespace Capa_Vista.Vista_Mantenimientos.Puesto
{
    partial class frmMantenimientoPuesto
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
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.NavegadorPuesto = new CapaVistaNavegador.Navegador();
            this.lblEstadoPuesto = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDPuesto = new System.Windows.Forms.TextBox();
            this.txtNombrePuesto = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbCodHorario = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(351, 114);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.Size = new System.Drawing.Size(716, 287);
            this.dgvPuestos.TabIndex = 10;
            // 
            // NavegadorPuesto
            // 
            this.NavegadorPuesto.BackColor = System.Drawing.Color.Transparent;
            this.NavegadorPuesto.Location = new System.Drawing.Point(12, 5);
            this.NavegadorPuesto.Name = "NavegadorPuesto";
            this.NavegadorPuesto.Size = new System.Drawing.Size(1059, 105);
            this.NavegadorPuesto.TabIndex = 11;
            this.NavegadorPuesto.Load += new System.EventHandler(this.NavegadorPuesto_Load);
            // 
            // lblEstadoPuesto
            // 
            this.lblEstadoPuesto.AutoSize = true;
            this.lblEstadoPuesto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPuesto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstadoPuesto.Location = new System.Drawing.Point(34, 340);
            this.lblEstadoPuesto.Name = "lblEstadoPuesto";
            this.lblEstadoPuesto.Size = new System.Drawing.Size(120, 15);
            this.lblEstadoPuesto.TabIndex = 20;
            this.lblEstadoPuesto.Text = "Estado del Puesto";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHorario.Location = new System.Drawing.Point(34, 288);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(56, 15);
            this.lblHorario.TabIndex = 16;
            this.lblHorario.Text = "Horario";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalario.Location = new System.Drawing.Point(34, 234);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 15);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario";
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDepa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIDepa.Location = new System.Drawing.Point(34, 135);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(68, 15);
            this.lblIDepa.TabIndex = 18;
            this.lblIDepa.Text = "ID Puesto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(34, 182);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 15);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre del Puesto";
            // 
            // txtIDPuesto
            // 
            this.txtIDPuesto.Location = new System.Drawing.Point(37, 153);
            this.txtIDPuesto.Name = "txtIDPuesto";
            this.txtIDPuesto.Size = new System.Drawing.Size(272, 20);
            this.txtIDPuesto.TabIndex = 21;
            this.txtIDPuesto.Tag = "pk_id_puesto";
            this.txtIDPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.Location = new System.Drawing.Point(37, 199);
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.Size = new System.Drawing.Size(272, 20);
            this.txtNombrePuesto.TabIndex = 22;
            this.txtNombrePuesto.Tag = "nombre_puesto";
            this.txtNombrePuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(37, 251);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(272, 20);
            this.txtSalario.TabIndex = 23;
            this.txtSalario.Tag = "salario_puesto";
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // cmbCodHorario
            // 
            this.cmbCodHorario.FormattingEnabled = true;
            this.cmbCodHorario.Location = new System.Drawing.Point(252, 307);
            this.cmbCodHorario.Name = "cmbCodHorario";
            this.cmbCodHorario.Size = new System.Drawing.Size(57, 21);
            this.cmbCodHorario.TabIndex = 24;
            this.cmbCodHorario.Tag = "fk_id_horario_puesto";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(319, 381);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(26, 20);
            this.txtEstado.TabIndex = 25;
            this.txtEstado.Tag = "estado_puesto";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(37, 307);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(183, 21);
            this.cmbHorario.TabIndex = 26;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnActivo.Location = new System.Drawing.Point(89, 369);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(65, 19);
            this.rbtnActivo.TabIndex = 27;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbtnInactivo.Location = new System.Drawing.Point(175, 369);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(77, 19);
            this.rbtnInactivo.TabIndex = 28;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // frmMantenimientoPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 413);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbCodHorario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNombrePuesto);
            this.Controls.Add(this.txtIDPuesto);
            this.Controls.Add(this.lblEstadoPuesto);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.NavegadorPuesto);
            this.Controls.Add(this.dgvPuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMantenimientoPuesto";
            this.Text = "309 - Mantenimiento Puestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPuestos;
        private CapaVistaNavegador.Navegador NavegadorPuesto;
        private System.Windows.Forms.Label lblEstadoPuesto;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDPuesto;
        private System.Windows.Forms.TextBox txtNombrePuesto;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cmbCodHorario;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.RadioButton rbtnInactivo;
    }
}