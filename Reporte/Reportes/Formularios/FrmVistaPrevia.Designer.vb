﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BdHRDataSet = New Reporte.BdHRDataSet()
        Me.jobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.jobsTableAdapter = New Reporte.BdHRDataSetTableAdapters.jobsTableAdapter()
        Me.JobsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BdHRDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.JobsBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reporte.rptCargo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'BdHRDataSet
        '
        Me.BdHRDataSet.DataSetName = "BdHRDataSet"
        Me.BdHRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'jobsBindingSource
        '
        Me.jobsBindingSource.DataMember = "jobs"
        Me.jobsBindingSource.DataSource = Me.BdHRDataSet
        '
        'jobsTableAdapter
        '
        Me.jobsTableAdapter.ClearBeforeFill = True
        '
        'JobsBindingSource1
        '
        Me.JobsBindingSource1.DataMember = "jobs"
        Me.JobsBindingSource1.DataSource = Me.BdHRDataSet
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "FrmVistaPrevia"
        CType(Me.BdHRDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents jobsBindingSource As BindingSource
    Friend WithEvents BdHRDataSet As BdHRDataSet
    Friend WithEvents jobsTableAdapter As BdHRDataSetTableAdapters.jobsTableAdapter
    Friend WithEvents JobsBindingSource1 As BindingSource
End Class
