/*******************************************************************************
 *              Nome: MedicoBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Medico com metodos (Inserir, Alterar, Excluir, 
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
    public class MedicoBD
    {
        ~MedicoBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_MEDICO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Medico)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Medico pobj_Medico)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_MEDICO " +
                           " ( " +
                           " I_COD_ESPECIALIDADE, "+
                           " S_NM_MEDICO, " +
                           " S_CRM_MEDICO " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_ESPECIALIDADE, " +
                           " @S_NM_MEDICO, " +
                           " @S_CRM_MEDICO " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_MEDICO') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", pobj_Medico.Cod_Especialidade);
            obj_CMD.Parameters.AddWithValue("@S_NM_MEDICO", pobj_Medico.Nm_Medico);
            obj_CMD.Parameters.AddWithValue("@S_CRM_MEDICO", pobj_Medico.CRM_Medico);

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
        *                    Usuários (TB_MEDICO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Medico)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Medico pobj_Medico)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_MEDICO SET " +
                           " I_COD_ESPECIALIDADE = @I_COD_ESPECIALIDADE, " +
                           " S_NM_MEDICO = @S_NM_MEDICO, " +
                           " S_CRM_MEDICO= @S_CRM_MEDICO " +
                           " WHERE I_COD_MEDICO = @I_COD_MEDICO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_MEDICO", pobj_Medico.Cod_Medico);
            obj_CMD.Parameters.AddWithValue("@I_COD_ESPECIALIDADE", pobj_Medico.Cod_Especialidade);
            obj_CMD.Parameters.AddWithValue("@S_NM_MEDICO", pobj_Medico.Nm_Medico);
            obj_CMD.Parameters.AddWithValue("@S_CRM_MEDICO", pobj_Medico.CRM_Medico);

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
        *                    Usuários (TB_MEDICO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Medico)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Medico pobj_Medico)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_MEDICO " +
                           " WHERE I_COD_MEDICO = @I_COD_MEDICO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_MEDICO", pobj_Medico.Cod_Medico);

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
        *                    Usuários (TB_MEDICO) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Medico)
        *           Returna: Classe Usuário (Medico)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Medico FindByCod(Medico pobj_Medico)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_MEDICO " +
                           " WHERE I_COD_MEDICO = @I_COD_MEDICO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_MEDICO", pobj_Medico.Cod_Medico);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Medico.Cod_Medico = Convert.ToInt16(obj_DTR["I_COD_MEDICO"].ToString());
                    pobj_Medico.Cod_Especialidade = Convert.ToInt16(obj_DTR["I_COD_ESPECIALIDADE"].ToString());
                    pobj_Medico.Nm_Medico = obj_DTR["S_NM_MEDICO"].ToString();
                    pobj_Medico.CRM_Medico = obj_DTR["S_CRM_MEDICO"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Medico = new Medico();
            }

            return pobj_Medico;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_MEDICO)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Medico>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Medico> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Medico> Lista = new List<Medico>();

            string s_SQL = " SELECT * FROM TB_MEDICO ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Medico obj_Medico = new Medico();

                        obj_Medico.Cod_Medico = Convert.ToInt16(obj_DTR["I_COD_MEDICO"].ToString());
                        obj_Medico.Cod_Especialidade = Convert.ToInt16(obj_DTR["I_COD_ESPECIALIDADE"].ToString());
                        obj_Medico.Nm_Medico = obj_DTR["S_NM_MEDICO"].ToString();
                        obj_Medico.CRM_Medico = obj_DTR["S_CRM_MEDICO"].ToString();

                        Lista.Add(obj_Medico);
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
