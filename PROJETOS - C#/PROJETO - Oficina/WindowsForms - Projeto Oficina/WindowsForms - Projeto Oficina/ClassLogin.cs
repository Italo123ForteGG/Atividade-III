using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsForms___Projeto_Oficina
{
    class ClassLogin
    {
        ClassConexaoBD bd = new ClassConexaoBD();

        public int codLogin { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email{ get; set; }


        public DataTable RealizarLogin()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE ATLogin LIKE '{0}' AND senha LIKE '{1}'", Login, Senha));
            bd.Desconectar();

            return dt;
        }

        public DataTable EsqueceuSenha()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email = '{0}'", Email));
            bd.Desconectar();

            return dt;
        }

    }
}
