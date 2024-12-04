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
    public partial class frm_Convenio : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Convenio obj_Convenio_Atual = new Convenio();


        public frm_Convenio()
        {
            InitializeComponent();
            //obj_FuncGeral.PopulaMascara(this);
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, false);
            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 1);
            //Popula a Lista
            PopulaLista();

        }

        /**********************************************************************************
        *              Nome: PopulaLista
        *              Obs.: Responsável por popular a lista (lbox_Convenios) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            ConvenioBD obj_ConvenioBD = new ConvenioBD();
            List<Convenio> Lista = new List<Convenio>();

            lbox_Convenios.Items.Clear();

            Lista = obj_ConvenioBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Convenios.Items.Add(Lista[i].Cod_Convenio.ToString() + "-" + Lista[i].Nm_Convenio);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Convenio_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Convenio_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Convenio PopulaObjeto()
        {
            Convenio obj_Convenio = new Convenio();

            if (tbox_Cod_Convenio.Text != "")
            {
                obj_Convenio.Cod_Convenio = Convert.ToInt16(tbox_Cod_Convenio.Text);
            }

            obj_Convenio.Nm_Convenio = tbox_Nm_Convenio.Text;
            obj_Convenio.Mod_Convenio = cbbox_Mod_Convenio.SelectedIndex;

            return obj_Convenio;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Convenio_Atual)
        *         Parametro: objeto (obj_Convenio_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Convenio pobj_Convenio)
        {
            if (pobj_Convenio.Cod_Convenio != -1)
            {
                tbox_Cod_Convenio.Text = pobj_Convenio.Cod_Convenio.ToString();
            }

            tbox_Nm_Convenio.Text = pobj_Convenio.Nm_Convenio;
            cbbox_Mod_Convenio.SelectedIndex = pobj_Convenio.Mod_Convenio; 
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Convenio.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Convenio.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Convenio_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Convenio_Atual.Nm_Convenio + "?",
                                                "Exclusão de Convenio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                ConvenioBD obj_ConvenioBD = new ConvenioBD();
                if (obj_ConvenioBD.Excluir(obj_Convenio_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Convenio_Atual.Nm_Convenio + " foi excluido com sucesso.",
                                    "Exclusão de Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Convenio_Atual = new Convenio();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Convenio_Atual.Cod_Convenio != -1)
            {
                PopulaTela(obj_Convenio_Atual);
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

                ConvenioBD obj_ConvenioBD = new ConvenioBD();

                obj_Convenio_Atual = PopulaObjeto();

                if (obj_Convenio_Atual.Cod_Convenio != -1)
                {
                    if (obj_ConvenioBD.Alterar(obj_Convenio_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Convenio_Atual.Nm_Convenio + " foi alterado com sucesso.",
                                        "Alteração de Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Convenio_Atual.Cod_Convenio = obj_ConvenioBD.Incluir(obj_Convenio_Atual);

                    if (obj_Convenio_Atual.Cod_Convenio != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Convenio_Atual.Nm_Convenio + " foi incluido com sucesso.",
                                        "Inclusão de Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Convenio_Atual);
                PopulaLista();
            }
        }

        private void lbox_Convenios_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            ConvenioBD obj_ConvenioBD = new ConvenioBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Convenios.Items[lbox_Convenios.SelectedIndex].ToString();

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
            obj_Convenio_Atual.Cod_Convenio = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
            obj_Convenio_Atual = obj_ConvenioBD.FindByCod(obj_Convenio_Atual);
            PopulaTela(obj_Convenio_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }
    }
}
