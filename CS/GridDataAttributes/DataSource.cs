using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridDataAttributes {
    [MetadataType(typeof(CompanyProductMetadata))]
    public class CompanyPublicInfo {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AdditionalInfo { get; set; }
    }

    [MetadataType(typeof(CompanyProductMetadata))]
    public class CompanyPrivateInfo {
        public string Password { get; set; }
        public DateTime Date2 { get; set; }
        public double Sales { get; set; }
        public double Profit { get; set; }
        public double SalesVsTarget { get; set; }
        public double MarketShare { get; set; }
        public double CustomersSatisfaction { get; set; }
    }

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

    public class CompanyProductMetadata {
        [Display(ShortName = "Company", Name = "Company Name", AutoGenerateFilter = false)]
        public object CompanyName;
        [Display(Order = 2)]
        public object Country;
        [Display(Order = 1), Editable(false)]
        public object City;
        [DataType(DataType.Url)]
        public object Url;
        [DataType(DataType.EmailAddress)]
        public object Email;
        [DataType(DataType.PhoneNumber), Required]
        public object Phone;
        [DataType(DataType.Text), Display(Order = -1)]
        public object Text;
        [Display(AutoGenerateField = false, Description = "This column isn't created")]
        public object AdditionalInfo;
        [DataType(DataType.Password), StringLength(20, MinimumLength = 3)]
        public object Password;
        [DisplayFormat(DataFormatString = "MMMM/yyyy"), Display(Name = "Date 2")]
        public object Date2;
        [DisplayFormat(DataFormatString = "#,##0,,M")]
        public object Sales;
        [DisplayFormat(DataFormatString = "#,##0,,M")]
        public object Profit;
        [DisplayFormat(DataFormatString = "p", ApplyFormatInEditMode = true), Display(Name = "Sales vs Target")]
        public object SalesVsTarget;
        [DisplayFormat(DataFormatString = "p0", ApplyFormatInEditMode = false)]
        public object MarketShare;
        [Display(Name = "Cust Satisfaction")]
        public object CustomersSatisfaction;
    }

    public enum ProductCategory {
        Beverages = 1,
        Fruit = 2,
        Vegetables = 3,
        Meat = 4,
        Condiments = 5,
        Confections = 6,
        DairyProducts = 7,
        GrainsCereals = 8,
        Seafood = 9
    }

    public class GridSampleDataList {
        static public List<CompanyPrivateInfo> GetCompanyPrivateInfo() {
            return new List<CompanyPrivateInfo> {
                        new CompanyPrivateInfo() {
                            CustomersSatisfaction = 3.1,
                            Date2 = DateTime.Now,
                            MarketShare = 42,
                            Password = "123qwerty",
                            Profit = 4951515,
                            Sales = 311414134,
                            SalesVsTarget = 0.0277,
                        }
                    };
        }
        static public List<CompanyPublicInfo> GetCompanyPublicInfo() {
            return new List<CompanyPublicInfo> {
                        new CompanyPublicInfo() {
                            AdditionalInfo = "Some Info",
                            City = "Glendale",
                            CompanyName = "Developer Express",
                            Country = "USA",
                            Email = "info@devexpress.com",
                            Phone = "1234567890",
                            Url = "www.devexpress.com",
                        }
                    };
        }
        static public List<Product> GetProductSample() {
            return new List<Product> {
                        new Product() {
                            Currency = 1000,
                            Category = 2,
                            Date = DateTime.Now,
                            MultilineText = "Line1\r\nLine2\r\nLine3",
                            Quantity = 321,
                            Text = "Sample Text",
                            Time = DateTime.Now,
                            UnitPrice = 1800,
                        }
                    };
        }
    }
}
