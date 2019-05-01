using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms___Projeto_Oficina
{
    public partial class frmLogin : Form
    {
        ClassLogin usuario = new ClassLogin();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_MouseEnter(object sender, EventArgs e)
        {
            btnLogar.BackColor = Color.Red;
            btnLogar.ForeColor = Color.White;
        }

        private void btnLogar_MouseLeave(object sender, EventArgs e)
        {
            btnLogar.BackColor = Color.White;
            btnLogar.ForeColor = Color.Red;
        }

        private void lblESenha_MouseEnter(object sender, EventArgs e)
        {
            lblESenha.ForeColor = Color.Red;
        }

        private void lblESenha_MouseLeave(object sender, EventArgs e)
        {
            lblESenha.ForeColor = Color.DarkGray;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
             if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por favor preencher todos os campos!");
            }
            else if (txtUsuario.Text == "Usuário" && txtSenha.Text == "Senha")
            {
                MessageBox.Show("Por favor preencher todos os campos!");
            }
            else
            {
                usuario.Login = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                DataTable dt = usuario.RealizarLogin();

                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0]["ATLogin"].ToString() == usuario.Login && dt.Rows[0]["senha"].ToString() == usuario.Senha)
                    {
                        frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
                        this.Hide();
                        frmTelaPrincipal.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSenha.Text = "Senha";
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
            }
        }

        private void txtSenha_Enter_1(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave_1(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.UseSystemPasswordChar = false;
            }
        }
    }
}
