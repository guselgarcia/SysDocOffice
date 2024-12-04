/*******************************************************************************
*              Nome: FuncGeral
*              Obs.: Esta classe possui todas as funções e procedimentos gerais 
*                    de apoio a formulários e classes.
*       Dt. Criação: 17/09/2024
*     Dt. Alteração: -
*    Obs. Alteração: -
*        Criada por: Monstro (mFacine)
*******************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SysDocOffice
{
    class FuncGeral
    {
        ///<summary>
        ///Vetor de byte utilizados para a criptografia (chave externa)
        /// </summary>

        private static byte[] bIV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
        string path = Environment.CurrentDirectory;
        public Usuario obj_Usuario = new Usuario();

        /// <summary>
        /// Representação de valor em base 64 (chave interna)
        /// O valor represanta a transformação para base64 de
        /// um conjunto de 32 caracteres (8 * 32 - 256 bits)
        /// a chave é: "Criptografia com Rijndael / AES"
        /// </summary>
        private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";


        /***********************************************************************
        *          NOME: Criptografa
        *        METODO: Criptografa o Password do usuário e retorna o
        *                Password criptografado
        *     PARAMETRO: String sPassWord
        *       RETORNO: String
        *    DT CRIAÇÃO: 24/09/2024
        *  DT ALTERAÇÃO: -
        *   ESCRITA POR: mFacine
        ***********************************************************************/
        public string Criptografa(string sPassWord)
        {
            try
            {
                //(27/05/2019-mfacine) Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(sPassWord))
                {
                    //(27/05/2019-mfacine) Cria instancias de vetores de bytes com as chaves
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = new UTF8Encoding().GetBytes(sPassWord);

                    //(27/05/2019-mfacine) Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    //(27 / 05 / 2019 - mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"
                    // Lembre-se: chaves possíves:
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)
                    rijndael.KeySize = 256;

                    //(27 / 05 / 2019 - mfacine)
                    // Cria o espaço de memória para guardar o valor criptografado:
                    MemoryStream mStream = new MemoryStream();
                    // Instancia o encriptador
                    CryptoStream encryptor = new CryptoStream(
                    mStream,
                    rijndael.CreateEncryptor(bKey, bIV),
                    CryptoStreamMode.Write);

                    //(27/05/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória
                    encryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.
                    encryptor.FlushFinalBlock();
                    // Pega o vetor de bytes da memória e gera a string criptografada
                    return Convert.ToBase64String(mStream.ToArray());
                }
                else
                {
                    //(27/05/2019-mfacine) Se a string for vazia retorna nulo
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(27/05/2019-mfacine) Se algum erro ocorrer, dispara a exceção
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }

        /*****************************************************************************
        *          Nome : DesCriptografa
        *  Procedimento : Descriptografa o password do usuário e retorna o
        *                 pass descriptografado
        *    Parametros : sCriptoPassWord
        *    Dt Criação : 24/09/2024
        * Dt. Alteração : -
        *    ESCRITA POR: mFacine
        * ***************************************************************************/
        public string DesCriptografa(string sCriptoPassWord)
        {
            try
            {
                //(27/05/2019-mfacine) Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(sCriptoPassWord))
                {
                    //(27/05/2019-mfacine) Cria instancias de vetores de bytes com as chaves
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = Convert.FromBase64String(sCriptoPassWord);

                    // Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    //(27/05/2019-mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"
                    // Lembre-se: chaves possíves:
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)
                    rijndael.KeySize = 256;

                    //(27/05/2019-mfacine) Cria o espaço de memória para guardar o valor DEScriptografado:
                    MemoryStream mStream = new MemoryStream();

                    //(27/05/2019-mfacine) Instancia o Decriptador
                    CryptoStream decryptor = new CryptoStream(
                    mStream,
                    rijndael.CreateDecryptor(bKey, bIV),
                    CryptoStreamMode.Write);

                    //(27/05/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória
                    decryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.
                    decryptor.FlushFinalBlock();
                    // Instancia a classe de codificação para que a string venha de forma correta
                    UTF8Encoding utf8 = new UTF8Encoding();
                    // Com o vetor de bytes da memória, gera a string descritografada em UTF8
                    return utf8.GetString(mStream.ToArray());
                }
                else
                {
                    //(27/05/2019-mfacine) Se a string for vazia retorna nulo
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(27/05/2019-mfacine) Se algum erro ocorrer, dispara a exceção
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }



        /**********************************************************************************
        *              Nome: LimpaTela
        *              Obs.: Responsável por limpar cada componente editável ou modificável 
        *                    do painel de detalhe (pnl_Detail)
        *       Dt. Criação: 17/09/2024
        *         Parametro: Formulário (Form)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public void LimpaTela(Form pobj_Form)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ((TextBox)ctrl).Clear();
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            ((MaskedTextBox)ctrl).Clear();
                        }

                        if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).SelectedIndex = -1;
                        }

                        if (ctrl is CheckBox)
                        {
                            ((CheckBox)ctrl).Checked = false;
                        }

                        if (ctrl is Label && Convert.ToInt16(((Label)ctrl).Tag) == 1)
                        {
                            ((Label)ctrl).Text = "";
                        }

                        if (ctrl is ListView)
                        {
                            ((ListView)ctrl).Items.Clear();
                        }
                    }
                }
            }
        }


        /**********************************************************************************
        *              Nome: HabilitaTela
        *              Obs.: Responsável por habilitar cada componente editável ou modificável 
        *                    do painel de detalhe (pnl_Detail)
        *       Dt. Criação: 17/09/2024
        *         Parametro: Formulário (Form)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public void HabilitaTela(Form pobj_Form, bool pb_Habilita)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox && Convert.ToInt16(ctrl.Tag) != 1)
                        {
                            ((TextBox)ctrl).Enabled = pb_Habilita;
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            ((MaskedTextBox)ctrl).Enabled = pb_Habilita;
                        }

                        if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).Enabled = pb_Habilita;
                        }

                        if (ctrl is CheckBox)
                        {
                            ((CheckBox)ctrl).Enabled = pb_Habilita;
                        }

                        if (ctrl is Button)
                        {
                            ((Button)ctrl).Enabled = pb_Habilita;
                        }

                        if (ctrl is ListView)
                        {
                            ((ListView)ctrl).Enabled = pb_Habilita;
                        }

                    }
                }
            }
        }

        /**********************************************************************************
        *              Nome: StatusBtn
        *              Obs.: Responsável por habilitar ou desabilitar cada botão do painel 
        *                    de Button (pnl_Button)
        *       Dt. Criação: 17/09/2024
        *         Parametro: Formulário (Form)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public void StatusBtn(Form pobj_Form, int pi_Status)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Button")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        switch (pi_Status)
                        {
                            case 1:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }
                                    break;
                                }

                            case 3:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ((Button)ctrl).Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ((Button)ctrl).Enabled = true;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
        }


        /**********************************************************************************
        *              Nome: ValidaTela
        *              Obs.: Responsável por Validar cada componente editável ou modificável 
        *                    do painel de detalhe (pnl_Detail), impedindo que seja gravado 
        *                    em branco. 
        *       Dt. Criação: 19/11/2024
        *         Parametro: Formulário (Form)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public bool ValidaTela(Form pobj_Form)
        {
            bool b_Valida = true;
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox && Convert.ToInt16(((TextBox)ctrl).Tag) != 1 && Convert.ToInt16(((TextBox)ctrl).Tag) != -1)
                        {
                            if (((TextBox)ctrl).Text == "")
                            {
                                b_Valida = false;
                                MessageBox.Show("O campo " + BuscaNmCampo(((TextBox)ctrl).Name, 5) + " não foi preenchido!", "Validação",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ((TextBox)ctrl).Focus();
                                break;
                            }

                        }

                        if (ctrl is ComboBox)
                        {
                            if (((ComboBox)ctrl).SelectedIndex == -1)
                            {
                                b_Valida = false;
                                MessageBox.Show("O campo " + BuscaNmCampo(((ComboBox)ctrl).Name, 6) + " não foi preenchido!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ((ComboBox)ctrl).Focus();
                                break;
                            }
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            if (((MaskedTextBox)ctrl).Text == "")
                            {
                                b_Valida = false;
                                MessageBox.Show("O campo " + BuscaNmCampo(((MaskedTextBox)ctrl).Name, 6) + " não foi preenchido!", "Validação",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ((MaskedTextBox)ctrl).Focus();
                                break;
                            }
                        }




                    }
                }
            }
            return b_Valida;
        }

        /**********************************************************************************
        *              Nome: PopulaMascara
        *              Obs.: Responsável por Popular o MaskTextBox do painel de Datalhes (pnl_Detail)
        *       Dt. Criação: 17/09/2024
        *         Parametro: Formulário (Form)
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *         Descrição: Mascaras possíveis:
        *                       1 - CPF
        *                       2 - CEP
        *                       3 - DATA
        *                       4 - HORA
        *                       5 - CRM
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public void PopulaMascara(Form pobj_Form)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is MaskedTextBox)
                        {
                            switch (Convert.ToInt16(ctrl.Tag))
                            {
                                case 1: // CPF
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "999.999.999-99";
                                        break;
                                    }
                                case 2: // CEP
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "99.999-9999";
                                        break;
                                    }
                                case 3: // Data
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "99/99/9999";
                                        break;
                                    }
                                case 4: // Hora
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "99:99";
                                        break;
                                    }
                                case 5: // CRM
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "999999-AA";
                                        break;
                                    }
                            }
                        }
                    }
                }
            }
        }

        /**********************************************************************************
        *              Nome: ValidaTipo
        *              Obs.: Responsável por validar os tipos de dados individualmente.
        *         Resultado: bool
        *         Parametro: Conteudo e Tipo
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        public bool ValidaTipo(string ps_Conteudo, Type pt_Tipo)
        {
            bool b_Valida = false;

            switch (pt_Tipo.Name)
            {
                case "Int16":
                    {
                        int i_Nro = 0;
                        b_Valida = int.TryParse(ps_Conteudo, out i_Nro);
                        break;
                    }

                case "double":
                    {
                        double d_Nro = 0;
                        b_Valida = double.TryParse(ps_Conteudo, out d_Nro);
                        break;
                    }

                case "DateTime":
                    {
                        DateTime dt_Data = DateTime.MinValue;
                        b_Valida = DateTime.TryParse(ps_Conteudo, out dt_Data);
                        break;
                    }
            }
            return b_Valida;

        }

        /**********************************************************************************
        *              Nome: BuscaNmCampo
        *              Obs.: Responsável por trazer o nome do campo por extenso. 
        *       Dt. Criação: 02/12/2024
        *         Parametro: TextBox
        *           Retorno: string
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        *              Obs.: -
        ***********************************************************************************/
        public string BuscaNmCampo(string s_Campo, int i_Leng)
        {
            string s_Nome = "";
            string s_Sigla = "";
            string s_Classe = "";

            string[] s_NmCampo = new string[s_Campo.Length - i_Leng];
            //tbox_<Sigla>_<Classe>
            //tbox_Nm_Exame --> "Nome Exame"

            s_NmCampo = s_Campo.Substring(i_Leng).Split('_');

            s_Sigla = s_NmCampo[0].ToString();
            s_Classe = s_NmCampo[1].ToString();

            switch (s_Sigla)
            {
                case "Nm":
                    {
                        s_Nome = "Nome";
                        break;
                    }

                case "NroConv":
                    {
                        s_Nome = "Número do Convênio";
                        break;
                    }

                case "Cod":
                    {
                        s_Nome = s_Classe;
                        break;
                    }

                case "Desc":
                    {
                        s_Nome = "Descrição";
                        break;
                    }

                case "UNm":
                    {
                        s_Nome = "Usuário";
                        break;
                    }

                case "PW":
                    {
                        s_Nome = "Senha";
                        break;
                    }

                case "Dt":
                    {
                        s_Nome = "Data";
                        break;
                    }

                case "Hr":
                    {
                        s_Nome = "Hora";
                        break;
                    }

                case "CPF":
                case "CRM":
                case "CEP":
                    {
                        s_Nome = s_Sigla;
                        break;
                    }


            }
            return s_Nome;
        }

        /**********************************************************************************
     *              Nome: Tamanho Máximo
     *              Obs.: Responsável por retornar com uma lista com Nome, tipo e tamanho dos campos da tabela 
     *                    passada por parametro
     *       Dt. Criação: 03/12/2024
     *         Parametro: Nome do Formularário e o Nome da Tabela
     *     Dt. Alteração: -
     *    Obs. Alteração: -
     *        Criada por: Monstro (mFacine)
     *              Obs.: -
     ***********************************************************************************/
        public void TamanhoMaximo(Form pobj_Form, String ps_Nm_Tabela)
        {
            Campo obj_Campo = new Campo();
            CampoBD obj_CampoBD = new CampoBD();
            List<Campo> Lista = new List<Campo>();

            string s_Nm_Campo = "";

            Lista = obj_CampoBD.FindAllCampo(ps_Nm_Tabela);
            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Campo.Nm_Campo = Lista[i].Nm_Campo;
                    obj_Campo.Tp_Campo = Lista[i].Tp_Campo;
                    obj_Campo.Tam_Campo = Lista[i].Tam_Campo;

                    foreach (Control pnl in pobj_Form.Controls)
                    {
                        if (pnl is Panel && pnl.Name == "pnl_Detail")
                        {
                            foreach (Control ctrl in pnl.Controls)
                            {
                                if (ctrl is TextBox)
                                {
                                    if (obj_Campo.Tp_Campo == "DateTime")
                                    {
                                        s_Nm_Campo = "TBOX" + obj_Campo.Nm_Campo.Substring(3, obj_Campo.Nm_Campo.Length - 3);
                                    }
                                    else
                                    {
                                        s_Nm_Campo = "TBOX" + obj_Campo.Nm_Campo.Substring(2, obj_Campo.Nm_Campo.Length - 2);

                                    }
                                    if (s_Nm_Campo == ctrl.Name.ToUpper())
                                    {
                                        ((TextBox)ctrl).MaxLength = obj_Campo.Tam_Campo;
                                    }
                                    if (ctrl is TextBox)
                                    {
                                        if (obj_Campo.Tp_Campo == "Text")
                                        {
                                            s_Nm_Campo = "TBOX" + obj_Campo.Nm_Campo.Substring(2, obj_Campo.Nm_Campo.Length - 2);
                                        }

                                        if (s_Nm_Campo == ctrl.Name.ToUpper())
                                        {
                                            ((TextBox)ctrl).MaxLength = 350;
                                        }

                                        if (ctrl is MaskedTextBox)
                                        {
                                            if (obj_Campo.Tp_Campo == "DateTime")
                                            {
                                                s_Nm_Campo = "TBOX" + obj_Campo.Nm_Campo.Substring(3, obj_Campo.Nm_Campo.Length - 3);
                                            }
                                            else
                                            {
                                                s_Nm_Campo = "TBOX" + obj_Campo.Nm_Campo.Substring(2, obj_Campo.Nm_Campo.Length - 2);

                                            }
                                            if (s_Nm_Campo == ctrl.Name.ToUpper())
                                            {
                                                ((MaskedTextBox)ctrl).MaxLength = obj_Campo.Tam_Campo;
                                            }

                                        }

                                    }
                                }
                            }
                        }

                    }

                }
            }
        }
    }
}
            