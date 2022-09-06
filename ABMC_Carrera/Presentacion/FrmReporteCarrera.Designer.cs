namespace ABMC_Carrera.Presentacion
{
    partial class FrmReporteCarrera
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
            this.paReporteCarreraDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCarrera = new ABMC_Carrera.DataSetCarrera();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paReporteCarreraDetalleTableAdapter = new ABMC_Carrera.DataSetCarreraTableAdapters.paReporteCarreraDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.paReporteCarreraDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // paReporteCarreraDetalleBindingSource
            // 
            this.paReporteCarreraDetalleBindingSource.DataMember = "paReporteCarreraDetalle";
            this.paReporteCarreraDetalleBindingSource.DataSource = this.dataSetCarrera;
            // 
            // dataSetCarrera
            // 
            this.dataSetCarrera.DataSetName = "DataSetCarrera";
            this.dataSetCarrera.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCarreraaa";
            reportDataSource1.Value = this.paReporteCarreraDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Carrera.Presentacion.Reportes.RptCarrera.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // paReporteCarreraDetalleTableAdapter
            // 
            this.paReporteCarreraDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCarrera";
            this.Text = "FrmReporteCarrera";
            this.Load += new System.EventHandler(this.FrmReporteCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paReporteCarreraDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCarrera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paReporteCarreraDetalleBindingSource;
        private DataSetCarrera dataSetCarrera;
        private DataSetCarreraTableAdapters.paReporteCarreraDetalleTableAdapter paReporteCarreraDetalleTableAdapter;
    }
}