using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExercicioPratico03
{
    public partial class Form1 : Form
    {
        List<AppSalesData> data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void Fill(string filter)
        {
            if(data == null)
                data = DataLoader.Load();

            dgvSales.Rows.Clear();
            foreach (AppSalesData a in data)
                if(filter == "" || a.CompanyName.ToUpper().Contains(filter.ToUpper()) || a.AppName.ToUpper().Contains(filter.ToUpper()) || a.CompanyCountry.ToUpper().Contains(filter.ToUpper()))
                dgvSales.Rows.Add(a.AppCode, a.AppName, a.Price.ToString("C"), a.Downloads, (a.Price * a.Downloads).ToString("C") , a.CompanyName, a.CompanyCountry);
            Console.Read();
        }


        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(txtFilter.Text);
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FormCompany form = new FormCompany(SummarizeSalesByCompany(data));
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);

        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            FormCountry form = new FormCountry(SummarizeSalesByCountry(data));
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private Dictionary<long, CompanySales> SummarizeSalesByCompany(List<AppSalesData> data)
        {
            Dictionary<long, CompanySales> result = new Dictionary<long, CompanySales>();
            foreach (AppSalesData a in data)
                if (result.ContainsKey(a.CompanyId))
                    result[a.CompanyId].TotalRevenue += a.Downloads * a.Price;
                else
                {
                    CompanySales c = new CompanySales(a.CompanyId, (a.Downloads * a.Price), a.CompanyName, a.CompanyCountry);
                    result.Add(c.Id, c);

                }
            return result;
        }

        private Dictionary<string, CountrySales> SummarizeSalesByCountry(List<AppSalesData> data)
        {
            Dictionary<string, CountrySales> result = new Dictionary<string, CountrySales>();
            foreach (AppSalesData a in data)
                if (result.ContainsKey(a.CompanyCountry))
                    result[a.CompanyCountry].TotalRevenue += a.Downloads * a.Price;
                else
                {
                    CountrySales c = new CountrySales(a.CompanyCountry, (a.Downloads * a.Price));
                    result.Add(c.Name, c);

                }
            return result;
        }
    }
}
