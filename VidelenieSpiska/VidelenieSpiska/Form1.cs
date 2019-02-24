using System;
using System.Windows.Forms;

namespace VidelenieSpiska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Кнопка "Найти"
        private void button1_Click(object sender, EventArgs e)
        {
            //Переменная для вывода количества выделенных слов
            var kol = 0;

            //Считывание инфо из текстовой строки
            var s = textBox1.Text;

            //Перевод буквы в верхний регистр
            s = s.ToUpper();

            //Сравнивание первой буквы слов списка с 
            //буквой текстовой строки и выделение совпадающего слова
            for (var i = 0; i < listBox1.Items.Count; i++)
            {
                var k = listBox1.Items[i].ToString();
                if (s[0] == k[0])
                {
                    listBox1.SetSelected(i, true);
                    kol = kol + 1;
                }
                else
                {
                    listBox1.SetSelected(i, false);
                }
            }

            //Вывод количества выделенных слов 
            if (kol > 0)
            {
                label1.Text = Convert.ToString(kol) + " слов";
            }
            else
            {
                label1.Text = "Ничего не найдено";
            }
        }
        //Стирание текстового поля при клике
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
