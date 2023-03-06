using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToroslarCam.App.WinForm.Pages;
using ToroslarCam.Domain.Entities;
using ToroslarCam.Domain.Repositories;

namespace ToroslarCam.App.WinForm
{
    public partial class MainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void barBtnAddOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            var rep = new OrderRepository();
            rep.Add(new Domain.Entities.Order
            {
                Description = "Falanca Pen",
                Id = "2222",
                OrderCode = "0002",
                OrderDate = DateTime.Now
            });
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var rep = new OrderRepository();
            var data = rep.GetById("2222");


            Report1 report = new Report1();
            report.DataSource = new List<Order>{ data };
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();

        }
    }
}