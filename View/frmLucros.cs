using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmLucros : Form
    {
        public frmLucros()
        {
            InitializeComponent();
        }
        VendaDAO comando = new VendaDAO();
        private void btn_PesquiarEntreDatas_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_PesquisaDatas.DataSource = null;
                dgv_PesquisaDatas.DataSource = comando.SelectEntreDatas(dtp_DataUm.Value.ToString("dd/MM/yyyy"), dtp_DataDois.Value.ToString("dd/MM/yyyy"));

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Carregar O Banco: " + Erro.Message, "Erro");
            }
        }

        private void btn_totalFinal_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_PesquisaDatas.DataSource = null;
                dgv_PesquisaDatas.DataSource = comando.SelectFullVendas();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Carregar O Banco: " + Erro.Message, "Erro");
            }
        }

        private void frmLucros_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btn_PesquiarEntreDatas;
        }

        private void btn_DeletarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                string data = dtp_DeletarVenda.Value.ToString("dd/MM/yyyy");

                if (comando.DeteteVendasPorData(data))
                {
                    MessageBox.Show("Renda E Lucro Do Dia " + data + " Foi Excluido Com Sucesso!", "Aviso");
                  
                }
                else
                {
                    MessageBox.Show("Erro Ao Excluir A Venda, Verifique Se A Data Corresponde A Um Dia De Venda","Aviso");
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro Ao Excluir A Venda: "+Erro.Message,"Erro");
            }
        }


    }
}
