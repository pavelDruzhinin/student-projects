using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CalculateOneMove.Helpers;

namespace CalculateOneMove
{
    public partial class Form1 : Form
    {
        private delegate decimal Operation(decimal d1, decimal d2);

        private readonly Dictionary<string, Operation> _operations;

        public Form1()
        {
            InitializeComponent();
            var calcHelper = new CalcHelper();
            _operations = new Dictionary<string, Operation>
            {
                {"+", calcHelper.Add},
                {"-",calcHelper.Subtract},
                {"*",calcHelper.Multiply},
                {"/",calcHelper.Divide}
            };
        }

        private void ClickBackSpace(TextBox textBox)
        {
            if (textBox.ReadOnly)
                return;

            var length = textBox.Text.Length;

            if (length <= 0)
                return;

            var str = textBox.Text.Remove(length - 1);

            textBox.Text = str;
        }

        private void ChangeSign(TextBox textBox)
        {
            //Для 1-ого слагаемого
            if (textBox.ReadOnly || textBox.Text == "" || textBox.Text == "0")
                return;

            var d = Convert.ToDouble(textBox.Text);

            d = -d;

            textBox.Text = Convert.ToString(d);
        }

        private void RunOperation(string op)
        {
            //Считывание информации из текстовых полей
            var s1 = textBox1.Text;
            var s2 = textBox3.Text;

            //Проверка содержимого текстовых полей
            if (s1 == "")
                s1 = "0";

            if (s2 == "")
                s2 = "0";

            //Перевод значений текстовых полей в цифровой тип 
            var d1 = Convert.ToDecimal(s1);
            var d2 = Convert.ToDecimal(s2);

            try
            {
                d1 = _operations[op](d1, d2);
            }
            catch (DivideNullException ex)
            {
                textBox2.Text = ex.Message;
            }

            textBox2.Text = Convert.ToString(d1);
            if (textBox2.TextLength > 16)
            {
                textBox2.Text = textBox2.Text.Remove(16);
            }
        }

        private string GetText(string str, string sCh, bool readOnly)
        {
            if (str.Length >= 15 || readOnly)
                return str;

            if (str == "0" || str == "")
                return sCh == "00" ? "0" : sCh;

            return str + sCh;
        }

        private void AddSeparate(TextBox textBox)
        {
            //Для 1-ого слагаемого
            if (textBox.ReadOnly)
                return;

            var s = textBox.Text;
            //Тип разделителя дробной части
            var sep = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

            if (s == "0" || s == "")
            {
                textBox.Text = "0" + sep;
                return;
            }

            if (s.All(x => x != sep[0]))
            {
                textBox.Text = s + sep;
            }
        }

        //Функция вставки числа в поле ввода
        private void VstChisla(string sCh1)
        {
            textBox1.Text = GetText(textBox1.Text, sCh1, textBox1.ReadOnly);
            textBox3.Text = GetText(textBox3.Text, sCh1, textBox3.ReadOnly);
        }

        //Кнопка сложения "+"
        private void AddOpertion_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button == null)
                return;

            label1.Text = button.Text;
            if (textBox1.ReadOnly)
                return;

            textBox1.ReadOnly = true;
            textBox3.ReadOnly = false;
        }

        //Возможность ввода при клике в первое текстовое поле
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ReadOnly = false;
            textBox3.ReadOnly = true;
        }

        //Возможность ввода при клике в второе текстовое поле
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = false;
        }

        //Кнопка "1"
        private void InsertDigit_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button == null) 
                return;

            var text = button.Text;

            VstChisla(text);
        }

        //Кнопка "="
        private void button18_Click(object sender, EventArgs e)
        {
            RunOperation(label1.Text);
        }

        //Кнопка "+/-"
        private void button15_Click(object sender, EventArgs e)
        {
            ChangeSign(textBox1);
            ChangeSign(textBox3);
        }

        //Кнопка ","
        private void button14_Click(object sender, EventArgs e)
        {
            AddSeparate(textBox1);
            AddSeparate(textBox3);
        }

        //Начальное задание значений
        private void Form1_Load(object sender, EventArgs e)
        {
            //Для текстовых полей
            const string n = "0";
            textBox1.Text = n;
            textBox2.Text = n;
            textBox3.Text = n;

            //Подключаем ввод цифр
            textBox1.KeyPress += this.textBox_KeyPress;
            textBox3.KeyPress += this.textBox_KeyPress;
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.PageDown)
                return;

            textBox1.ReadOnly = true;
            textBox3.ReadOnly = false;
        }
        //Разрешаем ввод только цифр
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Если пользователь с клавиатуры вводить буквы
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;

            e.Handled = true;
            textBox2.Text = "только цифры";
        }

        //Копирование 1 во 2
        private void из1Во2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }
        //Копирование 2 во 1
        private void из2В1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox3.Text;
        }
        //Кнопка "Очистить"
        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox1.ReadOnly = false;
            textBox3.Text = "0";
            textBox2.Text = "0";
            textBox1.Text = "0";
            label1.Text = "+";
        }

        //Кнопка "Справка"-->"О программе"
        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new About();
            frm.ShowDialog();
        }
        //Кнопка "Справка"-->"Помощь"
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Help();
            frm.Show();
        }
        //Кнопка "Fact"
        private void button19_Click(object sender, EventArgs e)
        {
            double i = 1, fact = 1;

            if (textBox1.ReadOnly)
                return;

            if ((textBox1.Text == "") || (textBox1.Text == "0"))
                return;

            var n = Convert.ToDouble(textBox1.Text);
            if (n < 20)
            {
                while (i <= n)
                {
                    fact = fact * i;
                    i = i + 1;
                }
                label1.Text = "n!";
                textBox2.Text = Convert.ToString(fact);
            }
            else
            {
                textBox2.Text = "считаем до 19";
            }
        }
        //Кнопка "→"
        private void button20_Click(object sender, EventArgs e)
        {
            ClickBackSpace(textBox1);
            ClickBackSpace(textBox3);
        }
        //"sqrt"
        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            var dSqrt = Convert.ToDouble(textBox1.Text);
            dSqrt = Math.Sqrt(dSqrt);
            label1.Text = "sqrt";
            textBox2.Text = Convert.ToString(dSqrt);
        }
        //"pow"
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
                return;

            var dPow = Convert.ToDouble(textBox1.Text);
            var dStep = Convert.ToDouble(textBox3.Text);
            dPow = Math.Pow(dPow, dStep);
            label1.Text = "pow";
            textBox2.Text = Convert.ToString(dPow);
        }
        //"exp"
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            var dExp = Convert.ToDouble(textBox1.Text);
            dExp = Math.Exp(dExp);
            label1.Text = "exp";
            textBox2.Text = Convert.ToString(dExp);
        }
        //"log"
        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            var dLog = Convert.ToDouble(textBox1.Text);
            dLog = Math.Log(dLog);
            label1.Text = "log";
            textBox2.Text = Convert.ToString(dLog);
        }
        //"Выход"
        private void выходToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}