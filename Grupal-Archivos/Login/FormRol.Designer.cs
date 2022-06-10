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
            this.label1 = new System.Windows.Forms.Label();
            this.panelRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginAdmin.Location = new System.Drawing.Point(155, 101);
            this.buttonLoginAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(89, 36);
            this.buttonLoginAdmin.TabIndex = 2;
            this.buttonLoginAdmin.Text = "Administrador";
            this.buttonLoginAdmin.UseVisualStyleBackColor = false;
            this.buttonLoginAdmin.Click += new System.EventHandler(this.buttonLoginAdmin_Click);
            // 
            // buttonLoginVendedor
            // 
            this.buttonLoginVendedor.BackColor = System.Drawing.Color.LightGreen;
            this.buttonLoginVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginVendedor.Location = new System.Drawing.Point(341, 101);
            this.buttonLoginVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoginVendedor.Name = "buttonLoginVendedor";
            this.buttonLoginVendedor.Size = new System.Drawing.Size(76, 36);
            this.buttonLoginVendedor.TabIndex = 3;
            this.buttonLoginVendedor.Text = "Vendedor";
            this.buttonLoginVendedor.UseVisualStyleBackColor = false;
            this.buttonLoginVendedor.Click += new System.EventHandler(this.buttonLoginVendedor_Click);
            // 
            // panelRoles
            // 
            this.panelRoles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelRoles.Controls.Add(this.label1);
            this.panelRoles.Controls.Add(this.buttonLoginAdmin);
            this.panelRoles.Controls.Add(this.buttonLoginVendedor);
            this.panelRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoles.Location = new System.Drawing.Point(0, 0);
            this.panelRoles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(569, 191);
            this.panelRoles.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escoja su rol";
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 191);
            this.Controls.Add(this.panelRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRol";
            this.Text = "FormRol";
            this.panelRoles.ResumeLayout(false);
            this.panelRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.Button buttonLoginVendedor;
        private System.Windows.Forms.Panel panelRoles;
        private System.Windows.Forms.Label label1;
    }
}