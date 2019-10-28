namespace apBiblioteca.UI
{
    partial class FrmLeitor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.txtTelefoneLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.bD19040DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD19040DataSet = new apBiblioteca.BD19040DataSet();
            this.leitorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoLeitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD19040DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD19040DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 328);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.txtEnderecoLeitor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnProcurar);
            this.tabPage1.Controls.Add(this.txtEmailLeitor);
            this.tabPage1.Controls.Add(this.txtTelefoneLeitor);
            this.tabPage1.Controls.Add(this.txtNomeLeitor);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(394, 116);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(153, 194);
            this.txtEnderecoLeitor.MaxLength = 20;
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(298, 20);
            this.txtEnderecoLeitor.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Endereco:";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(423, 249);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(299, 249);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(169, 249);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(47, 249);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(423, 36);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 8;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Location = new System.Drawing.Point(153, 156);
            this.txtEmailLeitor.MaxLength = 50;
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.Size = new System.Drawing.Size(194, 20);
            this.txtEmailLeitor.TabIndex = 7;
            // 
            // txtTelefoneLeitor
            // 
            this.txtTelefoneLeitor.Location = new System.Drawing.Point(153, 119);
            this.txtTelefoneLeitor.MaxLength = 20;
            this.txtTelefoneLeitor.Name = "txtTelefoneLeitor";
            this.txtTelefoneLeitor.Size = new System.Drawing.Size(112, 20);
            this.txtTelefoneLeitor.TabIndex = 6;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(153, 78);
            this.txtNomeLeitor.MaxLength = 50;
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(298, 20);
            this.txtNomeLeitor.TabIndex = 5;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(153, 36);
            this.txtIdLeitor.MaxLength = 4;
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(50, 20);
            this.txtIdLeitor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificação:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLeitor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.AutoGenerateColumns = false;
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLeitorDataGridViewTextBoxColumn,
            this.nomeLeitorDataGridViewTextBoxColumn,
            this.telefoneLeitorDataGridViewTextBoxColumn,
            this.emailLeitorDataGridViewTextBoxColumn,
            this.enderecoLeitorDataGridViewTextBoxColumn});
            this.dgvLeitor.DataSource = this.leitorBindingSource1;
            this.dgvLeitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeitor.Location = new System.Drawing.Point(3, 3);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.RowHeadersVisible = false;
            this.dgvLeitor.Size = new System.Drawing.Size(536, 296);
            this.dgvLeitor.TabIndex = 0;
            // 
            // bD19040DataSetBindingSource
            // 
            this.bD19040DataSetBindingSource.DataSource = this.bD19040DataSet;
            this.bD19040DataSetBindingSource.Position = 0;
            // 
            // bD19040DataSet
            // 
            this.bD19040DataSet.DataSetName = "BD19040DataSet";
            this.bD19040DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leitorBindingSource1
            // 
            this.leitorBindingSource1.DataSource = typeof(apBiblioteca.Leitor);
            // 
            // leitorBindingSource
            // 
            this.leitorBindingSource.DataSource = typeof(apBiblioteca.Leitor);
            // 
            // idLeitorDataGridViewTextBoxColumn
            // 
            this.idLeitorDataGridViewTextBoxColumn.DataPropertyName = "IdLeitor";
            this.idLeitorDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idLeitorDataGridViewTextBoxColumn.Name = "idLeitorDataGridViewTextBoxColumn";
            this.idLeitorDataGridViewTextBoxColumn.Width = 30;
            // 
            // nomeLeitorDataGridViewTextBoxColumn
            // 
            this.nomeLeitorDataGridViewTextBoxColumn.DataPropertyName = "NomeLeitor";
            this.nomeLeitorDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeLeitorDataGridViewTextBoxColumn.Name = "nomeLeitorDataGridViewTextBoxColumn";
            this.nomeLeitorDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneLeitorDataGridViewTextBoxColumn
            // 
            this.telefoneLeitorDataGridViewTextBoxColumn.DataPropertyName = "TelefoneLeitor";
            this.telefoneLeitorDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneLeitorDataGridViewTextBoxColumn.Name = "telefoneLeitorDataGridViewTextBoxColumn";
            // 
            // emailLeitorDataGridViewTextBoxColumn
            // 
            this.emailLeitorDataGridViewTextBoxColumn.DataPropertyName = "EmailLeitor";
            this.emailLeitorDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailLeitorDataGridViewTextBoxColumn.Name = "emailLeitorDataGridViewTextBoxColumn";
            this.emailLeitorDataGridViewTextBoxColumn.Width = 130;
            // 
            // enderecoLeitorDataGridViewTextBoxColumn
            // 
            this.enderecoLeitorDataGridViewTextBoxColumn.DataPropertyName = "EnderecoLeitor";
            this.enderecoLeitorDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoLeitorDataGridViewTextBoxColumn.Name = "enderecoLeitorDataGridViewTextBoxColumn";
            this.enderecoLeitorDataGridViewTextBoxColumn.Width = 110;
            // 
            // FrmLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmLeitor";
            this.Text = "Manutenção de Leitores";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD19040DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD19040DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leitorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.TextBox txtTelefoneLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLeitor;
        private System.Windows.Forms.BindingSource leitorBindingSource;
        private System.Windows.Forms.BindingSource bD19040DataSetBindingSource;
        private BD19040DataSet bD19040DataSet;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.BindingSource leitorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailLeitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoLeitorDataGridViewTextBoxColumn;
    }
}