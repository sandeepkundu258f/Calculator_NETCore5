using System;
using System.Windows.Forms;
using Calculator.UserControls.Forms;

namespace Calculator.UserControls
{
    public partial class MenuBar : UserControl
    {
        private WinBasic winBasicParent;
        public MenuBar(WinBasic _winBasicParent)
        {
            InitializeComponent();
            winBasicParent = _winBasicParent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new();
            aboutBox.ShowDialog(winBasicParent);
        }
    }
}
