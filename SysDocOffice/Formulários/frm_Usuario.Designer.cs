﻿namespace SysDocOffice
{
    partial class frm_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lbox_Usuarios = new System.Windows.Forms.ListBox();
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.chbox_Senha = new System.Windows.Forms.CheckBox();
            this.tbox_Cod_Usuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Nm_Usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_PW_Usuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_UNm_Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_Button.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 226);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(451, 32);
            this.pnl_Button.TabIndex = 5;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(169, 4);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(88, 4);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 3;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Location = new System.Drawing.Point(8, 4);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 2;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(367, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Location = new System.Drawing.Point(286, 4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_Title.Controls.Add(this.label1);
            this.pnl_Title.Controls.Add(this.label2);
            this.pnl_Title.Controls.Add(this.label6);
            this.pnl_Title.Controls.Add(this.label5);
            this.pnl_Title.Controls.Add(this.label4);
            this.pnl_Title.Controls.Add(this.label3);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(451, 66);
            this.pnl_Title.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(356, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(396, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(362, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(348, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(288, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(288, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário";
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.lbox_Usuarios);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 66);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(112, 160);
            this.pnl_List.TabIndex = 6;
            // 
            // lbox_Usuarios
            // 
            this.lbox_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Usuarios.FormattingEnabled = true;
            this.lbox_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.lbox_Usuarios.Name = "lbox_Usuarios";
            this.lbox_Usuarios.Size = new System.Drawing.Size(112, 160);
            this.lbox_Usuarios.TabIndex = 0;
            this.lbox_Usuarios.Click += new System.EventHandler(this.lbox_Usuarios_Click);
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Detail.Controls.Add(this.chbox_Senha);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Usuario);
            this.pnl_Detail.Controls.Add(this.label10);
            this.pnl_Detail.Controls.Add(this.tbox_Nm_Usuario);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Controls.Add(this.tbox_PW_Usuario);
            this.pnl_Detail.Controls.Add(this.label8);
            this.pnl_Detail.Controls.Add(this.tbox_UNm_Usuario);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(112, 66);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(339, 160);
            this.pnl_Detail.TabIndex = 7;
            // 
            // chbox_Senha
            // 
            this.chbox_Senha.AutoSize = true;
            this.chbox_Senha.Location = new System.Drawing.Point(305, 120);
            this.chbox_Senha.Name = "chbox_Senha";
            this.chbox_Senha.Size = new System.Drawing.Size(15, 14);
            this.chbox_Senha.TabIndex = 9;
            this.chbox_Senha.UseVisualStyleBackColor = true;
            this.chbox_Senha.Click += new System.EventHandler(this.chbox_Senha_Click);
            // 
            // tbox_Cod_Usuario
            // 
            this.tbox_Cod_Usuario.Enabled = false;
            this.tbox_Cod_Usuario.Location = new System.Drawing.Point(21, 37);
            this.tbox_Cod_Usuario.Name = "tbox_Cod_Usuario";
            this.tbox_Cod_Usuario.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Usuario.TabIndex = 8;
            this.tbox_Cod_Usuario.Tag = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Código";
            // 
            // tbox_Nm_Usuario
            // 
            this.tbox_Nm_Usuario.Location = new System.Drawing.Point(21, 77);
            this.tbox_Nm_Usuario.Name = "tbox_Nm_Usuario";
            this.tbox_Nm_Usuario.Size = new System.Drawing.Size(306, 20);
            this.tbox_Nm_Usuario.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nome";
            // 
            // tbox_PW_Usuario
            // 
            this.tbox_PW_Usuario.Location = new System.Drawing.Point(176, 117);
            this.tbox_PW_Usuario.Name = "tbox_PW_Usuario";
            this.tbox_PW_Usuario.PasswordChar = '•';
            this.tbox_PW_Usuario.Size = new System.Drawing.Size(123, 20);
            this.tbox_PW_Usuario.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Senha";
            // 
            // tbox_UNm_Usuario
            // 
            this.tbox_UNm_Usuario.Location = new System.Drawing.Point(21, 117);
            this.tbox_UNm_Usuario.Name = "tbox_UNm_Usuario";
            this.tbox_UNm_Usuario.Size = new System.Drawing.Size(149, 20);
            this.tbox_UNm_Usuario.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuário";
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 258);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.pnl_List.ResumeLayout(false);
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.TextBox tbox_Cod_Usuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Nm_Usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_PW_Usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_UNm_Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.CheckBox chbox_Senha;
        private System.Windows.Forms.ListBox lbox_Usuarios;
    }
}