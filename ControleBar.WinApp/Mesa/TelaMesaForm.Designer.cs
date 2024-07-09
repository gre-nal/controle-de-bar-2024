namespace ControleBar.WinApp.Mesa
{
    partial class TelaMesaForm
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
            IdMesa = new Label();
            numeroMesa = new Label();
            txtBoxIdMesa = new TextBox();
            txtBNumeroMesa = new TextBox();
            lblCadastroMesa = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // IdMesa
            // 
            IdMesa.AutoSize = true;
            IdMesa.Location = new Point(85, 83);
            IdMesa.Name = "IdMesa";
            IdMesa.Size = new Size(22, 20);
            IdMesa.TabIndex = 0;
            IdMesa.Text = "Id";
            // 
            // numeroMesa
            // 
            numeroMesa.AutoSize = true;
            numeroMesa.Location = new Point(41, 118);
            numeroMesa.Name = "numeroMesa";
            numeroMesa.Size = new Size(66, 20);
            numeroMesa.TabIndex = 1;
            numeroMesa.Text = "Número:";
            // 
            // txtBoxIdMesa
            // 
            txtBoxIdMesa.Location = new Point(113, 83);
            txtBoxIdMesa.Name = "txtBoxIdMesa";
            txtBoxIdMesa.Size = new Size(100, 27);
            txtBoxIdMesa.TabIndex = 2;
            // 
            // txtBNumeroMesa
            // 
            txtBNumeroMesa.Location = new Point(113, 118);
            txtBNumeroMesa.Name = "txtBNumeroMesa";
            txtBNumeroMesa.Size = new Size(100, 27);
            txtBNumeroMesa.TabIndex = 3;
            // 
            // lblCadastroMesa
            // 
            lblCadastroMesa.AutoSize = true;
            lblCadastroMesa.Location = new Point(12, 9);
            lblCadastroMesa.Name = "lblCadastroMesa";
            lblCadastroMesa.Size = new Size(128, 20);
            lblCadastroMesa.TabIndex = 4;
            lblCadastroMesa.Text = "Cadastro de Mesa";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(239, 392);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 35);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 35);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblCadastroMesa);
            Controls.Add(txtBNumeroMesa);
            Controls.Add(txtBoxIdMesa);
            Controls.Add(numeroMesa);
            Controls.Add(IdMesa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMesaForm";
            Text = "TelaMesaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdMesa;
        private Label numeroMesa;
        private TextBox txtBoxIdMesa;
        private TextBox txtBNumeroMesa;
        private Label lblCadastroMesa;
        private Button btnGravar;
        private Button btnCancelar;
    }
}