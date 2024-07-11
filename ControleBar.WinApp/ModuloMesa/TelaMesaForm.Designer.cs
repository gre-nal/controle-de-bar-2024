namespace ControleBar.WinApp.ModuloMesa
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
            label1 = new Label();
            btnOK = new Button();
            numMesa = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numMesa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Número da mesa:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(159, 50);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(89, 30);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnGravar_Click;
            // 
            // numMesa
            // 
            numMesa.Location = new Point(128, 21);
            numMesa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMesa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMesa.Name = "numMesa";
            numMesa.Size = new Size(120, 23);
            numMesa.TabIndex = 3;
            numMesa.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TelaMesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 97);
            Controls.Add(numMesa);
            Controls.Add(btnOK);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMesaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Mesa";
            ((System.ComponentModel.ISupportInitialize)numMesa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOK;
        private NumericUpDown numMesa;
    }
}