namespace Consumindo_WebAPI_Produtos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            this.btnObterProdutos = new System.Windows.Forms.Button();
            this.btnProdutosPorId = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnAtualizaProduto = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label - URI - Web API:";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(136, 5);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(639, 20);
            this.txtURI.TabIndex = 1;
            this.txtURI.Text = "http://localhost:59575/api/Produto";
            // 
            // gdvDados
            // 
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(16, 46);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.Size = new System.Drawing.Size(759, 353);
            this.gdvDados.TabIndex = 2;
            // 
            // btnObterProdutos
            // 
            this.btnObterProdutos.ForeColor = System.Drawing.Color.Black;
            this.btnObterProdutos.Location = new System.Drawing.Point(16, 405);
            this.btnObterProdutos.Name = "btnObterProdutos";
            this.btnObterProdutos.Size = new System.Drawing.Size(113, 23);
            this.btnObterProdutos.TabIndex = 3;
            this.btnObterProdutos.Text = "Retornar produtos";
            this.btnObterProdutos.UseVisualStyleBackColor = true;
            this.btnObterProdutos.Click += new System.EventHandler(this.btnObterProdutos_Click);
            // 
            // btnProdutosPorId
            // 
            this.btnProdutosPorId.Location = new System.Drawing.Point(136, 405);
            this.btnProdutosPorId.Name = "btnProdutosPorId";
            this.btnProdutosPorId.Size = new System.Drawing.Size(113, 23);
            this.btnProdutosPorId.TabIndex = 4;
            this.btnProdutosPorId.Text = "Obter produto por ID";
            this.btnProdutosPorId.UseVisualStyleBackColor = true;
            this.btnProdutosPorId.Click += new System.EventHandler(this.btnProdutosPorId_Click);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(256, 405);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(113, 23);
            this.btnIncluirProduto.TabIndex = 5;
            this.btnIncluirProduto.Text = "Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            // 
            // btnAtualizaProduto
            // 
            this.btnAtualizaProduto.Location = new System.Drawing.Point(375, 405);
            this.btnAtualizaProduto.Name = "btnAtualizaProduto";
            this.btnAtualizaProduto.Size = new System.Drawing.Size(113, 23);
            this.btnAtualizaProduto.TabIndex = 6;
            this.btnAtualizaProduto.Text = "Atualizar produto";
            this.btnAtualizaProduto.UseVisualStyleBackColor = true;
            this.btnAtualizaProduto.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(494, 405);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(113, 23);
            this.btnDeletarProduto.TabIndex = 7;
            this.btnDeletarProduto.Text = "Deletar produto";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 467);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizaProduto);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.btnProdutosPorId);
            this.Controls.Add(this.btnObterProdutos);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView gdvDados;
        private System.Windows.Forms.Button btnObterProdutos;
        private System.Windows.Forms.Button btnProdutosPorId;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnAtualizaProduto;
        private System.Windows.Forms.Button btnDeletarProduto;
    }
}

