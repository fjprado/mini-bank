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
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        int tipoConta;
        public FormCadastroConta(Form1 valorFormPrincipal)
        {
            this.formPrincipal = valorFormPrincipal;
            InitializeComponent();
        }
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (tipoConta == 0)
            {
                Conta novaConta = new ContaCorrente();
                novaConta.titular = new Cliente(textTitular.Text);
                //novaConta.numero = Convert.ToInt32(textNumero.Text);
                this.formPrincipal.AdicionarConta(novaConta);
                MessageBox.Show("Conta Corrente cadastrada com sucesso!");
            }
            else 
            {
                Conta novaConta = new ContaPoupanca();
                novaConta.titular = new Cliente(textTitular.Text);
                //novaConta.numero = Convert.ToInt32(textNumero.Text);
                this.formPrincipal.AdicionarConta(novaConta);
                MessageBox.Show("Conta Poupanca cadastrada com sucesso!");
            }

            this.Close();

        }

        private void comboBoxTipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tipoConta = comboBoxTipoDeConta.SelectedIndex;

            
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textNumero.Text = Convert.ToString(Conta.ProximoNumero());

            comboBoxTipoDeConta.SelectedItem = null;
            comboBoxTipoDeConta.Items.Add("Conta Corrente");//index 0
            comboBoxTipoDeConta.Items.Add("Conta Poupanca");//index 1
            comboBoxTipoDeConta.SelectedText = "Selecione...";
            
        }
    }
}
