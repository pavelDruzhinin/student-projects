using System;
using System.Globalization;
using System.Windows.Forms;

namespace PercentageCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var sum = Convert.ToInt32(firstSum.Text);
            var pr = Convert.ToInt32(procent.Text);
            var pm = Convert.ToInt32(monthContribution.Text);
            var nMonths = Convert.ToInt32(numberMonths.Text);


            for (var i = 0; i < nMonths; i++)
            {
                sum += pm + (sum * pr / 100);
            }

            total.Text = sum.ToString(CultureInfo.InvariantCulture);
        }
    }
}
