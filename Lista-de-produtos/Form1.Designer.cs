namespace Lista_de_produtos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Mangueira",
            "2",
            "30"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxProduto = new System.Windows.Forms.TextBox();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.btnObter = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listID,
            this.listProduto,
            this.listQuantidade,
            this.listPreco});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(89, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 264);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "PREÇO";
            // 
            // txtBoxId
            // 
            this.txtBoxId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxId.Location = new System.Drawing.Point(131, 355);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(66, 22);
            this.txtBoxId.TabIndex = 5;
            // 
            // txtBoxProduto
            // 
            this.txtBoxProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxProduto.Location = new System.Drawing.Point(198, 396);
            this.txtBoxProduto.Name = "txtBoxProduto";
            this.txtBoxProduto.Size = new System.Drawing.Size(94, 22);
            this.txtBoxProduto.TabIndex = 6;
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxQuantidade.Location = new System.Drawing.Point(227, 443);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(113, 22);
            this.txtBoxQuantidade.TabIndex = 7;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPreco.Location = new System.Drawing.Point(171, 486);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(93, 22);
            this.txtBoxPreco.TabIndex = 8;
            // 
            // btnObter
            // 
            this.btnObter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnObter.FlatAppearance.BorderSize = 2;
            this.btnObter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObter.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObter.ForeColor = System.Drawing.Color.Blue;
            this.btnObter.Location = new System.Drawing.Point(566, 480);
            this.btnObter.Name = "btnObter";
            this.btnObter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnObter.Size = new System.Drawing.Size(116, 42);
            this.btnObter.TabIndex = 9;
            this.btnObter.Text = "OBTER";
            this.btnObter.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.Location = new System.Drawing.Point(566, 417);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRemover.Size = new System.Drawing.Size(116, 42);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAdicionar.FlatAppearance.BorderSize = 2;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Lime;
            this.btnAdicionar.Location = new System.Drawing.Point(566, 355);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdicionar.Size = new System.Drawing.Size(116, 42);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listID
            // 
            this.listID.Text = "ID";
            // 
            // listProduto
            // 
            this.listProduto.Text = "Produto";
            this.listProduto.Width = 300;
            // 
            // listQuantidade
            // 
            this.listQuantidade.Text = "Quantidade";
            this.listQuantidade.Width = 127;
            // 
            // listPreco
            // 
            this.listPreco.Text = "Preço";
            this.listPreco.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.txtBoxQuantidade);
            this.Controls.Add(this.txtBoxProduto);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader listID;
        private System.Windows.Forms.ColumnHeader listProduto;
        private System.Windows.Forms.ColumnHeader listQuantidade;
        private System.Windows.Forms.ColumnHeader listPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxProduto;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

