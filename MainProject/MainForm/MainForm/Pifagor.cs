using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class Pifagor : Form
    {
        public Pifagor()
        {
            InitializeComponent();
        }
        
        //Вычисление значений катетов и гипотенузы по теореме Пифагора
        public void Formula(TextBox ob, TextBox ob1, TextBox ob2, TextBox ob3, string s)
        {
            try
            {
                var c = Convert.ToDouble(ob.Text);
                var a = Convert.ToDouble(ob1.Text);
                double b;
                if (s == "-")
                {
                    if (c > a)
                    {
                        b = c * c - a * a;
                    }
                    else
                    {
                        MessageBox.Show("Гипотенуза меньше катета!", "Ошибка!");
                        b = 0;
                    }
                }
                else if (s == "+")
                {
                    b = c * c + a * a;
                }
                else
                {
                    b = 0;
                }
                ob2.Text = "√" + Convert.ToString(b);

                b = Math.Sqrt(b);

                ob3.Text = Convert.ToString(b);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы не ввели число!", "Ошибка!"); 
            }
        }
        //Вычислить гипотенузу
        private void Addit_Click(object sender, EventArgs e)
        {
            Formula(aText, bText, korText, cText, "+");
        }
        //Вычислить разность гипотенузы и катета
        private void Substr_Click(object sender, EventArgs e)
        {
            Formula(cText2, aText2, korText2, bText2, "-");
        }
        //Кнопка "Закрыть"
        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Разрешение на ввод только цифр для текстбоксов
        private void Univ_Press(object sender, KeyPressEventArgs e)
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
        }
        //Обнуление текстбоксов
        private void Univ_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).Text = null;
        }

        private void Pifagor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            /*MathSoLution.MathSoLution MSL = new MathSoLution.MathSoLution();
            MSL.Close();*/
        }
    }
}
