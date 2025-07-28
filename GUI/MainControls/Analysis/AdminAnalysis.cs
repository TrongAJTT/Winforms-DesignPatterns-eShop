using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3S_eShop.PatternDistinctive.Builder;

namespace _3S_eShop.GUI.MainControls.Analysis
{
    public partial class AdminAnalysis: UserControl
    {
        private static byte VALUE_WEEK = 1, 
            VALUE_MONTH = 2, VALUE_QUARTER = 3, 
            VALUE_HALF_YEAR = 4, VALUE_YEAR = 5;

        public AdminAnalysis()
        {
            InitializeComponent();
        }

        private void AdminAnalysis_Load(object sender, EventArgs e)
        {
            cboTarget.Items.AddRange(new string[]
            {
                "Doanh số, doanh thu"
            });
            cboTime.Items.AddRange(new string[]
            {
                "Theo tuần",
                "Theo tháng",
                "Theo quý",
                "Theo nửa năm",
                "Theo năm"
            });
            cboTarget.SelectedIndex = 0;
            cboTime.SelectedIndex = 0;
        }

        private string BuildSalesReport(int timeValue)
        {
            string report = "";

            var query = new PagingQueryBuilder("Orders", "created_at", "id", true)
                .SetSelect("SUM(total_price) AS total_price")
                //.AddGroupBy("YEAR(created_at), MONTH(created_at)")
                //.AddOrderBy("created_at", "DESC")
                //.AddLimit(1)
                .Build();
            return report;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BuildSalesReport(1);
        }
    }
}
