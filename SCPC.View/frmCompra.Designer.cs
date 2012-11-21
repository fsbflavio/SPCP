namespace SPCP.View
{
    partial class frmCompra
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
            this.dgItens = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescricao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.dtPrevisao = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.grpCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.button2);
            this.grpCadastro.Controls.Add(this.label8);
            this.grpCadastro.Controls.Add(this.label7);
            this.grpCadastro.Controls.Add(this.label6);
            this.grpCadastro.Controls.Add(this.label2);
            this.grpCadastro.Controls.Add(this.groupBox2);
            this.grpCadastro.Controls.Add(this.dgItens);
            this.grpCadastro.Controls.Add(this.groupBox5);
            this.grpCadastro.Controls.Add(this.label3);
            this.grpCadastro.Controls.Add(this.groupBox1);
            this.grpCadastro.Controls.Add(this.groupBox14);
            this.grpCadastro.Controls.Add(this.groupBox13);
            // 
            // dgItens
            // 
            this.dgItens.AllowUserToDeleteRows = false;
            this.dgItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dgDescricao,
            this.ICMS,
            this.IPI,
            this.Qtd,
            this.Unit,
            this.Total,
            this.Obs});
            this.dgItens.Location = new System.Drawing.Point(8, 144);
            this.dgItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgItens.Name = "dgItens";
            this.dgItens.RowHeadersVisible = false;
            this.dgItens.RowTemplate.Height = 24;
            this.dgItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItens.Size = new System.Drawing.Size(1013, 160);
            this.dgItens.TabIndex = 75;
            this.dgItens.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 65;
            // 
            // dgDescricao
            // 
            this.dgDescricao.DataPropertyName = "IdItemDeEstoque";
            this.dgDescricao.HeaderText = "Descrição";
            this.dgDescricao.Name = "dgDescricao";
            this.dgDescricao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgDescricao.Width = 250;
            // 
            // ICMS
            // 
            this.ICMS.DataPropertyName = "ICMS";
            this.ICMS.HeaderText = "ICMS %";
            this.ICMS.Name = "ICMS";
            // 
            // IPI
            // 
            this.IPI.DataPropertyName = "IPI";
            this.IPI.HeaderText = "IPI %";
            this.IPI.Name = "IPI";
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "Qtd";
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.Width = 50;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "ValorUnitario";
            this.Unit.HeaderText = "Unit R$";
            this.Unit.Name = "Unit";
            this.Unit.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total R$";
            this.Total.Name = "Total";
            // 
            // Obs
            // 
            this.Obs.DataPropertyName = "Observacao";
            this.Obs.HeaderText = "Obs";
            this.Obs.Name = "Obs";
            this.Obs.Width = 255;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtCodigo);
            this.groupBox5.Location = new System.Drawing.Point(12, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(176, 48);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Location = new System.Drawing.Point(4, 19);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 200;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(168, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Tag = "Codigo";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1013, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Itens";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Location = new System.Drawing.Point(296, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(717, 48);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObs.Location = new System.Drawing.Point(4, 19);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.MaxLength = 200;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(709, 22);
            this.txtObs.TabIndex = 0;
            this.txtObs.Tag = "Observações";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cbxStatus);
            this.groupBox14.Location = new System.Drawing.Point(8, 61);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(280, 48);
            this.groupBox14.TabIndex = 72;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Status Pedido";
            // 
            // cbxStatus
            // 
            this.cbxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(4, 19);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(272, 24);
            this.cbxStatus.TabIndex = 57;
            this.cbxStatus.Tag = "Status";
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.cbxFornecedor);
            this.groupBox13.Location = new System.Drawing.Point(196, 16);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(537, 48);
            this.groupBox13.TabIndex = 70;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Fornecedor";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(4, 19);
            this.cbxFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(529, 24);
            this.cbxFornecedor.TabIndex = 56;
            this.cbxFornecedor.Tag = "Fornecedor";
            // 
            // dtPrevisao
            // 
            this.dtPrevisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrevisao.Location = new System.Drawing.Point(4, 19);
            this.dtPrevisao.Name = "dtPrevisao";
            this.dtPrevisao.Size = new System.Drawing.Size(152, 22);
            this.dtPrevisao.TabIndex = 76;
            this.dtPrevisao.Tag = "Previsão";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtPrevisao);
            this.groupBox2.Location = new System.Drawing.Point(741, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(160, 48);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Previsão de Chegada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Qtd. itens:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Valor total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(901, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "label8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(934, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 441);
            this.Name = "frmCompra";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgItens;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.DateTimePicker dtPrevisao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obs;
        private System.Windows.Forms.Button button2;
    }
}
