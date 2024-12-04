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
    public partial class frm_Principal : Form
    {
        public Usuario obj_Usuario_Atual = new Usuario();

        public frm_Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tm_Principal_Tick(object sender, EventArgs e)
        {
            tsslb_Data.Text = DateTime.Today.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Usuario obj_frm_Usuario = new frm_Usuario();
            obj_frm_Usuario.ShowDialog();
        }

        private void convênioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Convenio obj_frm_Convenio = new frm_Convenio();
            obj_frm_Convenio.ShowDialog();
        }

        private void frm_Principal_Shown(object sender, EventArgs e)
        {
            tsslb_Usuario.Text = obj_Usuario_Atual.UNm_Usuario;
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Especialidade obj_frm_Especialidade = new frm_Especialidade();
            obj_frm_Especialidade.ShowDialog();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Exame obj_frm_Exame = new frm_Exame();
            obj_frm_Exame.ShowDialog();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Medico obj_frm_Medico = new frm_Medico();
            obj_frm_Medico.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Paciente obj_frm_Paciente = new frm_Paciente();
            obj_frm_Paciente.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Consulta obj_frm_Consulta = new frm_Consulta();
            obj_frm_Consulta.ShowDialog();
        }


    }
}
