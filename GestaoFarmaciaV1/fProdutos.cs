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
    public partial class fProdutos : Form
    {
        public fProdutos()
        {
            InitializeComponent();
        }

        private void fProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From produtos", cn);
                    SqlDataReader Dr = cmd.ExecuteReader();
                    lbProduto.Items.Clear();
                    while (Dr.Read())
                    {
                        for (int i = 0; i != 20; i++)
                        {
                            lbProduto.Items.Add(Convert.ToString(Dr["nome"]) + " - " + Convert.ToString(Dr["preco"]) + " Kz - " + Convert.ToString(Dr["qtd"]));
                        }
                    }
                    cn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha \n\n\n" + ex.Message);
            }
        }

        private void lbPpreco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fp = new fAdProduto();
            fp.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
