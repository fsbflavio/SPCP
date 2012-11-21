using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SPCP.View
{
    public partial class frmMainMDI : Form
    {
        //private int childFormNumber = 0;

        public frmMainMDI()
        {
            InitializeComponent();
        }

        //fecha todas as janeles filhas
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private bool ExisteJanelaAberta(string frmNome)
        {
            bool existe = false;
            //Procura se a janela ja esta aberta pelo título da janela
            foreach (Form Procura in this.MdiChildren)
            {
                if (Procura.Name == frmNome)
                {
                    MessageBox.Show("Uma instância deste formulário já está sendo " + "executada!", "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procura.WindowState = FormWindowState.Normal;
                    Procura.BringToFront();
                    existe = true;
                    
                }
            }
            return existe;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmClientes"))
                return;
            frmClientes frmClientes = new frmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void custosDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmControleProducao"))
                return;
            frmControleProducao frmControleProducao = new frmControleProducao();
            frmControleProducao.MdiParent = this;
            frmControleProducao.Show();

        }

        private void pedidoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmCompra"))
                return;
            frmCompra frmCompra = new frmCompra();
            frmCompra.MdiParent = this;
            frmCompra.Show();
        }

        private void pedidoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmPedidoVenda"))
                return;
            frmPedidoVenda frmPedidoVenda = new frmPedidoVenda();
            frmPedidoVenda.MdiParent = this;
            frmPedidoVenda.Show();
        }

        private void frmMainMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmUsuarios"))
                return;
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void cadastrosDeTiposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmTpUsuarios"))
                return;
            frmTpUsuarios frmTpUsuario = new frmTpUsuarios();
            frmTpUsuario.MdiParent = this;
            frmTpUsuario.Show();
        }

        private void loteProducaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmLoteProducao"))
                return;
            frmLoteProducao frmLoteProducao = new frmLoteProducao();
            frmLoteProducao.MdiParent = this;
            frmLoteProducao.Show();
        }

        private void ordemProducaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmOrdemProducao"))
                return;
            frmOrdemProducao frmOrdemProducao = new frmOrdemProducao();
            frmOrdemProducao.MdiParent = this;
            frmOrdemProducao.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmItemEstoque"))
                return;
            frmItemEstoque frmItemEstoque = new frmItemEstoque();
            frmItemEstoque.MdiParent = this;
            frmItemEstoque.Show();
        }

        private void cadastroTipoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmGrupoEstoque"))
                return;
            frmGrupoEstoque frmGrupoEstoque = new frmGrupoEstoque();
            frmGrupoEstoque.MdiParent = this;
            frmGrupoEstoque.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmFornecedores"))
                return;
            frmFornecedores frmFornecedores = new frmFornecedores();
            frmFornecedores.MdiParent = this;
            frmFornecedores.Show();
        }

        private void itensDeEstoqqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmItemEstoque"))
                return;
            frmItemEstoque frmItemEstoque = new frmItemEstoque();
            frmItemEstoque.MdiParent = this;
            frmItemEstoque.Show();
        }

        private void fichaDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmFichaProduto"))
                return;
            frmFichaProduto frmFichaProduto = new frmFichaProduto();
            frmFichaProduto.MdiParent = this;
            frmFichaProduto.Show();
        }

        private void listagemDeRelatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmRelatorio"))
                return;
            frmRelatorio frmRelatorio = new frmRelatorio();
            frmRelatorio.MdiParent = this;
            frmRelatorio.Show();
        }

        private void fichaDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ExisteJanelaAberta("frmFichaProduto"))
                return;
            frmFichaProduto frmFichaProduto = new frmFichaProduto();
            frmFichaProduto.MdiParent = this;
            frmFichaProduto.Show();
        }
    }
}
