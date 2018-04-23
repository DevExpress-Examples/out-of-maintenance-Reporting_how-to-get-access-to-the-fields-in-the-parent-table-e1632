Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace GetValue
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub calculatedField1_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles calculatedField1.GetValue
			Dim view As DataRowView = TryCast(e.Row, DataRowView)
			e.Value = GetCurrentColumnValue("CategoryName") & " " & view.Row("UnitPrice")
		End Sub

	End Class
End Namespace
