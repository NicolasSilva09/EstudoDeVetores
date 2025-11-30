using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudosDeVetores
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEx1 Ex1 = new FrmEx1();
            Hide();
            Ex1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEx2 ex2 = new FrmEx2();
            Hide();
            ex2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEx3 ex3 = new FrmEx3();  
            Hide();
            ex3.Show();
        }
    }
}
