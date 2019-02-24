using System;
using System.Windows.Forms;

namespace TwoSpisok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Кнопка ">"
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count;i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
                i = i - 1;
            }
            textBox2.Text = listBox1.Items.Count.ToString();
            textBox1.Text = listBox2.Items.Count.ToString();
        }
        //Кнопка "<"
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.SelectedItems.Count;i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
                i = i - 1;
            }
            textBox2.Text = listBox1.Items.Count.ToString();
            textBox1.Text = listBox2.Items.Count.ToString();
        }
        //Кнопка переноса полностью списка вправо(>>)
        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listBox1.Items.Count;i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
                listBox1.Items.Remove(listBox1.Items[i]);
                i = i - 1;
            }
            textBox2.Text = listBox1.Items.Count.ToString();
            textBox1.Text = listBox2.Items.Count.ToString();
        }
        //Кнопка переноса списка влево(<<)
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count;i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
                listBox2.Items.Remove(listBox2.Items[i]);
                i = i - 1;
            }
            textBox2.Text = listBox1.Items.Count.ToString();
            textBox1.Text = listBox2.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = listBox2.Items.Count.ToString();
            textBox2.Text = listBox1.Items.Count.ToString();
        }
    }
}
