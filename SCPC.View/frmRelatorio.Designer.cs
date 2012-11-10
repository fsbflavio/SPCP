namespace SPCP.View
{
    partial class frmRelatorio
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
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.dgIdOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescGrupoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabPesquisa);
            this.tabCadCliente.Controls.Add(this.tabCadastro);
            this.tabCadCliente.Location = new System.Drawing.Point(3, 1);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.SelectedIndex = 0;
            this.tabCadCliente.Size = new System.Drawing.Size(518, 522);
            this.tabCadCliente.TabIndex = 20;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.dgPesquisa);
            this.tabPesquisa.Controls.Add(this.label4);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(510, 496);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdOp,
            this.dgDescGrupoItem});
            this.dgPesquisa.Location = new System.Drawing.Point(0, 26);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersVisible = false;
            this.dgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa.Size = new System.Drawing.Size(507, 467);
            this.dgPesquisa.TabIndex = 4;
            // 
            // dgIdOp
            // 
            this.dgIdOp.HeaderText = "Id";
            this.dgIdOp.Name = "dgIdOp";
            this.dgIdOp.Width = 60;
            // 
            // dgDescGrupoItem
            // 
            this.dgDescGrupoItem.HeaderText = "Descrição";
            this.dgDescGrupoItem.Name = "dgDescGrupoItem";
            this.dgDescGrupoItem.Width = 460;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Relatórios Disponiveis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.groupBox5);
            this.tabCadastro.Controls.Add(this.groupBox4);
            this.tabCadastro.Controls.Add(this.monthCalendar1);
            this.tabCadastro.Controls.Add(this.groupBox7);
            this.tabCadastro.Controls.Add(this.groupBox1);
            this.tabCadastro.Controls.Add(this.groupBox3);
            this.tabCadastro.Controls.Add(this.groupBox2);
            this.tabCadastro.Controls.Add(this.groupBox14);
            this.tabCadastro.Controls.Add(this.groupBox13);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(510, 496);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Parametros";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.comboBox5);
            this.groupBox5.Location = new System.Drawing.Point(266, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(233, 45);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Produto";
            // 
            // comboBox5
            // 
            this.comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Mt2"});
            this.comboBox5.Location = new System.Drawing.Point(3, 16);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(227, 21);
            this.comboBox5.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Location = new System.Drawing.Point(266, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 45);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordem de Produção";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Mt2"});
            this.comboBox3.Location = new System.Drawing.Point(3, 16);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(227, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 72;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.comboBox4);
            this.groupBox7.Location = new System.Drawing.Point(266, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 45);
            this.groupBox7.TabIndex = 70;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lote de Produção";
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Mt2"});
            this.comboBox4.Location = new System.Drawing.Point(3, 16);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(230, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(7, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 45);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Inicial";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(231, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(0, 45);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(0, 21);
            this.comboBox1.TabIndex = 69;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(266, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 45);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "à";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 16);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "Ato de Autorização do Curso";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 16);
            this.textBox4.MaxLength = 200;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.comboBox2);
            this.groupBox14.Location = new System.Drawing.Point(538, 26);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(210, 45);
            this.groupBox14.TabIndex = 65;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Status Pedido";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 21);
            this.comboBox2.TabIndex = 57;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.dateTimePicker1);
            this.groupBox13.Location = new System.Drawing.Point(300, 262);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(0, 45);
            this.groupBox13.TabIndex = 62;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Data Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(0, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Parametros de Filtro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 522);
            this.Controls.Add(this.tabCadCliente);
            this.MaximizeBox = false;
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Relatórios";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadCliente;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescGrupoItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}