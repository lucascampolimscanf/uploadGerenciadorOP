
namespace GerenciadorUpado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.tbox_valorOriginal = new System.Windows.Forms.TextBox();
            this.tbox_taxaCobrada = new System.Windows.Forms.TextBox();
            this.tbox_valorConvetido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbox_moedaDestino = new System.Windows.Forms.ComboBox();
            this.cbox_moedaOrigem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_nomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCambio = new System.Windows.Forms.TabPage();
            this.output = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Controls.Add(this.tabCambio);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.output);
            this.tabCadastro.Controls.Add(this.bt_Limpar);
            this.tabCadastro.Controls.Add(this.bt_Salvar);
            this.tabCadastro.Controls.Add(this.tbox_valorOriginal);
            this.tabCadastro.Controls.Add(this.tbox_taxaCobrada);
            this.tabCadastro.Controls.Add(this.tbox_valorConvetido);
            this.tabCadastro.Controls.Add(this.dateTimePicker1);
            this.tabCadastro.Controls.Add(this.cbox_moedaDestino);
            this.tabCadastro.Controls.Add(this.cbox_moedaOrigem);
            this.tabCadastro.Controls.Add(this.label7);
            this.tabCadastro.Controls.Add(this.label6);
            this.tabCadastro.Controls.Add(this.label5);
            this.tabCadastro.Controls.Add(this.label4);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Controls.Add(this.tbox_nomeCliente);
            this.tabCadastro.Controls.Add(this.label1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(792, 424);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastrar Cliente";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(133, 225);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(104, 27);
            this.bt_Limpar.TabIndex = 21;
            this.bt_Limpar.Text = "Limpar Campos";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(23, 225);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(104, 27);
            this.bt_Salvar.TabIndex = 20;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // tbox_valorOriginal
            // 
            this.tbox_valorOriginal.Location = new System.Drawing.Point(103, 128);
            this.tbox_valorOriginal.Name = "tbox_valorOriginal";
            this.tbox_valorOriginal.Size = new System.Drawing.Size(100, 20);
            this.tbox_valorOriginal.TabIndex = 19;
            // 
            // tbox_taxaCobrada
            // 
            this.tbox_taxaCobrada.Location = new System.Drawing.Point(103, 177);
            this.tbox_taxaCobrada.Name = "tbox_taxaCobrada";
            this.tbox_taxaCobrada.Size = new System.Drawing.Size(100, 20);
            this.tbox_taxaCobrada.TabIndex = 18;
            // 
            // tbox_valorConvetido
            // 
            this.tbox_valorConvetido.Location = new System.Drawing.Point(103, 151);
            this.tbox_valorConvetido.Name = "tbox_valorConvetido";
            this.tbox_valorConvetido.Size = new System.Drawing.Size(100, 20);
            this.tbox_valorConvetido.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // cbox_moedaDestino
            // 
            this.cbox_moedaDestino.FormattingEnabled = true;
            this.cbox_moedaDestino.Location = new System.Drawing.Point(103, 76);
            this.cbox_moedaDestino.Name = "cbox_moedaDestino";
            this.cbox_moedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cbox_moedaDestino.TabIndex = 15;
            // 
            // cbox_moedaOrigem
            // 
            this.cbox_moedaOrigem.FormattingEnabled = true;
            this.cbox_moedaOrigem.Location = new System.Drawing.Point(103, 47);
            this.cbox_moedaOrigem.Name = "cbox_moedaOrigem";
            this.cbox_moedaOrigem.Size = new System.Drawing.Size(121, 21);
            this.cbox_moedaOrigem.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Taxa Cobrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data da Operação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Original:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Convertido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moeda de Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de Origem:";
            // 
            // tbox_nomeCliente
            // 
            this.tbox_nomeCliente.Location = new System.Drawing.Point(103, 21);
            this.tbox_nomeCliente.Name = "tbox_nomeCliente";
            this.tbox_nomeCliente.Size = new System.Drawing.Size(325, 20);
            this.tbox_nomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // tabCambio
            // 
            this.tabCambio.Location = new System.Drawing.Point(4, 22);
            this.tabCambio.Name = "tabCambio";
            this.tabCambio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCambio.Size = new System.Drawing.Size(792, 424);
            this.tabCambio.TabIndex = 1;
            this.tabCambio.Text = "Calcular Câmbio";
            this.tabCambio.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(466, 134);
            this.output.MinimumSize = new System.Drawing.Size(120, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(120, 13);
            this.output.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GERENCIADOR DE CÂMBIO";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.TabPage tabCambio;
        private System.Windows.Forms.TextBox tbox_nomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbox_moedaDestino;
        private System.Windows.Forms.ComboBox cbox_moedaOrigem;
        private System.Windows.Forms.TextBox tbox_valorOriginal;
        private System.Windows.Forms.TextBox tbox_taxaCobrada;
        private System.Windows.Forms.TextBox tbox_valorConvetido;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Label output;
    }
}

