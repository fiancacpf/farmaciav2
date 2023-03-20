using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFarmaciaV1
{
    public partial class fAdProduto : Form
    {
        public fAdProduto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string vNome = Convert.ToString(tbNome.Text);
            string vPreco = Convert.ToString(tbPreco.Text);
            string vStock = Convert.ToString(tbStock.Text);
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    if (vNome != "" && vPreco != "" && vStock != "")
                    {
                        cn.Open();
                        SqlCommand cmd = new SqlCommand("insert into produtos(nome, preco, qtd, validade) values('" + vNome + "', " + vPreco + ", " + vStock + ", '2025-01-01')", cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Produto inserido com sucesso!");
                        tbNome.Text = "";
                        tbPreco.Text = "";
                        tbStock.Text = "";
                    }else
                        MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha \n\n\n" + ex.Message);
            }
        }

        private void btnVP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fp = new fProdutos();
            fp.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
