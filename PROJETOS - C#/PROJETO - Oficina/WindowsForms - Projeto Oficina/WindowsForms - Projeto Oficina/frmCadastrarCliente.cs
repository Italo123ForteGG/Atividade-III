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
    public partial class frmCadastrarCliente : Form
    {
        ClassCliente usuario = new ClassCliente();

        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            dgvDados.DataSource = usuario.RetTodosClientes();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvDados.SelectedCells.Count < 0)
                lblCodigoCliente.Text = dgvDados.Rows[e.RowIndex].Cells["codCliente"].Value.ToString();
                txtNome.Text = dgvDados.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtCPF.Text = dgvDados.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                txtCEP.Text = dgvDados.Rows[e.RowIndex].Cells["cep"].Value.ToString();
                txtEndereco.Text = dgvDados.Rows[e.RowIndex].Cells["endereco"].Value.ToString();
                txtBairro.Text = dgvDados.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                txtCidade.Text = dgvDados.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                txtCidade.Text = dgvDados.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
                txtCelular.Text = dgvDados.Rows[e.RowIndex].Cells["celular"].Value.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Cpf = txtCPF.Text;
            usuario.Cep = txtCEP.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.Bairro = txtBairro.Text;
            usuario.Cidade = txtCidade.Text;
            usuario.Celular = txtCelular.Text;

            if (usuario.Inserir() == true)
            {
                dgvDados.DataSource = usuario.RetTodosClientes();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cadastramento não realizado! ");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int CodCliente = int.Parse(lblCodigoCliente.Text);
            usuario.Nome = txtNome.Text;
            usuario.Cpf = txtCPF.Text;
            usuario.Cep = txtCEP.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.Bairro = txtBairro.Text;
            usuario.Cidade = txtCidade.Text;
            usuario.Celular = txtCelular.Text;

            if (usuario.Editar(CodCliente) == true)
            {
                dgvDados.DataSource = usuario.RetTodosClientes();
                MessageBox.Show("Código editado com sucesso!");
            }
            else
            {
                MessageBox.Show("Código não editado com sucesso! ");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lblCodigoCliente.Text != "")
            {
                int CodCliente = int.Parse(lblCodigoCliente.Text);
                usuario.Excluir(CodCliente);
                dgvDados.DataSource = usuario.RetTodosClientes();
                MessageBox.Show("Exclusão feita com sucesso!");
            }
            else
            {
                MessageBox.Show("Esta seleção está completamente vazia!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
            this.Hide();
            frmTelaPrincipal.Show();
        }
    }
}
