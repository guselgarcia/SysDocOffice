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
    public partial class frm_Especialidade : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Especialidade obj_Especialidade_Atual = new Especialidade();


        public frm_Especialidade()
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
        *              Obs.: Responsável por popular a lista (lbox_Especialidades) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
            List<Especialidade> Lista = new List<Especialidade>();

            lbox_Especialidades.Items.Clear();

            Lista = obj_EspecialidadeBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Especialidades.Items.Add(Lista[i].Cod_Especialidade.ToString() + "-" + Lista[i].Nm_Especialidade);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Especialidade_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Especialidade_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Especialidade PopulaObjeto()
        {
            Especialidade obj_Especialidade = new Especialidade();

            if (tbox_Cod_Especialidade.Text != "")
            {
                obj_Especialidade.Cod_Especialidade = Convert.ToInt16(tbox_Cod_Especialidade.Text);
            }

            obj_Especialidade.Nm_Especialidade = tbox_Nm_Especialidade.Text;
            obj_Especialidade.Desc_Especialidade = tbox_Desc_Especialidade.Text;

            return obj_Especialidade;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Especialidade_Atual)
        *         Parametro: objeto (obj_Especialidade_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Especialidade pobj_Especialidade)
        {
            if (pobj_Especialidade.Cod_Especialidade != -1)
            {
                tbox_Cod_Especialidade.Text = pobj_Especialidade.Cod_Especialidade.ToString();
            }

            tbox_Nm_Especialidade.Text = pobj_Especialidade.Nm_Especialidade;
            tbox_Desc_Especialidade.Text = pobj_Especialidade.Desc_Especialidade;
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Especialidade.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Especialidade.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Especialidade_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Especialidade_Atual.Nm_Especialidade + "?",
                                                "Exclusão de Especialidade", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
                if (obj_EspecialidadeBD.Excluir(obj_Especialidade_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Especialidade_Atual.Nm_Especialidade + " foi excluido com sucesso.",
                                    "Exclusão de Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Especialidade_Atual = new Especialidade();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Especialidade_Atual.Cod_Especialidade != -1)
            {
                PopulaTela(obj_Especialidade_Atual);
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
                EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();

                obj_Especialidade_Atual = PopulaObjeto();

                if (obj_Especialidade_Atual.Cod_Especialidade != -1)
                {
                    if (obj_EspecialidadeBD.Alterar(obj_Especialidade_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Especialidade_Atual.Nm_Especialidade + " foi alterado com sucesso.",
                                        "Alteração de Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Especialidade_Atual.Cod_Especialidade = obj_EspecialidadeBD.Incluir(obj_Especialidade_Atual);

                    if (obj_Especialidade_Atual.Cod_Especialidade != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Especialidade_Atual.Nm_Especialidade + " foi incluido com sucesso.",
                                        "Inclusão de Especialidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Especialidade_Atual);
                PopulaLista();
            }
        }

        private void lbox_Especialidades_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Especialidades.Items[lbox_Especialidades.SelectedIndex].ToString();

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
            obj_Especialidade_Atual.Cod_Especialidade = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
            obj_Especialidade_Atual = obj_EspecialidadeBD.FindByCod(obj_Especialidade_Atual);
            PopulaTela(obj_Especialidade_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }
    }
}
