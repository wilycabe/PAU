
namespace CapaDiseño.Reportes.Form_Reportes_Secundarios
{
    partial class FormReporteEncomienda_Pen
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
            this.dataSetPrincipal = new CapaDiseño.Reportes.Form_Reportes_Secundarios.DataSetPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_encomienda_pendienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_encomienda_pendienteTableAdapter = new CapaDiseño.Reportes.Form_Reportes_Secundarios.DataSetPrincipalTableAdapters.Reporte_encomienda_pendienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_encomienda_pendienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetPrincipal
            // 
            this.dataSetPrincipal.DataSetName = "DataSetPrincipal";
            this.dataSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSEncomiendas_pen";
            reportDataSource1.Value = this.Reporte_encomienda_pendienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaDiseño.Reportes.RDLC.Encomienda_Pen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // Reporte_encomienda_pendienteBindingSource
            // 
            this.Reporte_encomienda_pendienteBindingSource.DataMember = "Reporte_encomienda_pendiente";
            this.Reporte_encomienda_pendienteBindingSource.DataSource = this.dataSetPrincipal;
            // 
            // Reporte_encomienda_pendienteTableAdapter
            // 
            this.Reporte_encomienda_pendienteTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteEncomienda_Pen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteEncomienda_Pen";
            this.Text = "Reporte de Encomienda Pendientes";
            this.Load += new System.EventHandler(this.FormReporteEncomienda_Pen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_encomienda_pendienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetPrincipal dataSetPrincipal;
        private System.Windows.Forms.BindingSource Reporte_encomienda_pendienteBindingSource;
        private DataSetPrincipalTableAdapters.Reporte_encomienda_pendienteTableAdapter Reporte_encomienda_pendienteTableAdapter;
    }
}