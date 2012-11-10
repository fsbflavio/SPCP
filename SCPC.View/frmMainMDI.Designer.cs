namespace SPCP.View
{
    partial class frmMainMDI
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroTipoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.custosDeProduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loteProducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemProducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensDeEstoqqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fichaDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Silver;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.lançamentosToolStripMenuItem,
            this.produçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 6, 0, 10);
            this.menuStrip.Size = new System.Drawing.Size(1075, 44);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuariosToolStripMenuItem,
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroDeUsuariosToolStripMenuItem
            // 
            this.cadastroDeUsuariosToolStripMenuItem.Name = "cadastroDeUsuariosToolStripMenuItem";
            this.cadastroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(347, 28);
            this.cadastroDeUsuariosToolStripMenuItem.Text = "Cadastro de Usuarios";
            this.cadastroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuariosToolStripMenuItem_Click);
            // 
            // cadastrosDeTiposDeUsuariosToolStripMenuItem
            // 
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem.Name = "cadastrosDeTiposDeUsuariosToolStripMenuItem";
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(347, 28);
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem.Text = "Cadastros de Tipos de Usuarios";
            this.cadastrosDeTiposDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDeTiposDeUsuariosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroTipoDeProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroTipoDeProdutosToolStripMenuItem
            // 
            this.cadastroTipoDeProdutosToolStripMenuItem.Name = "cadastroTipoDeProdutosToolStripMenuItem";
            this.cadastroTipoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.cadastroTipoDeProdutosToolStripMenuItem.Text = "Cadastro Tipo de Produtos";
            this.cadastroTipoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroTipoDeProdutosToolStripMenuItem_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.custosDeProduçãoToolStripMenuItem,
            this.pedidoDeCompraToolStripMenuItem,
            this.pedidoDeVendaToolStripMenuItem,
            this.fichaDoProdutoToolStripMenuItem});
            this.lançamentosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            this.lançamentosToolStripMenuItem.Size = new System.Drawing.Size(135, 28);
            this.lançamentosToolStripMenuItem.Text = "Lançamentos";
            // 
            // custosDeProduçãoToolStripMenuItem
            // 
            this.custosDeProduçãoToolStripMenuItem.Name = "custosDeProduçãoToolStripMenuItem";
            this.custosDeProduçãoToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.custosDeProduçãoToolStripMenuItem.Text = "Custos de Produção";
            this.custosDeProduçãoToolStripMenuItem.Click += new System.EventHandler(this.custosDeProduçãoToolStripMenuItem_Click);
            // 
            // pedidoDeCompraToolStripMenuItem
            // 
            this.pedidoDeCompraToolStripMenuItem.Name = "pedidoDeCompraToolStripMenuItem";
            this.pedidoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.pedidoDeCompraToolStripMenuItem.Text = "Pedido de Compra";
            this.pedidoDeCompraToolStripMenuItem.Click += new System.EventHandler(this.pedidoDeCompraToolStripMenuItem_Click);
            // 
            // pedidoDeVendaToolStripMenuItem
            // 
            this.pedidoDeVendaToolStripMenuItem.Name = "pedidoDeVendaToolStripMenuItem";
            this.pedidoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.pedidoDeVendaToolStripMenuItem.Text = "Pedido de Venda";
            this.pedidoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoDeVendaToolStripMenuItem_Click);
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loteProducaoToolStripMenuItem,
            this.ordemProducaoToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.produçãoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.produçãoToolStripMenuItem.Text = "Produção";
            // 
            // loteProducaoToolStripMenuItem
            // 
            this.loteProducaoToolStripMenuItem.Name = "loteProducaoToolStripMenuItem";
            this.loteProducaoToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.loteProducaoToolStripMenuItem.Text = "Lote Produção";
            this.loteProducaoToolStripMenuItem.Click += new System.EventHandler(this.loteProducaoToolStripMenuItem_Click);
            // 
            // ordemProducaoToolStripMenuItem
            // 
            this.ordemProducaoToolStripMenuItem.Name = "ordemProducaoToolStripMenuItem";
            this.ordemProducaoToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.ordemProducaoToolStripMenuItem.Text = "Ordem Produção";
            this.ordemProducaoToolStripMenuItem.Click += new System.EventHandler(this.ordemProducaoToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itensDeEstoqqueToolStripMenuItem,
            this.fichaDeProdutoToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // itensDeEstoqqueToolStripMenuItem
            // 
            this.itensDeEstoqqueToolStripMenuItem.Name = "itensDeEstoqqueToolStripMenuItem";
            this.itensDeEstoqqueToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.itensDeEstoqqueToolStripMenuItem.Text = "Itens de Estoque";
            this.itensDeEstoqqueToolStripMenuItem.Click += new System.EventHandler(this.itensDeEstoqqueToolStripMenuItem_Click);
            // 
            // fichaDeProdutoToolStripMenuItem
            // 
            this.fichaDeProdutoToolStripMenuItem.Name = "fichaDeProdutoToolStripMenuItem";
            this.fichaDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.fichaDeProdutoToolStripMenuItem.Text = "Ficha de Produto";
            this.fichaDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.fichaDeProdutoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemDeRelatóriosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // listagemDeRelatóriosToolStripMenuItem
            // 
            this.listagemDeRelatóriosToolStripMenuItem.Name = "listagemDeRelatóriosToolStripMenuItem";
            this.listagemDeRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(270, 28);
            this.listagemDeRelatóriosToolStripMenuItem.Text = "Listagem de Relatórios";
            this.listagemDeRelatóriosToolStripMenuItem.Click += new System.EventHandler(this.listagemDeRelatóriosToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(273, 28);
            this.parametrosToolStripMenuItem.Text = "Parametros do Sistema";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 706);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1075, 24);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(47, 19);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // fichaDoProdutoToolStripMenuItem
            // 
            this.fichaDoProdutoToolStripMenuItem.Name = "fichaDoProdutoToolStripMenuItem";
            this.fichaDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(251, 28);
            this.fichaDoProdutoToolStripMenuItem.Text = "Ficha do Produto";
            this.fichaDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.fichaDoProdutoToolStripMenuItem_Click);
            // 
            // frmMainMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPCP.View.Properties.Resources.Sem_Título_1;
            this.ClientSize = new System.Drawing.Size(1075, 730);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMainMDI";
            this.Text = "SCPC - Sistema de Planejamento e Controle de Produção";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMDI_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem custosDeProduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeTiposDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loteProducaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemProducaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroTipoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensDeEstoqqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDeRelatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDoProdutoToolStripMenuItem;
    }
}



