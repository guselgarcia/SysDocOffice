namespace SysDocOffice
{
    partial class frm_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consulta));
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.mtbox_Hr_Consulta = new System.Windows.Forms.MaskedTextBox();
            this.mtbox_Dt_Consulta = new System.Windows.Forms.MaskedTextBox();
            this.lv_ItemConsulta = new System.Windows.Forms.ListView();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.lb_Jjm_Exame = new System.Windows.Forms.Label();
            this.lb_Nm_Exame = new System.Windows.Forms.Label();
            this.btn_Exame = new System.Windows.Forms.Button();
            this.tbox_Cod_Exame = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_Nm_Paciente = new System.Windows.Forms.Label();
            this.btn_Paciente = new System.Windows.Forms.Button();
            this.tbox_Cod_Paciente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Nm_Medico = new System.Windows.Forms.Label();
            this.btn_Medico = new System.Windows.Forms.Button();
            this.tbox_Desc_Consulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_Cod_Consulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbox_Cod_Medico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lbox_Consultas = new System.Windows.Forms.ListBox();
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
            this.pnl_Detail.Controls.Add(this.mtbox_Hr_Consulta);
            this.pnl_Detail.Controls.Add(this.mtbox_Dt_Consulta);
            this.pnl_Detail.Controls.Add(this.lv_ItemConsulta);
            this.pnl_Detail.Controls.Add(this.btn_Down);
            this.pnl_Detail.Controls.Add(this.btn_Up);
            this.pnl_Detail.Controls.Add(this.lb_Jjm_Exame);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Exame);
            this.pnl_Detail.Controls.Add(this.btn_Exame);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Exame);
            this.pnl_Detail.Controls.Add(this.label14);
            this.pnl_Detail.Controls.Add(this.label11);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Paciente);
            this.pnl_Detail.Controls.Add(this.btn_Paciente);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Paciente);
            this.pnl_Detail.Controls.Add(this.label13);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Medico);
            this.pnl_Detail.Controls.Add(this.btn_Medico);
            this.pnl_Detail.Controls.Add(this.tbox_Desc_Consulta);
            this.pnl_Detail.Controls.Add(this.label8);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Consulta);
            this.pnl_Detail.Controls.Add(this.label10);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Medico);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(127, 66);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(415, 410);
            this.pnl_Detail.TabIndex = 19;
            // 
            // mtbox_Hr_Consulta
            // 
            this.mtbox_Hr_Consulta.Location = new System.Drawing.Point(328, 117);
            this.mtbox_Hr_Consulta.Name = "mtbox_Hr_Consulta";
            this.mtbox_Hr_Consulta.Size = new System.Drawing.Size(68, 20);
            this.mtbox_Hr_Consulta.TabIndex = 6;
            this.mtbox_Hr_Consulta.Tag = "4";
            this.mtbox_Hr_Consulta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbox_Hr_Consulta.Leave += new System.EventHandler(this.mtbox_Hr_Consulta_Leave);
            // 
            // mtbox_Dt_Consulta
            // 
            this.mtbox_Dt_Consulta.Location = new System.Drawing.Point(328, 76);
            this.mtbox_Dt_Consulta.Name = "mtbox_Dt_Consulta";
            this.mtbox_Dt_Consulta.Size = new System.Drawing.Size(68, 20);
            this.mtbox_Dt_Consulta.TabIndex = 3;
            this.mtbox_Dt_Consulta.Tag = "3";
            this.mtbox_Dt_Consulta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbox_Dt_Consulta.Leave += new System.EventHandler(this.mtbox_Dt_Consulta_Leave);
            // 
            // lv_ItemConsulta
            // 
            this.lv_ItemConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_ItemConsulta.FullRowSelect = true;
            this.lv_ItemConsulta.GridLines = true;
            this.lv_ItemConsulta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_ItemConsulta.HideSelection = false;
            this.lv_ItemConsulta.Location = new System.Drawing.Point(26, 278);
            this.lv_ItemConsulta.Name = "lv_ItemConsulta";
            this.lv_ItemConsulta.Size = new System.Drawing.Size(377, 113);
            this.lv_ItemConsulta.TabIndex = 12;
            this.lv_ItemConsulta.UseCompatibleStateImageBehavior = false;
            this.lv_ItemConsulta.Click += new System.EventHandler(this.lv_ItemConsulta_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.Image = global::SysDocOffice.Properties.Resources.img_Down;
            this.btn_Down.Location = new System.Drawing.Point(375, 249);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(23, 22);
            this.btn_Down.TabIndex = 11;
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.FlatAppearance.BorderSize = 0;
            this.btn_Up.Image = global::SysDocOffice.Properties.Resources.img_UP;
            this.btn_Up.Location = new System.Drawing.Point(346, 249);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(23, 22);
            this.btn_Up.TabIndex = 10;
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // lb_Jjm_Exame
            // 
            this.lb_Jjm_Exame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_Jjm_Exame.Location = new System.Drawing.Point(280, 254);
            this.lb_Jjm_Exame.Name = "lb_Jjm_Exame";
            this.lb_Jjm_Exame.Size = new System.Drawing.Size(57, 13);
            this.lb_Jjm_Exame.TabIndex = 27;
            this.lb_Jjm_Exame.Tag = "1";
            // 
            // lb_Nm_Exame
            // 
            this.lb_Nm_Exame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_Nm_Exame.Location = new System.Drawing.Point(99, 254);
            this.lb_Nm_Exame.Name = "lb_Nm_Exame";
            this.lb_Nm_Exame.Size = new System.Drawing.Size(175, 13);
            this.lb_Nm_Exame.TabIndex = 26;
            this.lb_Nm_Exame.Tag = "1";
            // 
            // btn_Exame
            // 
            this.btn_Exame.FlatAppearance.BorderSize = 0;
            this.btn_Exame.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exame.Image")));
            this.btn_Exame.Location = new System.Drawing.Point(75, 250);
            this.btn_Exame.Name = "btn_Exame";
            this.btn_Exame.Size = new System.Drawing.Size(23, 22);
            this.btn_Exame.TabIndex = 9;
            this.btn_Exame.UseVisualStyleBackColor = true;
            this.btn_Exame.Click += new System.EventHandler(this.btn_Exame_Click);
            // 
            // tbox_Cod_Exame
            // 
            this.tbox_Cod_Exame.Location = new System.Drawing.Point(21, 251);
            this.tbox_Cod_Exame.Name = "tbox_Cod_Exame";
            this.tbox_Cod_Exame.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Exame.TabIndex = 8;
            this.tbox_Cod_Exame.Tag = "-1";
            this.tbox_Cod_Exame.Leave += new System.EventHandler(this.tbox_Cod_Exame_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Exame";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hora";
            // 
            // lb_Nm_Paciente
            // 
            this.lb_Nm_Paciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_Nm_Paciente.Location = new System.Drawing.Point(99, 120);
            this.lb_Nm_Paciente.Name = "lb_Nm_Paciente";
            this.lb_Nm_Paciente.Size = new System.Drawing.Size(223, 13);
            this.lb_Nm_Paciente.TabIndex = 20;
            this.lb_Nm_Paciente.Tag = "1";
            // 
            // btn_Paciente
            // 
            this.btn_Paciente.FlatAppearance.BorderSize = 0;
            this.btn_Paciente.Image = ((System.Drawing.Image)(resources.GetObject("btn_Paciente.Image")));
            this.btn_Paciente.Location = new System.Drawing.Point(75, 116);
            this.btn_Paciente.Name = "btn_Paciente";
            this.btn_Paciente.Size = new System.Drawing.Size(23, 22);
            this.btn_Paciente.TabIndex = 5;
            this.btn_Paciente.UseVisualStyleBackColor = true;
            this.btn_Paciente.Click += new System.EventHandler(this.btn_Paciente_Click);
            // 
            // tbox_Cod_Paciente
            // 
            this.tbox_Cod_Paciente.Location = new System.Drawing.Point(21, 117);
            this.tbox_Cod_Paciente.Name = "tbox_Cod_Paciente";
            this.tbox_Cod_Paciente.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Paciente.TabIndex = 4;
            this.tbox_Cod_Paciente.Leave += new System.EventHandler(this.tbox_Cod_Paciente_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Paciente";
            // 
            // lb_Nm_Medico
            // 
            this.lb_Nm_Medico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_Nm_Medico.Location = new System.Drawing.Point(99, 80);
            this.lb_Nm_Medico.Name = "lb_Nm_Medico";
            this.lb_Nm_Medico.Size = new System.Drawing.Size(223, 13);
            this.lb_Nm_Medico.TabIndex = 16;
            this.lb_Nm_Medico.Tag = "1";
            // 
            // btn_Medico
            // 
            this.btn_Medico.FlatAppearance.BorderSize = 0;
            this.btn_Medico.Image = ((System.Drawing.Image)(resources.GetObject("btn_Medico.Image")));
            this.btn_Medico.Location = new System.Drawing.Point(75, 76);
            this.btn_Medico.Name = "btn_Medico";
            this.btn_Medico.Size = new System.Drawing.Size(23, 22);
            this.btn_Medico.TabIndex = 2;
            this.btn_Medico.UseVisualStyleBackColor = true;
            this.btn_Medico.Click += new System.EventHandler(this.btn_Medico_Click);
            // 
            // tbox_Desc_Consulta
            // 
            this.tbox_Desc_Consulta.Location = new System.Drawing.Point(21, 157);
            this.tbox_Desc_Consulta.Multiline = true;
            this.tbox_Desc_Consulta.Name = "tbox_Desc_Consulta";
            this.tbox_Desc_Consulta.Size = new System.Drawing.Size(377, 62);
            this.tbox_Desc_Consulta.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data";
            // 
            // tbox_Cod_Consulta
            // 
            this.tbox_Cod_Consulta.Enabled = false;
            this.tbox_Cod_Consulta.Location = new System.Drawing.Point(21, 37);
            this.tbox_Cod_Consulta.Name = "tbox_Cod_Consulta";
            this.tbox_Cod_Consulta.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Consulta.TabIndex = 0;
            this.tbox_Cod_Consulta.Tag = "1";
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
            // tbox_Cod_Medico
            // 
            this.tbox_Cod_Medico.Location = new System.Drawing.Point(21, 77);
            this.tbox_Cod_Medico.Name = "tbox_Cod_Medico";
            this.tbox_Cod_Medico.Size = new System.Drawing.Size(53, 20);
            this.tbox_Cod_Medico.TabIndex = 1;
            this.tbox_Cod_Medico.Leave += new System.EventHandler(this.tbox_Cod_Medico_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Medico";
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.lbox_Consultas);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 66);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(127, 410);
            this.pnl_List.TabIndex = 18;
            // 
            // lbox_Consultas
            // 
            this.lbox_Consultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Consultas.FormattingEnabled = true;
            this.lbox_Consultas.Location = new System.Drawing.Point(0, 0);
            this.lbox_Consultas.Name = "lbox_Consultas";
            this.lbox_Consultas.Size = new System.Drawing.Size(127, 410);
            this.lbox_Consultas.TabIndex = 0;
            this.lbox_Consultas.Click += new System.EventHandler(this.lbox_Consultas_Click);
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
            this.pnl_Button.Location = new System.Drawing.Point(0, 476);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(542, 32);
            this.pnl_Button.TabIndex = 17;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(450, 4);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(369, 4);
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
            this.pnl_Title.Size = new System.Drawing.Size(542, 66);
            this.pnl_Title.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(547, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(597, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(553, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(539, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(460, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(469, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consulta";
            // 
            // frm_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 508);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Consulta";
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
        private System.Windows.Forms.Label lb_Nm_Medico;
        private System.Windows.Forms.Button btn_Medico;
        private System.Windows.Forms.TextBox tbox_Desc_Consulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_Cod_Consulta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Cod_Medico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox lbox_Consultas;
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
        private System.Windows.Forms.Label lb_Nm_Paciente;
        private System.Windows.Forms.Button btn_Paciente;
        private System.Windows.Forms.TextBox tbox_Cod_Paciente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_Nm_Exame;
        private System.Windows.Forms.Button btn_Exame;
        private System.Windows.Forms.TextBox tbox_Cod_Exame;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lv_ItemConsulta;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Label lb_Jjm_Exame;
        private System.Windows.Forms.MaskedTextBox mtbox_Hr_Consulta;
        private System.Windows.Forms.MaskedTextBox mtbox_Dt_Consulta;
    }
}