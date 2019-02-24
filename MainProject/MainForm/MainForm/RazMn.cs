using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class RazMn : Form
    {
        public RazMn()
        {
            InitializeComponent();
        }

        private void mnoz_Click(object sender, EventArgs e)
        {
            try
            {
                var str = "";

                if (digitBox.Text != "")
                {
                    var digit = Convert.ToDouble(digitBox.Text);
                    for (var i = 2; i <= digit; i++)
                    {
                        if (digit % i == 0)
                        {
                            str += i + "*";
                            digit /= i;
                            i = 1;
                        }
                        else if ((i == digit) && (str.Length != 0) && (digit > 11))
                        {
                            str += digit;
                        }
                        else if ((i == digit) && (str.Length == 0))
                        {
                            str = Convert.ToString(digit);
                        }
                    }
                    if ((str.Length - 1 > 0) && str[str.Length - 1] == '*')
                        str = str.Remove(str.Length - 1);
                }
                infBox.Text += digitBox.Text + " = " + str + "\r\n ";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Произошла ошибка!");
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
            digitBox.Text = "";
        }
    }
}