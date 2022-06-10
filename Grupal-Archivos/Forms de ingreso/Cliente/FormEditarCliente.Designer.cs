namespace Grupal_Archivos.Forms_de_ingreso.Cliente
{
    partial class FormEditarCliente
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataSetTienda1 = new Grupal_Archivos.DataSetTienda();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro (Loquito)"});
            this.cmbGenero.Location = new System.Drawing.Point(131, 233);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(125, 21);
            this.cmbGenero.TabIndex = 47;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Items.AddRange(new object[] {
            "Ambato",
            "Azoguez",
            "Babahoyo",
            "Cuenca",
            "Esmeraldas",
            "Guayaquil",
            "Guaranda",
            "Ibarra",
            "Latacunga ",
            "Loja",
            "Machala",
            "Macas",
            "Nueva Loja",
            "Portoviejo",
            "Puerto Francisco de Orellana ",
            "Puyo",
            "Quito",
            "Riobamba",
            "Santa Elena",
            "Std. Domingo",
            "Tena ",
            "Tulcan",
            "Zamora "});
            this.cmbCiudad.Location = new System.Drawing.Point(131, 198);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(125, 21);
            this.cmbCiudad.TabIndex = 46;
            // 
            // cmbEdad
            // 
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Items.AddRange(new object[] {
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmbEdad.Location = new System.Drawing.Point(131, 158);
            this.cmbEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(125, 21);
            this.cmbEdad.TabIndex = 45;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(554, 128);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 20);
            this.txtApellido.TabIndex = 44;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(131, 268);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(125, 20);
            this.txtCelular.TabIndex = 43;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(387, 200);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(138, 20);
            this.txtCorreo.TabIndex = 42;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(387, 167);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(199, 20);
            this.txtDireccion.TabIndex = 40;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(131, 128);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(125, 20);
            this.txtCedula.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(327, 128);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.label13.Location = new System.Drawing.Point(74, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Celular:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(74, 238);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Genero:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(276, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Correo electrónico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(324, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(74, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(272, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(74, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(74, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(498, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellido:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(267, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(208, 37);
            this.labelTitulo.TabIndex = 48;
            this.labelTitulo.Text = "Editar Cliente";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(314, 391);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(102, 29);
            this.buttonGuardar.TabIndex = 66;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataSetTienda1
            // 
            this.dataSetTienda1.DataSetName = "DataSetTienda";
            this.dataSetTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 482);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.cmbEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEditarCliente";
            this.Text = "FormEditarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonGuardar;
        private DataSetTienda dataSetTienda1;
    }
}