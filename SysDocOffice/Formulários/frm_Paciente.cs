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
    public partial class frm_Paciente : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Paciente obj_Paciente_Atual = new Paciente();


        public frm_Paciente()
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
        *              Obs.: Responsável por popular a lista (lbox_Pacientes) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            PacienteBD obj_PacienteBD = new PacienteBD();
            List<Paciente> Lista = new List<Paciente>();

            lbox_Pacientes.Items.Clear();

            Lista = obj_PacienteBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Pacientes.Items.Add(Lista[i].Cod_Paciente.ToString() + "-" + Lista[i].Nm_Paciente);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Paciente_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Paciente_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Paciente PopulaObjeto()
        {
            Paciente obj_Paciente = new Paciente();

            if (tbox_Cod_Paciente.Text != "")
            {
                obj_Paciente.Cod_Paciente = Convert.ToInt16(tbox_Cod_Paciente.Text);
            }
            obj_Paciente.Cod_Convenio = Convert.ToInt16(tbox_Cod_Convenio.Text);
            obj_Paciente.Nm_Paciente = tbox_Nm_Paciente.Text;
            obj_Paciente.CPF_Paciente = mtbox_CPF_Paciente.Text;
            obj_Paciente.NroConv_Paciente = tbox_NroConv_Paciente.Text;


            return obj_Paciente;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Paciente_Atual)
        *         Parametro: objeto (obj_Paciente_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Paciente pobj_Paciente)
        {
            if (pobj_Paciente.Cod_Paciente != -1)
            {
                tbox_Cod_Paciente.Text = pobj_Paciente.Cod_Paciente.ToString();
            }
            tbox_Cod_Convenio.Text = pobj_Paciente.Cod_Convenio.ToString();

            EventArgs e = new EventArgs();
            tbox_Cod_Convenio_Leave(tbox_Cod_Convenio, e);
            
            tbox_Nm_Paciente.Text = pobj_Paciente.Nm_Paciente;
            mtbox_CPF_Paciente.Text = pobj_Paciente.CPF_Paciente;
            tbox_NroConv_Paciente.Text = pobj_Paciente.NroConv_Paciente;
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Paciente.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Nm_Paciente.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Paciente_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir o usuário " + obj_Paciente_Atual.Nm_Paciente + "?",
                                                "Exclusão de Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                PacienteBD obj_PacienteBD = new PacienteBD();
                if (obj_PacienteBD.Excluir(obj_Paciente_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Paciente_Atual.Nm_Paciente + " foi excluido com sucesso.",
                                    "Exclusão de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Paciente_Atual = new Paciente();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Paciente_Atual.Cod_Paciente != -1)
            {
                PopulaTela(obj_Paciente_Atual);
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
                PacienteBD obj_PacienteBD = new PacienteBD();

                obj_Paciente_Atual = PopulaObjeto();

                if (obj_Paciente_Atual.Cod_Paciente != -1)
                {
                    if (obj_PacienteBD.Alterar(obj_Paciente_Atual))
                    {
                        MessageBox.Show("O usuário " + obj_Paciente_Atual.Nm_Paciente + " foi alterado com sucesso.",
                                        "Alteração de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    obj_Paciente_Atual.Cod_Paciente = obj_PacienteBD.Incluir(obj_Paciente_Atual);

                    if (obj_Paciente_Atual.Cod_Paciente != -1)
                    {
                        MessageBox.Show("O usuário " + obj_Paciente_Atual.Nm_Paciente + " foi incluido com sucesso.",
                                        "Inclusão de Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Paciente_Atual);
                PopulaLista();
            }
        }

        private void lbox_Pacientes_Click(object sender, EventArgs e)
        {
            /*
            9-Fabio Antônio
            12-Marcos Aurélio
            987-Felix Catus



            */

            PacienteBD obj_PacienteBD = new PacienteBD();
            int i_Pos = 0;
            string s_Linha = "";

            s_Linha = lbox_Pacientes.Items[lbox_Pacientes.SelectedIndex].ToString();

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
            obj_Paciente_Atual.Cod_Paciente = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
            obj_Paciente_Atual = obj_PacienteBD.FindByCod(obj_Paciente_Atual);
            PopulaTela(obj_Paciente_Atual);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.StatusBtn(this, 2);

        }

        private void tbox_Cod_Convenio_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Convenio.Text != "")
            {
                Convenio obj_Convenio = new Convenio();
                ConvenioBD obj_ConvenioBD = new ConvenioBD();

                obj_Convenio.Cod_Convenio = Convert.ToInt16(tbox_Cod_Convenio.Text);
                obj_Convenio = obj_ConvenioBD.FindByCod(obj_Convenio);

                lb_Nm_Convenio.Text = obj_Convenio.Nm_Convenio;
            }
        }

        private void btn_Convenio_Click(object sender, EventArgs e)
        {
            frm_Convenio obj_frm_Convenio = new frm_Convenio();
            obj_frm_Convenio.ShowDialog();
            tbox_Cod_Convenio.Text = obj_frm_Convenio.obj_Convenio_Atual.Cod_Convenio.ToString();
            tbox_Cod_Convenio_Leave(tbox_Cod_Convenio, e);
        }

    }
}
