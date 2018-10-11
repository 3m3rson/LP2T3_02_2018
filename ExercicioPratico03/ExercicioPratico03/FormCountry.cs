using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPratico03
{
    public partial class FormCountry : Form
    {
        Dictionary<string, CountrySales> data = null;

        public FormCountry(Dictionary<string, CountrySales> data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(txtFilter.Text);
        }

        private void FormCountry_Load(object sender, EventArgs e)
        {
            Fill("");
        }
        private void Fill(string filter)
        {
            dgvSales.Rows.Clear();
            foreach (CountrySales a in data.Values)
                if (filter == "" || a.Name.ToUpper().Contains(filter.ToUpper()))
                    dgvSales.Rows.Add(a.Name, a.TotalRevenue.ToString("C"));
            Console.Read();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            CountrySales most = data.Values.ToList()[0], min = data.Values.ToList()[0];
            double total = 0;
            foreach(CountrySales c in data.Values)
            {
                if (most.TotalRevenue <= c.TotalRevenue)
                    most = c;
                if (min.TotalRevenue >= c.TotalRevenue)
                    min = c;
                total += c.TotalRevenue;
            }
            MessageBox.Show("Bigger seller: " + most.Name + " Total " + most.TotalRevenue.ToString("C") + "\n"+
                "Worst seller: " + min.Name + " Total " + min.TotalRevenue.ToString("C") + "\n" +
                "Global revenue: " + total.ToString("C"));
        }
    }
}
