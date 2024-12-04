/*******************************************************************************
 *              Nome: ConsultaBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Consulta com metodos (Inserir, Alterar, Excluir, 
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
    public class ConsultaBD
    {
        ~ConsultaBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_CONSULTA)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Consulta)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Consulta pobj_Consulta)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_CONSULTA " +
                           " ( " +
                           " I_COD_MEDICO, " +
                           " I_COD_PACIENTE, " +
                           " DT_DH_CONSULTA, " +
                           " S_DESC_CONSULTA " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_MEDICO, " +
                           " @I_COD_PACIENTE, " +
                           " @DT_DH_CONSULTA, " +
                           " @S_DESC_CONSULTA " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_CONSULTA') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_MEDICO", pobj_Consulta.Cod_Medico);
            obj_CMD.Parameters.AddWithValue("@I_COD_PACIENTE", pobj_Consulta.Cod_Paciente);
            obj_CMD.Parameters.AddWithValue("@DT_DH_CONSULTA", pobj_Consulta.DH_Consulta);
            obj_CMD.Parameters.AddWithValue("@S_DESC_CONSULTA", pobj_Consulta.Desc_Consulta);

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
        *                    Usuários (TB_CONSULTA)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Consulta)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Consulta pobj_Consulta)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_CONSULTA SET " +
                           " I_COD_MEDICO = @I_COD_MEDICO, " +
                           " I_COD_PACIENTE = @I_COD_PACIENTE, " +
                           " DT_DH_CONSULTA= @DT_DH_CONSULTA, " +
                           " S_DESC_CONSULTA= @S_DESC_CONSULTA " +
                           " WHERE I_COD_CONSULTA = @I_COD_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Consulta.Cod_Consulta);
            obj_CMD.Parameters.AddWithValue("@I_COD_MEDICO", pobj_Consulta.Cod_Medico);
            obj_CMD.Parameters.AddWithValue("@I_COD_PACIENTE", pobj_Consulta.Cod_Paciente);
            obj_CMD.Parameters.AddWithValue("@DT_DH_CONSULTA", pobj_Consulta.DH_Consulta);
            obj_CMD.Parameters.AddWithValue("@S_DESC_CONSULTA", pobj_Consulta.Desc_Consulta);

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
        *                    Usuários (TB_CONSULTA)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Consulta)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Consulta pobj_Consulta)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_CONSULTA " +
                           " WHERE I_COD_CONSULTA = @I_COD_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Consulta.Cod_Consulta);

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
        *                    Usuários (TB_CONSULTA) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Consulta)
        *           Returna: Classe Usuário (Consulta)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Consulta FindByCod(Consulta pobj_Consulta)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_CONSULTA " +
                           " WHERE I_COD_CONSULTA = @I_COD_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Consulta.Cod_Consulta);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Consulta.Cod_Consulta = Convert.ToInt16(obj_DTR["I_COD_CONSULTA"].ToString());
                    pobj_Consulta.Cod_Medico = Convert.ToInt16(obj_DTR["I_COD_MEDICO"].ToString());
                    pobj_Consulta.Cod_Paciente = Convert.ToInt16(obj_DTR["I_COD_PACIENTE"].ToString());
                    pobj_Consulta.DH_Consulta = Convert.ToDateTime(obj_DTR["DT_DH_CONSULTA"].ToString());
                    pobj_Consulta.Desc_Consulta = obj_DTR["S_DESC_CONSULTA"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Consulta = new Consulta();
            }

            return pobj_Consulta;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_CONSULTA)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Consulta>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Consulta> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Consulta> Lista = new List<Consulta>();

            string s_SQL = " SELECT * FROM TB_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Consulta obj_Consulta = new Consulta();

                        obj_Consulta.Cod_Consulta = Convert.ToInt16(obj_DTR["I_COD_CONSULTA"].ToString());
                        obj_Consulta.Cod_Medico = Convert.ToInt16(obj_DTR["I_COD_MEDICO"].ToString());
                        obj_Consulta.Cod_Paciente = Convert.ToInt16(obj_DTR["I_COD_PACIENTE"].ToString());
                        obj_Consulta.DH_Consulta = Convert.ToDateTime(obj_DTR["DT_DH_CONSULTA"].ToString());
                        obj_Consulta.Desc_Consulta = obj_DTR["S_DESC_CONSULTA"].ToString();

                        Lista.Add(obj_Consulta);
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
