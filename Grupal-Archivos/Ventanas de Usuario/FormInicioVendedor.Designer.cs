namespace Grupal_Archivos.Ventanas_de_Usuario
{
    partial class FormInicioVendedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonVenta = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.buttonSalir);
            this.panel1.Controls.Add(this.buttonReportes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonVenta);
            this.panel1.Controls.Add(this.buttonClientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 607);
            this.panel1.TabIndex = 1;
            // 
            // buttonVenta
            // 
            this.buttonVenta.Location = new System.Drawing.Point(3, 250);
            this.buttonVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVenta.Name = "buttonVenta";
            this.buttonVenta.Size = new System.Drawing.Size(163, 29);
            this.buttonVenta.TabIndex = 4;
            this.buttonVenta.Text = "Generar Venta";
            this.buttonVenta.UseVisualStyleBackColor = true;
            this.buttonVenta.Click += new System.EventHandler(this.buttonVenta_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(3, 217);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(163, 29);
            this.buttonClientes.TabIndex = 3;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 49);
            this.panel2.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(167, 49);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(780, 558);
            this.panelMain.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupal_Archivos.Properties.Resources.articulos_de_aseo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vendedor";
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(2, 283);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(163, 29);
            this.buttonReportes.TabIndex = 5;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(3, 521);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(163, 29);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormInicioVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 607);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInicioVendedor";
            this.Text = "FormVendedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonSalir;
    }
}