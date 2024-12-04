/*******************************************************************************
 *              Nome: UsuarioBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Usuario com metodos (Inserir, Alterar, Excluir, 
 *                    FindByCod e FindAll) públicos.
 *       Dt. Criação: 09/09/2024
 *     Dt. Alteração: -
 *    Obs. Alteração: -
 *        Criada por: Monstro (mFacine)
 *              Obs.: 
 *******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SysDocOffice
{
    public class UsuarioBD
    {
        ~UsuarioBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_USUARIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Usuario)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Usuario pobj_Usuario)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_USUARIO " +
                           " ( " +
                           " S_NM_USUARIO, " +
                           " S_UNM_USUARIO, " +
                           " S_PW_USUARIO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_USUARIO, " +
                           " @S_UNM_USUARIO, " +
                           " @S_PW_USUARIO " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_USUARIO') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@S_NM_USUARIO", pobj_Usuario.Nm_Usuario);
            obj_CMD.Parameters.AddWithValue("@S_UNM_USUARIO", pobj_Usuario.UNm_Usuario);
            obj_CMD.Parameters.AddWithValue("@S_PW_USUARIO", pobj_Usuario.PW_Usuario);

            try
            {
                obj_CONN.Open();
                i_ID = Convert.ToInt16(obj_CMD.ExecuteScalar());
                obj_CONN.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return i_ID;
        }

        /*******************************************************************************
        *              Nome: Alterar
        *              Obs.: Responsável por alterar um objeto Usuário da Tabela de 
        *                    Usuários (TB_USUARIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Usuario)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Usuario pobj_Usuario)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_USUARIO SET " +
                           " S_NM_USUARIO = @S_NM_USUARIO, " +
                           " S_UNM_USUARIO= @S_UNM_USUARIO, " +
                           " S_PW_USUARIO = @S_PW_USUARIO " +
                           " WHERE I_COD_USUARIO = @I_COD_USUARIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);
            obj_CMD.Parameters.AddWithValue("@S_NM_USUARIO", pobj_Usuario.Nm_Usuario);
            obj_CMD.Parameters.AddWithValue("@S_UNM_USUARIO", pobj_Usuario.UNm_Usuario);
            obj_CMD.Parameters.AddWithValue("@S_PW_USUARIO", pobj_Usuario.PW_Usuario);

            try
            {
                obj_CONN.Open();
                obj_CMD.ExecuteNonQuery();
                obj_CONN.Close();
                b_Alterado = true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return b_Alterado;
        }

        /*******************************************************************************
        *              Nome: Excluir
        *              Obs.: Responsável por excluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_USUARIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Usuario)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Usuario pobj_Usuario)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_USUARIO " +
                           " WHERE I_COD_USUARIO = @I_COD_USUARIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);

            try
            {
                obj_CONN.Open();
                obj_CMD.ExecuteNonQuery();
                obj_CONN.Close();
                b_Excluido = true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return b_Excluido;
        }

        /*******************************************************************************
        *              Nome: FindByCod
        *              Obs.: Responsável por buscar um objeto Usuário da Tabela de 
        *                    Usuários (TB_USUARIO) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Usuario)
        *           Returna: Classe Usuário (Usuario)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Usuario FindByCod(Usuario pobj_Usuario)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_USUARIO " +
                           " WHERE I_COD_USUARIO = @I_COD_USUARIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_USUARIO", pobj_Usuario.Cod_Usuario);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();

                    pobj_Usuario.Nm_Usuario = obj_DTR["S_NM_USUARIO"].ToString();
                    pobj_Usuario.UNm_Usuario = obj_DTR["S_UNM_USUARIO"].ToString();
                    pobj_Usuario.PW_Usuario = obj_DTR["S_PW_USUARIO"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();

                
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Usuario = new Usuario();
            }

            return pobj_Usuario;
        }

        /*******************************************************************************
        *              Nome: FindByUNm
        *              Obs.: Responsável por buscar um objeto Usuário da Tabela de 
        *                    Usuários (TB_USUARIO) por Nome do Usuário 
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Usuario)
        *           Returna: Classe Usuário (Usuario)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Usuario FindByUNm(Usuario pobj_Usuario)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_USUARIO " +
                           " WHERE S_UNM_USUARIO = @S_UNM_USUARIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@S_UNM_USUARIO", pobj_Usuario.UNm_Usuario);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Usuario.Cod_Usuario = Convert.ToInt16(obj_DTR["I_COD_USUARIO"].ToString());
                    pobj_Usuario.Nm_Usuario = obj_DTR["S_NM_USUARIO"].ToString();
                    pobj_Usuario.UNm_Usuario = obj_DTR["S_UNM_USUARIO"].ToString();
                    pobj_Usuario.PW_Usuario = obj_DTR["S_PW_USUARIO"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Usuario = new Usuario();
            }

            return pobj_Usuario;
        }

        /*******************************************************************************
*              Nome: FindAll
*              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
*                    Usuários (TB_USUARIO)
*       Dt. Criação: 09/09/2024
*         Parametro: -
*           Returna: Lista de objetos Usuário (List<Usuario>)
*     Dt. Alteração: -
*    Obs. Alteração: -
*        Criada por: Monstro (mFacine)
*              Obs.: Esta classe se conecta com  o banco através da 
*                    classe Connection.
*******************************************************************************/
        public List<Usuario> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Usuario> Lista = new List<Usuario>();

            string s_SQL = " SELECT * FROM TB_USUARIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Usuario obj_Usuario = new Usuario();

                        obj_Usuario.Cod_Usuario = Convert.ToInt16(obj_DTR["I_COD_USUARIO"].ToString());
                        obj_Usuario.Nm_Usuario = obj_DTR["S_NM_USUARIO"].ToString();
                        obj_Usuario.UNm_Usuario = obj_DTR["S_UNM_USUARIO"].ToString();
                        obj_Usuario.PW_Usuario = obj_DTR["S_PW_USUARIO"].ToString();

                        Lista.Add(obj_Usuario);
                    }

                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Lista;
        }

    }
}
