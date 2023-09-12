Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Namespace GridDataAttributes

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            gridView1.OptionsView.ShowGroupPanel = False
            AddHandler gridControl1.DataSourceChanged, AddressOf gridControl1_DataSourceChanged
        End Sub

        Private Sub gridControl1_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.MainView.PopulateColumns()
            TryCast(gridControl1.MainView, GridView).BestFitColumns()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
        'gridControl1.DataSource = CompanyProductList.GetSampleData();
        'companyProductListBindingSource.DataSource = CompanyProductList.GetSampleData();
        'companyProductBindingSource.DataSource = CompanyProductList.GetSampleData();
        End Sub

        Private Sub barEditItem3_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case TryCast(barEditItem3.EditValue, String)
                Case "Company public info"
                    gridControl1.DataSource = GridSampleDataList.GetCompanyPublicInfo()
                Case "Company private info"
                    gridControl1.DataSource = GridSampleDataList.GetCompanyPrivateInfo()
                Case "Product info"
                    gridControl1.DataSource = GridSampleDataList.GetProductSample()
            End Select
        End Sub
    End Class
End Namespace
