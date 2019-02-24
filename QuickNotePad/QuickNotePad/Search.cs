using System.Windows.Forms;

namespace QuickNotePad
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        public RichTextBoxFinds FindCondition
        {
            get
            {
                if (cbMatchCase.Checked && cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.MatchCase | RichTextBoxFinds.WholeWord;
                }
                if(cbMatchCase.Checked)
                {
                    return RichTextBoxFinds.MatchCase;
                }
                if(cbMatchWhole.Checked)
                {
                    return RichTextBoxFinds.WholeWord;
                }
                return RichTextBoxFinds.None;
            }
        }
        public string FindText
        {
            get { return txtfind.Text; }
            set { txtfind.Text = value; }
        }
    }
}
