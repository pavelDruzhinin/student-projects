using System;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //"Открыть"
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            openFileDialog1.ShowDialog();
            //Создаем переменную для имени файла
            string flName = openFileDialog1.FileName;
            //Создаем поток для открытия файла
            FileStream flstream = File.Open(flName, FileMode.Open, FileAccess.Read);
            //Проверяем открыт ли поток

            //Поток для чтения файла
            var strmReader = new StreamReader(flstream);
            //Записываем содержимое файла в поле ввода
            richTextBox1.Text = strmReader.ReadToEnd();
            //Закрываем поток
            flstream.Close();

        }
        //"Сохранить"
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открываем диалоговое окно
            saveFileDialog1.ShowDialog();
            //Создаем переменную для имени файла
            string fileName = saveFileDialog1.FileName;
            //Открываем поток для открытия файла
            FileStream flstream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            //Проверяем открыт ли поток

            //Создаем поток для записи в файл
            var streamwriter = new StreamWriter(flstream);
            //Записываем в поток содержимое поля ввода
            streamwriter.Write(richTextBox1.Text);
            //Записываем поток в файл
            streamwriter.Flush();
            //Закрываем поток
            streamwriter.Close();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Oprog();
            frm.ShowDialog();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Color = richTextBox1.SelectionColor;
            fontDialog1.Font = richTextBox1.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
