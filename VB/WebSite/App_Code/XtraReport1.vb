Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
	Private xrTable1 As XRTable
	Private xrTableRow1 As XRTableRow
	Private xrTableCell1 As XRTableCell
	Private xrTableCell2 As XRTableCell
	Private xrTableCell3 As XRTableCell
	Private xrTableCell4 As XRTableCell
	Private dataSet11 As DataSet1
	Private custOrdersOrdersTableAdapter1 As DataSet1TableAdapters.CustOrdersOrdersTableAdapter
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New(ByVal customerID As String)
		InitializeComponent()
		Me.custOrdersOrdersTableAdapter1.Fill(Me.dataSet11.CustOrdersOrders, customerID)
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
		Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.dataSet11 = New DataSet1()
		Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
		Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
		Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
		Me.custOrdersOrdersTableAdapter1 = New DataSet1TableAdapters.CustOrdersOrdersTableAdapter()
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
		Me.Detail.Height = 23
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' PageHeader
		' 
		Me.PageHeader.Height = 30
		Me.PageHeader.Name = "PageHeader"
		Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' PageFooter
		' 
		Me.PageFooter.Height = 30
		Me.PageFooter.Name = "PageFooter"
		Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' dataSet11
		' 
		Me.dataSet11.DataSetName = "DataSet1"
		Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' xrTable1
		' 
		Me.xrTable1.Location = New System.Drawing.Point(0, 0)
		Me.xrTable1.Name = "xrTable1"
		Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
		Me.xrTable1.Size = New System.Drawing.Size(646, 23)
		' 
		' xrTableRow1
		' 
		Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4})
		Me.xrTableRow1.Name = "xrTableRow1"
		Me.xrTableRow1.Size = New System.Drawing.Size(646, 23)
		' 
		' xrTableCell1
		' 
		Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersOrders.OrderDate", "")})
		Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
		Me.xrTableCell1.Name = "xrTableCell1"
		Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrTableCell1.Size = New System.Drawing.Size(162, 23)
		Me.xrTableCell1.Text = "xrTableCell1"
		' 
		' xrTableCell2
		' 
		Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersOrders.OrderID", "")})
		Me.xrTableCell2.Location = New System.Drawing.Point(162, 0)
		Me.xrTableCell2.Name = "xrTableCell2"
		Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrTableCell2.Size = New System.Drawing.Size(162, 23)
		Me.xrTableCell2.Text = "xrTableCell2"
		' 
		' xrTableCell3
		' 
		Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersOrders.RequiredDate", "")})
		Me.xrTableCell3.Location = New System.Drawing.Point(324, 0)
		Me.xrTableCell3.Name = "xrTableCell3"
		Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrTableCell3.Size = New System.Drawing.Size(162, 23)
		Me.xrTableCell3.Text = "xrTableCell3"
		' 
		' xrTableCell4
		' 
		Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersOrders.ShippedDate", "")})
		Me.xrTableCell4.Location = New System.Drawing.Point(486, 0)
		Me.xrTableCell4.Name = "xrTableCell4"
		Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrTableCell4.Size = New System.Drawing.Size(160, 23)
		Me.xrTableCell4.Text = "xrTableCell4"
		' 
		' custOrdersOrdersTableAdapter1
		' 
		Me.custOrdersOrdersTableAdapter1.ClearBeforeFill = True
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
		Me.DataMember = "CustOrdersOrders"
		Me.DataSource = Me.dataSet11
		CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
