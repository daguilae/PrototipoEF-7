namespace Capa_Vista
{
    partial class frmMDI
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
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleadosMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReclutasMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleadosProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAscenderEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDespedirEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReclutamientoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarReclutaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeleccionReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleadosReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.tsmiIngresarFaltaMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCapacitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPuestoMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))));
            this.mspMDI.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiMantenimientos,
            this.tsmiProcesos,
            this.tsmiHerramientas,
            this.tsmiReportes,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mspMDI.Size = new System.Drawing.Size(975, 28);
            this.mspMDI.TabIndex = 0;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
            this.tsmiInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(63, 24);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.ToolTipText = "Opciones de Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(224, 26);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleadosMantenimientos,
            this.tsmiReclutasMantenimientos,
            this.tsmiPuestoMantenimientos});
            this.tsmiMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(137, 24);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            this.tsmiMantenimientos.ToolTipText = "Mantenimientos del Módulo";
            // 
            // tsmiEmpleadosMantenimientos
            // 
            this.tsmiEmpleadosMantenimientos.Name = "tsmiEmpleadosMantenimientos";
            this.tsmiEmpleadosMantenimientos.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmpleadosMantenimientos.Text = "Empleados";
            this.tsmiEmpleadosMantenimientos.Click += new System.EventHandler(this.tsmiPuestosMantenimientos_Click);
            // 
            // tsmiReclutasMantenimientos
            // 
            this.tsmiReclutasMantenimientos.Name = "tsmiReclutasMantenimientos";
            this.tsmiReclutasMantenimientos.Size = new System.Drawing.Size(224, 26);
            this.tsmiReclutasMantenimientos.Text = "Reclutas";
            this.tsmiReclutasMantenimientos.Click += new System.EventHandler(this.tsmiDepartamentoMantenimientos_Click);
            // 
            // tsmiProcesos
            // 
            this.tsmiProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleadosProceso,
            this.tsmiReclutamientoProceso});
            this.tsmiProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiProcesos.Name = "tsmiProcesos";
            this.tsmiProcesos.Size = new System.Drawing.Size(86, 24);
            this.tsmiProcesos.Text = "Procesos";
            // 
            // tsmiEmpleadosProceso
            // 
            this.tsmiEmpleadosProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarEmpleadoProceso,
            this.tsmiAscenderEmpleadoProceso,
            this.tsmiDespedirEmpleadoProceso});
            this.tsmiEmpleadosProceso.Name = "tsmiEmpleadosProceso";
            this.tsmiEmpleadosProceso.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmpleadosProceso.Text = "Empleados";
            // 
            // tsmiEditarEmpleadoProceso
            // 
            this.tsmiEditarEmpleadoProceso.Name = "tsmiEditarEmpleadoProceso";
            this.tsmiEditarEmpleadoProceso.Size = new System.Drawing.Size(232, 26);
            this.tsmiEditarEmpleadoProceso.Text = "Editar Empleado";
            this.tsmiEditarEmpleadoProceso.Click += new System.EventHandler(this.tsmiEditarEmpleadoProceso_Click);
            // 
            // tsmiAscenderEmpleadoProceso
            // 
            this.tsmiAscenderEmpleadoProceso.Name = "tsmiAscenderEmpleadoProceso";
            this.tsmiAscenderEmpleadoProceso.Size = new System.Drawing.Size(232, 26);
            this.tsmiAscenderEmpleadoProceso.Text = "Ascender Empleado";
            this.tsmiAscenderEmpleadoProceso.Click += new System.EventHandler(this.tsmiAscenderEmpleadoProceso_Click);
            // 
            // tsmiDespedirEmpleadoProceso
            // 
            this.tsmiDespedirEmpleadoProceso.Name = "tsmiDespedirEmpleadoProceso";
            this.tsmiDespedirEmpleadoProceso.Size = new System.Drawing.Size(232, 26);
            this.tsmiDespedirEmpleadoProceso.Text = "Despedir Empleado";
            this.tsmiDespedirEmpleadoProceso.Click += new System.EventHandler(this.tsmiDespedirEmpleadoProceso_Click);
            // 
            // tsmiReclutamientoProceso
            // 
            this.tsmiReclutamientoProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarReclutaProceso});
            this.tsmiReclutamientoProceso.Name = "tsmiReclutamientoProceso";
            this.tsmiReclutamientoProceso.Size = new System.Drawing.Size(224, 26);
            this.tsmiReclutamientoProceso.Text = "Reclutamiento";
            // 
            // tsmiIngresarReclutaProceso
            // 
            this.tsmiIngresarReclutaProceso.Name = "tsmiIngresarReclutaProceso";
            this.tsmiIngresarReclutaProceso.Size = new System.Drawing.Size(273, 26);
            this.tsmiIngresarReclutaProceso.Text = "Ingresar/Editar Reclutado";
            this.tsmiIngresarReclutaProceso.Click += new System.EventHandler(this.tsmiIngresarReclutaProceso_Click);
            // 
            // tsmiHerramientas
            // 
            this.tsmiHerramientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiHerramientas.Name = "tsmiHerramientas";
            this.tsmiHerramientas.Size = new System.Drawing.Size(118, 24);
            this.tsmiHerramientas.Text = "Herramientas";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeleccionReporte});
            this.tsmiReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(85, 24);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiSeleccionReporte
            // 
            this.tsmiSeleccionReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleadosReporte});
            this.tsmiSeleccionReporte.Name = "tsmiSeleccionReporte";
            this.tsmiSeleccionReporte.Size = new System.Drawing.Size(224, 26);
            this.tsmiSeleccionReporte.Text = "Selección";
            // 
            // tsmiEmpleadosReporte
            // 
            this.tsmiEmpleadosReporte.Name = "tsmiEmpleadosReporte";
            this.tsmiEmpleadosReporte.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmpleadosReporte.Text = "Empleados";
            this.tsmiEmpleadosReporte.Click += new System.EventHandler(this.tsmiEmpleadosReporte_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(66, 24);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(0, 507);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(975, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 28);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(975, 501);
            this.pnlContenedor.TabIndex = 1;
            // 
            // tsmiIngresarFaltaMantenimientos
            // 
            this.tsmiIngresarFaltaMantenimientos.Name = "tsmiIngresarFaltaMantenimientos";
            this.tsmiIngresarFaltaMantenimientos.Size = new System.Drawing.Size(169, 26);
            this.tsmiIngresarFaltaMantenimientos.Text = "Ingresar Falta";
            this.tsmiIngresarFaltaMantenimientos.Click += new System.EventHandler(this.tsmiIngresarFaltaMantenimientos_Click);
            // 
            // tsmiMantenimientosDeCapacitaciones
            // 
            this.tsmiMantenimientosDeCapacitaciones.Name = "tsmiMantenimientosDeCapacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Size = new System.Drawing.Size(293, 26);
            this.tsmiMantenimientosDeCapacitaciones.Text = "Mantenimientos de Capacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Click += new System.EventHandler(this.tsmiMantenimientosDeCapacitaciones_Click);
            // 
            // tsmiMantenimientosDeCursos
            // 
            this.tsmiMantenimientosDeCursos.Name = "tsmiMantenimientosDeCursos";
            this.tsmiMantenimientosDeCursos.Size = new System.Drawing.Size(293, 26);
            this.tsmiMantenimientosDeCursos.Text = "Mantenimientos de Cursos";
            this.tsmiMantenimientosDeCursos.Click += new System.EventHandler(this.tsmiMantenimientosDeCursos_Click);
            // 
            // tsmiPuestoMantenimientos
            // 
            this.tsmiPuestoMantenimientos.Name = "tsmiPuestoMantenimientos";
            this.tsmiPuestoMantenimientos.Size = new System.Drawing.Size(224, 26);
            this.tsmiPuestoMantenimientos.Text = "Puesto";
            this.tsmiPuestoMantenimientos.Click += new System.EventHandler(this.tsmiPuestoMantenimientos_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 529);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antonio Manuel Alejandro Garcia Gonzalez 0901-17-65";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcesos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiReclutamientoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeleccionReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleadosReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleadosMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReclutasMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarReclutaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleadosProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiAscenderEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDespedirEmpleadoProceso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarFaltaMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCapacitaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmiPuestoMantenimientos;
    }
}