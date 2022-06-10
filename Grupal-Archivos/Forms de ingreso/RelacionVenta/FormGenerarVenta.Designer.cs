namespace Grupal_Archivos.Forms_de_ingreso.RelacionVenta
{
    partial class FormGenerarVenta
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.dataSetTienda = new Grupal_Archivos.DataSetTienda();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tablaVendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tablaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de venta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula de Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre del cliente:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(194, 170);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(134, 20);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(331, 170);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(134, 20);
            this.textBoxApellido.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Subtipo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(129, 272);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(134, 20);
            this.textBoxCantidad.TabIndex = 16;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // dataSetTienda
            // 
            this.dataSetTienda.DataSetName = "DataSetTienda";
            this.dataSetTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tablaVendedorBindingSource;
            this.comboBox1.DisplayMember = "UserName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(528, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "Cedula";
            // 
            // tablaVendedorBindingSource
            // 
            this.tablaVendedorBindingSource.DataMember = "TablaVendedor";
            this.tablaVendedorBindingSource.DataSource = this.dataSetTienda;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tablaProductosBindingSource;
            this.comboBox2.DisplayMember = "tipoProducto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 228);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "codigoProducto";
            // 
            // tablaProductosBindingSource
            // 
            this.tablaProductosBindingSource.DataMember = "TablaProductos";
            this.tablaProductosBindingSource.DataSource = this.dataSetTienda;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tablaProductosBindingSource;
            this.comboBox3.DisplayMember = "subtipoProducto";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(332, 225);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "codigoProducto";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.tablaProductosBindingSource;
            this.comboBox4.DisplayMember = "nombreProducto";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(582, 225);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "codigoProducto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCompraDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablaCompraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // codigoCompraDataGridViewTextBoxColumn
            // 
            this.codigoCompraDataGridViewTextBoxColumn.DataPropertyName = "codigoCompra";
            this.codigoCompraDataGridViewTextBoxColumn.HeaderText = "codigoCompra";
            this.codigoCompraDataGridViewTextBoxColumn.Name = "codigoCompraDataGridViewTextBoxColumn";
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // tablaCompraBindingSource
            // 
            this.tablaCompraBindingSource.DataMember = "TablaCompra";
            this.tablaCompraBindingSource.DataSource = this.dataSetTienda;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(332, 492);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(112, 37);
            this.buttonGuardar.TabIndex = 23;
            this.buttonGuardar.Text = "Guardar item";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(294, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Valor:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tablaProductosBindingSource, "precioProducto", true));
            this.labelValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValor.Location = new System.Drawing.Point(373, 272);
            this.labelValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(79, 20);
            this.labelValor.TabIndex = 25;
            this.labelValor.Text = "labelValor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(290, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Generar venta";
            // 
            // FormGenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 558);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGenerarVenta";
            this.Text = "FormGenerarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private DataSetTienda dataSetTienda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tablaVendedorBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource tablaProductosBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablaCompraBindingSource;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label label11;
    }
}