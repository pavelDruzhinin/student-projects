using System;
using System.Windows.Forms;

namespace MathSoLution
{
    public partial class MathSoLution : Form
    {
        public MathSoLution()
        {
            InitializeComponent();
        }
        //метод на открытие формы и скрытии главной
        private void Forms_Click(Form os)
        {
            os.Show();
            Hide();
        }

        private void KvUr_Click(object sender, EventArgs e)
        {
            var newK = new Korni();
            newK.Show();

            //  Forms_Click(newK);
        }

        private void TeoPif_Click(object sender, EventArgs e)
        {
            var pif = new Pifagor();
            pif.Show();

            // Forms_Click(pif);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ab = new About();
            ab.Show();
        }

        private void Cosin_Click(object sender, EventArgs e)
        {
            var cos = new Cosinus();
            cos.Show();

            //  Forms_Click(cos);
        }

        private void RazMn_Click(object sender, EventArgs e)
        {
            var rz = new RazMn();
            rz.Show();

            //   Forms_Click(RZ);
        }

        private void RazNOD_Click(object sender, EventArgs e)
        {
            var fNod = new Nod();
            fNod.Show();
        }
    }
}
