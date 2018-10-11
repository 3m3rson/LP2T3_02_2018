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
    public partial class FormCompany : Form
    {
        Dictionary<long, CompanySales> data = null; 

        public FormCompany(Dictionary<long, CompanySales> data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            Fill("");
        }

        private void Fill(string filter)
        {
            dgvSales.Rows.Clear();
            foreach (CompanySales a in data.Values)
                if (filter == "" || a.Name.ToUpper().Contains(filter.ToUpper()) || a.Country.ToUpper().Contains(filter.ToUpper()))
                    dgvSales.Rows.Add(a.Id,  a.Name, a.Country, a.TotalRevenue.ToString("C"));
            Console.Read();
        }


        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            Fill(txtFilter.Text);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            CompanySales most = data.Values.ToList()[0], min = data.Values.ToList()[0];
            double total = 0;
            foreach (CompanySales c in data.Values)
            {
                if (most.TotalRevenue <= c.TotalRevenue)
                    most = c;
                if (min.TotalRevenue >= c.TotalRevenue)
                    min = c;
                total += c.TotalRevenue;
            }
            MessageBox.Show("Bigger seller: " + most.Name + " Total " + most.TotalRevenue.ToString("C") + "\n" +
                "Worst seller: " + min.Name + " Total " + min.TotalRevenue.ToString("C") + "\n" +
                "Global revenue: " + total.ToString("C"));
        }
    }
}
