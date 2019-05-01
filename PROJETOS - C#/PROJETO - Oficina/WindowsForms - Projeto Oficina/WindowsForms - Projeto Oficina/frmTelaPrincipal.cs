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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente frmCadastrarCliente = new frmCadastrarCliente();
            this.Hide();
            frmCadastrarCliente.Show();
        }

        private void btnCliente_MouseEnter(object sender, EventArgs e)
        {
            if (panel1Esquerdo.Visible == false && panel1Direito.Visible == false)
            {
                panel1Esquerdo.Visible = true;
                panel1Direito.Visible = true;

            }
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            if (panel1Esquerdo.Visible == true && panel1Direito.Visible == true)
            {
                panel1Esquerdo.Visible = false;
                panel1Direito.Visible = false;

            }
        }

        private void btnVeiculo_MouseEnter(object sender, EventArgs e)
        {
            if (panel2Esquerdo.Visible == false && panel2Direito.Visible == false)
            {
                panel2Esquerdo.Visible = true;
                panel2Direito.Visible = true;

            }
        }

        private void btnVeiculo_MouseLeave(object sender, EventArgs e)
        {
            if (panel2Esquerdo.Visible == true && panel2Direito.Visible == true)
            {
                panel2Esquerdo.Visible = false;
                panel2Direito.Visible = false;

            }
        }

        private void btnServiço_MouseEnter(object sender, EventArgs e)
        {
            if (panel3Esquerdo.Visible == false && panel3Direito.Visible == false)
            {
                panel3Esquerdo.Visible = true;
                panel3Direito.Visible = true;

            }
        }

        private void btnServiço_MouseLeave(object sender, EventArgs e)
        {
            if (panel3Esquerdo.Visible == true && panel3Direito.Visible == true)
            {
                panel3Esquerdo.Visible = false;
                panel3Direito.Visible = false;

            }
        }

        private void btnAgendamento_MouseEnter(object sender, EventArgs e)
        {
            if (panel4Esquerdo.Visible == false && panel4Direito.Visible == false)
            {
                panel4Esquerdo.Visible = true;
                panel4Direito.Visible = true;

            }
        }

        private void btnAgendamento_MouseLeave(object sender, EventArgs e)
        {
            if (panel4Esquerdo.Visible == true && panel4Direito.Visible == true)
            {
                panel4Esquerdo.Visible = false;
                panel4Direito.Visible = false;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            if (btnFechar.FlatAppearance.BorderSize == 0)
            {
                btnFechar.FlatAppearance.BorderSize = 2;
            }
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            if (btnFechar.FlatAppearance.BorderSize == 2)
            {
                btnFechar.FlatAppearance.BorderSize = 0;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            if (btnMinimizar.FlatAppearance.BorderSize == 0)
            {
                btnMinimizar.FlatAppearance.BorderSize = 2;
            }
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            if (btnMinimizar.FlatAppearance.BorderSize == 2)
            {
                btnMinimizar.FlatAppearance.BorderSize = 0;
            }
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            frmCadastramentoVeiculo frmCadastramentoVeiculo = new frmCadastramentoVeiculo();
            this.Hide();
            frmCadastramentoVeiculo.Show();
        }
    }
}
