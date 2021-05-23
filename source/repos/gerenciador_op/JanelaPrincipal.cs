using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using System.IO;
using System.Reflection;

namespace WindowsFormsAppComSQLite
{
    public partial class JanelaPrincipal : Form
    {
        public static SQLiteCommand commando;
        public static SQLiteConnection conn;

        bool controlaFocoOriginal = false;
        bool controlaFocoConvertido = false;

        public JanelaPrincipal()
        {
            InitializeComponent();
            Conecta_SQLite();

            dataGridView1.Columns.Add("colID", "ID");
            dataGridView1.Columns.Add("colNome", "Nome");
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 310;

            AtualizaDataGrid();
        }

        private void ValidaCampoNumerico(TextBox campo, Label lb)
        {
            if (campo.Text.Length == 0)
            {
                lb.Text = "";
                return;
            }

            int sel = campo.SelectionStart;
            if (campo.Text.Contains("."))
            {
                campo.Text = campo.Text.Replace(".", ",");
            }
            campo.Text = campo.Text.Replace("..", ".");
            campo.Text = campo.Text.Replace(",,", ".");

            campo.SelectionStart = sel;
            campo.SelectionLength = 0;

            try
            {
                Double valor;
                valor = Double.Parse(campo.Text);

                lb.Text = "";

            }
            catch (Exception)
            {
                if (campo.SelectionStart > 0)
                {
                    campo.SelectionStart--;
                }
                campo.SelectionLength = 1;
                lb.Text = "Conteúdo inválido!";
            } 
        }

        private void AtualizaDataGrid()
        {
            // Limpa conteúdo do DataGrid para inserir novamente os dados mais recentes do banco
            dataGridView1.Rows.Clear();

            try
            {
                // Verifica se a conexão com o banco SQLite está fechada
                if (conn.State != ConnectionState.Open)
                {
                    // Quando estiver fechada, abre a conexão
                    conn.Open();
                }

                // Define SQL para selecionar os dados no banco
                commando.CommandText = "SELECT * FROM tb_cadastros;";
                
                // Executa e reúne os dados retornados pelo banco SQLite
                SQLiteDataReader dados = commando.ExecuteReader();

                // Percorre o conjunto de dados retornado pelo banco
                while (dados.Read())
                {
                    // Recupera o campo ID de uma linha
                    int id = dados.GetInt32(0);
                    
                    // Recupera o campo nome da uma linha
                    string nome = dados.GetString(1);

                    // Insere intem por item no datagrid
                    dataGridView1.Rows.Add(id.ToString(), nome);
                }

                // Fecha o DataReader para que novas operações possam ser realizadas
                dados.Close();


            }
            catch (SQLiteException erro)
            {
                // Em caso de erro, exibe o código e a menssagem do erro
                string TextoStatus = "Ocorreu um erro: " + erro.ErrorCode;
                TextoStatus += " (" + erro.Message + ").";

                status.ForeColor = Color.FromArgb(160, 10, 0);
                status.Text = TextoStatus.Replace("\n", " ").Replace("\r", "");
            }
        }

        private void Conecta_SQLite()
        {
            // Recupera o diretório corrente onde o executável está em execução.
            string DirCorrente = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Nome do arquivo de banco de dados SQLite
            string ArquivoDB = "database.db";

            // Creates a full path that contains your DB file
            string CaminhoAbsoluto = Path.Combine(DirCorrente, ArquivoDB);

            // String de configuração da conexão com o banco SQLite
            string ConnConfig = "Data Source=" + CaminhoAbsoluto + "; Version=3; New=True; Compress=True";
            conn = new SQLiteConnection(ConnConfig);

            try
            {
                // Verifica se a conexão com o banco SQLite está fechada
                if (conn.State != ConnectionState.Open)
                {
                    // Quando estiver fechada, abre a conexão
                    conn.Open();
                }

                // Cria, define e executa SQL para criar uma tabela
                commando = conn.CreateCommand();
                commando.CommandText = "CREATE TABLE IF NOT EXISTS tb_cadastros(id INTEGER PRIMARY KEY ASC, nome CHAR(300) NOT NULL );";
                commando.ExecuteNonQuery();

                // Verifica o estado da conexão antes de fechar
                if (conn.State == ConnectionState.Open)
                {
                    // Fecha a conexão com o banco SQLite
                    conn.Close();
                }

                // Exibe status de operação realizada com sucesso
                status.ForeColor = Color.FromArgb(0, 160, 10);
                status.Text = "Conexão com o banco SQLite bem sucedida!";
            }
            catch (SQLiteException erro)
            {
                // Em caso de erro, exibe o código e a menssagem do erro
                string TextoStatus = "Ocorreu um erro: " + erro.ErrorCode;
                TextoStatus += " (" + erro.Message + ").";

                status.ForeColor = Color.FromArgb(160, 10, 0);
                status.Text = TextoStatus.Replace("\n", " ").Replace("\r", "");
               
            }
        }

        private void Btn_CastastrarCliente_Click(object sender, EventArgs e)
        {
            // Verifica se o campo está vazio e informa no status

            /*
             || ComboBox_MoedaOrigem.SelectedIndex == -1 ||
                ComboBox_MoedaDestino.SelectedIndex == -1 ||
                TBox_valorOriginal.Text.Length == 0 ||
                TBox_valorConvertido.Text.Length == 00
             */

            if (TBox_NomeCliente.Text.Length == 0)
            {
                status.ForeColor = Color.FromArgb(185, 100, 50);
                status.Text = "Preencha todos os campos!!";

                // Interrompe
                return;
            }

            // Recebe o nome de cliente digitado pelo usuário
            string nomeCliente = TBox_NomeCliente.Text;
            
            try
            {
                // Verifica se a conexão com o banco SQLite está fechada
                if (conn.State != ConnectionState.Open)
                {
                    // Quando estiver fechada, abre a conexão
                    conn.Open();
                }

                // Define e executa SQL para inserir os dados no banco
                commando.CommandText =
                    "INSERT INTO tb_cadastros(nome)" +
                    " VALUES ('" + nomeCliente + "');";

                int linhasAlteradas = commando.ExecuteNonQuery();

                // Verifica o estado da conexão antes de fechar
                if (conn.State == ConnectionState.Open)
                {
                    // Fecha a conexão com o banco SQLite
                    conn.Close();
                }

                // Exibe status de operação realizada com sucesso
                status.ForeColor = Color.FromArgb(0, 160, 10);
                status.Text = "Foi inserido " + linhasAlteradas + " iten no banco!";

                // Atualiza o conteúdo exibido no Datagrid para mostrar o item que acabe de ser inserido
                AtualizaDataGrid();
            }
            catch (SQLiteException erro)
            {
                // Em caso de erro, exibe o código e a menssagem do erro
                string TextoStatus = "Ocorreu um erro: " + erro.ErrorCode;
                TextoStatus += " (" + erro.Message + ").";

                status.ForeColor = Color.FromArgb(160, 10, 0);
                status.Text = TextoStatus.Replace("\n", " ").Replace("\r", "");

            }
        }

        private void Btn_LimparCampos_Click(object sender, EventArgs e)
        {
            TBox_NomeCliente.Text = "";
            ComboBox_MoedaOrigem.SelectedIndex = -1;
            ComboBox_MoedaOrigem.Text = "";
            ComboBox_MoedaDestino.SelectedIndex = -1;
            ComboBox_MoedaDestino.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            TBox_valorConvertido.Text = "";
            TBox_valorOriginal.Text = "";
        }

        private void TBox_valorOriginal_TextChanged(object sender, EventArgs e)
        {
            controlaFocoOriginal = true;
            ValidaCampoNumerico(TBox_valorOriginal, LB_ErroOrigem);
        }

        private void TBox_valorOriginal_Enter(object sender, EventArgs e)
        {
            TBox_valorOriginal.SelectionStart = TBox_valorOriginal.Text.Length;
            TBox_valorOriginal.SelectionLength = 0;
        }

        private void TBox_valorOriginal_Leave(object sender, EventArgs e)
        {
            controlaFocoOriginal = false;
        }

        private void TBox_valorOriginal_Click(object sender, EventArgs e)
        {
            if (controlaFocoOriginal == true)
            {
                return;
            }
            TBox_valorOriginal.SelectionStart = TBox_valorOriginal.Text.Length;
            TBox_valorOriginal.SelectionLength = 0;
            controlaFocoOriginal = true;
        }

        private void TBox_valorConvertido_TextChanged(object sender, EventArgs e)
        {
            controlaFocoConvertido = true;
            ValidaCampoNumerico(TBox_valorConvertido, LB_ErroDestino);
        }

        private void TBox_valorConvertido_Enter(object sender, EventArgs e)
        {
            TBox_valorConvertido.SelectionStart = TBox_valorConvertido.Text.Length;
            TBox_valorConvertido.SelectionLength = 0;
        }

        private void TBox_valorConvertido_Leave(object sender, EventArgs e)
        {
            controlaFocoConvertido = false;
        }

        private void TBox_valorConvertido_Click(object sender, EventArgs e)
        {
            if (controlaFocoConvertido == true)
            {
                return;
            }
            TBox_valorConvertido.SelectionStart = TBox_valorConvertido.Text.Length;
            TBox_valorConvertido.SelectionLength = 0;
            controlaFocoConvertido = true;
        }
    }
}
