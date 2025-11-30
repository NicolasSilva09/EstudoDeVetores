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
    public partial class FrmEx3 : Form
    {
        int[] A = new int[30];
        int[] B = new int[30];
        int i = 0;
        public FrmEx3()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (i<30)
            {
                A[i] = int.Parse(txtAdicionar.Text);
                lstvalores.Items.Add(A[i]);
                txtAdicionar.Clear();
                txtAdicionar.Focus();
                i++;
                if (i==30)
                {
                    for (int i = 0; i<30;i++){ 
                    B[i] = A[i] * A[i] * A[i];
                    lstresult.Items.Add(B[i]);
                    } 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtpesquisa.Text);
            bool achou = false;
            lstpesquisa.Items.Add ($"");

            for (int i = 0; i<30;i++) 
            {
                if (B[i] == valor)
                {
                    lstpesquisa.Items.Add($"encontrado na posição {i} \r\n ");
                    achou = true;
                }
            }
            
            if (!achou)
            {
                lstpesquisa.Items.Add ( $"Valor não encontrado");
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            Hide();
            menu.Show(this);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtpesquisa.Clear();
            lstpesquisa.Items.Clear();
            txtpesquisa.Focus();
        }
    }
}
