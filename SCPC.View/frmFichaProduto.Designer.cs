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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.grpCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.comboBox1);
            this.tabPesquisa.Controls.SetChildIndex(this.txtPESQUISA, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.button1, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.comboBox1, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label1, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label4, 0);
            this.tabPesquisa.Controls.SetChildIndex(this.label5, 0);
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.groupBox3);
            this.grpCadastro.Controls.Add(this.groupBox1);
            this.grpCadastro.Size = new System.Drawing.Size(733, 348);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(292, 18);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(594, 18);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(472, 18);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(165, 18);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(32, 18);
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(735, 25);
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(735, 25);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 24);
            this.comboBox1.TabIndex = 58;
            // 
            // frmFichaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(746, 441);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
