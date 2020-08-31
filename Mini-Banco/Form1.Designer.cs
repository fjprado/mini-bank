namespace Mini_Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textConta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.Depositar = new System.Windows.Forms.Button();
            this.Sacar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testTotal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero da Conta";
            // 
            // textConta
            // 
            this.textConta.Enabled = false;
            this.textConta.Location = new System.Drawing.Point(120, 27);
            this.textConta.Name = "textConta";
            this.textConta.Size = new System.Drawing.Size(100, 20);
            this.textConta.TabIndex = 1;
            this.textConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Enabled = false;
            this.textNome.Location = new System.Drawing.Point(120, 64);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 3;
            this.textNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // textSaldo
            // 
            this.textSaldo.Enabled = false;
            this.textSaldo.Location = new System.Drawing.Point(120, 96);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(100, 20);
            this.textSaldo.TabIndex = 5;
            this.textSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Depositar
            // 
            this.Depositar.Location = new System.Drawing.Point(39, 174);
            this.Depositar.Name = "Depositar";
            this.Depositar.Size = new System.Drawing.Size(75, 23);
            this.Depositar.TabIndex = 6;
            this.Depositar.Text = "Depositar";
            this.Depositar.UseVisualStyleBackColor = true;
            this.Depositar.Click += new System.EventHandler(this.Depositar_Click);
            // 
            // Sacar
            // 
            this.Sacar.Location = new System.Drawing.Point(120, 174);
            this.Sacar.Name = "Sacar";
            this.Sacar.Size = new System.Drawing.Size(75, 23);
            this.Sacar.TabIndex = 7;
            this.Sacar.Text = "Sacar";
            this.Sacar.UseVisualStyleBackColor = true;
            this.Sacar.Click += new System.EventHandler(this.Sacar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(120, 136);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 9;
            this.textValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.textConta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sacar);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.Depositar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSaldo);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // testTotal
            // 
            this.testTotal.Location = new System.Drawing.Point(12, 399);
            this.testTotal.Name = "testTotal";
            this.testTotal.Size = new System.Drawing.Size(114, 39);
            this.testTotal.TabIndex = 11;
            this.testTotal.Text = "Total";
            this.testTotal.UseVisualStyleBackColor = true;
            this.testTotal.Click += new System.EventHandler(this.testTotal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 149);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(95, 29);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 3;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            this.comboContas.TextUpdate += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a conta";
            // 
            // buttonNovaConta
            // 
            this.buttonNovaConta.Location = new System.Drawing.Point(132, 399);
            this.buttonNovaConta.Name = "buttonNovaConta";
            this.buttonNovaConta.Size = new System.Drawing.Size(114, 39);
            this.buttonNovaConta.TabIndex = 13;
            this.buttonNovaConta.Text = "Nova Conta";
            this.buttonNovaConta.UseVisualStyleBackColor = true;
            this.buttonNovaConta.Click += new System.EventHandler(this.buttonNovaConta_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(252, 399);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(114, 39);
            this.botaoImpostos.TabIndex = 14;
            this.botaoImpostos.Text = "Total de Tributos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.buttonNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.testTotal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Button Depositar;
        private System.Windows.Forms.Button Sacar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button testTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Button buttonNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

