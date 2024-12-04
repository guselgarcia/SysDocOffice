/*******************************************************************************
 *              Nome: ConvenioBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Convenio com metodos (Inserir, Alterar, Excluir, 
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
    public class ConvenioBD
    {
        ~ConvenioBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_CONVENIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Convenio)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Convenio pobj_Convenio)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_CONVENIO " +
                           " ( " +
                           " S_NM_CONVENIO, " +
                           " I_MOD_CONVENIO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @S_NM_CONVENIO, " +
                           " @I_MOD_CONVENIO " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_CONVENIO') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@S_NM_CONVENIO", pobj_Convenio.Nm_Convenio);
            obj_CMD.Parameters.AddWithValue("@I_MOD_CONVENIO", pobj_Convenio.Mod_Convenio);

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
        *                    Usuários (TB_CONVENIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Convenio)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Convenio pobj_Convenio)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_CONVENIO SET " +
                           " S_NM_CONVENIO = @S_NM_CONVENIO, " +
                           " I_MOD_CONVENIO= @I_MOD_CONVENIO " +
                           " WHERE I_COD_CONVENIO = @I_COD_CONVENIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);
            obj_CMD.Parameters.AddWithValue("@S_NM_CONVENIO", pobj_Convenio.Nm_Convenio);
            obj_CMD.Parameters.AddWithValue("@I_MOD_CONVENIO", pobj_Convenio.Mod_Convenio);

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
        *                    Usuários (TB_CONVENIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Convenio)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Convenio pobj_Convenio)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_CONVENIO " +
                           " WHERE I_COD_CONVENIO = @I_COD_CONVENIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);

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
        *                    Usuários (TB_CONVENIO) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Convenio)
        *           Returna: Classe Usuário (Convenio)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Convenio FindByCod(Convenio pobj_Convenio)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_CONVENIO " +
                           " WHERE I_COD_CONVENIO = @I_COD_CONVENIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Convenio.Cod_Convenio);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();

                    pobj_Convenio.Nm_Convenio = obj_DTR["S_NM_CONVENIO"].ToString();
                    pobj_Convenio.Mod_Convenio = Convert.ToInt16(obj_DTR["I_MOD_CONVENIO"].ToString());
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Convenio = new Convenio();
            }

            return pobj_Convenio;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_CONVENIO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Convenio>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Convenio> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Convenio> Lista = new List<Convenio>();

            string s_SQL = " SELECT * FROM TB_CONVENIO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Convenio obj_Convenio = new Convenio();

                        obj_Convenio.Cod_Convenio = Convert.ToInt16(obj_DTR["I_COD_CONVENIO"].ToString());
                        obj_Convenio.Nm_Convenio = obj_DTR["S_NM_CONVENIO"].ToString();
                        obj_Convenio.Mod_Convenio = Convert.ToInt16(obj_DTR["I_MOD_CONVENIO"].ToString());

                        Lista.Add(obj_Convenio);
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
