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
    public partial class frm_Exame : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Exame obj_Exame_Atual = new Exame();


        public frm_Exame()
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
        *              Obs.: Responsável por popular a lista (lbox_Exames) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            ExameBD obj_ExameBD = new ExameBD();
            List<Exame> Lista = new List<Exame>();

            lbox_Exames.Items.Clear();

            Lista = obj_ExameBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Exames.Items.Add(Lista[i].Cod_Exame.ToString() + "-" + Lista[i].Nm_Exame);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Exame_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Exame_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Exame PopulaObjeto()
        {
            Exame obj_Exame = new Exame();

            if (tbox_Cod_Exame.Text != "")
            {
                obj_Exame.Cod_Exame = Convert.ToInt16(tbox_Cod_Exame.Text);
            }

            obj_Exame.Nm_Exame = tbox_Nm_Exame.Text;
            obj_Exame.Jjm_Exame = chbox_Jjm_Exame.Checked;

            return obj_Exame;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Exame_Atual)
        *         Parametro: objeto (obj_Exame_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Exame pobj_Exame)
        {
            if (pobj_Exame.Cod_Exame != -1)
            {
                tbox_Cod_Exame.Text = pobj_Exame.Cod_Exame.ToString();
            }

            tbox_Nm_Exame.Text = pobj_Exame.Nm_Exame;
            chbox_Jjm_Exame.Checked = pobj_Exame.Jjm_Exame;
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Exame.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Exame.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Exame_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Exame_Atual.Nm_Exame + "?",
                                                "Exclusão de Exame", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                ExameBD obj_ExameBD = new ExameBD();
                if (obj_ExameBD.Excluir(obj_Exame_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Exame_Atual.Nm_Exame + " foi excluido com sucesso.",
                                    "Exclusão de Exame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Exame_Atual = new Exame();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Exame_Atual.Cod_Exame != -1)
            {
                PopulaTela(obj_Exame_Atual);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (obj_FuncGeral.ValidaTela(this))
            {
                ExameBD obj_ExameBD = new ExameBD();

                obj_Exame_Atual = PopulaObjeto();

                if (obj_Exame_Atual.Cod_Exame != -1)
                {
                    if (obj_ExameBD.Alterar(obj_Exame_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Exame_Atual.Nm_Exame + " foi alterado com sucesso.",
                                        "Alteração de Exame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Exame_Atual.Cod_Exame = obj_ExameBD.Incluir(obj_Exame_Atual);

                    if (obj_Exame_Atual.Cod_Exame != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Exame_Atual.Nm_Exame + " foi incluido com sucesso.",
                                        "Inclusão de Exame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Exame_Atual);
                PopulaLista();
            }
        }

        private void lbox_Exames_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            ExameBD obj_ExameBD = new ExameBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Exames.Items[lbox_Exames.SelectedIndex].ToString();

            if (s_Linha.Length != 0)
            {
                for (int i = 0; i < s_Linha.Length; i++)
                {
                    if (s_Linha.Substring(i, 1) == "-")
                    {
                        i_Pos = i;
                        break;
                    }
                }
            }
            obj_Exame_Atual.Cod_Exame = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
            obj_Exame_Atual = obj_ExameBD.FindByCod(obj_Exame_Atual);
            PopulaTela(obj_Exame_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }
    }
}
