﻿namespace Grupal_Archivos
{
    partial class menu
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
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProductos
            // 
            this.buttonProductos.Location = new System.Drawing.Point(273, 257);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(75, 23);
            this.buttonProductos.TabIndex = 0;
            this.buttonProductos.Text = "Productos";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(434, 257);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(75, 23);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClientes);
            this.Controls.Add(this.buttonProductos);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonClientes;
    }
}