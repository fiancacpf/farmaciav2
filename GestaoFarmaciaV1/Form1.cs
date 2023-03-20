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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string vUser = Convert.ToString(tbUser.Text);
            string vPass = Convert.ToString(tbPass.Text);
            if(vUser == "admin"){
                if (vPass == "123456") {
                    //MessageBox.Show("Login efectuado com sucesso");
                    this.Hide();
                    Form fp = new fProdutos();
                    fp.Show();
                }else
                    MessageBox.Show("Senha incorreta");
            }else
                MessageBox.Show("Usuário inválido");
        }
    }
}
