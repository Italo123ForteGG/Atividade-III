using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsForms___Projeto_Oficina
{
    class ClassCliente
    {
        //public int IdCliente { get; set; }
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Celular { get; set; }


        //Objetos
        ClassConexaoBD bd = new ClassConexaoBD();

        //------Métodos CRUD
        public bool Inserir()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Cliente (nome, cpf, cep, endereco, bairro, cidade, celular) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",Nome,Cpf,Cep,Endereco,Bairro,Cidade,Celular));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir cliente. ");
            }
        }

        public DataTable RetTodosClientes()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Cliente"));
            bd.Desconectar();

            return dt;
        }

        public bool Editar(int CodCliente)
        {
            bd.Conectar();
            bd.ExecutarComandosSql(String.Format("UPDATE Cliente SET nome = '{0}', cpf = '{1}', cep = '{2}', endereco = '{3}', bairro = '{4}', cidade = '{5}', celular = '{6}' WHERE codCliente = {7}", Nome, Cpf, Cep, Endereco, Bairro, Cidade, Celular, CodCliente));
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
                bd.ExecutarComandosSql(String.Format("DELETE FROM Cliente WHERE CodCliente = {0} ", CodCliente));
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
