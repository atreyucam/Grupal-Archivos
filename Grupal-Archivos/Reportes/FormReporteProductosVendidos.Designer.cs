namespace Grupal_Archivos.Reportes
{
    partial class FormReporteProductosVendidos
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
            this.tablaCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTienda = new Grupal_Archivos.DataSetTienda();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TablaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCompraBindingSource1
            // 
            this.tablaCompraBindingSource1.DataMember = "TablaCompra";
            this.tablaCompraBindingSource1.DataSource = this.dataSetTienda;
            // 
            // dataSetTienda
            // 
            this.dataSetTienda.DataSetName = "DataSetTienda";
            this.dataSetTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaCompraBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grupal_Archivos.Reportes.ReportProductosVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1361, 1165);
            this.reportViewer1.TabIndex = 0;
            // 
            // TablaCompraBindingSource
            // 
            this.TablaCompraBindingSource.DataMember = "TablaCompra";
            this.TablaCompraBindingSource.DataSource = this.dataSetTienda;
            // 
            // FormReporteProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 1165);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReporteProductosVendidos";
            this.Text = "FormReporteProductosVendidos";
            this.Load += new System.EventHandler(this.FormReporteProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetTienda dataSetTienda;
        private System.Windows.Forms.BindingSource tablaCompraBindingSource1;
        private System.Windows.Forms.BindingSource TablaCompraBindingSource;
    }
}