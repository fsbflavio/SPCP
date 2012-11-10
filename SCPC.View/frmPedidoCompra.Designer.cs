namespace SPCP.View
{
    partial class frmPedidoCompra
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
            this.tabCadCliente = new System.Windows.Forms.TabControl();
            this.tabPesquisa = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.dgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDtPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatusPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPESQUISA = new System.Windows.Forms.TextBox();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabPesquisa);
            this.tabCadCliente.Controls.Add(this.tabCadastro);
            this.tabCadCliente.Location = new System.Drawing.Point(1, 1);
            this.tabCadCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.SelectedIndex = 0;
            this.tabCadCliente.Size = new System.Drawing.Size(1028, 375);
            this.tabCadCliente.TabIndex = 1;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.label6);
            this.tabPesquisa.Controls.Add(this.textBox1);
            this.tabPesquisa.Controls.Add(this.dgPesquisa);
            this.tabPesquisa.Controls.Add(this.label5);
            this.tabPesquisa.Controls.Add(this.label4);
            this.tabPesquisa.Controls.Add(this.button1);
            this.tabPesquisa.Controls.Add(this.label1);
            this.tabPesquisa.Controls.Add(this.txtPESQUISA);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 25);
            this.tabPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPesquisa.Size = new System.Drawing.Size(1020, 346);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Id Pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 58;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgId,
            this.dgFornecedor,
            this.dgDtPedido,
            this.dgStatusPedido,
            this.dgObs});
            this.dgPesquisa.Location = new System.Drawing.Point(4, 116);
            this.dgPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersVisible = false;
            this.dgPesquisa.RowTemplate.Height = 24;
            this.dgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa.Size = new System.Drawing.Size(1005, 224);
            this.dgPesquisa.TabIndex = 4;
            // 
            // dgId
            // 
            this.dgId.HeaderText = "Id";
            this.dgId.Name = "dgId";
            this.dgId.Width = 60;
            // 
            // dgFornecedor
            // 
            this.dgFornecedor.HeaderText = "Fornecedor";
            this.dgFornecedor.Name = "dgFornecedor";
            this.dgFornecedor.Width = 350;
            // 
            // dgDtPedido
            // 
            this.dgDtPedido.HeaderText = "Data Pedido";
            this.dgDtPedido.Name = "dgDtPedido";
            // 
            // dgStatusPedido
            // 
            this.dgStatusPedido.HeaderText = "Status Pedido";
            this.dgStatusPedido.Name = "dgStatusPedido";
            // 
            // dgObs
            // 
            this.dgObs.HeaderText = "Observações";
            this.dgObs.Name = "dgObs";
            this.dgObs.Width = 200;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1013, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Resultado";
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(909, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fornecedor";
            // 
            // txtPESQUISA
            // 
            this.txtPESQUISA.Location = new System.Drawing.Point(384, 49);
            this.txtPESQUISA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPESQUISA.Name = "txtPESQUISA";
            this.txtPESQUISA.Size = new System.Drawing.Size(491, 22);
            this.txtPESQUISA.TabIndex = 6;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.dataGridView1);
            this.tabCadastro.Controls.Add(this.groupBox5);
            this.tabCadastro.Controls.Add(this.label3);
            this.tabCadastro.Controls.Add(this.groupBox1);
            this.tabCadastro.Controls.Add(this.groupBox14);
            this.tabCadastro.Controls.Add(this.groupBox13);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastro.Size = new System.Drawing.Size(1020, 346);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgReg,
            this.dgItem,
            this.dgDescricao,
            this.dgQtd,
            this.dgUnit,
            this.dgTotal,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(4, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 161);
            this.dataGridView1.TabIndex = 69;
            // 
            // dgReg
            // 
            this.dgReg.HeaderText = "Reg";
            this.dgReg.Name = "dgReg";
            this.dgReg.Width = 50;
            // 
            // dgItem
            // 
            this.dgItem.HeaderText = "Id Item";
            this.dgItem.Name = "dgItem";
            this.dgItem.Width = 65;
            // 
            // dgDescricao
            // 
            this.dgDescricao.HeaderText = "Descrição";
            this.dgDescricao.Name = "dgDescricao";
            this.dgDescricao.Width = 250;
            // 
            // dgQtd
            // 
            this.dgQtd.HeaderText = "Qtd";
            this.dgQtd.Name = "dgQtd";
            this.dgQtd.Width = 50;
            // 
            // dgUnit
            // 
            this.dgUnit.HeaderText = "Unit R$";
            this.dgUnit.Name = "dgUnit";
            this.dgUnit.Width = 80;
            // 
            // dgTotal
            // 
            this.dgTotal.HeaderText = "Total R$";
            this.dgTotal.Name = "dgTotal";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(8, 32);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(176, 55);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Código";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(4, 22);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.MaxLength = 200;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.Tag = "Ato de Autorização do Curso";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1013, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Itens";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(292, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(717, 55);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(4, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(708, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.comboBox2);
            this.groupBox14.Location = new System.Drawing.Point(4, 95);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox14.Size = new System.Drawing.Size(280, 55);
            this.groupBox14.TabIndex = 65;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Status Pedido";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(271, 24);
            this.comboBox2.TabIndex = 57;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.comboBox1);
            this.groupBox13.Location = new System.Drawing.Point(192, 32);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(537, 55);
            this.groupBox13.TabIndex = 62;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Fornecedor";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(528, 24);
            this.comboBox1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1016, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Dados Gerais do Pedido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(420, 12);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnCancelar.Location = new System.Drawing.Point(723, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 27);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(600, 12);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(119, 27);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(293, 12);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 27);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Location = new System.Drawing.Point(160, 12);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(119, 27);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
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
            this.panel1.Location = new System.Drawing.Point(1, 379);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 54);
            this.panel1.TabIndex = 12;
            // 
            // frmPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCadCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido de Compra";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadCliente;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPESQUISA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatusPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgObs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}