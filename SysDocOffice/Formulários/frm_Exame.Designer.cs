﻿namespace SysDocOffice
{
    partial class frm_Exame
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
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.chbox_Jjm_Exame = new System.Windows.Forms.CheckBox();
            this.tbox_Cod_Exame = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Nm_Exame = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lbox_Exames = new System.Windows.Forms.ListBox();
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
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl_Detail.Controls.Add(this.chbox_Jjm_Exame);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Exame);
            this.pnl_Detail.Controls.Add(this.label10);
            this.pnl_Detail.Controls.Add(this.tbox_Nm_Exame);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(127, 66);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(335, 129);
            this.pnl_Detail.TabIndex = 15;
            // 
            // chbox_Jjm_Exame
            // 
            this.chbox_Jjm_Exame.AutoSize = true;
            this.chbox_Jjm_Exame.Location = new System.Drawing.Point(251, 87);
            this.chbox_Jjm_Exame.Name = "chbox_Jjm_Exame";
            this.chbox_Jjm_Exame.Size = new System.Drawing.Size(53, 17);
            this.chbox_Jjm_Exame.TabIndex = 9;
            this.chbox_Jjm_Exame.Text = "Jejum";
            this.chbox_Jjm_Exame.UseVisualStyleBackColor = true;
            // 
            // tbox_Cod_Exame
            // 
            this.tbox_Cod_Exame.Enabled = false;
            this.tbox_Cod_Exame.Location = new System.Drawing.Point(21, 37);
            this.tbox_Cod_Exame.Name = "tbox_Cod_Exame";
            this.tbox_Cod_Exame.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Exame.TabIndex = 8;
            this.tbox_Cod_Exame.Tag = "1";
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
            // tbox_Nm_Exame
            // 
            this.tbox_Nm_Exame.Location = new System.Drawing.Point(21, 87);
            this.tbox_Nm_Exame.Name = "tbox_Nm_Exame";
            this.tbox_Nm_Exame.Size = new System.Drawing.Size(224, 20);
            this.tbox_Nm_Exame.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nome";
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.lbox_Exames);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 66);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(127, 129);
            this.pnl_List.TabIndex = 14;
            // 
            // lbox_Exames
            // 
            this.lbox_Exames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Exames.FormattingEnabled = true;
            this.lbox_Exames.Location = new System.Drawing.Point(0, 0);
            this.lbox_Exames.Name = "lbox_Exames";
            this.lbox_Exames.Size = new System.Drawing.Size(127, 129);
            this.lbox_Exames.TabIndex = 0;
            this.lbox_Exames.Click += new System.EventHandler(this.lbox_Exames_Click);
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
            this.pnl_Button.Location = new System.Drawing.Point(0, 195);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(462, 32);
            this.pnl_Button.TabIndex = 13;
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
            this.pnl_Title.Size = new System.Drawing.Size(462, 66);
            this.pnl_Title.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(375, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exame";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(331, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Exame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(317, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exame";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(238, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(247, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exame";
            // 
            // frm_Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 227);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.pnl_List.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.CheckBox chbox_Jjm_Exame;
        private System.Windows.Forms.TextBox tbox_Cod_Exame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Nm_Exame;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox lbox_Exames;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}