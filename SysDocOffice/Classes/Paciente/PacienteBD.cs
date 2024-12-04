/*******************************************************************************
 *              Nome: PacienteBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Paciente com metodos (Inserir, Alterar, Excluir, 
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
    public class PacienteBD
    {
        ~PacienteBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Usuário da Tabela de 
        *                    Usuários (TB_PACIENTE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Paciente)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Paciente pobj_Paciente)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_PACIENTE " +
                           " ( " +
                           " I_COD_CONVENIO, " +
                           " S_NM_PACIENTE, " +
                           " S_CPF_PACIENTE, " +
                           " S_NROCONV_PACIENTE " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_CONVENIO, " +
                           " @S_NM_PACIENTE, " +
                           " @S_CPF_PACIENTE, " +
                           " @S_NROCONV_PACIENTE " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_PACIENTE') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Paciente.Cod_Convenio);
            obj_CMD.Parameters.AddWithValue("@S_NM_PACIENTE", pobj_Paciente.Nm_Paciente);
            obj_CMD.Parameters.AddWithValue("@S_CPF_PACIENTE", pobj_Paciente.CPF_Paciente);
            obj_CMD.Parameters.AddWithValue("@S_NROCONV_PACIENTE", pobj_Paciente.NroConv_Paciente);

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
        *                    Usuários (TB_PACIENTE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Paciente)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Alterar(Paciente pobj_Paciente)
        {
            //Declaração da variável de retorno
            bool b_Alterado = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " UPDATE TB_PACIENTE SET " +
                           " I_COD_CONVENIO = @I_COD_CONVENIO, " +
                           " S_NM_PACIENTE = @S_NM_PACIENTE, " +
                           " S_CPF_PACIENTE= @S_CPF_PACIENTE, " +
                           " S_NROCONV_PACIENTE= @S_NROCONV_PACIENTE " +
                           " WHERE I_COD_PACIENTE = @I_COD_PACIENTE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_PACIENTE", pobj_Paciente.Cod_Paciente);
            obj_CMD.Parameters.AddWithValue("@I_COD_CONVENIO", pobj_Paciente.Cod_Convenio);
            obj_CMD.Parameters.AddWithValue("@S_NM_PACIENTE", pobj_Paciente.Nm_Paciente);
            obj_CMD.Parameters.AddWithValue("@S_CPF_PACIENTE", pobj_Paciente.CPF_Paciente);
            obj_CMD.Parameters.AddWithValue("@S_NROCONV_PACIENTE", pobj_Paciente.NroConv_Paciente);

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
        *                    Usuários (TB_PACIENTE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Paciente)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool Excluir(Paciente pobj_Paciente)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_PACIENTE " +
                           " WHERE I_COD_PACIENTE = @I_COD_PACIENTE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_PACIENTE", pobj_Paciente.Cod_Paciente);

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
        *                    Usuários (TB_PACIENTE) por Código
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe Usuário (Paciente)
        *           Returna: Classe Usuário (Paciente)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public Paciente FindByCod(Paciente pobj_Paciente)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " SELECT * FROM TB_PACIENTE " +
                           " WHERE I_COD_PACIENTE = @I_COD_PACIENTE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_PACIENTE", pobj_Paciente.Cod_Paciente);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    obj_DTR.Read();
                    pobj_Paciente.Cod_Paciente = Convert.ToInt16(obj_DTR["I_COD_PACIENTE"].ToString());
                    pobj_Paciente.Cod_Convenio = Convert.ToInt16(obj_DTR["I_COD_CONVENIO"].ToString());
                    pobj_Paciente.Nm_Paciente = obj_DTR["S_NM_PACIENTE"].ToString();
                    pobj_Paciente.CPF_Paciente = obj_DTR["S_CPF_PACIENTE"].ToString();
                    pobj_Paciente.NroConv_Paciente = obj_DTR["S_NROCONV_PACIENTE"].ToString();
                }

                obj_CONN.Close();
                obj_DTR.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "Erro de Conexão com o Banco",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                pobj_Paciente = new Paciente();
            }

            return pobj_Paciente;
        }

        /*******************************************************************************
        *              Nome: FindAll
        *              Obs.: Responsável por buscar todos os objetos Usuário da Tabela de 
        *                    Usuários (TB_PACIENTE)
        *       Dt. Criação: 09/09/2024
        *         Parametro: -
        *           Returna: Lista de objetos Usuário (List<Paciente>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Paciente> FindAll()
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Paciente> Lista = new List<Paciente>();

            string s_SQL = " SELECT * FROM TB_PACIENTE ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Paciente obj_Paciente = new Paciente();

                        obj_Paciente.Cod_Paciente = Convert.ToInt16(obj_DTR["I_COD_PACIENTE"].ToString());
                        obj_Paciente.Cod_Convenio = Convert.ToInt16(obj_DTR["I_COD_CONVENIO"].ToString());
                        obj_Paciente.Nm_Paciente = obj_DTR["S_NM_PACIENTE"].ToString();
                        obj_Paciente.CPF_Paciente = obj_DTR["S_CPF_PACIENTE"].ToString();
                        obj_Paciente.NroConv_Paciente = obj_DTR["S_NROCONV_PACIENTE"].ToString();
                        Lista.Add(obj_Paciente);
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
