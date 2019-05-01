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
    public partial class frmCadastramentoVeiculo : Form
    {
        public frmCadastramentoVeiculo()
        {
            InitializeComponent();
        }

        DataTable dt;
        ClassVeiculo veiculo = new ClassVeiculo();
        int CodVeiculo = 0;


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

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgvDados.Rows[e.RowIndex].Cells["codVeiculo"].Value.ToString();
            txtModelo.Text = dgvDados.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            txtAno.Text = dgvDados.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
            txtCor.Text = dgvDados.Rows[e.RowIndex].Cells["Cor"].Value.ToString();
            txtMarca.Text = dgvDados.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtKilometragem.Text = dgvDados.Rows[e.RowIndex].Cells["kmAtual"].Value.ToString();
            cmbCombustivel.Text = dgvDados.Rows[e.RowIndex].Cells["Combustivel"].Value.ToString();
            txtDescricao.Text = dgvDados.Rows[e.RowIndex].Cells["Observação"].Value.ToString();
            lblCodigoCliente.Text = dgvDados.Rows[e.RowIndex].Cells["Cliente_codCliente"].Value.ToString();

        }

        private void frmCadastramentoVeiculo_Load(object sender, EventArgs e)
        {
            dgvDados.DataSource = veiculo.RetTodosVeiculos();
            dgvDadosCliente.DataSource = veiculo.RetTodosClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            veiculo.CodVeiculo = txtPlaca.Text;
            veiculo.Modelo = txtModelo.Text;
            veiculo.Ano = int.Parse(txtAno.Text);
            veiculo.Cor = txtCor.Text;
            veiculo.Marca = txtMarca.Text;
            veiculo.KmAtual = int.Parse(txtKilometragem.Text);
            veiculo.Combustivel = cmbCombustivel.Text;

            if (txtDescricao.Text == "")
            {
                veiculo.Observacao = "Sem observações!";
            }
            else
            {
                veiculo.Observacao = txtDescricao.Text;
            }

            if (lblCodigoCliente.Text != "")
            {
                veiculo.CodCliente = int.Parse(lblCodigoCliente.Text);

                if (veiculo.Inserir() == true)
                {
                    dgvDados.DataSource = veiculo.RetTodosVeiculos();
                    MessageBox.Show("Inserido com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Escolha um cliente!");
            }
        }

        private void dgvDadosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigoCliente.Text = dgvDadosCliente.Rows[e.RowIndex].Cells["codCliente"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            veiculo.CodVeiculo = txtPlaca.Text;
            veiculo.Modelo = txtModelo.Text;
            veiculo.Ano = int.Parse(txtAno.Text);
            veiculo.Cor = txtCor.Text;
            veiculo.Marca = txtMarca.Text;
            veiculo.KmAtual = int.Parse(txtKilometragem.Text);
            veiculo.Combustivel = cmbCombustivel.Text;

            if (lblCodigoCliente.Text != "")
            {
                veiculo.CodCliente = int.Parse(lblCodigoCliente.Text);
                if (veiculo.Editar() == true)
                {
                    dgvDados.DataSource = veiculo.RetTodosVeiculos();
                    MessageBox.Show("Editado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Escolha um cliente!");
            }
        }
    }
}
