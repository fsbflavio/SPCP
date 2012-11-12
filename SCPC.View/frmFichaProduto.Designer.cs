namespace SPCP.View
{
    partial class frmFichaProduto
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.tabCustos = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnExcluirDgCursos = new System.Windows.Forms.Button();
            this.bttnAddDgCursos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgMateriais = new System.Windows.Forms.DataGridView();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.grpCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabCustos.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriais)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabCustos);
            this.tabCadCliente.Size = new System.Drawing.Size(1042, 377);
            this.tabCadCliente.Controls.SetChildIndex(this.tabCustos, 0);
            this.tabCadCliente.Controls.SetChildIndex(this.tabCadastro, 0);
            this.tabCadCliente.Controls.SetChildIndex(this.tabPesquisa, 0);
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.cbxProduto);
            this.tabPesquisa.Size = new System.Drawing.Size(1034, 348);
            this.tabPesquisa.Controls.SetChildIndex(this.txtPESQUISA, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.button1, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.cbxProduto, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label1, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label4, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label5, 0);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Size = new System.Drawing.Size(1034, 348);
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.groupBox3);
            this.grpCadastro.Controls.Add(this.groupBox1);
            this.grpCadastro.Size = new System.Drawing.Size(733, 348);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(418, 21);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(720, 21);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(598, 21);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(291, 21);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(158, 21);
            // 
            // label5
            // 
            this.label5.Text = "Produto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 47);
            this.button1.Visible = false;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.Text = "Nome Produto";
            // 
            // txtPESQUISA
            // 
            this.txtPESQUISA.Location = new System.Drawing.Point(580, 55);
            this.txtPESQUISA.Size = new System.Drawing.Size(32, 22);
            this.txtPESQUISA.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Location = new System.Drawing.Point(3, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(3, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código Ficha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNomeProduto);
            this.groupBox3.Location = new System.Drawing.Point(4, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeProduto.Location = new System.Drawing.Point(3, 18);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(483, 22);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(142, 51);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(309, 24);
            this.cbxProduto.TabIndex = 58;
            this.cbxProduto.SelectionChangeCommitted += new System.EventHandler(this.cbxProduto_SelectionChangeCommitted);
            // 
            // tabCustos
            // 
            this.tabCustos.Controls.Add(this.groupBox6);
            this.tabCustos.Controls.Add(this.groupBox5);
            this.tabCustos.Controls.Add(this.bttnExcluirDgCursos);
            this.tabCustos.Controls.Add(this.bttnAddDgCursos);
            this.tabCustos.Controls.Add(this.groupBox4);
            this.tabCustos.Controls.Add(this.groupBox2);
            this.tabCustos.Controls.Add(this.label2);
            this.tabCustos.Controls.Add(this.dgMateriais);
            this.tabCustos.Location = new System.Drawing.Point(4, 25);
            this.tabCustos.Name = "tabCustos";
            this.tabCustos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustos.Size = new System.Drawing.Size(1034, 348);
            this.tabCustos.TabIndex = 2;
            this.tabCustos.Text = "Custos";
            this.tabCustos.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Location = new System.Drawing.Point(617, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 48);
            this.groupBox6.TabIndex = 64;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Observações";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 22);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(547, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(67, 48);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Qtd";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 0;
            // 
            // bttnExcluirDgCursos
            // 
            this.bttnExcluirDgCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnExcluirDgCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExcluirDgCursos.ForeColor = System.Drawing.Color.Transparent;
            this.bttnExcluirDgCursos.Image = global::SPCP.View.Properties.Resources.delete_48x48;
            this.bttnExcluirDgCursos.Location = new System.Drawing.Point(978, 39);
            this.bttnExcluirDgCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnExcluirDgCursos.Name = "bttnExcluirDgCursos";
            this.bttnExcluirDgCursos.Size = new System.Drawing.Size(49, 43);
            this.bttnExcluirDgCursos.TabIndex = 62;
            this.bttnExcluirDgCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttnExcluirDgCursos.UseVisualStyleBackColor = true;
            // 
            // bttnAddDgCursos
            // 
            this.bttnAddDgCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnAddDgCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddDgCursos.ForeColor = System.Drawing.Color.Transparent;
            this.bttnAddDgCursos.Image = global::SPCP.View.Properties.Resources.camera_test;
            this.bttnAddDgCursos.Location = new System.Drawing.Point(913, 31);
            this.bttnAddDgCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnAddDgCursos.Name = "bttnAddDgCursos";
            this.bttnAddDgCursos.Size = new System.Drawing.Size(59, 51);
            this.bttnAddDgCursos.TabIndex = 61;
            this.bttnAddDgCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttnAddDgCursos.UseVisualStyleBackColor = true;
            this.bttnAddDgCursos.Click += new System.EventHandler(this.bttnAddDgCursos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxItem);
            this.groupBox4.Location = new System.Drawing.Point(276, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 48);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Item";
            // 
            // cbxItem
            // 
            this.cbxItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(3, 18);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(262, 24);
            this.cbxItem.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxGrupo);
            this.groupBox2.Location = new System.Drawing.Point(8, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 48);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(3, 18);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(259, 24);
            this.cbxGrupo.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1027, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Materiais Diretos, Indiretos, Secundários";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgMateriais
            // 
            this.dgMateriais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMateriais.Location = new System.Drawing.Point(4, 87);
            this.dgMateriais.Name = "dgMateriais";
            this.dgMateriais.RowTemplate.Height = 24;
            this.dgMateriais.Size = new System.Drawing.Size(1023, 255);
            this.dgMateriais.TabIndex = 0;
            // 
            // frmFichaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1045, 441);
            this.Name = "frmFichaProduto";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.grpCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCustos.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMateriais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TabPage tabCustos;
        private System.Windows.Forms.DataGridView dgMateriais;
        private System.Windows.Forms.Button bttnExcluirDgCursos;
        private System.Windows.Forms.Button bttnAddDgCursos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxGrupo;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox2;
    }
}
