using System;
using System.Windows.Forms;

namespace QuickNotePad
{
    public partial class Form1 : Form
    {
        private int openDoc;
        public Form1()
        {
            InitializeComponent();
            сохранитьToolStripMenuItem.Enabled = false;
        }
        //Кнопка "Файл"--"Создать"
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new blank
            {
                DocName = "Документ " + ++openDoc
            };
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }
        //Окна
        //Каскадом
        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Рядом
        private void рядомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        //Стопкой
        private void стопкойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        
        //"Правка"-->"Вставить"
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }
        //"Правка"--"Вырезать"
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }
        //Правка--Копировать
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }
        //Правка--Удалить
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }
        //Правка--Выделить все
        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.SelectedAll();
        }
        //"Открыть"
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если выбрано открытие файла через диалоговое окно
            if (openFileDialog1.ShowDialog() != DialogResult.OK) 
                return;

            //Создаем новую форму
            var frm = new blank();
            //Открываем диалоговое окно
            frm.Open(openFileDialog1.FileName);
            //Указываем что это родительская форма
            frm.MdiParent = this;
            //Присваеиваем имя файла имя документа 
            frm.Text = frm.DocName;
            //Запускаем форму
            frm.Show();
        }
        //Сохранить как...
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) 
                return;

            var frm = (blank)this.ActiveMdiChild;
            frm.Save(saveFileDialog1.FileName);
            frm.MdiParent = this;
            frm.DocName = saveFileDialog1.FileName;
            frm.Text = frm.DocName;
            сохранитьToolStripMenuItem.Enabled = true;
            frm.IsSaved = true;
        }
        //Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = (blank)this.ActiveMdiChild;
            frm.Save(frm.DocName);
            frm.IsSaved = true;
        }       
        
        //"Шрифт"
        private void шрифтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на главную форму
            var frm = (blank)this.ActiveMdiChild;
            //Указываем что данная форма дочерняя
            frm.MdiParent = this;
            //Подключаем диалог
            fontDialog1.ShowColor = true;
            //Связываем свойства диалога со свойствами richtextbox
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            //Если пользователь нажимает ОК
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //Присваиваем сввойства диалога свойствам текста
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            //Показываем форму
            frm.Show();
        }
        //"Цвет"
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переключаем фокус на главную форму
            var frm = (blank)this.ActiveMdiChild;
            //Указываем что данная форма родительская
            frm.MdiParent = this;
            //Свойства диалога связываем со свойствами richtextbox
            colorDialog1.Color = frm.richTextBox1.SelectionColor;
            //Если пользователь нажимает ОК
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Присваиваем выбранный цвет пользователем цвету текста
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            //Показываем форму
            frm.Show();
        }
        //"Поиск"
        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Search();
            if (frm.ShowDialog(this) == DialogResult.Cancel)
            {
                return;
            }
            var form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void tbNew_Click(object sender, EventArgs e)
        {
            создатьToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbOpen_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(this,new EventArgs());
        }

        private void tbCut_Click(object sender, EventArgs e)
        {
            вырезатьToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbCopy_Click(object sender, EventArgs e)
        {
            копироватьToolStripMenuItem_Click(this, new EventArgs());
        }

        private void tbPaste_Click(object sender, EventArgs e)
        {
            вставитьToolStripMenuItem_Click(this, new EventArgs());
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new CalculateOneMove.About();
            frm.ShowDialog();
        }
       
    }
}
