using System;
using System.Windows.Forms;

namespace Mnojestva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Вывод информации для пользователя
            //Заводим переменные для подсчета не посьавленных галочек
            int k = 0;
            int j = 0;

            //Здесь мы снимаем галочки с множества С
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }

            //Считаем количество не отмеченных элементов 
            //множеств А и В
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == false)
                {
                    k = k + 1;
                }
                if (checkedListBox2.GetItemChecked(i) == false)
                {
                    j = j + 1;
                }
            }

            //Если не отмечено ни одного элемента то выводим информацию 
            //об этом факте
            if (k == checkedListBox1.Items.Count && j == checkedListBox2.Items.Count)
            {
                textBox1.Text = "Не отмечено ни " + Environment.NewLine + "одного элемента во множествах";
            }
            else
                //Если галочек нет в одном из множеств
                //В множестве А
                if (k == checkedListBox1.Items.Count)
                {
                    textBox1.Text = "Не отмечено элементов во множестве А";
                }
                else
                    //В множестве В
                    if (j == checkedListBox2.Items.Count)
                    {
                        textBox1.Text = "Не отмечено элементов во множестве B";
                    }
                    //Если все хорошо
                    else
                    {
                        textBox1.Text = "Смотри результат во множестве С";
                    }
            //Считываем операцию, которую выбрал пользователь
            string s = comboBox1.Text;

            //Действия при выборе операции:

            //Разности
            //При разности мы выводим элементы 
            //которые не совпадают в множествах
            if (s == "Разность")
            {
                checkedListBox4.SetItemChecked(0, false);
                checkedListBox4.SetItemChecked(1, false);
                checkedListBox4.SetItemChecked(2, true);
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true && checkedListBox2.GetItemChecked(i) == true)
                    {
                        checkedListBox3.SetItemChecked(i, false);
                    }
                    if (checkedListBox1.GetItemChecked(i) == true && checkedListBox2.GetItemChecked(i) == false)
                    {
                        checkedListBox3.SetItemChecked(i, true);
                    }
                    if (checkedListBox2.GetItemChecked(i) == true && checkedListBox1.GetItemChecked(i) == false)
                    {
                        checkedListBox3.SetItemChecked(i, true);
                    }
                }
            }

            //Обьединение
            //При обьединении мы выводим все 
            //элементы входящие в множества
            if (s == "Обьединение")
            {
                checkedListBox4.SetItemChecked(0, false);
                checkedListBox4.SetItemChecked(1, true);
                checkedListBox4.SetItemChecked(2, false);
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true || checkedListBox2.GetItemChecked(i) == true)
                    {
                        checkedListBox3.SetItemChecked(i, true);
                    }
                }
            }

            //Пересечение
            //При пересечении мы выводим только 
            //элементы которые совпадают в множествах
            if (s == "Пересечение")
            {
                checkedListBox4.SetItemChecked(0, true);
                checkedListBox4.SetItemChecked(1, false);
                checkedListBox4.SetItemChecked(2, false);
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true && checkedListBox2.GetItemChecked(i) == true)
                    {
                        checkedListBox3.SetItemChecked(i, true);
                    }
                }
            }
        }
    }
}
