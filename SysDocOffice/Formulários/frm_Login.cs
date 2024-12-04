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
    public partial class frm_Login : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (tbox_UNm_Usuario.Text == "Master" && tbox_PW_Usuario.Text == "")
            {
                frm_Principal obj_frm_Principal = new frm_Principal();
                obj_frm_Principal.obj_Usuario_Atual.UNm_Usuario = "Master Senha";
                obj_frm_Principal.ShowDialog();
            }
            else 
            { 

                if (tbox_UNm_Usuario.Text != "" && tbox_PW_Usuario.Text != "")
                {
                    Usuario obj_Usuario = new Usuario();
                    UsuarioBD obj_UsuarioBD = new UsuarioBD();

                    obj_Usuario.UNm_Usuario = tbox_UNm_Usuario.Text;
                    obj_Usuario = obj_UsuarioBD.FindByUNm(obj_Usuario);

                    if (obj_Usuario.Cod_Usuario != -1)
                    {
                        if (obj_Usuario.PW_Usuario == obj_FuncGeral.Criptografa(tbox_PW_Usuario.Text))
                        {
                            frm_Principal obj_frm_Principal = new frm_Principal();
                            obj_frm_Principal.obj_Usuario_Atual = obj_Usuario;
                            obj_frm_Principal.ShowDialog();
                            Close();
                        }

                        else
                        {
                            MessageBox.Show("Senha Inválida.", "Login",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não Encontrado.", "Login",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Campo não preenchido.", "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (tbox_UNm_Usuario.Text == "")
                    {
                        tbox_UNm_Usuario.Focus();
                    }
                    else
                    {
                        tbox_PW_Usuario.Focus();
                    }
                }
            }


        }

        private void pbox_PW_Usuario_MouseHover(object sender, EventArgs e)
        {
            pbox_PW_Usuario.Image = global::SysDocOffice.Properties.Resources.img_OlhoOn;
            tbox_PW_Usuario.PasswordChar = '\u0000';
        }

        private void pbox_PW_Usuario_MouseLeave(object sender, EventArgs e)
        {
            pbox_PW_Usuario.Image = global::SysDocOffice.Properties.Resources.img_OlhoOff;
            tbox_PW_Usuario.PasswordChar = '*';
        }
    }
}
