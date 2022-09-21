﻿namespace AppForm.Formularios.Produto
{
  partial class Produto_Frm
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
      this.Nome_Label = new System.Windows.Forms.Label();
      this.Nome_TxtBox = new System.Windows.Forms.TextBox();
      this.Preco_Label = new System.Windows.Forms.Label();
      this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
      this.Estoque_Label = new System.Windows.Forms.Label();
      this.Estoque_Txt_Box = new System.Windows.Forms.TextBox();
      this.Unidade_CmbBox = new System.Windows.Forms.ComboBox();
      this.Unidade_Label = new System.Windows.Forms.Label();
      this.CadastrarUnidade_Btn = new System.Windows.Forms.Button();
      this.Categorias_Label = new System.Windows.Forms.Label();
      this.Categorias_ChkListBox = new System.Windows.Forms.CheckedListBox();
      this.CadastrarCategoria_Btn = new System.Windows.Forms.Button();
      this.SalvarProduto_Btn = new System.Windows.Forms.Button();
      this.CancelarProduto_Btn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Nome_Label
      // 
      this.Nome_Label.AutoSize = true;
      this.Nome_Label.Location = new System.Drawing.Point(8, 6);
      this.Nome_Label.Name = "Nome_Label";
      this.Nome_Label.Size = new System.Drawing.Size(43, 15);
      this.Nome_Label.TabIndex = 0;
      this.Nome_Label.Text = "Nome:";
      // 
      // Nome_TxtBox
      // 
      this.Nome_TxtBox.Location = new System.Drawing.Point(8, 24);
      this.Nome_TxtBox.Name = "Nome_TxtBox";
      this.Nome_TxtBox.Size = new System.Drawing.Size(432, 23);
      this.Nome_TxtBox.TabIndex = 1;
      // 
      // Preco_Label
      // 
      this.Preco_Label.AutoSize = true;
      this.Preco_Label.Location = new System.Drawing.Point(446, 6);
      this.Preco_Label.Name = "Preco_Label";
      this.Preco_Label.Size = new System.Drawing.Size(40, 15);
      this.Preco_Label.TabIndex = 2;
      this.Preco_Label.Text = "Preco:";
      // 
      // maskedTextBox1
      // 
      this.maskedTextBox1.Location = new System.Drawing.Point(446, 24);
      this.maskedTextBox1.Mask = "$ 0000.00";
      this.maskedTextBox1.Name = "maskedTextBox1";
      this.maskedTextBox1.Size = new System.Drawing.Size(96, 23);
      this.maskedTextBox1.TabIndex = 3;
      // 
      // Estoque_Label
      // 
      this.Estoque_Label.AutoSize = true;
      this.Estoque_Label.Location = new System.Drawing.Point(8, 50);
      this.Estoque_Label.Name = "Estoque_Label";
      this.Estoque_Label.Size = new System.Drawing.Size(86, 15);
      this.Estoque_Label.TabIndex = 4;
      this.Estoque_Label.Text = "Estoque Inicial:";
      // 
      // Estoque_Txt_Box
      // 
      this.Estoque_Txt_Box.Location = new System.Drawing.Point(8, 68);
      this.Estoque_Txt_Box.Name = "Estoque_Txt_Box";
      this.Estoque_Txt_Box.Size = new System.Drawing.Size(100, 23);
      this.Estoque_Txt_Box.TabIndex = 5;
      // 
      // Unidade_CmbBox
      // 
      this.Unidade_CmbBox.FormattingEnabled = true;
      this.Unidade_CmbBox.Items.AddRange(new object[] {
            "Caixa",
            "Sachê",
            "Pacote",
            "Fardo",
            "Item"});
      this.Unidade_CmbBox.Location = new System.Drawing.Point(114, 68);
      this.Unidade_CmbBox.Name = "Unidade_CmbBox";
      this.Unidade_CmbBox.Size = new System.Drawing.Size(326, 23);
      this.Unidade_CmbBox.TabIndex = 6;
      // 
      // Unidade_Label
      // 
      this.Unidade_Label.AutoSize = true;
      this.Unidade_Label.Location = new System.Drawing.Point(114, 50);
      this.Unidade_Label.Name = "Unidade_Label";
      this.Unidade_Label.Size = new System.Drawing.Size(54, 15);
      this.Unidade_Label.TabIndex = 7;
      this.Unidade_Label.Text = "Unidade:";
      // 
      // CadastrarUnidade_Btn
      // 
      this.CadastrarUnidade_Btn.Location = new System.Drawing.Point(446, 66);
      this.CadastrarUnidade_Btn.Name = "CadastrarUnidade_Btn";
      this.CadastrarUnidade_Btn.Size = new System.Drawing.Size(96, 24);
      this.CadastrarUnidade_Btn.TabIndex = 8;
      this.CadastrarUnidade_Btn.Text = "Cadastrar Un.";
      this.CadastrarUnidade_Btn.UseVisualStyleBackColor = true;
      this.CadastrarUnidade_Btn.Click += new System.EventHandler(this.CadastrarUnidade_Btn_Click);
      // 
      // Categorias_Label
      // 
      this.Categorias_Label.AutoSize = true;
      this.Categorias_Label.Location = new System.Drawing.Point(8, 94);
      this.Categorias_Label.Name = "Categorias_Label";
      this.Categorias_Label.Size = new System.Drawing.Size(66, 15);
      this.Categorias_Label.TabIndex = 9;
      this.Categorias_Label.Text = "Categorias:";
      // 
      // Categorias_ChkListBox
      // 
      this.Categorias_ChkListBox.FormattingEnabled = true;
      this.Categorias_ChkListBox.Items.AddRange(new object[] {
            "Limpeza",
            "Alimentação",
            "Cozinha",
            "Vestuário",
            "Eletrônicos"});
      this.Categorias_ChkListBox.Location = new System.Drawing.Point(8, 112);
      this.Categorias_ChkListBox.Name = "Categorias_ChkListBox";
      this.Categorias_ChkListBox.Size = new System.Drawing.Size(534, 76);
      this.Categorias_ChkListBox.TabIndex = 11;
      // 
      // CadastrarCategoria_Btn
      // 
      this.CadastrarCategoria_Btn.Location = new System.Drawing.Point(8, 194);
      this.CadastrarCategoria_Btn.Name = "CadastrarCategoria_Btn";
      this.CadastrarCategoria_Btn.Size = new System.Drawing.Size(135, 23);
      this.CadastrarCategoria_Btn.TabIndex = 12;
      this.CadastrarCategoria_Btn.Text = "Cadastrar Categoria";
      this.CadastrarCategoria_Btn.UseVisualStyleBackColor = true;
      this.CadastrarCategoria_Btn.Click += new System.EventHandler(this.CadastrarCategoria_Btn_Click);
      // 
      // SalvarProduto_Btn
      // 
      this.SalvarProduto_Btn.Location = new System.Drawing.Point(446, 194);
      this.SalvarProduto_Btn.Name = "SalvarProduto_Btn";
      this.SalvarProduto_Btn.Size = new System.Drawing.Size(96, 23);
      this.SalvarProduto_Btn.TabIndex = 14;
      this.SalvarProduto_Btn.Text = "Salvar";
      this.SalvarProduto_Btn.UseVisualStyleBackColor = true;
      this.SalvarProduto_Btn.Click += new System.EventHandler(this.SalvarProduto_Btn_Click);
      // 
      // CancelarProduto_Btn
      // 
      this.CancelarProduto_Btn.Location = new System.Drawing.Point(344, 194);
      this.CancelarProduto_Btn.Name = "CancelarProduto_Btn";
      this.CancelarProduto_Btn.Size = new System.Drawing.Size(96, 23);
      this.CancelarProduto_Btn.TabIndex = 15;
      this.CancelarProduto_Btn.Text = "Cancelar";
      this.CancelarProduto_Btn.UseVisualStyleBackColor = true;
      this.CancelarProduto_Btn.Click += new System.EventHandler(this.CancelarProduto_Btn_Click);
      // 
      // Produto_Frm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(549, 227);
      this.Controls.Add(this.CancelarProduto_Btn);
      this.Controls.Add(this.SalvarProduto_Btn);
      this.Controls.Add(this.CadastrarCategoria_Btn);
      this.Controls.Add(this.Categorias_Label);
      this.Controls.Add(this.Categorias_ChkListBox);
      this.Controls.Add(this.CadastrarUnidade_Btn);
      this.Controls.Add(this.Unidade_Label);
      this.Controls.Add(this.Unidade_CmbBox);
      this.Controls.Add(this.Estoque_Txt_Box);
      this.Controls.Add(this.Estoque_Label);
      this.Controls.Add(this.maskedTextBox1);
      this.Controls.Add(this.Nome_Label);
      this.Controls.Add(this.Nome_TxtBox);
      this.Controls.Add(this.Preco_Label);
      this.MaximizeBox = false;
      this.Name = "Produto_Frm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Cadastro de Produto";
      this.Load += new System.EventHandler(this.Produto_Frm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Label Nome_Label;
        private TextBox Nome_TxtBox;
        private Label Preco_Label;
        private MaskedTextBox maskedTextBox1;
        private Label Estoque_Label;
        private TextBox Estoque_Txt_Box;
        private ComboBox Unidade_CmbBox;
        private Label Unidade_Label;
        private Button CadastrarUnidade_Btn;
        private Label Categorias_Label;
        private CheckedListBox Categorias_ChkListBox;
        private Button CadastrarCategoria_Btn;
        private Button SalvarProduto_Btn;
        private Button CancelarProduto_Btn;
    }
}