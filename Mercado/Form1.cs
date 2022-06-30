using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int Qtd;
            double ValorUnitário;
;           double Resultado;
            double Desconto = 5.0 / 100.0;
            double Juros = 30.0 / 100.0;
            double TotalAVista;
            double TotalCartão;

            if (radioButtonAVista.Checked == true)
            {
                Qtd = int.Parse(tbQtd.Text);
                ValorUnitário = double.Parse(tbValorUnitario.Text);
                Resultado = Qtd * ValorUnitário;
                TotalAVista = Resultado - (Desconto * Resultado);
                tbTotalAVista.Text = TotalAVista.ToString("C2");
                tbTotalCartao.Clear();
            }
            else if (radioButtonCartao.Checked == true)
            {
                Qtd = int.Parse(tbQtd.Text);
                ValorUnitário = double.Parse(tbValorUnitario.Text);
                Resultado = Qtd * ValorUnitário;
                TotalCartão = Resultado + (Juros * Resultado);
                tbTotalCartao.Text = TotalCartão.ToString("C2");
                tbTotalAVista.Clear();
            }
            else if (tbQtd.Text == "" || tbValorUnitario.Text == "" ||tbCodigo.Text == "")
            {
                MessageBox.Show("Insira os dados corretamente, por favor.", "Dados incompletos!" + "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbQtd.Clear();
            tbValorUnitario.Clear();
            tbTotalAVista.Clear();
            tbTotalCartao.Clear();
            radioButtonAVista.Checked = false;
            radioButtonCartao.Checked = false;
        }
    }
}