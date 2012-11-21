using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SPCP.Controller;
using SPCP.Util; //remover?

namespace SPCP.View
{
    public partial class frmFichaProduto : SPCP.View.frmCadastroMain
    {
        ArrayList itensInsertUpdate = new ArrayList();
        ArrayList itensRemoved = new ArrayList();

        BindingSource bs = new BindingSource(); // necessario para exibir as atualização no grid;
        BindingSource pesquisa = new BindingSource();

        public frmFichaProduto()
        {
            InitializeComponent();
            bs.DataSource = itensInsertUpdate;
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                ProdutoControl produto = new ProdutoControl();
                FichaProdutoControl ficha = new FichaProdutoControl();

                ProdutoDTO produtoDTO = new ProdutoDTO();
                produtoDTO.Id = id;
                produtoDTO.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                produtoDTO.Descricao = this.txtNomeProduto.Text;

                if (ModoOperacao == "E")
                {
                    produto.Alterar(produtoDTO);
                    ficha.SalvaGrid(itensInsertUpdate, itensRemoved);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    produto.Incluir(produtoDTO);
                    ficha.SalvaGrid(itensInsertUpdate, itensRemoved);

                    ModoOperacao = "";
                    DesativaControles();


                    MessageBox.Show("O registro foi salvo com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }


                Pesquisar(dgPesquisa, this.txtPESQUISA.Text);
                SistemaEmEspera();
            }
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.txtCodigo))
                return false;
            if (!ValidaPreenchimento(this.txtNomeProduto))
                return false;

            decimal result;
            if (!decimal.TryParse(this.txtCodigo.Text, out result))
            {
                MessageBox.Show("Deve ser Informado um valor numérico no campo Código da Ficha", "Tipo de dado informado Invalido!");
                return false;
            }
            if (dgMateriais.Rows.Count <= 0) //grid não pode estar vazio
            {
                MessageBox.Show("A lista de composição do Produto esta vazia. Insira os materiais ", "Composição vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        public bool ValidaCamposCustos()
        {
            //valida inserção no grid
            if (!ValidaPreenchimento(this.cbxGrupo))
                return false;
            if (!ValidaPreenchimento(this.cbxItem))
                return false;
            if (!ValidaPreenchimento(this.txtQtd))
                return false;
            //verifica se é numérico
            decimal result;
            if (!decimal.TryParse(this.txtQtd.Text, out result))
            {
                MessageBox.Show("Deve ser Informado um valor numérico no campo Qtd");
                return false;
            }
            
            return true;
        }

        public override void Pesquisar(DataGridView dg, string nome)
        {
            ProdutoControl pControl = new ProdutoControl();
                
            pesquisa.DataSource = pControl.GetProdutosByNome(nome);
            dg.DataSource = pesquisa;

            if (pesquisa.Count <= 0) //trata o caso q a busca é vazia. evita q os cabeçalhos sumam.
            {
                return;
            }

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;

            //formata as colunas do datagrid
            dg.Columns["Id"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["Id"].Width = 78; //largura coluna
            dg.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Id"].ToolTipText = "Número do Registro";
            dg.Columns["Id"].DefaultCellStyle.Format = "0000000";
            dg.Columns["Id"].Visible = true;

            dg.Columns["Codigo"].HeaderText = "Código"; //Nome coluna
            dg.Columns["Codigo"].Width = 100; //largura coluna
            dg.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Codigo"].ToolTipText = "Codigo do Produto";
            dg.Columns["Codigo"].Visible = true;

            dg.Columns["Descricao"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["Descricao"].Width = 845; //largura coluna
            dg.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Descricao"].ToolTipText = "Descrição do Produto";
            dg.Columns["Descricao"].Visible = true;

            dg.Refresh();
        }

        public void ConfiguraDataGrid(DataGridView dg, BindingSource bs)
        {
            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = bs;

            //formata as colunas do datagrid
            dg.Columns["Id"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["Id"].Width = 78; //largura coluna
            dg.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Id"].ToolTipText = "Número do Registro";
            dg.Columns["Id"].DefaultCellStyle.Format = "0000000";
            dg.Columns["Id"].Visible = true;

            dg.Columns["Item"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["Item"].Width = 400; //largura coluna
            dg.Columns["Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Item"].ToolTipText = "Descrição Item";
            dg.Columns["Item"].Visible = true;

            //dg.Columns["Produto"].HeaderText = "Produto"; //Nome coluna
            //dg.Columns["Produto"].Width = 845; //largura coluna
            //dg.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //dg.Columns["Produto"].ToolTipText = "Produto";
            //dg.Columns["Produto"].Visible = false;

            dg.Columns["Qtd"].HeaderText = "QTD"; //Nome coluna
            dg.Columns["Qtd"].Width = 80; //largura coluna
            dg.Columns["Qtd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Qtd"].ToolTipText = "Quantidade";
            dg.Columns["Qtd"].Visible = true;

            dg.Columns["Observacao"].HeaderText = "Observações"; //Nome coluna
            dg.Columns["Observacao"].Width = 465; //largura coluna
            dg.Columns["Observacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Observacao"].ToolTipText = "Observações";
            dg.Columns["Observacao"].Visible = true;

            dg.Refresh();

        }

        public override void LimpaCampos()
        {
            base.LimpaCampos();
            dgMateriais.Rows.Clear();
        }

        public void CarregaDataGridCustos(DataGridView dg, int id)
        {
            FichaProdutoControl ficha = new FichaProdutoControl();

            itensInsertUpdate = ficha.GetFicha(id);
            bs.DataSource = itensInsertUpdate;

            if (bs.Count > 0) //trata o caso q a busca é vazia. evita q os cabeçalhos sumam.
            {
                ConfiguraDataGrid(dgMateriais, bs);
            }

            return;
        }

        public override void CarregaDadosControles(int id)
        {
            ProdutoControl produto = new ProdutoControl();
            ProdutoDTO p = produto.GetProduto(id);
            
            try
            {
                this.id = p.Id;
                this.txtCodigo.Text = p.Codigo.ToString();
                this.txtNomeProduto.Text = p.Descricao.ToString();

                CarregaDataGridCustos(dgMateriais, id); // Carrega os materiais de um produto no grid
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar dados do Produto: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void InicializarComboBoxes()
        {
            try
            {
                this.cbxGrupo.DataSource = ComboBoxSistema.gruposItemEstoque();
                this.cbxGrupo.ValueMember = "id";
                this.cbxGrupo.DisplayMember = "descricao";
                this.cbxGrupo.SelectedIndex = -1;

                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar ComboBoxes: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public override void AtivaControles()
        {
            this.grpCadastro.Enabled = true;
            this.tabPesquisa.Enabled = false;
            this.tabCustos.Enabled = true;
        }

        public override void DesativaControles()
        {
            this.tabPesquisa.Enabled = true;
            this.grpCadastro.Enabled = false;
            this.tabCustos.Enabled = false;

        }

        public override void Excluir(int id)
        {
            bool excluido;

            try
            {
                //verifica se existe um registro em estado de edição
                if (ModoOperacao == "E")
                {
                    MessageBox.Show("Atenção, uma transação de atualização de registro " +
                        "não foi finalizada. Se você executou alterações no registro em " +
                        "edição, salve-as, por favor. Se desejar cancelar as atualizações, " +
                        "clique no botão correspondente do formulário.",
                        "Edição de registro em andamento",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ModoOperacao == "N")
                {
                    MessageBox.Show("Atenção, uma transação de criação de registro " +
                        "não foi finalizada. Se esta inserindo um novo registro " +
                        "salve-o, por favor. Se desejar cancelar a inserção, " +
                        "clique no botão correspondente do formulário.",
                        "Edição de registro em andamento",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (id == 0)
                {
                    MessageBox.Show("Atenção, não há um registro selecionado em vídeo " +
                        "para exclusão. Verifique, por favor!", "Transação Inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //inicia procedimento de exclusão do registro corrente
                DialogResult i;
                i = MessageBox.Show("Atenção, o seguinte registro será permanentemente " +
                    "excluído do sistema:" + "\r\n" + "\r\n" +
                    "Registro nº : " + id.ToString() + "\r\n" +
                    "Descrição : " + this.txtNomeProduto.Text.ToUpper() + "\r\n" +
                        "\r\n" +
                    "Confirma a exclusão do registro corrente?", "Exclusão de Registros",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (i)
                {
                    case (DialogResult.No):
                        MessageBox.Show("A exclusão do registro corrente foi cancelada " +
                            "pelo usuário!", "Exclusão Cancelada", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                }

                FichaProdutoControl f = new FichaProdutoControl();
                foreach (FichaProdutoDTO dto in bs)
                {
                    f.Excluir(dto);
                }

                ProdutoControl p = new ProdutoControl();
                excluido = p.Excluir(id);

                if (excluido)
                {
                    LimpaCampos();
                    SistemaEmEspera();
                    pesquisa.RemoveCurrent();
                    bs.Clear();
                    //Pesquisar(dgPesquisa, txtPESQUISA.Text);

                    MessageBox.Show("O registro foi excluído com sucesso!", "Exclusão " +
                        "de registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Atenção, o registro não pôde ser excluído!. " +
                        "Repita a operação. Se o problema persistir, entre em contato " +
                        "com o suporte.", "Problema na exclusão do registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bttnAddDgCursos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCamposCustos())
                {
                    FichaProdutoDTO p = new FichaProdutoDTO();
                    p.Item = (ItemEstoqueDTO)cbxItem.SelectedItem;
                    p.Produto.Id = this.id;
                    p.Qtd = Convert.ToInt32(txtQtd.Text);
                    p.Observacao = txtObservacoes.Text;

                    bs.Add(p);
                    //itensInsertUpdate.Add(p);
                    ConfiguraDataGrid(dgMateriais, bs);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao inserir composição no grid. Verifique se as informações inseridas são validas e tente novamente", "Falha ao adicionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttnExcluirDgCursos_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)// trata o caso q o grid esta vazio
            {
                itensRemoved.Add(bs.Current);

                bs.Remove(bs.Current);
                dgMateriais.DataSource = bs;
            }
        }

        private void cbxGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindingSource filtro = new BindingSource();
            ArrayList a = ComboBoxSistema.ItensEstoque();

            foreach (ItemEstoqueDTO i in a)
            {
                if (i.IdGrupoItemEstoque == (cbxGrupo.SelectedItem as ComboBoxItem).id)
                    filtro.Add(i);
            }

            if (filtro.Count > 0)
            {
                this.cbxItem.DataSource = filtro;
                this.cbxItem.ValueMember = "Id";
                this.cbxItem.DisplayMember = "Descricao";
                this.cbxItem.SelectedIndex = -1;
            }
        }
    }
}
