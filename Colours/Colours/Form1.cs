using System;
using System.Drawing;
using System.Windows.Forms;

namespace Colours
{
    public partial class Form1 : Form
    {
        internal int i = 0, j = 0;
        private Label[,] Labels;
        private readonly Color[,] Colors = { { Color.White, Color.Red, Color.Blue }, { Color.Green, Color.Cyan, Color.Yellow }, { Color.Black, Color.Brown, Color.BlueViolet } };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Labels = new[,] { { label1, label2, label3 }, { label4, label5, label6 }, { label7, label8, label9 } };
            Labels[i, j].BackColor = Colors[i, j];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                Labels[i, j].BackColor = Color.Empty;
                i = i - 1;
            }
            Labels[i, j].BackColor = Colors[i, j];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i < 2)
            {
                Labels[i, j].BackColor = Color.Empty;
                i = i + 1;
            }
            Labels[i, j].BackColor = Colors[i, j];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (j > 0)
            {
                Labels[i, j].BackColor = Color.Empty;
                j = j - 1;
            }
            Labels[i, j].BackColor = Colors[i, j];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (j < 2)
            {
                Labels[i, j].BackColor = Color.Empty;
                j = j + 1;
            }
            Labels[i, j].BackColor = Colors[i, j];
        }

    }
}
