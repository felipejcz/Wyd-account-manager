namespace WYD_Server_Manager
{
    partial class Principal
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
            this.lb_contas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_selecionar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_numerica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_exportar = new System.Windows.Forms.Button();
            this.cb_ranking_pvp = new System.Windows.Forms.CheckBox();
            this.cb_ranking_gold = new System.Windows.Forms.CheckBox();
            this.cb_ranking_level = new System.Windows.Forms.CheckBox();
            this.cb_ranking_geral = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tl_statusTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.tl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quemSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_contas
            // 
            this.lb_contas.FormattingEnabled = true;
            this.lb_contas.Location = new System.Drawing.Point(12, 50);
            this.lb_contas.Name = "lb_contas";
            this.lb_contas.Size = new System.Drawing.Size(120, 199);
            this.lb_contas.TabIndex = 0;
            this.lb_contas.SelectedIndexChanged += new System.EventHandler(this.lb_contas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de contas:";
            // 
            // cb_selecionar
            // 
            this.cb_selecionar.AutoSize = true;
            this.cb_selecionar.Location = new System.Drawing.Point(15, 253);
            this.cb_selecionar.Name = "cb_selecionar";
            this.cb_selecionar.Size = new System.Drawing.Size(105, 17);
            this.cb_selecionar.TabIndex = 2;
            this.cb_selecionar.Text = "Selecionar todas";
            this.cb_selecionar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_numerica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_usuario);
            this.groupBox1.Location = new System.Drawing.Point(150, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numérica:";
            // 
            // tb_numerica
            // 
            this.tb_numerica.Location = new System.Drawing.Point(283, 44);
            this.tb_numerica.MaxLength = 6;
            this.tb_numerica.Name = "tb_numerica";
            this.tb_numerica.Size = new System.Drawing.Size(100, 20);
            this.tb_numerica.TabIndex = 4;
            this.tb_numerica.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(145, 44);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 2;
            this.tb_senha.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuário:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(9, 44);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 0;
            this.tb_usuario.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(547, 34);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(99, 38);
            this.bt_novo.TabIndex = 5;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(547, 78);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(99, 38);
            this.bt_excluir.TabIndex = 8;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(547, 210);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(99, 38);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_exportar);
            this.groupBox2.Controls.Add(this.cb_ranking_pvp);
            this.groupBox2.Controls.Add(this.cb_ranking_gold);
            this.groupBox2.Controls.Add(this.cb_ranking_level);
            this.groupBox2.Controls.Add(this.cb_ranking_geral);
            this.groupBox2.Location = new System.Drawing.Point(150, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exportar para:";
            // 
            // bt_exportar
            // 
            this.bt_exportar.Location = new System.Drawing.Point(283, 13);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(100, 69);
            this.bt_exportar.TabIndex = 5;
            this.bt_exportar.Text = "Exportar";
            this.bt_exportar.UseVisualStyleBackColor = true;
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // cb_ranking_pvp
            // 
            this.cb_ranking_pvp.AutoSize = true;
            this.cb_ranking_pvp.Location = new System.Drawing.Point(9, 88);
            this.cb_ranking_pvp.Name = "cb_ranking_pvp";
            this.cb_ranking_pvp.Size = new System.Drawing.Size(90, 17);
            this.cb_ranking_pvp.TabIndex = 4;
            this.cb_ranking_pvp.Text = "Ranking PVP";
            this.cb_ranking_pvp.UseVisualStyleBackColor = true;
            this.cb_ranking_pvp.CheckedChanged += new System.EventHandler(this.cb_ranking_pvp_CheckedChanged);
            // 
            // cb_ranking_gold
            // 
            this.cb_ranking_gold.AutoSize = true;
            this.cb_ranking_gold.Location = new System.Drawing.Point(9, 65);
            this.cb_ranking_gold.Name = "cb_ranking_gold";
            this.cb_ranking_gold.Size = new System.Drawing.Size(91, 17);
            this.cb_ranking_gold.TabIndex = 3;
            this.cb_ranking_gold.Text = "Ranking Gold";
            this.cb_ranking_gold.UseVisualStyleBackColor = true;
            this.cb_ranking_gold.CheckedChanged += new System.EventHandler(this.cb_ranking_gold_CheckedChanged);
            // 
            // cb_ranking_level
            // 
            this.cb_ranking_level.AutoSize = true;
            this.cb_ranking_level.Location = new System.Drawing.Point(9, 42);
            this.cb_ranking_level.Name = "cb_ranking_level";
            this.cb_ranking_level.Size = new System.Drawing.Size(95, 17);
            this.cb_ranking_level.TabIndex = 2;
            this.cb_ranking_level.Text = "Ranking Level";
            this.cb_ranking_level.UseVisualStyleBackColor = true;
            this.cb_ranking_level.CheckedChanged += new System.EventHandler(this.cb_ranking_level_CheckedChanged);
            // 
            // cb_ranking_geral
            // 
            this.cb_ranking_geral.AutoSize = true;
            this.cb_ranking_geral.Location = new System.Drawing.Point(9, 19);
            this.cb_ranking_geral.Name = "cb_ranking_geral";
            this.cb_ranking_geral.Size = new System.Drawing.Size(94, 17);
            this.cb_ranking_geral.TabIndex = 1;
            this.cb_ranking_geral.Text = "Ranking Geral";
            this.cb_ranking_geral.UseVisualStyleBackColor = true;
            this.cb_ranking_geral.CheckedChanged += new System.EventHandler(this.cb_ranking_geral_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tl_statusTitle,
            this.tl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 26);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tl_statusTitle
            // 
            this.tl_statusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_statusTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tl_statusTitle.Name = "tl_statusTitle";
            this.tl_statusTitle.Size = new System.Drawing.Size(61, 21);
            this.tl_statusTitle.Text = "Status:";
            // 
            // tl_status
            // 
            this.tl_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tl_status.Name = "tl_status";
            this.tl_status.Size = new System.Drawing.Size(122, 21);
            this.tl_status.Text = "Aguardando ação...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirContasToolStripMenuItem,
            this.salvarContasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirContasToolStripMenuItem
            // 
            this.abrirContasToolStripMenuItem.Name = "abrirContasToolStripMenuItem";
            this.abrirContasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.abrirContasToolStripMenuItem.Text = "Abrir contas";
            this.abrirContasToolStripMenuItem.Click += new System.EventHandler(this.abrirContasToolStripMenuItem_Click);
            // 
            // salvarContasToolStripMenuItem
            // 
            this.salvarContasToolStripMenuItem.Name = "salvarContasToolStripMenuItem";
            this.salvarContasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salvarContasToolStripMenuItem.Text = "Salvar contas";
            this.salvarContasToolStripMenuItem.Click += new System.EventHandler(this.salvarContasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quemSomosToolStripMenuItem,
            this.versãoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // quemSomosToolStripMenuItem
            // 
            this.quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            this.quemSomosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quemSomosToolStripMenuItem.Text = "Quem somos";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 296);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_selecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_contas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "WYD Account Manager";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.TextChanged += new System.EventHandler(this.Principal_TextChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_contas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_selecionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_numerica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_ranking_geral;
        private System.Windows.Forms.CheckBox cb_ranking_pvp;
        private System.Windows.Forms.CheckBox cb_ranking_gold;
        private System.Windows.Forms.CheckBox cb_ranking_level;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tl_statusTitle;
        private System.Windows.Forms.ToolStripStatusLabel tl_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quemSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarContasToolStripMenuItem;
        private System.Windows.Forms.Button bt_exportar;
    }
}

