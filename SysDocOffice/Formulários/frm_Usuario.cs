using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDocOffice
{
    public partial class frm_Usuario : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Usuario obj_Usuario_Atual = new Usuario();


        public frm_Usuario()
        {
            InitializeComponent();
            //Habilitar a Tela
            //obj_FuncGeral.PopulaMascara(this);
            obj_FuncGeral.HabilitaTela(this, false);
            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 1);
            //Popula a Lista
            PopulaLista();

        }

        /**********************************************************************************
        *              Nome: PopulaLista
        *              Obs.: Responsável por popular a lista (lbox_Usuarios) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            UsuarioBD obj_UsuarioBD = new UsuarioBD();
            List<Usuario> Lista = new List<Usuario>();

            lbox_Usuarios.Items.Clear();

            Lista = obj_UsuarioBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Usuarios.Items.Add(Lista[i].Cod_Usuario.ToString() + "-" + Lista[i].Nm_Usuario);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Usuario_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Usuario_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Usuario PopulaObjeto()
        {
            Usuario obj_Usuario = new Usuario();

            if (tbox_Cod_Usuario.Text != "")
            {
                obj_Usuario.Cod_Usuario = Convert.ToInt16(tbox_Cod_Usuario.Text);
            }

            obj_Usuario.Nm_Usuario = tbox_Nm_Usuario.Text;
            obj_Usuario.UNm_Usuario = tbox_UNm_Usuario.Text;
            obj_Usuario.PW_Usuario = obj_FuncGeral.Criptografa(tbox_PW_Usuario.Text);

            return obj_Usuario;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Usuario_Atual)
        *         Parametro: objeto (obj_Usuario_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Usuario pobj_Usuario)
        {
            if (pobj_Usuario.Cod_Usuario != -1)
            {
                tbox_Cod_Usuario.Text = pobj_Usuario.Cod_Usuario.ToString();
            }
             
            tbox_Nm_Usuario.Text  = pobj_Usuario.Nm_Usuario ;
            tbox_UNm_Usuario.Text = pobj_Usuario.UNm_Usuario;
            tbox_PW_Usuario.Text = obj_FuncGeral.DesCriptografa(pobj_Usuario.PW_Usuario);
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Usuario.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Usuario.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Usuario_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Usuario_Atual.Nm_Usuario + "?",
                                                "Exclusão de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                UsuarioBD obj_UsuarioBD = new UsuarioBD();
                if (obj_UsuarioBD.Excluir(obj_Usuario_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Usuario_Atual.Nm_Usuario + " foi excluido com sucesso.",
                                    "Exclusão de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Usuario_Atual = new Usuario();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Usuario_Atual.Cod_Usuario != -1)
            {
                PopulaTela(obj_Usuario_Atual);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
            chbox_Senha.Checked = false;
            chbox_Senha_Click(chbox_Senha, e);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (obj_FuncGeral.ValidaTela(this))
            {
                UsuarioBD obj_UsuarioBD = new UsuarioBD();

                obj_Usuario_Atual = PopulaObjeto();

                if (obj_Usuario_Atual.Cod_Usuario != -1)
                {
                    if (obj_UsuarioBD.Alterar(obj_Usuario_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Usuario_Atual.Nm_Usuario + " foi alterado com sucesso.",
                                        "Alteração de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Usuario_Atual.Cod_Usuario = obj_UsuarioBD.Incluir(obj_Usuario_Atual);

                    if (obj_Usuario_Atual.Cod_Usuario != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Usuario_Atual.Nm_Usuario + " foi incluido com sucesso.",
                                        "Inclusão de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Usuario_Atual);
                PopulaLista();
                chbox_Senha.Checked = false;
                chbox_Senha_Click(chbox_Senha, e);
            }
        }

        private void lbox_Usuarios_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            UsuarioBD obj_UsuarioBD = new UsuarioBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Usuarios.Items[lbox_Usuarios.SelectedIndex].ToString();

            if (s_Linha.Length != 0)
            {
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i,1) == "-")
                    {
                        i_Pos = i;
                        break;
                    }
                }
            }
            obj_Usuario_Atual.Cod_Usuario = Convert.ToInt16(s_Linha.Substring(0,i_Pos));
            obj_Usuario_Atual = obj_UsuarioBD.FindByCod(obj_Usuario_Atual);
            PopulaTela(obj_Usuario_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }

        private void chbox_Senha_Click(object sender, EventArgs e)
        {
            if (chbox_Senha.Checked)
            {
                tbox_PW_Usuario.PasswordChar = '\u0000';
            }
            else
            {
                tbox_PW_Usuario.PasswordChar = '•';
            }
        }
    }
}
