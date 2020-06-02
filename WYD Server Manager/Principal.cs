using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WYD_Server_Manager
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
                
        private void Principal_Load(object sender, EventArgs e)
        {     
        }
        

        private void alteraStatus(string texto, int tipo)
        {
            switch (tipo)
            {
                case 0:
                    tl_statusTitle.ForeColor = System.Drawing.Color.Red;
                    tl_status.Text = texto;
                    break;
                case 1:
                    tl_statusTitle.ForeColor = System.Drawing.Color.ForestGreen;
                    tl_status.Text = texto;
                    break;

                default:
                    Console.WriteLine("Tipo enviado ao metodo alteraStatus é invalido!");
                    break;
            }
        }

        private void atualizaListaContas()
        {
            lb_contas.Items.Clear();
            int cont = External.listaContas.Count;
            System.Object[] ItemObject = new System.Object[cont];
            for (int i = 0; i < cont; i++)
            {
                ItemObject[i] = External.listaContas[i].Info.AccountName;
            }
            lb_contas.Items.AddRange(ItemObject);
        }

        private void atualizaInformacoes()
        {
            string numerica = "";
            for(int i=0;i < 6; i++)
            {
                numerica += Convert.ToString(External.conta.Info.NumericToken[i]);
            }
            if (numerica == "ÿÿÿÿÿÿ")
                numerica = "";

            tb_usuario.Text = External.conta.Info.AccountName;
            tb_senha.Text = External.conta.Info.AccountPass;
            tb_numerica.Text = Convert.ToString(numerica);
             
        }

        private void limpaInformacoes()
        {
            External.currentChar = -1;
            tb_usuario.Clear();
            tb_senha.Clear();
            tb_numerica.Clear();
        }

        private void lb_contas_SelectedIndexChanged(object sender, EventArgs e)
        {
            External.currentChar = lb_contas.SelectedIndex;
            External.conta = External.listaContas[External.currentChar];
            atualizaInformacoes();
        }

        private void cb_ranking_geral_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ranking_geral.Checked)
            {
                cb_ranking_level.Checked = false;
                cb_ranking_gold.Checked = false;
                cb_ranking_pvp.Checked = false;
            }
        }

        private void cb_ranking_level_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ranking_level.Checked)
            {
                cb_ranking_geral.Checked = false;
                cb_ranking_gold.Checked = false;
                cb_ranking_pvp.Checked = false;
            }
        }

        private void cb_ranking_gold_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ranking_gold.Checked)
            {
                cb_ranking_level.Checked = false;
                cb_ranking_geral.Checked = false;
                cb_ranking_pvp.Checked = false;
            }
        }

        private void cb_ranking_pvp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ranking_pvp.Checked)
            {
                cb_ranking_level.Checked = false;
                cb_ranking_gold.Checked = false;
                cb_ranking_geral.Checked = false;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            if(External.currentChar == -1)
            {
                alteraStatus("Você deve selecionar uma conta!", 0);
                return;
            }
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;
            char[] numerica = new char[6];
            if (string.IsNullOrEmpty(tb_numerica.Text))
            {
                numerica[0] = 'ÿ';
                numerica[1] = 'ÿ';
                numerica[2] = 'ÿ';
                numerica[3] = 'ÿ';
                numerica[4] = 'ÿ';
                numerica[5] = 'ÿ';
            }else
            {
                for (int i = 0; i < 6; i++)
                {
                    if(tb_numerica.TextLength > i)
                    {
                        numerica[i] = Convert.ToChar(tb_numerica.Text[i]);
                        
                    }else
                    {
                        numerica[i] = '\0';
                    }
                    
                }
            }

            External.conta.Info.AccountName = usuario;
            External.conta.Info.AccountPass = senha;
            External.conta.Info.NumericToken = numerica;
            External.listaContas[External.currentChar] = External.conta;
            atualizaListaContas();
            lb_contas.SelectedIndex = External.currentChar;
            alteraStatus("Conta alterada com sucesso.",1);
            

        }

        public void abrirContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpaInformacoes();
            External.currentChar = -1;
            if (!Functions.LocalizarContas())
            {
                alteraStatus("Não a contas cadastradas.", 0);
                return;
            }
            alteraStatus("Contas adicionadas com sucesso.", 1);
            atualizaListaContas();
            
            return;
        }

        private void salvarContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lb_contas.Items.Count < 1)
            {
                alteraStatus("Não a contas para salvar.", 0);
                return;
            }
            Functions.SaveAccounts();
            alteraStatus("Lista de contas salva com sucesso.",1);
        }
        private void bt_novo_Click(object sender, EventArgs e)
        {
            if(lb_contas.Items.Count < 1)
            {
                alteraStatus("Não a contas abertas.", 0);
                return;
            }
            CriarConta novaConta = new CriarConta(this);
            novaConta.Show();           
            
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            if(External.currentChar == -1)
            {
                alteraStatus("Nenhuma conta selecionada!", 0);
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir esta conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (Functions.excluirConta())
            {
                abrirContasToolStripMenuItem_Click(sender,e);
                alteraStatus("Conta excluida com sucesso.", 1);
            }else
            {
                alteraStatus("Não foi possivel excluir conta.", 0);
            }
            
        }

        private void Principal_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "criado")
            {
                this.Text = "WYD Account Manager";
                abrirContasToolStripMenuItem_Click(sender, e);
            }
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            if (lb_contas.Items.Count < 1)
            {
                alteraStatus("Não a contas abertas.", 0);
                return;
            }
            string checado = "";
            if (cb_ranking_geral.Checked)
            {
                checado = "geral";
            }
            else if(cb_ranking_gold.Checked)
            {
                checado = "gold";
            }
            else if (cb_ranking_level.Checked)
            {
                checado = "level";
            }
            else if (cb_ranking_pvp.Checked)
            {
                checado = "pvp";
            }
            if(checado == "")
            {
                alteraStatus("Selecione qual Ranking deseja exportar!", 0);
                return;
            }
            if(External.currentChar == -1 && cb_selecionar.Checked == false)
            {
                alteraStatus("Selecione uma conta ou clique em selecionar todas,", 0);
                return;
            }
            List<Structs.STRUCT_ACCOUNTFILE> contas = new List<Structs.STRUCT_ACCOUNTFILE>();
            if (cb_selecionar.Checked)
            {
                foreach(Structs.STRUCT_ACCOUNTFILE conta in External.listaContas)
                {
                    contas.Add(conta);
                }
            }else
            {
                contas.Add(External.listaContas[External.currentChar]);
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Escolha onde sera salvo o arquivo json.";
            saveFile.InitialDirectory = Environment.CurrentDirectory;
            saveFile.Filter = "Arquivo Json | *.json";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            {
                alteraStatus("Exportação cancelada.", 0);
                return;
            }
            alteraStatus(Functions.exportJson(contas, saveFile.FileName, checado),1);
        }
    }
}
