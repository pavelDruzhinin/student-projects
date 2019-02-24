using System;
using System.Windows.Forms;
using System.IO;

namespace QuickNotePad
{
    public partial class blank : Form
    {
        public bool IsSaved = false;
        //переменная для номера документа
        public string DocName = "";
        //переменная для буфера
        public string BufText = "";
        public blank()
        {
            InitializeComponent();
            sbTime.Text = Convert.ToString(DateTime.Now.ToLongTimeString());
            sbTime.ToolTipText = Convert.ToString(DateTime.Today.ToLongDateString());
        }
        //метод Вырезаниеp
        public void Cut()
        {
            this.BufText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        //метод Копирование текста
        public void Copy()
        {
            this.BufText = richTextBox1.SelectedText;
        }
        //метод Вставка текста
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufText;
        }
        //метод Выделение всего текста
        public void SelectedAll()
        {
            richTextBox1.SelectAll();
        }
        //метод Удаление
        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufText = "";
        }
        //Пункты контекстного меню
        //Вырезать
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }
        //Копировать
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }
        //Вставить
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }
        //Удалить
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        //Выделить все
        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedAll();
        }
        //Создаем метод Open для загрузки файла
        public void Open(string OpenFileName)
        {
            //Если ничего не выбрано возвращаемся к диалогу
            if (OpenFileName == "")
                return;

            //Создаем новый обьект StreamReader и передаем
            //переменную OpenFileName
            var sr = new StreamReader(OpenFileName);
            //Загружаем файл в richTextBox
            richTextBox1.Text = sr.ReadToEnd();
            //Закрываем поток
            sr.Close();
            //Имя файла присваиваем документу
            DocName = OpenFileName;
        }
        //Создаем метод Save
        public void Save(string SaveFileName)
        {
            //Если не набрано имя сохраняемого документа
            //то возвращаемся к диалоговому окну
            if (SaveFileName == "")
                return;


            //Создаем новый поток для чтения содержимого 
            //richtextbox'a формы
            var sw = new StreamWriter(SaveFileName);
            //Переписываем richtextbox'a в файл
            sw.WriteLine(richTextBox1.Text);
            //Закрываем поток
            sw.Close();
            //Сохраненному файлу присваиваем имя документа
            DocName = SaveFileName;
        }
        //Событие при закрытии формы
        private void blank_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если документ был уже сохранен
            if (!IsSaved)
                return;

            //Открываем диалоговое сообщение и проверяем открыто ли оно
            if (MessageBox.Show("Вы хотите сохранить документ " + this.DocName + " ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Включаем сохранение
                this.Save(this.DocName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sbAmount.Text = "Количество символов: " + richTextBox1.Text.Length.ToString();
        }
    }
}
