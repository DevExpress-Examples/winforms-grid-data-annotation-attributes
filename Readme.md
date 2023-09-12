<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624108/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T162611)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Bind to a data source with Data Annotation attributes

This example demonstrates how to apply [Data Annotation attributes](https://docs.devexpress.com/WindowsForms/18273/common-features/data-binding/data-annotation-attributes) to a data source.

```csharp
public class Product {
    [ReadOnly(true)]
    public double UnitPrice { get; set; }
    [EnumDataType(typeof(ProductCategory))]
    public int Category { get; set; }
    [Display(Description = "The amount of currently available product")]
    public int Quantity { get; set; }
    [DataType(DataType.Text), Display(Order = -1)]
    public string Text { get; set; }
    [DataType(DataType.MultilineText)]
    public string MultilineText { get; set; }
    [DataType(DataType.Currency), Range(200, 5000)]
    public int Currency { get; set; }
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }
    [DataType(DataType.Time)]
    public DateTime Time { get; set; }
}
```


## Files to Review

* [DataSource.cs](./CS/GridDataAttributes/DataSource.cs) (VB: [DataSource.vb](./VB/GridDataAttributes/DataSource.vb))
* [Form1.cs](./CS/GridDataAttributes/Form1.cs) (VB: [Form1.vb](./VB/GridDataAttributes/Form1.vb))


## Documentation

* [Data Annotation Attributes](https://docs.devexpress.com/WindowsForms/18273/common-features/data-binding/data-annotation-attributes)
* [Tutorial: Create and Manage Data in Code and Apply Data Annotation Attributes](https://docs.devexpress.com/WindowsForms/114704/controls-and-libraries/data-grid/getting-started/walkthroughs/data-binding-and-working-with-columns/tutorial-create-and-manage-data-in-code-and-apply-data-annotation-attributes)
