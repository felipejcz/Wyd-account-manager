namespace WYD_Server_Manager
{
    partial class CriarConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_criar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(15, 26);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 20);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(124, 26);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(15, 52);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(100, 35);
            this.bt_limpar.TabIndex = 4;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // bt_criar
            // 
            this.bt_criar.Location = new System.Drawing.Point(124, 52);
            this.bt_criar.Name = "bt_criar";
            this.bt_criar.Size = new System.Drawing.Size(100, 35);
            this.bt_criar.TabIndex = 5;
            this.bt_criar.Text = "Criar";
            this.bt_criar.UseVisualStyleBackColor = true;
            this.bt_criar.Click += new System.EventHandler(this.bt_criar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 101);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(238, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tl_status
            // 
            this.tl_status.Name = "tl_status";
            this.tl_status.Size = new System.Drawing.Size(132, 17);
            this.tl_status.Text = "Digite usuario e senha...";
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 123);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_criar);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.label1);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CriarConta_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_criar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tl_status;
        private System.Windows.Forms.TextBox tb_senha;
    }
}