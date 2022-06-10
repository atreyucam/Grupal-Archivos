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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(105, 81);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 2;
            this.textBoxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de caducidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de elaboraion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Subtipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
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
            this.comboBoxTipo.Location = new System.Drawing.Point(291, 80);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 11;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // comboBoxSubtipo
            // 
            this.comboBoxSubtipo.FormattingEnabled = true;
            this.comboBoxSubtipo.Location = new System.Drawing.Point(498, 80);
            this.comboBoxSubtipo.Name = "comboBoxSubtipo";
            this.comboBoxSubtipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubtipo.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(105, 181);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 14;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(291, 130);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 15;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(105, 228);
            this.richTextBoxDescripcion.MaxLength = 100;
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(286, 55);
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
            this.comboBoxDiaElaboracion.Location = new System.Drawing.Point(531, 220);
            this.comboBoxDiaElaboracion.Name = "comboBoxDiaElaboracion";
            this.comboBoxDiaElaboracion.Size = new System.Drawing.Size(46, 21);
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
            this.comboBoxDiaCaducidad.Location = new System.Drawing.Point(531, 264);
            this.comboBoxDiaCaducidad.Name = "comboBoxDiaCaducidad";
            this.comboBoxDiaCaducidad.Size = new System.Drawing.Size(46, 21);
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
            this.comboBoxMesElaboracion.Location = new System.Drawing.Point(583, 220);
            this.comboBoxMesElaboracion.Name = "comboBoxMesElaboracion";
            this.comboBoxMesElaboracion.Size = new System.Drawing.Size(46, 21);
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
            this.comboBoxMesCaducidad.Location = new System.Drawing.Point(583, 264);
            this.comboBoxMesCaducidad.Name = "comboBoxMesCaducidad";
            this.comboBoxMesCaducidad.Size = new System.Drawing.Size(46, 21);
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
            this.comboBoxYearElaboracion.Location = new System.Drawing.Point(635, 220);
            this.comboBoxYearElaboracion.Name = "comboBoxYearElaboracion";
            this.comboBoxYearElaboracion.Size = new System.Drawing.Size(46, 21);
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
            this.comboBoxYearCaducidad.Location = new System.Drawing.Point(635, 264);
            this.comboBoxYearCaducidad.Name = "comboBoxYearCaducidad";
            this.comboBoxYearCaducidad.Size = new System.Drawing.Size(46, 21);
            this.comboBoxYearCaducidad.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "DÍA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 248);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "DÍA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 204);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "MES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(580, 248);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "MES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(632, 204);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "AÑO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(632, 248);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(708, 150);
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
            this.buttonGuardar.Location = new System.Drawing.Point(93, 497);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(95, 31);
            this.buttonGuardar.TabIndex = 30;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(244, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Precio:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(291, 181);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 32;
            this.textBoxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrecio_KeyPress);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(105, 129);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 33;
            this.comboBoxMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMarca_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(598, 497);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 31);
            this.buttonBuscar.TabIndex = 34;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.buttonEliminar);
            this.panelMain.Controls.Add(this.buttonEditar);
            this.panelMain.Controls.Add(this.buttonBuscar);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.comboBoxMarca);
            this.panelMain.Controls.Add(this.textBoxCodigo);
            this.panelMain.Controls.Add(this.textBoxPrecio);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label17);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.buttonGuardar);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label16);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label15);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.Controls.Add(this.label14);
            this.panelMain.Controls.Add(this.label9);
            this.panelMain.Controls.Add(this.label13);
            this.panelMain.Controls.Add(this.label10);
            this.panelMain.Controls.Add(this.label11);
            this.panelMain.Controls.Add(this.comboBoxTipo);
            this.panelMain.Controls.Add(this.label12);
            this.panelMain.Controls.Add(this.comboBoxSubtipo);
            this.panelMain.Controls.Add(this.comboBoxYearCaducidad);
            this.panelMain.Controls.Add(this.textBoxNombre);
            this.panelMain.Controls.Add(this.comboBoxYearElaboracion);
            this.panelMain.Controls.Add(this.textBoxStock);
            this.panelMain.Controls.Add(this.comboBoxMesCaducidad);
            this.panelMain.Controls.Add(this.richTextBoxDescripcion);
            this.panelMain.Controls.Add(this.comboBoxMesElaboracion);
            this.panelMain.Controls.Add(this.comboBoxDiaElaboracion);
            this.panelMain.Controls.Add(this.comboBoxDiaCaducidad);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(780, 558);
            this.panelMain.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(278, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingresar Productos";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(442, 497);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(95, 31);
            this.buttonEliminar.TabIndex = 36;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(273, 497);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(95, 31);
            this.buttonEditar.TabIndex = 35;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 558);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label label1;
    }
}

