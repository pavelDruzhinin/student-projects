using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class Korni : Form
    {
        public Korni()
        {
            InitializeComponent();
        }
        public string stR(double x1)
        {
            var str = Convert.ToString(x1);
            return str.Remove(6);
        }

        public string Show(double x1)
        {
            return "\r\n" + "x1 = " + stR(x1);
        }
        public string Show(double x1, double x2)
        {
            return "\r\n" + "x1 = " + stR(x1) + "\r\n" + "x2 = " + stR(x2);
        }
        private void Calc_Click(object sender, EventArgs e)
        {
            double x2 = 0;

            try
            {
                try
                {
                    var a = Convert.ToDouble(aBox.Text);
                    var b = Convert.ToDouble(bBox.Text);
                    var c = Convert.ToDouble(cBox.Text);
                    if (a == 0 && b == 0 && c == 0)
                    {
                        infBox.Text = "Введи уже что-нибудь я вся горю от нетерпения!";
                    }
                    else
                    {
                        double x1;
                        if (a == 0 && b != 0 && c != 0)
                        {
                            x1 = -(c / b);
                            infBox.Text = "a = 0" + "\r\n"
                                          + "Cледовательно решением уравнения:" + "\r\n"
                                          + b + "*x + " + c + " = 0" + "\r\n"
                                          + "будет один корень"
                                          + Show(x1);
                        }
                        else if (a != 0 && b == 0 && c != 0)
                        {
                            x1 = Math.Sqrt(c / a);
                            x2 = -x1;
                            infBox.Text = "b = 0" + "\r\n"
                                          + "Cледовательно решением уравнения вида:" + "\r\n"
                                          + a + "*x*x + " + c + " = 0" + "\r\n"
                                          + "будет два корня" + Show(x1, x2);
                        }
                        else if (a != 0 && b != 0 && c == 0)
                        {
                            x1 = -(b / a);
                            infBox.Text = "c = 0" + "\r\n"
                                          + "Cледовательно решением уравнения вида:" + "\r\n"
                                          + a + "*x*x + " + b + "*x = 0" + "\r\n"
                                          + "будет два корня" + Show(x1, x2);
                        }
                        else
                        {
                            var d = b * b - 4 * a * c;

                            if (d > 0)
                            {
                                d = Math.Sqrt(d);
                                x1 = (-b - d) / (2 * a);
                                x2 = (-b + d) / (2 * a);
                                infBox.Text = "Дискриминант = " + d + " и он больше 0, следовательно есть два корня" + Show(x1, x2);
                            }
                            if (d == 0)
                            {
                                x1 = (-(b) / (2 * a));
                                infBox.Text = "Дискриминант = 0, следовательно есть два корня" + Show(x1, x2);
                            }
                            if (d < 0)
                            {
                                infBox.Text = "Дискриминант = " + d + " и он меньше 0, следовательно корней нет!";
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    infBox.Text = "Введи уже что-нибудь я вся горю от нетерпения!";
                }
            }

            catch (Exception exc)
            {

                MessageBox.Show("Непредвиденная ошибка!" + "\r\n" + "\r\n" + exc + "\r\n" + "\r\n"
                    + "Большая просьба обратиться в техподдержку по электронному адресу:" + "\r\n"
                    + "paveldsirius@gmail.com", "Все таки сломал!");
            }
        }
        public void Univ_Press(object sender, KeyPressEventArgs e)
        {
            // разрешаем цифры (и "Delete" как ни странно)
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // разрешаем "Backspace" 
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            //Проверяем количество введенных символов и разрешаем ввод "-"
            if (((TextBox)sender).Text.Length == 0 && e.KeyChar == Convert.ToChar("-"))
            {
                e.Handled = false;
            }
        }

        private void Univ_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aBox.Focus();
        }
    }
}
