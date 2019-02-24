using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class Cosinus : Form
    {
        public Cosinus()
        {
            InitializeComponent();
        }

        private string Angle(string s, double angle)
        {
            return s + "(" + angle + ") = ";
        }

        private void univ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void angleSub_Click(object sender, EventArgs e)
        {
            try
            {
                var angle = Convert.ToDouble(angleBox.Text);
                var radian = angle * (Math.PI / 180);
                switch (comboTrig.Text)
                {
                    case "sin":
                        infBox.Text = Angle("sin", angle) + Math.Sin(radian);
                        break;
                    case "cos":
                        infBox.Text = Angle("cos", angle) + Math.Cos(radian);
                        break;
                    case "tg":
                        infBox.Text = Angle("tg", angle) + Math.Tan(radian);
                        break;
                    case "ctg":
                        infBox.Text = Angle("ctg", angle) + (Math.Cos(radian) / Math.Sin(radian));
                        break;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error!");
            }
        }

        private void Cosinus_Load(object sender, EventArgs e)
        {
            /*   Cosinus os = new Cosinus();
               os.Location.X = 1;
               os.Location.Y = 1;*/
        }
    }
}
