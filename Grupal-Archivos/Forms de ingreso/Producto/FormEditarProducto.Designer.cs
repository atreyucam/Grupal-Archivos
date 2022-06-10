namespace Grupal_Archivos.Forms_de_ingreso
{
    partial class FormEditarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxSubtipo = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataSetTienda1 = new Grupal_Archivos.DataSetTienda();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = "Editar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(103, 153);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 64;
            this.comboBoxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMarca_KeyPress);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(103, 106);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 36;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(289, 205);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 63;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(242, 213);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(444, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Subtipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "CABELLO",
            "ASEO BUCAL",
            "ASEO CORPORAL"});
            this.comboBoxTipo.Location = new System.Drawing.Point(289, 105);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 45;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubtipo_SelectedIndexChanged);
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(496, 105);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubtipo.TabIndex = 46;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(103, 205);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 47;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(289, 154);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 48;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(103, 264);
            this.richTextBoxDescripcion.MaxLength = 100;
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(388, 55);
            this.richTextBoxDescripcion.TabIndex = 49;
            this.richTextBoxDescripcion.Text = "";
            this.richTextBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxDescripcion_KeyPress);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(322, 412);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(102, 29);
            this.buttonGuardar.TabIndex = 65;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataSetTienda1
            // 
            this.dataSetTienda1.DataSetName = "DataSetTienda";
            this.dataSetTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 482);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxSubtipo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Name = "FormEditarProducto";
            this.Text = "FormEditarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxSubtipo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Button buttonGuardar;
        private DataSetTienda dataSetTienda1;
    }
}