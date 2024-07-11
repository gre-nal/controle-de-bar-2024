namespace ControleBar.WinApp.ModuloConta
{
    partial class TelaPedidoForm
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
            label1 = new Label();
            label2 = new Label();
            cmbProdutos = new ComboBox();
            NumQuantidade = new NumericUpDown();
            label3 = new Label();
            ListaPedidos = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 21);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantidade:";
            // 
            // cmbProdutos
            // 
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(85, 18);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(121, 23);
            cmbProdutos.TabIndex = 1;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Location = new Point(338, 17);
            NumQuantidade.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(52, 23);
            NumQuantidade.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 59);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Pedidos:";
            // 
            // ListaPedidos
            // 
            ListaPedidos.FormattingEnabled = true;
            ListaPedidos.ItemHeight = 15;
            ListaPedidos.Location = new Point(26, 77);
            ListaPedidos.Name = "ListaPedidos";
            ListaPedidos.Size = new Size(364, 169);
            ListaPedidos.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(234, 51);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(315, 51);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(26, 252);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 42);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnGravar_Click;
            // 
            // TelaPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 306);
            Controls.Add(btnOK);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(ListaPedidos);
            Controls.Add(label3);
            Controls.Add(NumQuantidade);
            Controls.Add(cmbProdutos);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPedidoForm";
            ShowIcon = false;
            Text = "Cadastro de Pedidos";
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbProdutos;
        private NumericUpDown NumQuantidade;
        private Label label3;
        private ListBox ListaPedidos;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnCancelar;
        private Button btnOK;
    }
}