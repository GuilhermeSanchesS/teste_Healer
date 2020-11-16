using Healer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healer.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComados loginDao = new LoginDaoComados();
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String usuario, String senha, String confSenha)
        {
            LoginDaoComados loginDao = new LoginDaoComados();
            this.mensagem = loginDao.cadastrar(usuario, senha, confSenha);
            if (loginDao.tem) // a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
