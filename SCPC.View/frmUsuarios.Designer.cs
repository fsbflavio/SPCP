namespace SPCP.View
{
    partial class frmUsuarios
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
            this.dgIdOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTpUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabCadCliente.SuspendLayout();
            this.tabPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabPesquisa);
            this.tabCadCliente.Controls.Add(this.tabCadastro);
            this.tabCadCliente.Location = new System.Drawing.Point(1, 5);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.SelectedIndex = 0;
            this.tabCadCliente.Size = new System.Drawing.Size(536, 296);
            this.tabCadCliente.TabIndex = 14;
            // 
            // tabPesquisa
            // 
            this.tabPesquisa.Controls.Add(this.label6);
            this.tabPesquisa.Controls.Add(this.textBox1);
            this.tabPesquisa.Controls.Add(this.dgPesquisa);
            this.tabPesquisa.Controls.Add(this.label4);
            this.tabPesquisa.Controls.Add(this.button1);
            this.tabPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tabPesquisa.Name = "tabPesquisa";
            this.tabPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPesquisa.Size = new System.Drawing.Size(528, 270);
            this.tabPesquisa.TabIndex = 0;
            this.tabPesquisa.Text = "Pesquisa";
            this.tabPesquisa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nome do Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 58;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdOp,
            this.dgNomeUsuario,
            this.dgTpUsuario});
            this.dgPesquisa.Location = new System.Drawing.Point(0, 65);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersVisible = false;
            this.dgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa.Size = new System.Drawing.Size(532, 210);
            this.dgPesquisa.TabIndex = 4;
            // 
            // dgIdOp
            // 
            this.dgIdOp.HeaderText = "Id";
            this.dgIdOp.Name = "dgIdOp";
            this.dgIdOp.Width = 60;
            // 
            // dgNomeUsuario
            // 
            this.dgNomeUsuario.HeaderText = "Nome do Usuário";
            this.dgNomeUsuario.Name = "dgNomeUsuario";
            this.dgNomeUsuario.Width = 265;
            // 
            // dgTpUsuario
            // 
            this.dgTpUsuario.HeaderText = "Tipo de Usuário";
            this.dgTpUsuario.Name = "dgTpUsuario";
            this.dgTpUsuario.Width = 200;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(760, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Pesquisa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(443, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.groupBox11);
            this.tabCadastro.Controls.Add(this.groupBox10);
            this.tabCadastro.Controls.Add(this.groupBox9);
            this.tabCadastro.Controls.Add(this.groupBox1);
            this.tabCadastro.Controls.Add(this.groupBox3);
            this.tabCadastro.Controls.Add(this.groupBox2);
            this.tabCadastro.Controls.Add(this.groupBox5);
            this.tabCadastro.Controls.Add(this.groupBox14);
            this.tabCadastro.Controls.Add(this.groupBox13);
            this.tabCadastro.Controls.Add(this.label2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(528, 270);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.textBox6);
            this.groupBox11.Location = new System.Drawing.Point(7, 170);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(231, 45);
            this.groupBox11.TabIndex = 65;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tipo Usuário";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(3, 16);
            this.textBox6.MaxLength = 200;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 20);
            this.textBox6.TabIndex = 0;
            this.textBox6.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.dateTimePicker5);
            this.groupBox10.Location = new System.Drawing.Point(125, 122);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(113, 45);
            this.groupBox10.TabIndex = 70;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Data Inicial";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker5.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker5.TabIndex = 69;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.dateTimePicker4);
            this.groupBox9.Location = new System.Drawing.Point(6, 122);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(113, 45);
            this.groupBox9.TabIndex = 65;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Inicial";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker4.TabIndex = 69;
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
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(7, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 45);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Senha";
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(3, 16);
            this.textBox4.MaxLength = 200;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(359, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Location = new System.Drawing.Point(6, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(366, 45);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nome";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 16);
            this.textBox3.MaxLength = 200;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(360, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Tag = "Ato de Autorização do Curso";
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
            this.groupBox13.Location = new System.Drawing.Point(119, 128);
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
            this.label2.Size = new System.Drawing.Size(529, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Dados Gerais do Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Location = new System.Drawing.Point(7, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 45);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Senha";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 16);
            this.textBox2.MaxLength = 200;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Location = new System.Drawing.Point(6, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(399, 45);
            this.groupBox6.TabIndex = 68;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nome";
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(3, 16);
            this.textBox5.MaxLength = 200;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(393, 20);
            this.textBox5.TabIndex = 1;
            this.textBox5.Tag = "Ato de Autorização do Curso";
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(538, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 45);
            this.groupBox7.TabIndex = 65;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Status Pedido";
            // 
            // comboBox4
            // 
            this.comboBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 16);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 21);
            this.comboBox4.TabIndex = 57;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Location = new System.Drawing.Point(119, 128);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(109, 45);
            this.groupBox8.TabIndex = 62;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Data Final";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(3, 16);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(529, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Dados Gerais do Pedido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 44);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(206, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(433, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 22);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(11, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 22);
            this.button4.TabIndex = 13;
            this.button4.Text = "Novo";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(341, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 22);
            this.button5.TabIndex = 15;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(111, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 22);
            this.button6.TabIndex = 14;
            this.button6.Text = "Editar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCadCliente);
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.tabCadCliente.ResumeLayout(false);
            this.tabPesquisa.ResumeLayout(false);
            this.tabPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadCliente;
        private System.Windows.Forms.TabPage tabPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTpUsuario;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}