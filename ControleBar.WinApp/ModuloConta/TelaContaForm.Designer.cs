namespace ControleBar.WinApp.ModuloConta
{
    partial class TelaContaForm
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
            comboBoxGarcom = new ComboBox();
            lblGarcom = new Label();
            lblMesa = new Label();
            comboBoxMesa = new ComboBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // comboBoxGarcom
            // 
            comboBoxGarcom.FormattingEnabled = true;
            comboBoxGarcom.Location = new Point(253, 54);
            comboBoxGarcom.Name = "comboBoxGarcom";
            comboBoxGarcom.Size = new Size(121, 23);
            comboBoxGarcom.TabIndex = 0;
            // 
            // lblGarcom
            // 
            lblGarcom.AutoSize = true;
            lblGarcom.Location = new Point(195, 57);
            lblGarcom.Name = "lblGarcom";
            lblGarcom.Size = new Size(52, 15);
            lblGarcom.TabIndex = 1;
            lblGarcom.Text = "Garçom:";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(12, 57);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(38, 15);
            lblMesa.TabIndex = 2;
            lblMesa.Text = "Mesa:";
            // 
            // comboBoxMesa
            // 
            comboBoxMesa.FormattingEnabled = true;
            comboBoxMesa.Location = new Point(56, 54);
            comboBoxMesa.Name = "comboBoxMesa";
            comboBoxMesa.Size = new Size(121, 23);
            comboBoxMesa.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(290, 180);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(89, 30);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnGravar_Click;
            // 
            // TelaContaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 222);
            Controls.Add(btnOK);
            Controls.Add(lblMesa);
            Controls.Add(lblGarcom);
            Controls.Add(comboBoxMesa);
            Controls.Add(comboBoxGarcom);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Conta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGarcom;
        private Label lblGarcom;
        private Label lblMesa;
        private ComboBox comboBoxMesa;
        private Button btnOK;
    }
}