using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDocOffice
{
    internal class QuartoBD
    {
        ~QuartoBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_QUARTO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Quarto)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Quarto pobj_Quarto)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_QUARTO " +
                           " ( " +
                           " I_AND_QUARTO, "+
                           " I_NRO_QUARTO, "+
                           " I_TP_QUARTO   " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_AND_QUARTO, " +
                           " @I_NRO_QUARTO, " +
                           " @I_TP_QUARTO   " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_QUARTO') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_AND_QUARTO", pobj_Quarto.And_Quarto);
            obj_CMD.Parameters.AddWithValue("@I_NRO_QUARTO", pobj_Quarto.Nro_Quarto);
            obj_CMD.Parameters.AddWithValue("@I_TP_QUARTO", pobj_Quarto.Tp_Quarto);

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
        *                    Usuários (TB_QUARTO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Quarto)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Quarto pobj_Quarto)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_QUARTO SET " +
                           " I_AND_QUARTO = @I_AND_QUARTO, " +
                           " I_NRO_QUARTO = @I_NRO_QUARTO, "+
                           " I_TP_QUARTO  = @I_TP_QUARTO  "+
                           " WHERE I_COD_QUARTO = @I_COD_QUARTO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_QUARTO", pobj_Quarto.Cod_Quarto);
            obj_CMD.Parameters.AddWithValue("@I_AND_QUARTO", pobj_Quarto.And_Quarto);
            obj_CMD.Parameters.AddWithValue("@I_NRO_QUARTO", pobj_Quarto.Nro_Quarto);
            obj_CMD.Parameters.AddWithValue("@I_TP_QUARTO ", pobj_Quarto.Tp_Quarto);

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
        *                    Usuários (TB_QUARTO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Quarto)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Quarto pobj_Quarto)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_QUARTO " +
                           " WHERE I_COD_QUARTO = @I_COD_QUARTO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_QUARTO", pobj_Quarto.Cod_Quarto);

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
        *                    Usuários (TB_QUARTO) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Quarto)
        *           Returna: Classe Usuário (Quarto)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Quarto FindByCod(Quarto pobj_Quarto)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_QUARTO " +
                           " WHERE I_COD_QUARTO = @I_COD_QUARTO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_QUARTO", pobj_Quarto.Cod_Quarto);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Quarto.Cod_Quarto = Convert.ToInt16(obj_DTR["I_COD_QUARTO"].ToString());
                    pobj_Quarto.And_Quarto = Convert.ToInt16(obj_DTR["I_AND_QUARTO"].ToString());
                    pobj_Quarto.Nro_Quarto = Convert.ToInt16(obj_DTR["I_NRO_QUARTO"].ToString());
                    pobj_Quarto.Tp_Quarto  = Convert.ToInt16(obj_DTR["I_TP_QUARTO"].ToString());
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Quarto = new Quarto();
            }

            return pobj_Quarto;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_QUARTO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Quarto>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Quarto> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Quarto> Lista = new List<Quarto>();

            string s_SQL = " SELECT * FROM TB_QUARTO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Quarto obj_Quarto = new Quarto();

                        obj_Quarto.Cod_Quarto = Convert.ToInt16(obj_DTR["I_COD_QUARTO"].ToString());
                        obj_Quarto.And_Quarto = Convert.ToInt16(obj_DTR["I_AND_QUARTO"].ToString());
                        obj_Quarto.Nro_Quarto = Convert.ToInt16(obj_DTR["I_NRO_QUARTO"].ToString());
                        obj_Quarto.Tp_Quarto = Convert.ToInt16(obj_DTR["I_TP_QUARTO"].ToString());

                        Lista.Add(obj_Quarto);
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
