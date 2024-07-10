namespace ControleBar.WinApp.Pedido
{
    partial class TabelaPedidoControl
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
            gridPedido = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridPedido).BeginInit();
            SuspendLayout();
            // 
            // gridPedido
            // 
            gridPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPedido.Location = new Point(-1, 0);
            gridPedido.Name = "gridPedido";
            gridPedido.Size = new Size(805, 457);
            gridPedido.TabIndex = 0;
            // 
            // TabelaPedidoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridPedido);
            Name = "TabelaPedidoControl";
            Text = "TabelaPedidoControl";
            ((System.ComponentModel.ISupportInitialize)gridPedido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPedido;
    }
}