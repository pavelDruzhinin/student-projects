using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class Nod : Form
    {
        public Nod()
        {
            InitializeComponent();
        }

        private void mnoz_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                var x = a = Convert.ToDouble(aBox.Text);
                var y = b = Convert.ToDouble(bBox.Text);
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

                var r = a;
                double q = 1;
                while (r >= b)
                {
                    r = a - (b * q);
                    q++;
                }
                for (var i = 0; ; i++)
                {
                    if (r != 0)
                    {
                        a = b;
                        b = r;
                        q = 1;
                        while (r >= b)
                        {
                            r = a - (b * q);
                            q++;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                infBox.Text = "NOD("+x+","+y+") = "+b;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }
        }

        private void Univ_Press(object sender, KeyPressEventArgs e)
        {
            //Если пользователь с клавиатуры вводить буквы
            if (!(char.IsDigit(e.KeyChar)))
            {
                //Не блокируем backspace
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        private void digitBox_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }
    }
}