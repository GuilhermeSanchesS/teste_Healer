using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healer.DAL
{
    class LoginDaoComados
    {
        public bool tem = false;
        public String mensagem = ""; // tudo OK
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            cmd.CommandText = "SELECT * FROM logins WHERE usuario = @login AND senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontardo
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
        public String cadastrar(String usuario, String senha, String confSenha)
        {
            tem = false;
            //comandos para iniciar
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "INSERT INTO logins VALUES(@u, @s);";
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de dados";
                }

            }

            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}
