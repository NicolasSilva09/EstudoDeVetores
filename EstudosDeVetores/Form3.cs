using Microsoft.VisualBasic;
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
    public partial class FrmEx2 : Form
    {
        int[] A = new int[10];
        int[] B = new int[10];
        int indice = 0;
        public FrmEx2()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            for (;indice<10;indice++)
            {
                string valor = Interaction.InputBox($"Digite o {indice + 1}ºNúmero", "Inserir valor");
                int result = Convert.ToInt32(valor);

                A[indice] = result;

                lstValores.Items.Add(result);
            }
            MessageBox.Show("Os 10 Números ja foram inseridos!");
            MessageBox.Show("Clique em calcular para obter eles na forma negativa");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            for (int indice = 0; indice < 10;indice++)
            {
                B[indice] = -A[indice];
                lstresult.Items.Add(B[indice]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            lstValores.Items.Clear();

            A = new int[10];
            B = new int[10];
            indice = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            Hide();
            menu.Show(this);
        }
    }
}
