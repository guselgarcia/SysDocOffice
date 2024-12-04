/*******************************************************************************
 *              Nome: ExameBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Exame com metodos (Inserir, Alterar, Excluir, 
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
    public class ExameBD
    {
        ~ExameBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_EXAME)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Exame)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Exame pobj_Exame)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_EXAME " +
                           " ( " +
                           " S_NM_EXAME, " +
                           " B_JJM_EXAME " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_EXAME, " +
                           " @B_JJM_EXAME " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_EXAME') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@S_NM_EXAME", pobj_Exame.Nm_Exame);
            obj_CMD.Parameters.AddWithValue("@B_JJM_EXAME", pobj_Exame.Jjm_Exame);

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
        *                    Usuários (TB_EXAME)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Exame)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Exame pobj_Exame)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_EXAME SET " +
                           " S_NM_EXAME = @S_NM_EXAME, " +
                           " B_JJM_EXAME= @B_JJM_EXAME " +
                           " WHERE I_COD_EXAME = @I_COD_EXAME ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_EXAME", pobj_Exame.Cod_Exame);
            obj_CMD.Parameters.AddWithValue("@S_NM_EXAME", pobj_Exame.Nm_Exame);
            obj_CMD.Parameters.AddWithValue("@B_JJM_EXAME", pobj_Exame.Jjm_Exame);

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
        *                    Usuários (TB_EXAME)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Exame)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Exame pobj_Exame)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_EXAME " +
                           " WHERE I_COD_EXAME = @I_COD_EXAME ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_EXAME", pobj_Exame.Cod_Exame);

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
        *                    Usuários (TB_EXAME) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Exame)
        *           Returna: Classe Usuário (Exame)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Exame FindByCod(Exame pobj_Exame)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_EXAME " +
                           " WHERE I_COD_EXAME = @I_COD_EXAME ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_EXAME", pobj_Exame.Cod_Exame);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Exame.Cod_Exame = Convert.ToInt16(obj_DTR["I_COD_EXAME"].ToString());
                    pobj_Exame.Nm_Exame = obj_DTR["S_NM_EXAME"].ToString();
                    pobj_Exame.Jjm_Exame = Convert.ToInt16(obj_DTR["B_JJM_EXAME"].ToString()) == 1 ? true : false;
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Exame = new Exame();
            }

            return pobj_Exame;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_EXAME)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Exame>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Exame> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Exame> Lista = new List<Exame>();

            string s_SQL = " SELECT * FROM TB_EXAME ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Exame obj_Exame = new Exame();

                        obj_Exame.Cod_Exame = Convert.ToInt16(obj_DTR["I_COD_EXAME"].ToString());
                        obj_Exame.Nm_Exame = obj_DTR["S_NM_EXAME"].ToString();
                        obj_Exame.Jjm_Exame = Convert.ToInt16(obj_DTR["B_JJM_EXAME"].ToString()) == 1 ? true : false;

                        Lista.Add(obj_Exame);
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
