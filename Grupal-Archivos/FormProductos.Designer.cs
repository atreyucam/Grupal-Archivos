namespace Grupal_Archivos
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.comboBoxDiaElaboracion = new System.Windows.Forms.ComboBox();
            this.comboBoxDiaCaducidad = new System.Windows.Forms.ComboBox();
            this.comboBoxMesElaboracion = new System.Windows.Forms.ComboBox();
            this.comboBoxMesCaducidad = new System.Windows.Forms.ComboBox();
            this.comboBoxYearElaboracion = new System.Windows.Forms.ComboBox();
            this.comboBoxYearCaducidad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaElaboracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCaducidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTienda1 = new Grupal_Archivos.DataSetTienda();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(159, 134);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(148, 26);
            this.textBoxCodigo.TabIndex = 2;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de caducidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de elaboraion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Subtipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "CABELLO",
            "ASEO BUCAL",
            "ASEO CORPORAL"});
            this.comboBoxTipo.Location = new System.Drawing.Point(438, 132);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(180, 28);
            this.comboBoxTipo.TabIndex = 11;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(748, 132);
            this.comboBoxSubtipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSubtipo.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(159, 288);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(148, 26);
            this.textBoxNombre.TabIndex = 14;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(438, 209);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(148, 26);
            this.textBoxStock.TabIndex = 15;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(159, 360);
            this.richTextBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxDescripcion.MaxLength = 100;
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(427, 82);
            this.richTextBoxDescripcion.TabIndex = 16;
            this.richTextBoxDescripcion.Text = "";
            this.richTextBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxDescripcion_KeyPress);
            // 
            // comboBoxDiaElaboracion
            // 
            this.comboBoxDiaElaboracion.FormattingEnabled = true;
            this.comboBoxDiaElaboracion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
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
            "31"});
            this.comboBoxDiaElaboracion.Location = new System.Drawing.Point(798, 348);
            this.comboBoxDiaElaboracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDiaElaboracion.Name = "comboBoxDiaElaboracion";
            this.comboBoxDiaElaboracion.Size = new System.Drawing.Size(67, 28);
            this.comboBoxDiaElaboracion.TabIndex = 17;
            // 
            // comboBoxDiaCaducidad
            // 
            this.comboBoxDiaCaducidad.FormattingEnabled = true;
            this.comboBoxDiaCaducidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
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
            "31"});
            this.comboBoxDiaCaducidad.Location = new System.Drawing.Point(798, 415);
            this.comboBoxDiaCaducidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDiaCaducidad.Name = "comboBoxDiaCaducidad";
            this.comboBoxDiaCaducidad.Size = new System.Drawing.Size(67, 28);
            this.comboBoxDiaCaducidad.TabIndex = 18;
            // 
            // comboBoxMesElaboracion
            // 
            this.comboBoxMesElaboracion.FormattingEnabled = true;
            this.comboBoxMesElaboracion.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMesElaboracion.Location = new System.Drawing.Point(876, 348);
            this.comboBoxMesElaboracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMesElaboracion.Name = "comboBoxMesElaboracion";
            this.comboBoxMesElaboracion.Size = new System.Drawing.Size(67, 28);
            this.comboBoxMesElaboracion.TabIndex = 19;
            // 
            // comboBoxMesCaducidad
            // 
            this.comboBoxMesCaducidad.FormattingEnabled = true;
            this.comboBoxMesCaducidad.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMesCaducidad.Location = new System.Drawing.Point(876, 415);
            this.comboBoxMesCaducidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMesCaducidad.Name = "comboBoxMesCaducidad";
            this.comboBoxMesCaducidad.Size = new System.Drawing.Size(67, 28);
            this.comboBoxMesCaducidad.TabIndex = 20;
            // 
            // comboBoxYearElaboracion
            // 
            this.comboBoxYearElaboracion.FormattingEnabled = true;
            this.comboBoxYearElaboracion.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBoxYearElaboracion.Location = new System.Drawing.Point(954, 348);
            this.comboBoxYearElaboracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxYearElaboracion.Name = "comboBoxYearElaboracion";
            this.comboBoxYearElaboracion.Size = new System.Drawing.Size(67, 28);
            this.comboBoxYearElaboracion.TabIndex = 21;
            // 
            // comboBoxYearCaducidad
            // 
            this.comboBoxYearCaducidad.FormattingEnabled = true;
            this.comboBoxYearCaducidad.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.comboBoxYearCaducidad.Location = new System.Drawing.Point(954, 415);
            this.comboBoxYearCaducidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxYearCaducidad.Name = "comboBoxYearCaducidad";
            this.comboBoxYearCaducidad.Size = new System.Drawing.Size(67, 28);
            this.comboBoxYearCaducidad.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(794, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "DÍA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(794, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "DÍA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(872, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "MES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(872, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "MES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(950, 323);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "AÑO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(950, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "AÑO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.subtipoProductoDataGridViewTextBoxColumn,
            this.marcaProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.stockProductoDataGridViewTextBoxColumn,
            this.fechaElaboracionDataGridViewTextBoxColumn,
            this.fechaCaducidadDataGridViewTextBoxColumn,
            this.precioProductoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablaProductosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 486);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(822, 231);
            this.dataGridView1.TabIndex = 29;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "codigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "codigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // subtipoProductoDataGridViewTextBoxColumn
            // 
            this.subtipoProductoDataGridViewTextBoxColumn.DataPropertyName = "subtipoProducto";
            this.subtipoProductoDataGridViewTextBoxColumn.HeaderText = "subtipoProducto";
            this.subtipoProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subtipoProductoDataGridViewTextBoxColumn.Name = "subtipoProductoDataGridViewTextBoxColumn";
            this.subtipoProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaProductoDataGridViewTextBoxColumn
            // 
            this.marcaProductoDataGridViewTextBoxColumn.DataPropertyName = "marcaProducto";
            this.marcaProductoDataGridViewTextBoxColumn.HeaderText = "marcaProducto";
            this.marcaProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marcaProductoDataGridViewTextBoxColumn.Name = "marcaProductoDataGridViewTextBoxColumn";
            this.marcaProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "descripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "descripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            this.descripcionProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockProductoDataGridViewTextBoxColumn
            // 
            this.stockProductoDataGridViewTextBoxColumn.DataPropertyName = "stockProducto";
            this.stockProductoDataGridViewTextBoxColumn.HeaderText = "stockProducto";
            this.stockProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockProductoDataGridViewTextBoxColumn.Name = "stockProductoDataGridViewTextBoxColumn";
            this.stockProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaElaboracionDataGridViewTextBoxColumn
            // 
            this.fechaElaboracionDataGridViewTextBoxColumn.DataPropertyName = "fechaElaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.HeaderText = "fechaElaboracion";
            this.fechaElaboracionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaElaboracionDataGridViewTextBoxColumn.Name = "fechaElaboracionDataGridViewTextBoxColumn";
            this.fechaElaboracionDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCaducidadDataGridViewTextBoxColumn
            // 
            this.fechaCaducidadDataGridViewTextBoxColumn.DataPropertyName = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.HeaderText = "fechaCaducidad";
            this.fechaCaducidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCaducidadDataGridViewTextBoxColumn.Name = "fechaCaducidadDataGridViewTextBoxColumn";
            this.fechaCaducidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            this.precioProductoDataGridViewTextBoxColumn.DataPropertyName = "precioProducto";
            this.precioProductoDataGridViewTextBoxColumn.HeaderText = "precioProducto";
            this.precioProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            this.precioProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // tablaProductosBindingSource
            // 
            this.tablaProductosBindingSource.DataMember = "TablaProductos";
            this.tablaProductosBindingSource.DataSource = this.dataSetTienda1;
            // 
            // dataSetTienda1
            // 
            this.dataSetTienda1.DataSetName = "DataSetTienda";
            this.dataSetTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(954, 651);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 48);
            this.buttonGuardar.TabIndex = 30;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(368, 298);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Precio:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(438, 288);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(148, 26);
            this.textBoxPrecio.TabIndex = 32;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(159, 208);
            this.comboBoxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(148, 28);
            this.comboBoxMarca.TabIndex = 33;
            this.comboBoxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMarca_KeyPress);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 763);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxYearCaducidad);
            this.Controls.Add(this.comboBoxYearElaboracion);
            this.Controls.Add(this.comboBoxMesCaducidad);
            this.Controls.Add(this.comboBoxMesElaboracion);
            this.Controls.Add(this.comboBoxDiaCaducidad);
            this.Controls.Add(this.comboBoxDiaElaboracion);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxSubtipo);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProductos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.ComboBox comboBoxDiaElaboracion;
        private System.Windows.Forms.ComboBox comboBoxDiaCaducidad;
        private System.Windows.Forms.ComboBox comboBoxMesElaboracion;
        private System.Windows.Forms.ComboBox comboBoxMesCaducidad;
        private System.Windows.Forms.ComboBox comboBoxYearElaboracion;
        private System.Windows.Forms.ComboBox comboBoxYearCaducidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DataSetTienda dataSetTienda1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaElaboracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCaducidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablaProductosBindingSource;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxMarca;
    }
}

