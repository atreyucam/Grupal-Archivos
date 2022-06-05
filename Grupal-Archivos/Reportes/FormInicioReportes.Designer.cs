namespace Grupal_Archivos.Reportes
{
    partial class FormInicioReportes
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
            this.buttonReporteProductos = new System.Windows.Forms.Button();
            this.buttonReporteCliente = new System.Windows.Forms.Button();
            this.buttonReporteVendedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReporteProductos
            // 
            this.buttonReporteProductos.Location = new System.Drawing.Point(151, 446);
            this.buttonReporteProductos.Name = "buttonReporteProductos";
            this.buttonReporteProductos.Size = new System.Drawing.Size(198, 54);
            this.buttonReporteProductos.TabIndex = 0;
            this.buttonReporteProductos.Text = "Reporte de productos";
            this.buttonReporteProductos.UseVisualStyleBackColor = true;
            this.buttonReporteProductos.Click += new System.EventHandler(this.buttonReporteProductos_Click);
            // 
            // buttonReporteCliente
            // 
            this.buttonReporteCliente.Location = new System.Drawing.Point(667, 446);
            this.buttonReporteCliente.Name = "buttonReporteCliente";
            this.buttonReporteCliente.Size = new System.Drawing.Size(198, 54);
            this.buttonReporteCliente.TabIndex = 2;
            this.buttonReporteCliente.Text = "Reporte de Clientes";
            this.buttonReporteCliente.UseVisualStyleBackColor = true;
            this.buttonReporteCliente.Click += new System.EventHandler(this.buttonReporteCliente_Click);
            // 
            // buttonReporteVendedores
            // 
            this.buttonReporteVendedores.Location = new System.Drawing.Point(405, 446);
            this.buttonReporteVendedores.Name = "buttonReporteVendedores";
            this.buttonReporteVendedores.Size = new System.Drawing.Size(198, 54);
            this.buttonReporteVendedores.TabIndex = 3;
            this.buttonReporteVendedores.Text = "Reporte de vendedores";
            this.buttonReporteVendedores.UseVisualStyleBackColor = true;
            this.buttonReporteVendedores.Click += new System.EventHandler(this.buttonReporteVendedores_Click);
            // 
            // FormInicioReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 803);
            this.Controls.Add(this.buttonReporteVendedores);
            this.Controls.Add(this.buttonReporteCliente);
            this.Controls.Add(this.buttonReporteProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicioReportes";
            this.Text = "FormInicioReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReporteProductos;
        private System.Windows.Forms.Button buttonReporteCliente;
        private System.Windows.Forms.Button buttonReporteVendedores;
    }
}