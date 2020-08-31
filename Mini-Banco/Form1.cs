using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;

        public void AdicionarConta(Conta contaNova)
        {
            this.contas.Add(contaNova);
            comboContas.Items.Add("Titular: " + contaNova.titular.Nome );
        }

        public Form1()
        {
            InitializeComponent();

        }
            private void Form1_Load(object sender, EventArgs e)
        {
            this.contas = new List<Conta>();

            Conta c1 = new ContaCorrente();
            c1.titular = new Cliente("Thomas");
            //c1.NumeroDaConta = 2547;
            AdicionarConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.titular = new Cliente("Fernando");
            //c2.NumeroDaConta = 1435;
            AdicionarConta(c2);

            //this.contas = new ContaPoupanca();
            //contas = new Conta();
            //contas.titular = new Cliente();

            //textConta.Text = Convert.ToString(contas.Numero);
            //textSaldo.Text = Convert.ToString(contas.Saldo);
            //textNome.Text = contas.titular.Nome;
            //textValor.Text = Convert.ToString(0);

            //ContaPoupanca contaPoup1 = new ContaPoupanca();
            //contaPoup1.Depositar(300);

        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDig = textValor.Text;
            double valorDouble = Convert.ToDouble(valorDig);

            try
            {
                selecionada.Depositar(valorDouble);
                textSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro depositado!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível depositar um valor negativo");
            }
            textSaldo.Text = Convert.ToString(selecionada.Saldo);
            textValor.Text = Convert.ToString(0);
            //tudo em uma linha: conta1.Depositar(Convert.ToDouble(textValor.Text));
        }

        private void Sacar_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            string valorDig = textValor.Text;
            double valorDouble = Convert.ToDouble(valorDig);
            try
            {
                selecionada.Sacar(valorDouble);
                textSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Dinheiro Liberado!");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Não é possível sacar um valor negativo");
            }
            /*bool deuCerto = selecionada.Sacar(valorDouble);

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valor digitado maior que o saldo em conta!");
            }*/
            textSaldo.Text = Convert.ToString(selecionada.Saldo);
            textValor.Text = Convert.ToString(0);
            
        }

        private void testTotal_Click(object sender, EventArgs e)
        {
            var totalContas = new TotalizadorDeContas();
            totalContas.Soma(contas.Saldo);
            var campoTotal = Convert.ToString(totalContas.ValorTotal);

            MessageBox.Show(string.Format("Total saldo: {0}", campoTotal));
            
            /*
            string format
            MessageBox.Show(string.Format("Total saldo: {0}", campoTotal));
                        ou
            string interpolation
            MessageBox.Show($"Saldo {campoTotal}");
            */
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textConta.Text = Convert.ToString(selecionada.numero);
            textNome.Text = selecionada.titular.Nome;
            textSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void buttonNovaConta_Click(object sender, EventArgs e)
        {   
            FormCadastroConta formCadastroConta = new FormCadastroConta(this);
            formCadastroConta.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente cc1 = new ContaCorrente();
            cc1.Depositar(200);

            TotalizadorDeTributos totalTri = new TotalizadorDeTributos();
            totalTri.Adiciona(this.contas);
            MessageBox.Show($"Total tributos: {totalTri.TotalTributos}");
        }
    }
}