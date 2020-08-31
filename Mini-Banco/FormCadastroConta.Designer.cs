namespace Mini_Banco
{
    partial class FormCadastroConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoDeConta = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textNumero
            // 
            this.textNumero.Enabled = false;
            this.textNumero.Location = new System.Drawing.Point(114, 44);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(100, 20);
            this.textNumero.TabIndex = 2;
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(114, 83);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(100, 20);
            this.textTitular.TabIndex = 3;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(50, 171);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 4;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxTipoDeConta);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.textTitular);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Conta";
            // 
            // comboBoxTipoDeConta
            // 
            this.comboBoxTipoDeConta.FormattingEnabled = true;
            this.comboBoxTipoDeConta.Location = new System.Drawing.Point(114, 121);
            this.comboBoxTipoDeConta.Name = "comboBoxTipoDeConta";
            this.comboBoxTipoDeConta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDeConta.TabIndex = 5;
            this.comboBoxTipoDeConta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDeConta_SelectedIndexChanged);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoDeConta;
    }
}