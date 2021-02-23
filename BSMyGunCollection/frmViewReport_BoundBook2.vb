﻿Imports BSMyGunCollection.MGC
Imports Microsoft.Reporting.WinForms
Public Class frmViewReport_BoundBook2
    Public BySorting As String
    Public IsFirstRun As Boolean
    Sub LoadData()
        Try
            Dim ReportTitle As String = ToolStripTextBox1.Text
            Dim parmList As New Generic.List(Of ReportParameter)
            parmList.Add(New ReportParameter("UserName", OwnerName))
            parmList.Add(New ReportParameter("ReportTitle", ReportTitle))
            parmList.Add(New ReportParameter("License", OwnerLIC))
            Me.ReportViewer1.LocalReport.SetParameters(parmList)
            Select Case LCase(UCase(ToolStripComboBox1.SelectedItem.ToString))
                Case LCase("Custom Catalog No.")
                    Me.BoundBooksTableAdapter.FillByCustomID(Me.MGCDataSet.BoundBooks)
                Case LCase("Purchase Date")
                    Me.BoundBooksTableAdapter.FillByPurchaseDate(Me.MGCDataSet.BoundBooks)
                Case LCase("C & R Only")
                    Me.BoundBooksTableAdapter.FillByCAndR(Me.MGCDataSet.BoundBooks)
                Case LCase("Brand")
                    Me.BoundBooksTableAdapter.FillByBrand(Me.MGCDataSet.BoundBooks)
                Case LCase("Type")
                    Me.BoundBooksTableAdapter.FillByType(Me.MGCDataSet.BoundBooks)
                Case LCase("Caliber")
                    Me.BoundBooksTableAdapter.FillByCaliber(Me.MGCDataSet.BoundBooks)
                Case LCase("Gun Shop")
                    Me.BoundBooksTableAdapter.FillByGun_Shop_Name(Me.MGCDataSet.BoundBooks)
                Case LCase("Class III")
                    Me.BoundBooksTableAdapter.FillBy_ClassIII(Me.MGCDataSet.BoundBooks)
                Case Else
                    Me.BoundBooksTableAdapter.Fill(Me.MGCDataSet.BoundBooks)
            End Select
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            Dim sSubFunc As String = "LoadData"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Call LoadData()
    End Sub

    Private Sub frmViewReport_BoundBook2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ToolStripTextBox1.Text = "Firearms Acquisition and Disposition Records"
            Me.ReportViewer1.RefreshReport()
            Call LoadData()
            ReportViewer1.Cursor = Cursors.Arrow
        Catch ex As Exception
            Dim sSubFunc As String = "Load"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
        IsFirstRun = False
    End Sub
    Public Sub New()
        IsFirstRun = True
        InitializeComponent()
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Try
            If Not IsFirstRun Then Call LoadData()
        Catch ex As Exception
            Dim sSubFunc As String = "ToolStripComboBox1_SelectedIndexChanged"
            Call LogError(Me.Name, sSubFunc, Err.Number, ex.Message.ToString)
        End Try
    End Sub
End Class