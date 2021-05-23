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

namespace GerenciadorUpado
{
    public partial class Form1 : Form
    {

        public SQLiteCommand comando;
        public SQLiteConnection con;

        public Form1()
        {
            InitializeComponent();
            con = new SQLiteConnection("Data Source=database.db; Version=3; New=True; Compress=True;");
            comando = con.CreateCommand();
            
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            comando.CommandText = "CREATE TABLE table_name(column1 INTEGER AUTOINCREMENT,column2 datatype,column3 datatype,columnN datatype,);";
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(comando.CommandText + "\n" + Erro.ToString());
            }
            output.Text = tbox_nomeCliente.Text;
            // comando.CommandText = "INSERT INTO ()"

        }
    }
}
