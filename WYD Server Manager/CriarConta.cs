using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WYD_Server_Manager
{
    public partial class CriarConta : Form
    {
        private Form form;
        public CriarConta(Form f)
        {
            InitializeComponent();
            this.form = f;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_usuario.Clear();
            tb_senha.Clear();
            tl_status.Text = "Campos limpos.";
        }

        private void bt_criar_Click(object sender, EventArgs e)
        {

            try
            {
                byte[] data = new byte[7800];

                string logintxt = tb_usuario.Text;
                string senhatxt = tb_senha.Text;

                Byte[] login = Encoding.Default.GetBytes(logintxt);
                Byte[] senha = Encoding.Default.GetBytes(senhatxt);
                Byte[] senha2 = new byte[] { 255, 255, 255, 255, 255, 255 };

                if (login.Length < 4 || login.Length >= 16)
                {
                    tl_status.Text = "Login deve ter 4~15 caracteres";
                    return;
                }

                if (Functions.CheckSpecialCaracters(tb_usuario.Text))
                {
                    tl_status.Text = "Login  não deve ter caracteres especiais";
                    return;
                }
                for (int i = 0; i < login.Length; i++)
                    data[i] = login[i];
                if (senha.Length < 4 || senha.Length >= 12)
                {
                    tl_status.Text = "Senha deve ter 4~12 caracteres";
                    return;
                }
                if (Functions.CheckSpecialCaracters(tb_senha.Text))
                {
                    tl_status.Text = "Senha  não deve ter caracteres especiais";
                    return;
                }
                for (int i = 0; i < senha.Length; i++)
                    data[i + 16] = senha[i];

                for (int i = 0; i < senha2.Length; i++)
                    data[i + 202] = senha2[i];


                string dir = "./account/etc";
                var isAlpha = char.IsLetter(tb_usuario.Text[0]);
                if (isAlpha)
                    dir = "./account/" + tb_usuario.Text[0].ToString().ToUpper();

                bool folderExists = Directory.Exists(dir);
                if (!folderExists)
                    Directory.CreateDirectory(dir);

                dir = dir + "/" + tb_usuario.Text;
                if (File.Exists(dir))
                {
                    tl_status.Text = "Conta já existe, altere o usuario.";
                    return;
                }
                File.WriteAllBytes(dir, data);
                tl_status.Text = "Conta criada com Sucesso!";
                this.Close();
            }
            catch (Exception error)
            {
                tl_status.Text = "Erro: " + error.Message;
            }
            
        }

        private void CriarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form.Text = "criado";
        }
    }
}
