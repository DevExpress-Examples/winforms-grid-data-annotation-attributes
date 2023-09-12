Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace GridDataAttributes

    <MetadataType(GetType(CompanyProductMetadata))>
    Public Class CompanyPublicInfo

        Public Property CompanyName As String

        Public Property Country As String

        Public Property City As String

        Public Property Url As String

        Public Property Email As String

        Public Property Phone As String

        Public Property AdditionalInfo As String
    End Class

    <MetadataType(GetType(CompanyProductMetadata))>
    Public Class CompanyPrivateInfo

        Public Property Password As String

        Public Property Date2 As Date

        Public Property Sales As Double

        Public Property Profit As Double

        Public Property SalesVsTarget As Double

        Public Property MarketShare As Double

        Public Property CustomersSatisfaction As Double
    End Class

    Public Class Product

        <[ReadOnly](True)>
        Public Property UnitPrice As Double

        <EnumDataType(GetType(ProductCategory))>
        Public Property Category As Integer

        <Display(Description:="The amount of currently available product")>
        Public Property Quantity As Integer

        <DataType(DataType.Text), Display(Order:=-1)>
        Public Property Text As String

        <DataType(DataType.MultilineText)>
        Public Property MultilineText As String

        <DataType(DataType.Currency), Range(200, 5000)>
        Public Property Currency As Integer

        <DataType(DataType.Date)>
        Public Property [Date] As Date

        <DataType(DataType.Time)>
        Public Property Time As Date
    End Class

    Public Class CompanyProductMetadata

        <Display(ShortName:="Company", Name:="Company Name", AutoGenerateFilter:=False)>
        Public CompanyName As Object

        <Display(Order:=2)>
        Public Country As Object

        <Display(Order:=1), Editable(False)>
        Public City As Object

        <DataType(DataType.Url)>
        Public Url As Object

        <DataType(DataType.EmailAddress)>
        Public Email As Object

        <DataType(DataType.PhoneNumber), Required>
        Public Phone As Object

        <DataType(DataType.Text), Display(Order:=-1)>
        Public Text As Object

        <Display(AutoGenerateField:=False, Description:="This column isn't created")>
        Public AdditionalInfo As Object

        <DataType(DataType.Password), StringLength(20, MinimumLength:=3)>
        Public Password As Object

        <DisplayFormat(DataFormatString:="MMMM/yyyy"), Display(Name:="Date 2")>
        Public Date2 As Object

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Sales As Object

        <DisplayFormat(DataFormatString:="#,##0,,M")>
        Public Profit As Object

        <DisplayFormat(DataFormatString:="p", ApplyFormatInEditMode:=True), Display(Name:="Sales vs Target")>
        Public SalesVsTarget As Object

        <DisplayFormat(DataFormatString:="p0", ApplyFormatInEditMode:=False)>
        Public MarketShare As Object

        <Display(Name:="Cust Satisfaction")>
        Public CustomersSatisfaction As Object
    End Class

    Public Enum ProductCategory
        Beverages = 1
        Fruit = 2
        Vegetables = 3
        Meat = 4
        Condiments = 5
        Confections = 6
        DairyProducts = 7
        GrainsCereals = 8
        Seafood = 9
    End Enum

    Public Class GridSampleDataList

        Shared Public Function GetCompanyPrivateInfo() As List(Of CompanyPrivateInfo)
            Return New List(Of CompanyPrivateInfo) From {New CompanyPrivateInfo() With {.CustomersSatisfaction = 3.1, .Date2 = Date.Now, .MarketShare = 42, .Password = "123qwerty", .Profit = 4951515, .Sales = 311414134, .SalesVsTarget = 0.0277}}
        End Function

        Shared Public Function GetCompanyPublicInfo() As List(Of CompanyPublicInfo)
            Return New List(Of CompanyPublicInfo) From {New CompanyPublicInfo() With {.AdditionalInfo = "Some Info", .City = "Glendale", .CompanyName = "Developer Express", .Country = "USA", .Email = "info@devexpress.com", .Phone = "1234567890", .Url = "www.devexpress.com"}}
        End Function

        Shared Public Function GetProductSample() As List(Of Product)
            Return New List(Of Product) From {New Product() With {.Currency = 1000, .Category = 2, .[Date] = Date.Now, .MultilineText = "Line1" & Microsoft.VisualBasic.Constants.vbCrLf & "Line2" & Microsoft.VisualBasic.Constants.vbCrLf & "Line3", .Quantity = 321, .Text = "Sample Text", .Time = Date.Now, .UnitPrice = 1800}}
        End Function
    End Class
End Namespace
