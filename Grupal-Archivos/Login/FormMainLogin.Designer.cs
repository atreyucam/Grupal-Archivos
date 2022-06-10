namespace Grupal_Archivos.Login
{
    partial class FormMainLogin
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRegresar = new System.Windows.Forms.Panel();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dataSetTienda1 = new Grupal_Archivos.DataSetTienda();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            this.panelRegresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SpringGreen;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(145, 292);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(145, 40);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(599, 252);
            this.panelMain.TabIndex = 1;
            // 
            // panelRegresar
            // 
            this.panelRegresar.BackColor = System.Drawing.Color.Aquamarine;
            this.panelRegresar.Controls.Add(this.buttonRegresar);
            this.panelRegresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegresar.Location = new System.Drawing.Point(145, 0);
            this.panelRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRegresar.Name = "panelRegresar";
            this.panelRegresar.Size = new System.Drawing.Size(599, 40);
            this.panelRegresar.TabIndex = 1;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(17, 8);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(77, 21);
            this.buttonRegresar.TabIndex = 2;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dataSetTienda1
            // 
            this.dataSetTienda1.DataSetName = "DataSetTienda";
            this.dataSetTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupal_Archivos.Properties.Resources.articulos_de_aseo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 292);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRegresar);
            this.Controls.Add(this.panelLogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMainLogin";
            this.Text = "FormRol";
            this.panelLogo.ResumeLayout(false);
            this.panelRegresar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRegresar;
        private System.Windows.Forms.Button buttonRegresar;
        private DataSetTienda dataSetTienda1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}