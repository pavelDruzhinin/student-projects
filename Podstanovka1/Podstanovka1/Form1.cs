using System;
using System.Linq;
using System.Windows.Forms;

namespace Podstanovka1
{
    public partial class Form1 : Form
    {
        protected char[] ABCarr
        {
            get { return Enumerable.Range(0, 64).Select((x, i) => (char)('А' + i)).ToArray(); }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char[] A = str.ToCharArray();
            int count = A.Length;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < ABCarr.Length; j++)
                {
                    if (A[i] == ABCarr[j])
                    {
                        A[i] = ABCarr[j + 5];
                    }
                }
            }
            foreach (var item in A)
            {
                textBox2.Text += item;
            }
            //char[] B = new char[5] { 'б', 'п', 'т', 'ж', 'к' };
            //if (str == "мама мыла раму")
            //{
            //    MessageBox.Show("Вот молодец!");
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (A[i] == 'а')
            //        {
            //            A[i] = B[0];
            //        }
            //        if (A[i] == 'м')
            //        {
            //            A[i] = B[1];
            //        }
            //        if (A[i] == 'р')
            //        {
            //            A[i] = B[2];
            //        }
            //        if (A[i] == 'л')
            //        {
            //            A[i] = B[3];
            //        }
            //        if (A[i] == 'ы')
            //        {
            //            A[i] = B[4];
            //        }
            //    }
            //    str = "";
            //    for (int i = 0; i < n; i++)
            //        str = str + A[i].ToString();
            //    textBox2.Text = str;
            //}
            //else
            //{
            //    MessageBox.Show("Попробуйте еще раз, после 3 неудачных попыток будет форматирован диск C:/!");
            //    textBox1.Clear();
            //    textBox1.Focus();
            //}          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = textBox2.Text;
            var A = str.ToCharArray();
            var n = A.Length;
            var B = new[] { 'а', 'м', 'р', 'л', 'ы' };
            for (var i = 0; i < n; i++)
            {
                if (A[i] == 'б')
                {
                    A[i] = B[0];
                }
                if (A[i] == 'п')
                {
                    A[i] = B[1];
                }
                if (A[i] == 'т')
                {
                    A[i] = B[2];
                }
                if (A[i] == 'ж')
                {
                    A[i] = B[3];
                }
                if (A[i] == 'к')
                {
                    A[i] = B[4];
                }
            }

            str = "";
            for (int i = 0; i < n; i++)
                str = str + A[i];

            textBox3.Text = str;
            MessageBox.Show("Программа выполнила работу! Так что давай, до свидания!");
            Close();
        }

    }
}
