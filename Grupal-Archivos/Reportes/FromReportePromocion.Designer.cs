namespace Grupal_Archivos.Reportes
{
    partial class FromReportePromocion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tablaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTienda1 = new Grupal_Archivos.DataSetTienda();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grupal_Archivos.Reportes.ReportePromocion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1121, 918);
            this.reportViewer1.TabIndex = 0;
            // 
            // FromReportePromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 918);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FromReportePromocion";
            this.Text = "FromReportePromocion";
            this.Load += new System.EventHandler(this.FromReportePromocion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tablaProductosBindingSource;
        private DataSetTienda dataSetTienda1;
    }
}