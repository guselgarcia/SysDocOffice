using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDocOffice
{
    public partial class frm_Consulta : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Consulta obj_Consulta_Atual = new Consulta();


        public frm_Consulta()
        {
            InitializeComponent();

            obj_FuncGeral.PopulaMascara(this);

            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, false);
            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 1);
            //Popula a Lista
            PopulaLista();
            //Popula os Titulos
            PopulaTitulo();

        }

        /**********************************************************************************
        *              Nome: PopulaLista
        *              Obs.: Responsável por popular a lista (lbox_Consultas) com os usuários
        *                    que estão no banco de dados
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLista()
        {
            ConsultaBD obj_ConsultaBD = new ConsultaBD();
            List<Consulta> Lista = new List<Consulta>();

            lbox_Consultas.Items.Clear();

            Lista = obj_ConsultaBD.FindAll();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    lbox_Consultas.Items.Add(Lista[i].Cod_Consulta.ToString() + "-" + Lista[i].DH_Consulta);
                }
            }
        }

        /**********************************************************************************
        *              Nome: PopulaTitulo
        *              Obs.: Responsável por popular o titulo da ListView
        *       Dt. Criação: 02/10/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTitulo()
        {
            lv_ItemConsulta.View = View.Details;
            lv_ItemConsulta.Columns.Add("Cód Exame", 70);
            lv_ItemConsulta.Columns.Add("Nome Exame", 183);
            lv_ItemConsulta.Columns.Add("Estado", 93);
        }

        /**********************************************************************************
        *              Nome: PopulaLinhaItem
        *              Obs.: Responsável por popular a Linha do ListView
        *       Dt. Criação: 02/10/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaLinhaItem (ListView plv_Lista, int pi_Codigo, 
                                      string ps_Nome, string ps_Estado)
        {
            ListViewItem item = new ListViewItem(new[] 
                                       { pi_Codigo.ToString(), ps_Nome, ps_Estado });
            plv_Lista.Items.Add(item);
        }



        /**********************************************************************************
        *              Nome: PopulaObjeto
        *              Obs.: Responsável por popular o objeto (obj_Consulta_Atual) com os 
        *                    dados que estão na tela.
        *         Resultado: objeto (obj_Consulta_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private Consulta PopulaObjeto()
        {
            
            Consulta obj_Consulta = new Consulta();

            if (tbox_Cod_Consulta.Text != "")
            {
                obj_Consulta.Cod_Consulta = Convert.ToInt16(tbox_Cod_Consulta.Text);
            }
            
            obj_Consulta.Cod_Medico = Convert.ToInt16(tbox_Cod_Medico.Text);
            obj_Consulta.Cod_Paciente = Convert.ToInt16(tbox_Cod_Paciente.Text);
            obj_Consulta.DH_Consulta = Convert.ToDateTime(mtbox_Hr_Consulta.Text);
            obj_Consulta.Desc_Consulta = tbox_Desc_Consulta.Text;

            return obj_Consulta;
        }

        /**********************************************************************************
        *              Nome: PopulaTela
        *              Obs.: Responsável por popular a tela com os dados que estão no 
        *                    objeto (obj_Consulta_Atual)
        *         Parametro: objeto (obj_Consulta_Atual)
        *       Dt. Criação: 18/09/2024
        *     Dt. Alteração: -
        *    Obs. Alteração: -
        *        Criada por: Monstro (mFacine)
        ***********************************************************************************/
        private void PopulaTela(Consulta pobj_Consulta)
        {
            EventArgs e = new EventArgs();

            Item obj_Item = new Item();
            ItemBD obj_ItemBD = new ItemBD();

            Exame obj_Exame = new Exame();
            ExameBD obj_ExameBD = new ExameBD();

            if (pobj_Consulta.Cod_Consulta != -1)
            {
                tbox_Cod_Consulta.Text = pobj_Consulta.Cod_Consulta.ToString();
            }

            tbox_Cod_Medico.Text = pobj_Consulta.Cod_Medico.ToString();
            tbox_Cod_Medico_Leave(tbox_Cod_Medico, e);

            tbox_Cod_Paciente.Text = pobj_Consulta.Cod_Paciente.ToString();
            tbox_Cod_Paciente_Leave(tbox_Cod_Paciente, e);

            mtbox_Dt_Consulta.Text = pobj_Consulta.DH_Consulta.ToString("dd/MM/yyyy");
            mtbox_Hr_Consulta.Text = pobj_Consulta.DH_Consulta.ToString("hh:mm");
            
            tbox_Desc_Consulta.Text = pobj_Consulta.Desc_Consulta;

            List<Item> Lista = new List<Item>();

            obj_Item.Cod_Consulta = pobj_Consulta.Cod_Consulta;

            Lista = obj_ItemBD.FindAllByCodConsulta(obj_Item);

            lv_ItemConsulta.Items.Clear();

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Exame.Cod_Exame = Lista[i].Cod_Exame;
                    obj_Exame = obj_ExameBD.FindByCod(obj_Exame);

                    PopulaLinhaItem(lv_ItemConsulta, Lista[i].Cod_Exame, obj_Exame.Nm_Exame, obj_Exame.Jjm_Exame ? "Em jejum" : "");

                }
                
            }



        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Limpar a Tela
            obj_FuncGeral.LimpaTela(this);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            tbox_Cod_Medico.Focus();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            //Habilitar a Tela
            obj_FuncGeral.HabilitaTela(this, true);

            //Status de Botão
            obj_FuncGeral.StatusBtn(this, 3);

            mtbox_Dt_Consulta.Focus();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            obj_Consulta_Atual = PopulaObjeto();

            DialogResult Resp = MessageBox.Show("Deseja realmente excluir a consulta " + obj_Consulta_Atual.DH_Consulta + "?",
                                                "Exclusão de Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resp == DialogResult.Yes)
            {
                ItemBD obj_ItemBD = new ItemBD();
                Item obj_Item = new Item();
                obj_Item.Cod_Consulta = obj_Consulta_Atual.Cod_Consulta;
                obj_ItemBD.ExcluirByCodConsulta(obj_Item);


                ConsultaBD obj_ConsultaBD = new ConsultaBD();
                if (obj_ConsultaBD.Excluir(obj_Consulta_Atual))
                {
                    MessageBox.Show("O usuário " + obj_Consulta_Atual.DH_Consulta + " foi excluido com sucesso.",
                                    "Exclusão de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            PopulaLista();
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.LimpaTela(this);
            obj_FuncGeral.StatusBtn(this, 1);
            obj_Consulta_Atual = new Consulta();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (obj_Consulta_Atual.Cod_Consulta != -1)
            {
                PopulaTela(obj_Consulta_Atual);
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
                
                ConsultaBD obj_ConsultaBD = new ConsultaBD();
                obj_Consulta_Atual = PopulaObjeto();
                ItemBD obj_ItemBD = new ItemBD();
                Item obj_Item = new Item();
                bool b_Alterado = false;

                if (obj_Consulta_Atual.Cod_Consulta != -1)
                {
                    b_Alterado = obj_ConsultaBD.Alterar(obj_Consulta_Atual);

                    obj_Item.Cod_Consulta = Convert.ToInt16(tbox_Cod_Consulta.Text);
                    obj_ItemBD.ExcluirByCodConsulta(obj_Item);
                }
                else
                {
                    obj_Consulta_Atual.Cod_Consulta = obj_ConsultaBD.Incluir(obj_Consulta_Atual);
                }

                if (lv_ItemConsulta.Items.Count != 0)
                {
                    for (int i = 0; i < lv_ItemConsulta.Items.Count; i++)
                    {
                        obj_Item.Cod_Consulta = Convert.ToInt16(obj_Consulta_Atual.Cod_Consulta);
                        obj_Item.Cod_Exame = Convert.ToInt16(lv_ItemConsulta.Items[i].SubItems[0].Text);
                        int cod = obj_ItemBD.Incluir(obj_Item);
                    }

                }

                if (b_Alterado)
                {
                    MessageBox.Show("A consulta " + obj_Consulta_Atual.DH_Consulta + " foi alterado com sucesso.",
                                                        "Alteração de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A consulta " + obj_Consulta_Atual.DH_Consulta + " foi incluida com sucesso.",
                                        "Inclusão de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
                PopulaTela(obj_Consulta_Atual);
                PopulaLista();
            }
        }

        private void lbox_Consultas_Click(object sender, EventArgs e)
        {


            ConsultaBD obj_ConsultaBD = new ConsultaBD();
            int i_Pos = 0;
            string s_Linha = "";


            if (lbox_Consultas.SelectedIndex != -1)
            {
                s_Linha = lbox_Consultas.Items[lbox_Consultas.SelectedIndex].ToString();

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
                obj_Consulta_Atual.Cod_Consulta = Convert.ToInt16(s_Linha.Substring(0, i_Pos));
                obj_Consulta_Atual = obj_ConsultaBD.FindByCod(obj_Consulta_Atual);
                PopulaTela(obj_Consulta_Atual);
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }
        }

        private void tbox_Cod_Medico_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Medico.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(tbox_Cod_Medico.Text, typeof(Int16)))
                {
                    Medico obj_Medico = new Medico();
                    MedicoBD obj_MedicoBD = new MedicoBD();

                    obj_Medico.Cod_Medico = Convert.ToInt16(tbox_Cod_Medico.Text);
                    obj_Medico = obj_MedicoBD.FindByCod(obj_Medico);

                    lb_Nm_Medico.Text = obj_Medico.Nm_Medico;

                    if (lb_Nm_Medico.Text == "")
                    {
                        MessageBox.Show("O Código do Médico não cadastrado!",
                                        "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbox_Cod_Medico.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("O Código do Médico inválido!",
                                    "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbox_Cod_Medico.Focus();
                    tbox_Cod_Medico.Clear();
                }
            }
            
        }

        private void btn_Medico_Click(object sender, EventArgs e)
        {
            frm_Medico obj_frm_Medico = new frm_Medico();
            obj_frm_Medico.ShowDialog();
            tbox_Cod_Medico.Text = obj_frm_Medico.obj_Medico_Atual.Cod_Medico.ToString();
            tbox_Cod_Medico_Leave(tbox_Cod_Medico, e);
        }

        private void tbox_Cod_Paciente_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Paciente.Text != "")
            {
                if (obj_FuncGeral.ValidaTipo(tbox_Cod_Medico.Text, typeof(Int16)))
                {
                    Paciente obj_Paciente = new Paciente();
                    PacienteBD obj_PacienteBD = new PacienteBD();

                    obj_Paciente.Cod_Paciente = Convert.ToInt16(tbox_Cod_Paciente.Text);
                    obj_Paciente = obj_PacienteBD.FindByCod(obj_Paciente);

                    lb_Nm_Paciente.Text = obj_Paciente.Nm_Paciente;

                    if (lb_Nm_Paciente.Text == "")
                    {
                        MessageBox.Show("O Código do Paciente não cadastrado!",
                                        "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbox_Cod_Paciente.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("O Código do Paciente inválido!",
                                    "Código inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbox_Cod_Paciente.Focus();
                    tbox_Cod_Paciente.Clear();
                }
            }
        }

        private void btn_Paciente_Click(object sender, EventArgs e)
        {
            frm_Paciente obj_frm_Paciente = new frm_Paciente();
            obj_frm_Paciente.ShowDialog();
            tbox_Cod_Paciente.Text = obj_frm_Paciente.obj_Paciente_Atual.Cod_Paciente.ToString();
            tbox_Cod_Paciente_Leave(tbox_Cod_Paciente, e);
        }


        //***********************************************

        private void tbox_Cod_Exame_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_Exame.Text != "")
            {
                Exame obj_Exame = new Exame();
                ExameBD obj_ExameBD = new ExameBD();

                obj_Exame.Cod_Exame = Convert.ToInt16(tbox_Cod_Exame.Text);
                obj_Exame = obj_ExameBD.FindByCod(obj_Exame);

                lb_Nm_Exame.Text = obj_Exame.Nm_Exame;
                lb_Jjm_Exame.Text = obj_Exame.Jjm_Exame? "Em jejum": "";
            }
        }

        private void btn_Exame_Click(object sender, EventArgs e)
        {
            frm_Exame obj_frm_Exame = new frm_Exame();
            obj_frm_Exame.ShowDialog();
            tbox_Cod_Exame.Text = obj_frm_Exame.obj_Exame_Atual.Cod_Exame.ToString();
            tbox_Cod_Exame_Leave(tbox_Cod_Exame, e);
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (tbox_Cod_Exame.Text != "")
            {
                PopulaLinhaItem(lv_ItemConsulta, Convert.ToInt16(tbox_Cod_Exame.Text),
                                lb_Nm_Exame.Text, lb_Jjm_Exame.Text);
                tbox_Cod_Exame.Text = "";
                lb_Nm_Exame.Text = "";
                lb_Jjm_Exame.Text = "";
                tbox_Cod_Exame.Focus();
            }
            else
            {
                MessageBox.Show("Código do Exame está vazio.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbox_Cod_Exame.Focus();
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (lv_ItemConsulta.SelectedItems.Count != 0)
            {
                DialogResult v_Resp = MessageBox.Show("Confirma a retirada do exame selecionado?",
                                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(v_Resp == DialogResult.Yes)
                {
                    for(int i = 0; i < lv_ItemConsulta.Items.Count; i++)
                    {
                        if (lv_ItemConsulta.Items[i].Selected)
                        {
                            tbox_Cod_Exame.Text = lv_ItemConsulta.Items[i].SubItems[0].Text;
                            lb_Nm_Exame.Text = lv_ItemConsulta.Items[i].SubItems[1].Text;
                            lb_Jjm_Exame.Text = lv_ItemConsulta.Items[i].SubItems[2].Text;
                            lv_ItemConsulta.Items[i].Remove();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Exame não selecionado.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lv_ItemConsulta_Click(object sender, EventArgs e)
        {
            if (lv_ItemConsulta.SelectedItems != null)
            {

            }
        }

        private void mtbox_Dt_Consulta_Leave(object sender, EventArgs e)
        {
            if (mtbox_Dt_Consulta.Text != "")
            {
                mtbox_Dt_Consulta.TextMaskFormat = MaskFormat.IncludeLiterals;
                if (!obj_FuncGeral.ValidaTipo(mtbox_Dt_Consulta.Text, typeof(DateTime)))
                {
                    MessageBox.Show("Data Inválida!", "Valida Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtbox_Dt_Consulta.Focus();
                }
                mtbox_Dt_Consulta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }

        private void mtbox_Hr_Consulta_Leave(object sender, EventArgs e)
        {
            if (mtbox_Hr_Consulta.Text != "")
            {
                mtbox_Hr_Consulta.TextMaskFormat = MaskFormat.IncludeLiterals;
                if (!obj_FuncGeral.ValidaTipo(mtbox_Hr_Consulta.Text, typeof(DateTime)))
                {
                    MessageBox.Show("Hora Inválida!", "Valida Hora",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtbox_Hr_Consulta.Focus();
                }
                mtbox_Hr_Consulta.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
        }
    }
}
