namespace apBiblioteca.UI
{
    partial class FrmOperacoes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefoneLeitor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLivros = new System.Windows.Forms.ComboBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.txtDevolucao = new System.Windows.Forms.TextBox();
            this.tpDevolucao = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAutorLivroDev = new System.Windows.Forms.TextBox();
            this.txtTituloLivroDev = new System.Windows.Forms.TextBox();
            this.txtCodLivroDev = new System.Windows.Forms.TextBox();
            this.txtIdLivroDev = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnListarLeitores = new System.Windows.Forms.Button();
            this.btnListarLivros = new System.Windows.Forms.Button();
            this.lsbLeitores = new System.Windows.Forms.ListBox();
            this.lsbLivros = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDevolucao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbLeitores);
            this.groupBox1.Controls.Add(this.btnListarLeitores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.txtEnderecoLeitor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailLeitor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefoneLeitor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeLeitor);
            this.groupBox1.Controls.Add(this.txtIdLeitor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Identificação:";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(208, 51);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 27);
            this.btnProcurar.TabIndex = 24;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(22, 290);
            this.txtEnderecoLeitor.MaxLength = 20;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.ReadOnly = true;
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(261, 20);
            this.txtEnderecoLeitor.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Endereco:";
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Location = new System.Drawing.Point(23, 228);
            this.txtEmailLeitor.MaxLength = 50;
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.ReadOnly = true;
            this.txtEmailLeitor.Size = new System.Drawing.Size(194, 20);
            this.txtEmailLeitor.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefone:";
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(22, 167);
            this.txtTelefoneLeitor.MaxLength = 20;
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.ReadOnly = true;
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(112, 20);
            this.txtTelefoneLeitor.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email:";
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(22, 111);
            this.txtNomeLeitor.MaxLength = 50;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.ReadOnly = true;
            this.txtNomeLeitor.Size = new System.Drawing.Size(261, 20);
            this.txtNomeLeitor.TabIndex = 21;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(22, 53);
            this.txtIdLeitor.MaxLength = 4;
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(69, 20);
            this.txtIdLeitor.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbLivros);
            this.groupBox2.Controls.Add(this.btnListarLivros);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtAutorLivro);
            this.groupBox2.Controls.Add(this.txtTituloLivro);
            this.groupBox2.Controls.Add(this.txtCodigoLivro);
            this.groupBox2.Controls.Add(this.txtIdLivro);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 177);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Livro";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Procurar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Location = new System.Drawing.Point(96, 141);
            this.txtAutorLivro.MaxLength = 50;
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.ReadOnly = true;
            this.txtAutorLivro.Size = new System.Drawing.Size(207, 20);
            this.txtAutorLivro.TabIndex = 21;
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(96, 104);
            this.txtTituloLivro.MaxLength = 50;
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.ReadOnly = true;
            this.txtTituloLivro.Size = new System.Drawing.Size(261, 20);
            this.txtTituloLivro.TabIndex = 20;
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(96, 66);
            this.txtCodigoLivro.MaxLength = 6;
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.ReadOnly = true;
            this.txtCodigoLivro.Size = new System.Drawing.Size(69, 20);
            this.txtCodigoLivro.TabIndex = 19;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(96, 26);
            this.txtIdLivro.MaxLength = 4;
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(50, 20);
            this.txtIdLivro.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Autor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Título:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Identificação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Data - Devolução: ";
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Location = new System.Drawing.Point(9, 260);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(116, 34);
            this.btnEmprestimo.TabIndex = 1;
            this.btnEmprestimo.Text = "Realizar Emprestimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Data - Hoje: ";
            // 
            // cbLivros
            // 
            this.cbLivros.FormattingEnabled = true;
            this.cbLivros.Location = new System.Drawing.Point(18, 15);
            this.cbLivros.Name = "cbLivros";
            this.cbLivros.Size = new System.Drawing.Size(196, 21);
            this.cbLivros.TabIndex = 4;
            this.cbLivros.Text = "Livros pendentes";
            this.cbLivros.SelectedIndexChanged += new System.EventHandler(this.cbLivros_SelectedIndexChanged);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Location = new System.Drawing.Point(236, 60);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(128, 49);
            this.btnDevolucao.TabIndex = 1;
            this.btnDevolucao.Text = "Realizar Devolução";
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpDevolucao);
            this.tabControl1.Location = new System.Drawing.Point(322, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 329);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEmprestimo);
            this.tabPage1.Controls.Add(this.txtDevolucao);
            this.tabPage1.Controls.Add(this.btnEmprestimo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empréstimo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(116, 199);
            this.txtEmprestimo.MaxLength = 10;
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.ReadOnly = true;
            this.txtEmprestimo.Size = new System.Drawing.Size(116, 20);
            this.txtEmprestimo.TabIndex = 7;
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Location = new System.Drawing.Point(175, 230);
            this.txtDevolucao.MaxLength = 10;
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.ReadOnly = true;
            this.txtDevolucao.Size = new System.Drawing.Size(116, 20);
            this.txtDevolucao.TabIndex = 5;
            // 
            // tpDevolucao
            // 
            this.tpDevolucao.Controls.Add(this.btnListar);
            this.tpDevolucao.Controls.Add(this.groupBox3);
            this.tpDevolucao.Controls.Add(this.btnDevolucao);
            this.tpDevolucao.Controls.Add(this.cbLivros);
            this.tpDevolucao.Location = new System.Drawing.Point(4, 22);
            this.tpDevolucao.Name = "tpDevolucao";
            this.tpDevolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolucao.Size = new System.Drawing.Size(381, 303);
            this.tpDevolucao.TabIndex = 1;
            this.tpDevolucao.Text = "Devolução";
            this.tpDevolucao.UseVisualStyleBackColor = true;
            this.tpDevolucao.Enter += new System.EventHandler(this.tpDevolucao_Enter);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(235, 15);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(129, 21);
            this.btnListar.TabIndex = 27;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAutorLivroDev);
            this.groupBox3.Controls.Add(this.txtTituloLivroDev);
            this.groupBox3.Controls.Add(this.txtCodLivroDev);
            this.groupBox3.Controls.Add(this.txtIdLivroDev);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(7, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 177);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Livro";
            // 
            // txtAutorLivroDev
            // 
            this.txtAutorLivroDev.Location = new System.Drawing.Point(96, 141);
            this.txtAutorLivroDev.MaxLength = 50;
            this.txtAutorLivroDev.Name = "txtAutorLivroDev";
            this.txtAutorLivroDev.ReadOnly = true;
            this.txtAutorLivroDev.Size = new System.Drawing.Size(207, 20);
            this.txtAutorLivroDev.TabIndex = 21;
            // 
            // txtTituloLivroDev
            // 
            this.txtTituloLivroDev.Location = new System.Drawing.Point(96, 104);
            this.txtTituloLivroDev.MaxLength = 50;
            this.txtTituloLivroDev.Name = "txtTituloLivroDev";
            this.txtTituloLivroDev.ReadOnly = true;
            this.txtTituloLivroDev.Size = new System.Drawing.Size(261, 20);
            this.txtTituloLivroDev.TabIndex = 20;
            // 
            // txtCodLivroDev
            // 
            this.txtCodLivroDev.Location = new System.Drawing.Point(96, 66);
            this.txtCodLivroDev.MaxLength = 6;
            this.txtCodLivroDev.Name = "txtCodLivroDev";
            this.txtCodLivroDev.ReadOnly = true;
            this.txtCodLivroDev.Size = new System.Drawing.Size(69, 20);
            this.txtCodLivroDev.TabIndex = 19;
            // 
            // txtIdLivroDev
            // 
            this.txtIdLivroDev.Location = new System.Drawing.Point(96, 26);
            this.txtIdLivroDev.MaxLength = 4;
            this.txtIdLivroDev.Name = "txtIdLivroDev";
            this.txtIdLivroDev.ReadOnly = true;
            this.txtIdLivroDev.Size = new System.Drawing.Size(50, 20);
            this.txtIdLivroDev.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Autor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Título:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Código:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Identificação:";
            // 
            // btnListarLeitores
            // 
            this.btnListarLeitores.Location = new System.Drawing.Point(127, 51);
            this.btnListarLeitores.Name = "btnListarLeitores";
            this.btnListarLeitores.Size = new System.Drawing.Size(75, 27);
            this.btnListarLeitores.TabIndex = 27;
            this.btnListarLeitores.Text = "Listar";
            this.btnListarLeitores.UseVisualStyleBackColor = true;
            this.btnListarLeitores.Click += new System.EventHandler(this.btnListarLeitores_Click);
            // 
            // btnListarLivros
            // 
            this.btnListarLivros.Location = new System.Drawing.Point(201, 26);
            this.btnListarLivros.Name = "btnListarLivros";
            this.btnListarLivros.Size = new System.Drawing.Size(75, 23);
            this.btnListarLivros.TabIndex = 28;
            this.btnListarLivros.Text = "Listar";
            this.btnListarLivros.UseVisualStyleBackColor = true;
            this.btnListarLivros.Click += new System.EventHandler(this.btnListarLivros_Click);
            // 
            // lsbLeitores
            // 
            this.lsbLeitores.FormattingEnabled = true;
            this.lsbLeitores.Location = new System.Drawing.Point(22, 22);
            this.lsbLeitores.Name = "lsbLeitores";
            this.lsbLeitores.Size = new System.Drawing.Size(261, 290);
            this.lsbLeitores.TabIndex = 28;
            this.lsbLeitores.Visible = false;
            this.lsbLeitores.SelectedIndexChanged += new System.EventHandler(this.lsbLeitores_SelectedIndexChanged);
            // 
            // lsbLivros
            // 
            this.lsbLivros.FormattingEnabled = true;
            this.lsbLivros.Location = new System.Drawing.Point(22, 27);
            this.lsbLivros.Name = "lsbLivros";
            this.lsbLivros.Size = new System.Drawing.Size(335, 134);
            this.lsbLivros.TabIndex = 29;
            this.lsbLivros.Visible = false;
            this.lsbLivros.SelectedIndexChanged += new System.EventHandler(this.lsbLivros_SelectedIndexChanged);
            // 
            // FrmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOperacoes";
            this.Text = "FrmOperacoes";
            this.Load += new System.EventHandler(this.FrmOperacoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpDevolucao.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.TextBox txtTelefoneLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.TextBox txtTituloLivro;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLivros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpDevolucao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAutorLivroDev;
        private System.Windows.Forms.TextBox txtTituloLivroDev;
        private System.Windows.Forms.TextBox txtCodLivroDev;
        private System.Windows.Forms.TextBox txtIdLivroDev;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.TextBox txtDevolucao;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lsbLeitores;
        private System.Windows.Forms.Button btnListarLeitores;
        private System.Windows.Forms.Button btnListarLivros;
        private System.Windows.Forms.ListBox lsbLivros;
    }
}