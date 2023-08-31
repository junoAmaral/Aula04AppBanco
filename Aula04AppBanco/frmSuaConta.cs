using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class frmSuaConta : Form
    {
        // Variável global 
        List<string> extratos = new List<string>();


        public frmSuaConta()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            double saldo = double.Parse(lblSaldo.Text.Replace("R$", ""));
            double soma;

            if (lblOperação.Text == "Sacar")
            {
                soma = saldo - valor;
                extratos.Add("Saque no valor de R$ " + valor);
            }
            else
            {
                soma = saldo + valor;
                extratos.Add("Depósito no valor de R$ " + valor);
            }

            lblSaldo.Text = "R$ " + soma;

            //Para resolver o erro causado pelo 'R$' direto por código (s/ criar 2 lbl):
            //string novo_saldo = lblSaldo.Text;
            //novo_saldo = novo_saldo.Substring(0, 2);  ou  novo_saldo = novo_saldo.Replace("R$", "");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            btnDeposito.BackColor = Color.Gold;
            btnSaque.BackColor = Color.Thistle;
            lblOperação.Text = "Depositar";
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            btnSaque.BackColor = Color.Gold;
            btnDeposito.BackColor = Color.Thistle;
            lblOperação.Text = "Sacar";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            frmExtrato pagina_estrato = new frmExtrato();
            pagina_estrato.extratos = extratos;
            pagina_estrato.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSaque_Click_1(object sender, EventArgs e)
        {
            btnSaque.BackColor = Color.Gold;
            btnDeposito.BackColor = Color.Thistle;
            lblOperação.Text = "Sacar";
        }
    }
}
