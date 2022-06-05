namespace Grupal_Archivos.Login
{
    partial class FormRol
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
            this.buttonLoginAdmin = new System.Windows.Forms.Button();
            this.buttonLoginVendedor = new System.Windows.Forms.Button();
            this.panelRoles = new System.Windows.Forms.Panel();
            this.panelRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.Location = new System.Drawing.Point(266, 164);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(134, 56);
            this.buttonLoginAdmin.TabIndex = 2;
            this.buttonLoginAdmin.Text = "Administrador";
            this.buttonLoginAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAdmin.Click += new System.EventHandler(this.buttonLoginAdmin_Click);
            // 
            // buttonLoginVendedor
            // 
            this.buttonLoginVendedor.Location = new System.Drawing.Point(545, 164);
            this.buttonLoginVendedor.Name = "buttonLoginVendedor";
            this.buttonLoginVendedor.Size = new System.Drawing.Size(114, 56);
            this.buttonLoginVendedor.TabIndex = 3;
            this.buttonLoginVendedor.Text = "Vendedor";
            this.buttonLoginVendedor.UseVisualStyleBackColor = true;
            this.buttonLoginVendedor.Click += new System.EventHandler(this.buttonLoginVendedor_Click);
            // 
            // panelRoles
            // 
            this.panelRoles.Controls.Add(this.buttonLoginAdmin);
            this.panelRoles.Controls.Add(this.buttonLoginVendedor);
            this.panelRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoles.Location = new System.Drawing.Point(0, 0);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(854, 294);
            this.panelRoles.TabIndex = 4;
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 294);
            this.Controls.Add(this.panelRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRol";
            this.Text = "FormRol";
            this.panelRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.Button buttonLoginVendedor;
        private System.Windows.Forms.Panel panelRoles;
    }
}