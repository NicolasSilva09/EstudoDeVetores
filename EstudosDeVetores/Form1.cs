using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace EstudosDeVetores
{
    public partial class FrmEx1 : Form
    {      
        double[] ValoresInseridos = new double[15];
        int valores = 0; 
        public FrmEx1()
        {
            InitializeComponent();


        }

        private void btninserir_Click(object sender, EventArgs e)
        {
           for(;valores < 15; valores++){
           string entrada = Interaction.InputBox($"{valores + 1}º número:","Inserir Valor");
           double valor = Convert.ToDouble(entrada);
           ValoresInseridos[valores]= valor;
           lstValores.Items.Add(valor); 
           
           }
           MessageBox.Show("Os 15 números ja foram preenchidos,clique em calcular para obter o quadrado deles");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 15; i++)
            {
                double result = ValoresInseridos[i] * ValoresInseridos[i];
                lstresult.Items.Add(result);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            lstValores.Items.Clear();
            ValoresInseridos = new double[15];
            valores = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Hide();
            Menu.Show();
        }
    }
}
