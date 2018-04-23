using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace GridDataAttributes {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            gridView1.OptionsView.ShowGroupPanel = false;
            gridControl1.DataSourceChanged += gridControl1_DataSourceChanged;
        }

        void gridControl1_DataSourceChanged(object sender, EventArgs e) {
            gridControl1.MainView.PopulateColumns();
            (gridControl1.MainView as GridView).BestFitColumns();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            //gridControl1.DataSource = CompanyProductList.GetSampleData();
            //companyProductListBindingSource.DataSource = CompanyProductList.GetSampleData();
            //companyProductBindingSource.DataSource = CompanyProductList.GetSampleData();
        }

        private void barEditItem3_EditValueChanged(object sender, EventArgs e) {
            switch (barEditItem3.EditValue as string) {
                case "Company public info":
                    gridControl1.DataSource = GridSampleDataList.GetCompanyPublicInfo();
                    break;
                case "Company private info":
                    gridControl1.DataSource = GridSampleDataList.GetCompanyPrivateInfo();
                    break;
                case "Product info":
                    gridControl1.DataSource = GridSampleDataList.GetProductSample();
                    break;
            }
        }
    }
}
