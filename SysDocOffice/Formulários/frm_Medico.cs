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
    public partial class frm_Medico : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Medico obj_Medico_Atual = new Medico();


        public frm_Medico()
        {
            InitializeComponent();

            obj_FuncGeral.PopulaMascara(this);

            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, false);
            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 1);
            //Popula a Lista
            PopulaLista();

        }

        /**********************************************************************************
        *              Nome: PopulaLista
        *              Obs.: Responsável por popular a lista (lbox_Medicos) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            MedicoBD obj_MedicoBD = new MedicoBD();
            List<Medico> Lista = new List<Medico>();

            lbox_Medicos.Items.Clear();

            Lista = obj_MedicoBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Medicos.Items.Add(Lista[i].Cod_Medico.ToString() + "-" + Lista[i].Nm_Medico);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Medico_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Medico_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Medico PopulaObjeto()
        {
            Medico obj_Medico = new Medico();

            if (tbox_Cod_Medico.Text != "")
            {
                obj_Medico.Cod_Medico = Convert.ToInt16(tbox_Cod_Medico.Text);
            }
            obj_Medico.Cod_Especialidade = Convert.ToInt16(tbox_Cod_Especialidade.Text);
            obj_Medico.Nm_Medico = tbox_Nm_Medico.Text;
            obj_Medico.CRM_Medico = mtbox_CRM_Medico.Text;

            return obj_Medico;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Medico_Atual)
        *         Parametro: objeto (obj_Medico_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Medico pobj_Medico)
        {
            
            if (pobj_Medico.Cod_Medico != -1)
            {
                tbox_Cod_Medico.Text = pobj_Medico.Cod_Medico.ToString();
            }
            tbox_Cod_Especialidade.Text = pobj_Medico.Cod_Especialidade.ToString();
            
            EventArgs e = new EventArgs();
            tbox_Cod_Especialidade_Leave(tbox_Cod_Especialidade, e);
            
            tbox_Nm_Medico.Text = pobj_Medico.Nm_Medico;
            mtbox_CRM_Medico.Text = pobj_Medico.CRM_Medico;
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Cod_Especialidade.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Medico.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Medico_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Medico_Atual.Nm_Medico + "?",
                                                "Exclusão de Medico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                MedicoBD obj_MedicoBD = new MedicoBD();
                if (obj_MedicoBD.Excluir(obj_Medico_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Medico_Atual.Nm_Medico + " foi excluido com sucesso.",
                                    "Exclusão de Medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Medico_Atual = new Medico();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Medico_Atual.Cod_Medico != -1)
            {
                PopulaTela(obj_Medico_Atual);
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
                MedicoBD obj_MedicoBD = new MedicoBD();

                obj_Medico_Atual = PopulaObjeto();

                if (obj_Medico_Atual.Cod_Medico != -1)
                {
                    if (obj_MedicoBD.Alterar(obj_Medico_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Medico_Atual.Nm_Medico + " foi alterado com sucesso.",
                                        "Alteração de Medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Medico_Atual.Cod_Medico = obj_MedicoBD.Incluir(obj_Medico_Atual);

                    if (obj_Medico_Atual.Cod_Medico != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Medico_Atual.Nm_Medico + " foi incluido com sucesso.",
                                        "Inclusão de Medico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Medico_Atual);
                PopulaLista();
            }
        }

        private void lbox_Medicos_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            MedicoBD obj_MedicoBD = new MedicoBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Medicos.Items[lbox_Medicos.SelectedIndex].ToString();

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
            obj_Medico_Atual.Cod_Medico = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
            obj_Medico_Atual = obj_MedicoBD.FindByCod(obj_Medico_Atual);
            PopulaTela(obj_Medico_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }

        private void tbox_Cod_Especialidade_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Especialidade.Text != "")
            {
                Especialidade obj_Especialidade = new Especialidade();
                EspecialidadeBD obj_EspecialidadeBD = new EspecialidadeBD();

                obj_Especialidade.Cod_Especialidade = Convert.ToInt16(tbox_Cod_Especialidade.Text);
                obj_Especialidade = obj_EspecialidadeBD.FindByCod(obj_Especialidade);

                lb_Nm_Especialidade.Text = obj_Especialidade.Nm_Especialidade;
            }
        }

        private void btn_Especialidade_Click(object sender, EventArgs e)
        {
            
            frm_Especialidade obj_frm_Especialidade = new frm_Especialidade();
            obj_frm_Especialidade.ShowDialog();
            tbox_Cod_Especialidade.Text = obj_frm_Especialidade.obj_Especialidade_Atual.Cod_Especialidade.ToString();
            tbox_Cod_Especialidade_Leave(tbox_Cod_Especialidade, e);
        }
    }
}
