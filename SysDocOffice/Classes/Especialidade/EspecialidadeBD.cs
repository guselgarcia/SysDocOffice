/*******************************************************************************
 *              Nome: EspecialidadeBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Especialidade com metodos (Inserir, Alterar, Excluir, 
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
    public class EspecialidadeBD
    {
        ~EspecialidadeBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_ESPECIALIDADE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Especialidade)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Especialidade pobj_Especialidade)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_ESPECIALIDADE " +
                           " ( " +
                           " S_NM_ESPECIALIDADE, " +
                           " S_DESC_ESPECIALIDADE " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_ESPECIALIDADE, " +
                           " @S_DESC_ESPECIALIDADE " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_ESPECIALIDADE') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@S_NM_ESPECIALIDADE", pobj_Especialidade.Nm_Especialidade);
            obj_CMD.Parameters.AddWithValue("@S_DESC_ESPECIALIDADE", pobj_Especialidade.Desc_Especialidade);

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
        *                    Usuários (TB_ESPECIALIDADE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Especialidade)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Especialidade pobj_Especialidade)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_ESPECIALIDADE SET " +
                           " S_NM_ESPECIALIDADE = @S_NM_ESPECIALIDADE, " +
                           " S_DESC_ESPECIALIDADE= @S_DESC_ESPECIALIDADE " +
                           " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", pobj_Especialidade.Cod_Especialidade);
            obj_CMD.Parameters.AddWithValue("@S_NM_ESPECIALIDADE", pobj_Especialidade.Nm_Especialidade);
            obj_CMD.Parameters.AddWithValue("@S_DESC_ESPECIALIDADE", pobj_Especialidade.Desc_Especialidade);

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
        *                    Usuários (TB_ESPECIALIDADE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Especialidade)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Especialidade pobj_Especialidade)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_ESPECIALIDADE " +
                           " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", pobj_Especialidade.Cod_Especialidade);

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
        *                    Usuários (TB_ESPECIALIDADE) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Especialidade)
        *           Returna: Classe Usuário (Especialidade)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Especialidade FindByCod(Especialidade pobj_Especialidade)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_ESPECIALIDADE " +
                           " WHERE I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", pobj_Especialidade.Cod_Especialidade);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();

                    pobj_Especialidade.Nm_Especialidade = obj_DTR["S_NM_ESPECIALIDADE"].ToString();
                    pobj_Especialidade.Desc_Especialidade = obj_DTR["S_DESC_ESPECIALIDADE"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Especialidade = new Especialidade();
            }

            return pobj_Especialidade;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_ESPECIALIDADE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Especialidade>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Especialidade> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Especialidade> Lista = new List<Especialidade>();

            string s_SQL = " SELECT * FROM TB_ESPECIALIDADE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Especialidade obj_Especialidade = new Especialidade();

                        obj_Especialidade.Cod_Especialidade = Convert.ToInt16(obj_DTR["I_COD_ESPECIALIDADE"].ToString());
                        obj_Especialidade.Nm_Especialidade = obj_DTR["S_NM_ESPECIALIDADE"].ToString();
                        obj_Especialidade.Desc_Especialidade = obj_DTR["S_DESC_ESPECIALIDADE"].ToString();

                        Lista.Add(obj_Especialidade);
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
