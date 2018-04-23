Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GridDataAttributes
    <MetadataType(GetType(CompanyProductMetadata))> _
    Public Class CompanyPublicInfo
        Public Property CompanyName() As String
        Public Property Country() As String
        Public Property City() As String
        Public Property Url() As String
        Public Property Email() As String
        Public Property Phone() As String
        Public Property AdditionalInfo() As String
    End Class

    <MetadataType(GetType(CompanyProductMetadata))> _
    Public Class CompanyPrivateInfo
        Public Property Password() As String
        Public Property Date2() As Date
        Public Property Sales() As Double
        Public Property Profit() As Double
        Public Property SalesVsTarget() As Double
        Public Property MarketShare() As Double
        Public Property CustomersSatisfaction() As Double
    End Class

    Public Class Product
        <[ReadOnly](True)> _
        Public Property UnitPrice() As Double
        <EnumDataType(GetType(ProductCategory))> _
        Public Property Category() As Integer
        <Display(Description := "The amount of currently available product")> _
        Public Property Quantity() As Integer
        <DataType(DataType.Text), Display(Order := -1)> _
        Public Property Text() As String
        <DataType(DataType.MultilineText)> _
        Public Property MultilineText() As String
        <DataType(DataType.Currency), Range(200, 5000)> _
        Public Property Currency() As Integer
        <DataType(DataType.Date)> _
        Public Property [Date]() As Date
        <DataType(DataType.Time)> _
        Public Property Time() As Date
    End Class

    Public Class CompanyProductMetadata
        <Display(ShortName := "Company", Name := "Company Name", AutoGenerateFilter := False)> _
        Public CompanyName As Object
        <Display(Order := 2)> _
        Public Country As Object
        <Display(Order := 1), Editable(False)> _
        Public City As Object
        <DataType(DataType.Url)> _
        Public Url As Object
        <DataType(DataType.EmailAddress)> _
        Public Email As Object
        <DataType(DataType.PhoneNumber), Required> _
        Public Phone As Object
        <DataType(DataType.Text), Display(Order := -1)> _
        Public Text As Object
        <Display(AutoGenerateField := False, Description := "This column isn't created")> _
        Public AdditionalInfo As Object
        <DataType(DataType.Password), StringLength(20, MinimumLength := 3)> _
        Public Password As Object
        <DisplayFormat(DataFormatString := "MMMM/yyyy"), Display(Name := "Date 2")> _
        Public Date2 As Object
        <DisplayFormat(DataFormatString := "#,##0,,M")> _
        Public Sales As Object
        <DisplayFormat(DataFormatString := "#,##0,,M")> _
        Public Profit As Object
        <DisplayFormat(DataFormatString := "p", ApplyFormatInEditMode := True), Display(Name := "Sales vs Target")> _
        Public SalesVsTarget As Object
        <DisplayFormat(DataFormatString := "p0", ApplyFormatInEditMode := False)> _
        Public MarketShare As Object
        <Display(Name := "Cust Satisfaction")> _
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
        Public Shared Function GetCompanyPrivateInfo() As List(Of CompanyPrivateInfo)
            Return New List(Of CompanyPrivateInfo) From { _
                New CompanyPrivateInfo() With {.CustomersSatisfaction = 3.1, .Date2 = Date.Now, .MarketShare = 42, .Password = "123qwerty", .Profit = 4951515, .Sales = 311414134, .SalesVsTarget = 0.0277} _
            }
        End Function
        Public Shared Function GetCompanyPublicInfo() As List(Of CompanyPublicInfo)
            Return New List(Of CompanyPublicInfo) From { _
                New CompanyPublicInfo() With {.AdditionalInfo = "Some Info", .City = "Glendale", .CompanyName = "Developer Express", .Country = "USA", .Email = "info@devexpress.com", .Phone = "1234567890", .Url = "www.devexpress.com"} _
            }
        End Function
        Public Shared Function GetProductSample() As List(Of Product)
            Return New List(Of Product) From { _
                New Product() With {.Currency = 1000, .Category = 2, .Date = Date.Now, .MultilineText = "Line1" & ControlChars.CrLf & "Line2" & ControlChars.CrLf & "Line3", .Quantity = 321, .Text = "Sample Text", .Time = Date.Now, .UnitPrice = 1800} _
            }
        End Function
    End Class
End Namespace
