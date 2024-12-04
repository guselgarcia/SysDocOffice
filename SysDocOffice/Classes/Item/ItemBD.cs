/*******************************************************************************
 *              Nome: ItemBD
 *              Obs.: Esta classe representa a Entidade de controle de Banco de 
 *                    dados Item com metodos (Inserir, Alterar, Excluir, 
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
    public class ItemBD
    {
        ~ItemBD()
        {

        }

        /*******************************************************************************
        *              Nome: Incluir
        *              Obs.: Responsável por incluir um objeto Item da Tabela de 
        *                    Items (TB_ITEM)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe item (Item)
        *           Returna: Inteiro (int) Último identificador da tabela
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public int Incluir(Item pobj_Item)
        {
            //Declaração da variável de retorno
            int i_ID = -1;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " INSERT INTO TB_ITEM " +
                           " ( " +
                           " I_COD_CONSULTA, " +
                           " I_COD_EXAME " +
                           " ) " +
                           " VALUES " +
                           " ( " +
                           " @I_COD_CONSULTA, " +
                           " @I_COD_EXAME " +
                           " ); " +
                           " SELECT IDENT_CURRENT ('TB_ITEM') AS 'ID' ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Item.Cod_Consulta);
            obj_CMD.Parameters.AddWithValue("@I_COD_EXAME", pobj_Item.Cod_Exame);

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
        *              Nome: ExcluirByCodConsulta
        *              Obs.: Responsável por excluir um objeto item da Tabela de 
        *                    Item mediante o Codigo da Consulta (TB_ITEM)
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe item (Item)
        *           Returna: Booleano (bool) 
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public bool ExcluirByCodConsulta(Item pobj_Item)
        {
            //Declaração da variável de retorno
            bool b_Excluido = false;

            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            string s_SQL = " DELETE FROM TB_ITEM " +
                           " WHERE I_COD_CONSULTA = @I_COD_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Item.Cod_Consulta);

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
        *              Nome: FindAllByCodConsulta
        *              Obs.: Responsável por buscar todos os objetos Item da Tabela de 
        *                    Items (TB_ITEM) mediante o código da Consulta.
        *       Dt. Criação: 09/09/2024
        *         Parametro: Classe item (Item)
        *           Returna: Lista de objetos Item (List<Item>)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: Esta classe se conecta com  o banco através da 
        *                    classe Connection.
        *******************************************************************************/
        public List<Item> FindAllByCodConsulta(Item pobj_Item)
        {
            //Conexão com o Banco de Dados
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Item> Lista = new List<Item>();

            string s_SQL = " SELECT * FROM TB_ITEM "+
                           " WHERE I_COD_CONSULTA = @I_COD_CONSULTA ";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            obj_CMD.Parameters.AddWithValue("@I_COD_CONSULTA", pobj_Item.Cod_Consulta);
            try
            {
                obj_CONN.Open();

                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {
                    while (obj_DTR.Read())
                    {
                        Item obj_Item = new Item();

                        obj_Item.Cod_Item = Convert.ToInt16(obj_DTR["I_COD_ITEM"].ToString());
                        obj_Item.Cod_Consulta = Convert.ToInt16(obj_DTR["I_COD_CONSULTA"].ToString());
                        obj_Item.Cod_Exame = Convert.ToInt16(obj_DTR["I_COD_EXAME"].ToString());

                        Lista.Add(obj_Item);
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
