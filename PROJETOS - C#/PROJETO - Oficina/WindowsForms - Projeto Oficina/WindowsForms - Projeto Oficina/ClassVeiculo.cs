using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsForms___Projeto_Oficina
{
    class ClassVeiculo
    {
        public string CodVeiculo { get; set; }
        public int CodCliente { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int KmAtual { get; set; }
        public string Combustivel { get; set; }
        public string Observacao { get; set; }

        ClassConexaoBD bd = new ClassConexaoBD();

        //------Métodos CRUD
        public bool Inserir()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(string.Format("INSERT INTO Veiculo (codVeiculo, Modelo, Cliente_codCliente, Ano, Cor, Marca, kmAtual, Combustivel, Observação) VALUES ('{0}', '{1}', {2}, {3},'{4}', '{5}', {6},'{7}', '{8}')", CodVeiculo, Modelo, CodCliente, Ano, Cor, Marca, KmAtual, Combustivel, Observacao));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir cliente. ");
            }
        }

        public DataTable RetTodosVeiculos()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Veiculo"));
            bd.Desconectar();

            return dt;
        }

        public DataTable RetTodosClientes()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente"));
            bd.Desconectar();

            return dt;
        }

        public bool Editar()
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Veiculo SET Modelo = '{0}', Cliente_codCliente = {1}, Ano = {2}, Cor = '{3}', Marca= '{4}', kmAtual = {5}, Combustivel = '{6}', Observação = '{7}' WHERE codVeiculo = {8}", Modelo, CodCliente, Ano, Cor, Marca, KmAtual, Combustivel, Observacao, CodVeiculo));
            bd.Desconectar();

            return true;
        }

        //public DataTable RetClientePorNome(string nome)
        //{
        //    bd.Conectar();
        //    DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente WHERE nome LIKE '%{0}%' ", Nome));
        //    bd.Desconectar();

        //    return dt;
        //}

        public bool Excluir(int CodCliente)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE FROM Veiculo WHERE CodVeiculo = {0} ", CodVeiculo));
                bd.Desconectar();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir cliente. ");
            }
        }


    }
}
