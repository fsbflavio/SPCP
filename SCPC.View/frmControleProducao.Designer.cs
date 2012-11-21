namespace SPCP.View
{
    partial class frmControleProducao
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
            this.tabOutrosGastos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabTributos = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.bttnExcluirDgCursos = new System.Windows.Forms.Button();
            this.bttnAddDgCursos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.grpCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabOutrosGastos.SuspendLayout();
            this.tabTributos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabOutrosGastos);
            this.tabCadCliente.Controls.Add(this.tabTributos);
            this.tabCadCliente.Controls.SetChildIndex(this.tabTributos, 0);
            this.tabCadCliente.Controls.SetChildIndex(this.tabOutrosGastos, 0);
            this.tabCadCliente.Controls.SetChildIndex(this.tabCadastro, 0);
            this.tabCadCliente.Controls.SetChildIndex(this.tabPesquisa, 0);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Text = "Mão de Obra";
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.groupBox7);
            this.grpCadastro.Controls.Add(this.groupBox6);
            this.grpCadastro.Controls.Add(this.groupBox5);
            this.grpCadastro.Controls.Add(this.bttnExcluirDgCursos);
            this.grpCadastro.Controls.Add(this.bttnAddDgCursos);
            this.grpCadastro.Controls.Add(this.groupBox4);
            this.grpCadastro.Controls.Add(this.groupBox3);
            this.grpCadastro.Controls.Add(this.dataGridView1);
            this.grpCadastro.Text = "Mão de Obra";
            // 
            // tabOutrosGastos
            // 
            this.tabOutrosGastos.Controls.Add(this.groupBox1);
            this.tabOutrosGastos.Location = new System.Drawing.Point(4, 25);
            this.tabOutrosGastos.Name = "tabOutrosGastos";
            this.tabOutrosGastos.Size = new System.Drawing.Size(1037, 348);
            this.tabOutrosGastos.TabIndex = 2;
            this.tabOutrosGastos.Text = "Outros Gastos";
            this.tabOutrosGastos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outros Gastos";
            // 
            // tabTributos
            // 
            this.tabTributos.Controls.Add(this.groupBox2);
            this.tabTributos.Location = new System.Drawing.Point(4, 25);
            this.tabTributos.Name = "tabTributos";
            this.tabTributos.Size = new System.Drawing.Size(1037, 348);
            this.tabTributos.TabIndex = 3;
            this.tabTributos.Text = "Tributos";
            this.tabTributos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tributos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxProduto);
            this.groupBox5.Location = new System.Drawing.Point(512, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(174, 48);
            this.groupBox5.TabIndex = 69;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produto";
            // 
            // cbxProduto
            // 
            this.cbxProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(3, 18);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(168, 24);
            this.cbxProduto.TabIndex = 61;
            // 
            // bttnExcluirDgCursos
            // 
            this.bttnExcluirDgCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnExcluirDgCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExcluirDgCursos.ForeColor = System.Drawing.Color.Transparent;
            this.bttnExcluirDgCursos.Image = global::SPCP.View.Properties.Resources.delete_48x48;
            this.bttnExcluirDgCursos.Location = new System.Drawing.Point(975, 30);
            this.bttnExcluirDgCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnExcluirDgCursos.Name = "bttnExcluirDgCursos";
            this.bttnExcluirDgCursos.Size = new System.Drawing.Size(49, 43);
            this.bttnExcluirDgCursos.TabIndex = 68;
            this.bttnExcluirDgCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttnExcluirDgCursos.UseVisualStyleBackColor = true;
            // 
            // bttnAddDgCursos
            // 
            this.bttnAddDgCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnAddDgCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddDgCursos.ForeColor = System.Drawing.Color.Transparent;
            this.bttnAddDgCursos.Image = global::SPCP.View.Properties.Resources.camera_test;
            this.bttnAddDgCursos.Location = new System.Drawing.Point(920, 26);
            this.bttnAddDgCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAddDgCursos.Name = "bttnAddDgCursos";
            this.bttnAddDgCursos.Size = new System.Drawing.Size(59, 51);
            this.bttnAddDgCursos.TabIndex = 67;
            this.bttnAddDgCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttnAddDgCursos.UseVisualStyleBackColor = true;
            this.bttnAddDgCursos.Click += new System.EventHandler(this.bttnAddDgCursos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxServico);
            this.groupBox4.Location = new System.Drawing.Point(252, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 48);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviço";
            // 
            // cbxServico
            // 
            this.cbxServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Location = new System.Drawing.Point(3, 18);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(251, 24);
            this.cbxServico.TabIndex = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxFornecedor);
            this.groupBox3.Location = new System.Drawing.Point(5, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 48);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fornecedor / Colaborador";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(3, 18);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(238, 24);
            this.cbxFornecedor.TabIndex = 60;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtInicio);
            this.groupBox6.Location = new System.Drawing.Point(689, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(115, 48);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Inicio";
            // 
            // dtInicio
            // 
            this.dtInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtInicio.Location = new System.Drawing.Point(3, 18);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(109, 22);
            this.dtInicio.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtTermino);
            this.groupBox7.Location = new System.Drawing.Point(807, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 48);
            this.groupBox7.TabIndex = 71;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Termino";
            // 
            // dtTermino
            // 
            this.dtTermino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTermino.Location = new System.Drawing.Point(3, 18);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(109, 22);
            this.dtTermino.TabIndex = 0;
            // 
            // frmControleProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 441);
            this.Name = "frmControleProducao";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.grpCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabOutrosGastos.ResumeLayout(false);
            this.tabTributos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabOutrosGastos;
        private System.Windows.Forms.TabPage tabTributos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Button bttnExcluirDgCursos;
        private System.Windows.Forms.Button bttnAddDgCursos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxFornecedor;
    }
}
