using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDocOffice
{
    class CampoBD
    {
        ~CampoBD()
        {
        }
        /*******************************************************************************
            *              Nome: FindAll
            *              Obs.: Responsável por buscar todos os objetos Campos Cadastrados na TB_CAMPO
            *       Dt. Criação: 03/12/2024
            *         Parametro: Nome da tabela (string)
            *           Returna: Lista de campos (List<Campo>)
            *     Dt. Alteração: -
            *    Obs. Alteração: -
            *        Criada por: Gustavo (GusElGarcia)
            *              Obs.: Esta classe se conecta com  o banco através da 
            *                    classe Connection.
            *******************************************************************************/

        public List<Campo> FindAllCampo(string ps_NmTabela)
        {
            // Conexão com o Banco de Dados 
            SqlConnection obj_CONN = new SqlConnection(Connection.Connection_Path());

            List<Campo> Lista_Campo = new List<Campo>();

            string s_SQL = "SELECT " +
                           "cNmColuna = C.Name, " +
                           "cTpColuna = UPPER(TYPE_NAME(C.user_type_id)), " +
                           "iMaxDigit = CASE " +
                           "            WHEN T.precision = 0 " +
                           "            THEN C.max_length " +
                           "            ELSE T.precision " +
                           "            END " +
                           "FROM sys.all_colums C WITH(NOLOCK) " +
                           "INNER JOIN sys.types T WITH(NOLOCK " +
                           "ON T.user_Type_id = C.user_type_id " +
                           "WHERE C.object_id = Object_Id('" + ps_NmTabela + "')";

            SqlCommand obj_CMD = new SqlCommand(s_SQL, obj_CONN);

            try
            {
                obj_CONN.Open();
                SqlDataReader obj_DTR = obj_CMD.ExecuteReader();

                if (obj_DTR.HasRows)
                {

                    while (obj_DTR.Read())
                    {
                        Campo obj_Campo = new Campo();

                        obj_Campo.Nm_Campo = obj_DTR["cNmColuna"].ToString();
                        obj_Campo.Tp_Campo = obj_DTR["cTpColuna"].ToString();
                        obj_Campo.Tam_Campo = Convert.ToInt16(obj_DTR["iMaxDigit"]);

                        Lista_Campo.Add(obj_Campo);
                    }
                }

                obj_CONN.Close();
                obj_DTR.Close();

            }
            catch (Exception Erro) 
            {
                MessageBox.Show(Erro.Message, "ERRO NO BANCO DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Lista_Campo;

              
        }
    }
}

