namespace SPCP.View
{
    partial class frmItemEstoqueold
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
            this.tabControlItemEstoque = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPESQUISA = new System.Windows.Forms.TextBox();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.groupBoxUnidadeMedida = new System.Windows.Forms.GroupBox();
            this.comboBoxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.groupBoxEstoqueMinimo = new System.Windows.Forms.GroupBox();
            this.textBoxEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.groupBoxGrupoEstoque = new System.Windows.Forms.GroupBox();
            this.comboBoxGrupoEstoque = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxCodigo = new System.Windows.Forms.GroupBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBoxDescricao = new System.Windows.Forms.GroupBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControlItemEstoque.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.groupBoxUnidadeMedida.SuspendLayout();
            this.groupBoxEstoqueMinimo.SuspendLayout();
            this.groupBoxGrupoEstoque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxCodigo.SuspendLayout();
            this.groupBoxDescricao.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlItemEstoque
            // 
            this.tabControlItemEstoque.Controls.Add(this.tabPesquisa);
            this.tabControlItemEstoque.Controls.Add(this.tabCadastro);
            this.tabControlItemEstoque.Location = new System.Drawing.Point(0, 0);
            this.tabControlItemEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlItemEstoque.Name = "tabControlItemEstoque";
            this.tabControlItemEstoque.SelectedIndex = 0;
            this.tabControlItemEstoque.Size = new System.Drawing.Size(715, 370);
            this.tabControlItemEstoque.TabIndex = 19;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.label6);
            this.tabPesquisa.Controls.Add(this.txtPESQUISA);
            this.tabPesquisa.Controls.Add(this.dgPesquisa);
            this.tabPesquisa.Controls.Add(this.label4);
            this.tabPesquisa.Controls.Add(this.btnPesquisar);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tabPesquisa.Size = new System.Drawing.Size(707, 341);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Parametro de Busca";
            // 
            // txtPESQUISA
            // 
            this.txtPESQUISA.Location = new System.Drawing.Point(243, 37);
            this.txtPESQUISA.Margin = new System.Windows.Forms.Padding(4);
            this.txtPESQUISA.Name = "txtPESQUISA";
            this.txtPESQUISA.Size = new System.Drawing.Size(289, 22);
            this.txtPESQUISA.TabIndex = 58;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(0, 80);
            this.dgPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.ReadOnly = true;
            this.dgPesquisa.RowHeadersVisible = false;
            this.dgPesquisa.RowTemplate.Height = 24;
            this.dgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa.Size = new System.Drawing.Size(703, 258);
            this.dgPesquisa.TabIndex = 4;
            this.dgPesquisa.Click += new System.EventHandler(this.dgPesquisa_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1013, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pesquisa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Location = new System.Drawing.Point(572, 34);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 28);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.groupBoxUnidadeMedida);
            this.tabCadastro.Controls.Add(this.groupBoxEstoqueMinimo);
            this.tabCadastro.Controls.Add(this.groupBoxGrupoEstoque);
            this.tabCadastro.Controls.Add(this.groupBox1);
            this.tabCadastro.Controls.Add(this.groupBox3);
            this.tabCadastro.Controls.Add(this.groupBoxCodigo);
            this.tabCadastro.Controls.Add(this.groupBoxDescricao);
            this.tabCadastro.Controls.Add(this.groupBox14);
            this.tabCadastro.Controls.Add(this.groupBox13);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Size = new System.Drawing.Size(707, 341);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBoxUnidadeMedida
            // 
            this.groupBoxUnidadeMedida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUnidadeMedida.Controls.Add(this.comboBoxUnidadeMedida);
            this.groupBoxUnidadeMedida.Location = new System.Drawing.Point(4, 279);
            this.groupBoxUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUnidadeMedida.Name = "groupBoxUnidadeMedida";
            this.groupBoxUnidadeMedida.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUnidadeMedida.Size = new System.Drawing.Size(289, 55);
            this.groupBoxUnidadeMedida.TabIndex = 70;
            this.groupBoxUnidadeMedida.TabStop = false;
            this.groupBoxUnidadeMedida.Text = "Unidade de Medida";
            // 
            // comboBoxUnidadeMedida
            // 
            this.comboBoxUnidadeMedida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnidadeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeMedida.Location = new System.Drawing.Point(4, 19);
            this.comboBoxUnidadeMedida.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUnidadeMedida.Name = "comboBoxUnidadeMedida";
            this.comboBoxUnidadeMedida.Size = new System.Drawing.Size(281, 24);
            this.comboBoxUnidadeMedida.TabIndex = 0;
            // 
            // groupBoxEstoqueMinimo
            // 
            this.groupBoxEstoqueMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEstoqueMinimo.Controls.Add(this.textBoxEstoqueMinimo);
            this.groupBoxEstoqueMinimo.Location = new System.Drawing.Point(4, 220);
            this.groupBoxEstoqueMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEstoqueMinimo.Name = "groupBoxEstoqueMinimo";
            this.groupBoxEstoqueMinimo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEstoqueMinimo.Size = new System.Drawing.Size(155, 55);
            this.groupBoxEstoqueMinimo.TabIndex = 69;
            this.groupBoxEstoqueMinimo.TabStop = false;
            this.groupBoxEstoqueMinimo.Text = "Estoque Mínimo";
            // 
            // textBoxEstoqueMinimo
            // 
            this.textBoxEstoqueMinimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEstoqueMinimo.Location = new System.Drawing.Point(4, 19);
            this.textBoxEstoqueMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEstoqueMinimo.MaxLength = 200;
            this.textBoxEstoqueMinimo.Name = "textBoxEstoqueMinimo";
            this.textBoxEstoqueMinimo.Size = new System.Drawing.Size(147, 22);
            this.textBoxEstoqueMinimo.TabIndex = 1;
            this.textBoxEstoqueMinimo.Tag = "Ato de Autorização do Curso";
            // 
            // groupBoxGrupoEstoque
            // 
            this.groupBoxGrupoEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGrupoEstoque.Controls.Add(this.comboBoxGrupoEstoque);
            this.groupBoxGrupoEstoque.Location = new System.Drawing.Point(4, 95);
            this.groupBoxGrupoEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGrupoEstoque.Name = "groupBoxGrupoEstoque";
            this.groupBoxGrupoEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGrupoEstoque.Size = new System.Drawing.Size(568, 55);
            this.groupBoxGrupoEstoque.TabIndex = 69;
            this.groupBoxGrupoEstoque.TabStop = false;
            this.groupBoxGrupoEstoque.Text = Mensagens.LabelGrupoItemEstoque;
            // 
            // comboBoxGrupoEstoque
            // 
            this.comboBoxGrupoEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxGrupoEstoque.FormattingEnabled = true;
            this.comboBoxGrupoEstoque.Location = new System.Drawing.Point(4, 19);
            this.comboBoxGrupoEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGrupoEstoque.Name = "comboBoxGrupoEstoque";
            this.comboBoxGrupoEstoque.Size = new System.Drawing.Size(560, 24);
            this.comboBoxGrupoEstoque.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(9, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(0, 55);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Inicial";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(4, 19);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(0, 22);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(308, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(0, 55);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 19);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(0, 25);
            this.comboBox1.TabIndex = 69;
            // 
            // groupBoxCodigo
            // 
            this.groupBoxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCodigo.Controls.Add(this.textBoxCodigo);
            this.groupBoxCodigo.Location = new System.Drawing.Point(4, 32);
            this.groupBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCodigo.Name = "groupBoxCodigo";
            this.groupBoxCodigo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCodigo.Size = new System.Drawing.Size(124, 55);
            this.groupBoxCodigo.TabIndex = 64;
            this.groupBoxCodigo.TabStop = false;
            this.groupBoxCodigo.Text = "Código";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCodigo.Location = new System.Drawing.Point(4, 19);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.MaxLength = 200;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(116, 22);
            this.textBoxCodigo.TabIndex = 0;
            this.textBoxCodigo.Tag = "Ato de Autorização do Curso";
            // 
            // groupBoxDescricao
            // 
            this.groupBoxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescricao.Controls.Add(this.textBoxDescricao);
            this.groupBoxDescricao.Location = new System.Drawing.Point(4, 158);
            this.groupBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDescricao.Name = "groupBoxDescricao";
            this.groupBoxDescricao.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDescricao.Size = new System.Drawing.Size(568, 55);
            this.groupBoxDescricao.TabIndex = 68;
            this.groupBoxDescricao.TabStop = false;
            this.groupBoxDescricao.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescricao.Location = new System.Drawing.Point(4, 19);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricao.MaxLength = 200;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(560, 22);
            this.textBoxDescricao.TabIndex = 1;
            this.textBoxDescricao.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.comboBox2);
            this.groupBox14.Location = new System.Drawing.Point(717, 32);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(280, 55);
            this.groupBox14.TabIndex = 65;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Status Pedido";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 19);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 24);
            this.comboBox2.TabIndex = 57;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.dateTimePicker1);
            this.groupBox13.Location = new System.Drawing.Point(159, 158);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(0, 55);
            this.groupBox13.TabIndex = 62;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Data Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Dados Gerais Item";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 54);
            this.panel1.TabIndex = 20;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(275, 10);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(119, 27);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(577, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 27);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Location = new System.Drawing.Point(15, 10);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(119, 27);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(455, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 27);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(148, 10);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 27);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmItemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlItemEstoque);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmItemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens de Estoques";
            this.Load += new System.EventHandler(this.frmItemEstoque_Load);
            this.tabControlItemEstoque.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.groupBoxUnidadeMedida.ResumeLayout(false);
            this.groupBoxEstoqueMinimo.ResumeLayout(false);
            this.groupBoxEstoqueMinimo.PerformLayout();
            this.groupBoxGrupoEstoque.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxCodigo.ResumeLayout(false);
            this.groupBoxCodigo.PerformLayout();
            this.groupBoxDescricao.ResumeLayout(false);
            this.groupBoxDescricao.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlItemEstoque;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPESQUISA;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.GroupBox groupBoxDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBoxUnidadeMedida;
        private System.Windows.Forms.ComboBox comboBoxUnidadeMedida;
        private System.Windows.Forms.GroupBox groupBoxEstoqueMinimo;
        private System.Windows.Forms.TextBox textBoxEstoqueMinimo;
        private System.Windows.Forms.GroupBox groupBoxGrupoEstoque;
        private System.Windows.Forms.ComboBox comboBoxGrupoEstoque;
    }
}