
namespace WindowsFormsAppComSQLite
{
    partial class JanelaPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ComboBox_MoedaDestino = new System.Windows.Forms.ComboBox();
            this.ComboBox_MoedaOrigem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_ErroDestino = new System.Windows.Forms.Label();
            this.TBox_valorConvertido = new System.Windows.Forms.TextBox();
            this.LB_ErroOrigem = new System.Windows.Forms.Label();
            this.TBox_valorOriginal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_LimparCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_CastastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.tabCambio = new System.Windows.Forms.TabPage();
            this.tabGerenciar = new System.Windows.Forms.TabPage();
            this.tabGerenciarMoedas = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridMoedas = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabGerenciarMoedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoedas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabCambio);
            this.tabControl1.Controls.Add(this.tabGerenciar);
            this.tabControl1.Controls.Add(this.tabGerenciarMoedas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.dateTimePicker1);
            this.tabCadastrar.Controls.Add(this.ComboBox_MoedaDestino);
            this.tabCadastrar.Controls.Add(this.ComboBox_MoedaOrigem);
            this.tabCadastrar.Controls.Add(this.label5);
            this.tabCadastrar.Controls.Add(this.label6);
            this.tabCadastrar.Controls.Add(this.LB_ErroDestino);
            this.tabCadastrar.Controls.Add(this.TBox_valorConvertido);
            this.tabCadastrar.Controls.Add(this.LB_ErroOrigem);
            this.tabCadastrar.Controls.Add(this.TBox_valorOriginal);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.Btn_LimparCampos);
            this.tabCadastrar.Controls.Add(this.dataGridView1);
            this.tabCadastrar.Controls.Add(this.Btn_CastastrarCliente);
            this.tabCadastrar.Controls.Add(this.label1);
            this.tabCadastrar.Controls.Add(this.TBox_NomeCliente);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 22);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCadastrar.Size = new System.Drawing.Size(578, 339);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar Cliente";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // ComboBox_MoedaDestino
            // 
            this.ComboBox_MoedaDestino.FormattingEnabled = true;
            this.ComboBox_MoedaDestino.Location = new System.Drawing.Point(115, 75);
            this.ComboBox_MoedaDestino.Name = "ComboBox_MoedaDestino";
            this.ComboBox_MoedaDestino.Size = new System.Drawing.Size(173, 21);
            this.ComboBox_MoedaDestino.TabIndex = 21;
            // 
            // ComboBox_MoedaOrigem
            // 
            this.ComboBox_MoedaOrigem.FormattingEnabled = true;
            this.ComboBox_MoedaOrigem.Location = new System.Drawing.Point(115, 43);
            this.ComboBox_MoedaOrigem.Name = "ComboBox_MoedaOrigem";
            this.ComboBox_MoedaOrigem.Size = new System.Drawing.Size(173, 21);
            this.ComboBox_MoedaOrigem.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Valor convertido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor original:";
            // 
            // LB_ErroDestino
            // 
            this.LB_ErroDestino.AutoSize = true;
            this.LB_ErroDestino.ForeColor = System.Drawing.Color.DarkRed;
            this.LB_ErroDestino.Location = new System.Drawing.Point(258, 174);
            this.LB_ErroDestino.MinimumSize = new System.Drawing.Size(160, 0);
            this.LB_ErroDestino.Name = "LB_ErroDestino";
            this.LB_ErroDestino.Size = new System.Drawing.Size(160, 13);
            this.LB_ErroDestino.TabIndex = 16;
            // 
            // TBox_valorConvertido
            // 
            this.TBox_valorConvertido.Location = new System.Drawing.Point(115, 171);
            this.TBox_valorConvertido.MaxLength = 25;
            this.TBox_valorConvertido.Name = "TBox_valorConvertido";
            this.TBox_valorConvertido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBox_valorConvertido.Size = new System.Drawing.Size(137, 20);
            this.TBox_valorConvertido.TabIndex = 15;
            this.TBox_valorConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBox_valorConvertido.Click += new System.EventHandler(this.TBox_valorConvertido_Click);
            this.TBox_valorConvertido.TextChanged += new System.EventHandler(this.TBox_valorConvertido_TextChanged);
            this.TBox_valorConvertido.Enter += new System.EventHandler(this.TBox_valorConvertido_Enter);
            this.TBox_valorConvertido.Leave += new System.EventHandler(this.TBox_valorConvertido_Leave);
            // 
            // LB_ErroOrigem
            // 
            this.LB_ErroOrigem.AutoSize = true;
            this.LB_ErroOrigem.ForeColor = System.Drawing.Color.DarkRed;
            this.LB_ErroOrigem.Location = new System.Drawing.Point(258, 142);
            this.LB_ErroOrigem.MinimumSize = new System.Drawing.Size(160, 0);
            this.LB_ErroOrigem.Name = "LB_ErroOrigem";
            this.LB_ErroOrigem.Size = new System.Drawing.Size(160, 13);
            this.LB_ErroOrigem.TabIndex = 14;
            // 
            // TBox_valorOriginal
            // 
            this.TBox_valorOriginal.Location = new System.Drawing.Point(115, 139);
            this.TBox_valorOriginal.MaxLength = 25;
            this.TBox_valorOriginal.Name = "TBox_valorOriginal";
            this.TBox_valorOriginal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBox_valorOriginal.Size = new System.Drawing.Size(137, 20);
            this.TBox_valorOriginal.TabIndex = 13;
            this.TBox_valorOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TBox_valorOriginal.Click += new System.EventHandler(this.TBox_valorOriginal_Click);
            this.TBox_valorOriginal.TextChanged += new System.EventHandler(this.TBox_valorOriginal_TextChanged);
            this.TBox_valorOriginal.Enter += new System.EventHandler(this.TBox_valorOriginal_Enter);
            this.TBox_valorOriginal.Leave += new System.EventHandler(this.TBox_valorOriginal_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data da operação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Moeda de destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Moeda de origem:";
            // 
            // Btn_LimparCampos
            // 
            this.Btn_LimparCampos.Location = new System.Drawing.Point(447, 41);
            this.Btn_LimparCampos.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.Btn_LimparCampos.Name = "Btn_LimparCampos";
            this.Btn_LimparCampos.Size = new System.Drawing.Size(116, 23);
            this.Btn_LimparCampos.TabIndex = 4;
            this.Btn_LimparCampos.Text = "Limpar Campos";
            this.Btn_LimparCampos.UseVisualStyleBackColor = true;
            this.Btn_LimparCampos.Click += new System.EventHandler(this.Btn_LimparCampos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(346, 111);
            this.dataGridView1.TabIndex = 3;
            // 
            // Btn_CastastrarCliente
            // 
            this.Btn_CastastrarCliente.Location = new System.Drawing.Point(447, 9);
            this.Btn_CastastrarCliente.Name = "Btn_CastastrarCliente";
            this.Btn_CastastrarCliente.Size = new System.Drawing.Size(116, 23);
            this.Btn_CastastrarCliente.TabIndex = 2;
            this.Btn_CastastrarCliente.Text = "Cadastrar Cliente";
            this.Btn_CastastrarCliente.UseVisualStyleBackColor = true;
            this.Btn_CastastrarCliente.Click += new System.EventHandler(this.Btn_CastastrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do cliente:";
            // 
            // TBox_NomeCliente
            // 
            this.TBox_NomeCliente.Location = new System.Drawing.Point(115, 12);
            this.TBox_NomeCliente.MaxLength = 299;
            this.TBox_NomeCliente.Name = "TBox_NomeCliente";
            this.TBox_NomeCliente.Size = new System.Drawing.Size(309, 20);
            this.TBox_NomeCliente.TabIndex = 0;
            // 
            // tabCambio
            // 
            this.tabCambio.Location = new System.Drawing.Point(4, 22);
            this.tabCambio.Name = "tabCambio";
            this.tabCambio.Padding = new System.Windows.Forms.Padding(3);
            this.tabCambio.Size = new System.Drawing.Size(578, 339);
            this.tabCambio.TabIndex = 1;
            this.tabCambio.Text = "Calcular Câmbio";
            this.tabCambio.UseVisualStyleBackColor = true;
            // 
            // tabGerenciar
            // 
            this.tabGerenciar.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciar.Name = "tabGerenciar";
            this.tabGerenciar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabGerenciar.Size = new System.Drawing.Size(578, 339);
            this.tabGerenciar.TabIndex = 2;
            this.tabGerenciar.Text = "Gerenciar Clientes";
            this.tabGerenciar.UseVisualStyleBackColor = true;
            // 
            // tabGerenciarMoedas
            // 
            this.tabGerenciarMoedas.Controls.Add(this.textBox2);
            this.tabGerenciarMoedas.Controls.Add(this.textBox1);
            this.tabGerenciarMoedas.Controls.Add(this.dataGridMoedas);
            this.tabGerenciarMoedas.Controls.Add(this.label8);
            this.tabGerenciarMoedas.Controls.Add(this.label7);
            this.tabGerenciarMoedas.Location = new System.Drawing.Point(4, 22);
            this.tabGerenciarMoedas.Name = "tabGerenciarMoedas";
            this.tabGerenciarMoedas.Size = new System.Drawing.Size(578, 339);
            this.tabGerenciarMoedas.TabIndex = 3;
            this.tabGerenciarMoedas.Text = "Gerenciar Moedas";
            this.tabGerenciarMoedas.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 46);
            this.textBox2.MaxLength = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 9);
            this.textBox1.MaxLength = 299;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridMoedas
            // 
            this.dataGridMoedas.AllowUserToAddRows = false;
            this.dataGridMoedas.AllowUserToDeleteRows = false;
            this.dataGridMoedas.AllowUserToResizeRows = false;
            this.dataGridMoedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMoedas.ColumnHeadersVisible = false;
            this.dataGridMoedas.Location = new System.Drawing.Point(280, 6);
            this.dataGridMoedas.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridMoedas.Name = "dataGridMoedas";
            this.dataGridMoedas.ReadOnly = true;
            this.dataGridMoedas.RowHeadersVisible = false;
            this.dataGridMoedas.ShowCellErrors = false;
            this.dataGridMoedas.ShowCellToolTips = false;
            this.dataGridMoedas.ShowEditingIcon = false;
            this.dataGridMoedas.Size = new System.Drawing.Size(295, 309);
            this.dataGridMoedas.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor de Cotação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 12, 3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome da moeda:";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ControlLight;
            this.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(0, 343);
            this.status.MinimumSize = new System.Drawing.Size(590, 22);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(2);
            this.status.Size = new System.Drawing.Size(590, 22);
            this.status.TabIndex = 1;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 365);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.Text = "Sistema de Cálculo de Câmbio";
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabGerenciarMoedas.ResumeLayout(false);
            this.tabGerenciarMoedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMoedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabCambio;
        private System.Windows.Forms.Button Btn_CastastrarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBox_NomeCliente;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_LimparCampos;
        private System.Windows.Forms.TabPage tabGerenciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBox_valorOriginal;
        private System.Windows.Forms.Label LB_ErroOrigem;
        private System.Windows.Forms.Label LB_ErroDestino;
        private System.Windows.Forms.TextBox TBox_valorConvertido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ComboBox_MoedaDestino;
        private System.Windows.Forms.ComboBox ComboBox_MoedaOrigem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabGerenciarMoedas;
        private System.Windows.Forms.DataGridView dataGridMoedas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

