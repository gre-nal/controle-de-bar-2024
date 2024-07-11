namespace ControleBar.WinApp.ModuloConta
{
    partial class TelaFaturamentoForm
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
            rdbDia = new RadioButton();
            rdbMes = new RadioButton();
            rdbSemana = new RadioButton();
            label1 = new Label();
            txtLucro = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // rdbDia
            // 
            rdbDia.AutoSize = true;
            rdbDia.Location = new Point(24, 12);
            rdbDia.Name = "rdbDia";
            rdbDia.Size = new Size(124, 19);
            rdbDia.TabIndex = 0;
            rdbDia.Text = "Exibir fatura do dia";
            rdbDia.UseVisualStyleBackColor = true;
            rdbDia.CheckedChanged += rdbDia_CheckedChanged;
            // 
            // rdbMes
            // 
            rdbMes.AutoSize = true;
            rdbMes.Location = new Point(308, 12);
            rdbMes.Name = "rdbMes";
            rdbMes.Size = new Size(130, 19);
            rdbMes.TabIndex = 0;
            rdbMes.Text = "Exibir fatura do mês";
            rdbMes.UseVisualStyleBackColor = true;
            rdbMes.CheckedChanged += rdbMes_CheckedChanged;
            // 
            // rdbSemana
            // 
            rdbSemana.AutoSize = true;
            rdbSemana.Location = new Point(154, 12);
            rdbSemana.Name = "rdbSemana";
            rdbSemana.Size = new Size(148, 19);
            rdbSemana.TabIndex = 0;
            rdbSemana.Text = "Exibir fatura da semana";
            rdbSemana.UseVisualStyleBackColor = true;
            rdbSemana.CheckedChanged += rdbSemana_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 88);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 1;
            label1.Text = " R$";
            // 
            // txtLucro
            // 
            txtLucro.AutoSize = true;
            txtLucro.Location = new Point(183, 88);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(13, 15);
            txtLucro.TabIndex = 1;
            txtLucro.Text = "0";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(363, 88);
            button1.Name = "button1";
            button1.Size = new Size(71, 31);
            button1.TabIndex = 2;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaFaturamentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 131);
            Controls.Add(button1);
            Controls.Add(txtLucro);
            Controls.Add(label1);
            Controls.Add(rdbSemana);
            Controls.Add(rdbMes);
            Controls.Add(rdbDia);
            Name = "TelaFaturamentoForm";
            Text = "Faturamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbDia;
        private RadioButton rdbMes;
        private RadioButton rdbSemana;
        private Label label1;
        private Label txtLucro;
        private Button button1;
    }
}