﻿namespace ControleBar.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            garcomToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            mesaToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnRemover = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRegistrarPedido = new ToolStripButton();
            btnFecharPedido = new ToolStripButton();
            btnVisualizar = new ToolStripButton();
            btnFaturamento = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1088, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(62, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { garcomToolStripMenuItem, produtoToolStripMenuItem, mesaToolStripMenuItem, contaToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // garcomToolStripMenuItem
            // 
            garcomToolStripMenuItem.Name = "garcomToolStripMenuItem";
            garcomToolStripMenuItem.Size = new Size(131, 24);
            garcomToolStripMenuItem.Text = "Garçom";
            garcomToolStripMenuItem.Click += garcomToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(131, 24);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // mesaToolStripMenuItem
            // 
            mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            mesaToolStripMenuItem.Size = new Size(131, 24);
            mesaToolStripMenuItem.Text = "Mesa";
            mesaToolStripMenuItem.Click += mesaToolStripMenuItem_Click;
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(131, 24);
            contaToolStripMenuItem.Text = "Conta";
            contaToolStripMenuItem.Click += contaToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1088, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnRemover, toolStripSeparator1, btnRegistrarPedido, btnFecharPedido, btnVisualizar, btnFaturamento, toolStripSeparator3, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1088, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemover.Enabled = false;
            btnRemover.Image = Properties.Resources.btnExcluir;
            btnRemover.ImageScaling = ToolStripItemImageScaling.None;
            btnRemover.ImageTransparentColor = Color.Magenta;
            btnRemover.Name = "btnRemover";
            btnRemover.Padding = new Padding(5);
            btnRemover.Size = new Size(38, 38);
            btnRemover.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnRegistrarPedido
            // 
            btnRegistrarPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRegistrarPedido.Enabled = false;
            btnRegistrarPedido.Image = (Image)resources.GetObject("btnRegistrarPedido.Image");
            btnRegistrarPedido.ImageScaling = ToolStripItemImageScaling.None;
            btnRegistrarPedido.ImageTransparentColor = Color.Magenta;
            btnRegistrarPedido.Name = "btnRegistrarPedido";
            btnRegistrarPedido.Padding = new Padding(5);
            btnRegistrarPedido.Size = new Size(38, 38);
            btnRegistrarPedido.Click += btn_AdicionarPedido_Click;
            // 
            // btnFecharPedido
            // 
            btnFecharPedido.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFecharPedido.Enabled = false;
            btnFecharPedido.Image = (Image)resources.GetObject("btnFecharPedido.Image");
            btnFecharPedido.ImageScaling = ToolStripItemImageScaling.None;
            btnFecharPedido.ImageTransparentColor = Color.Magenta;
            btnFecharPedido.Name = "btnFecharPedido";
            btnFecharPedido.Padding = new Padding(5);
            btnFecharPedido.Size = new Size(38, 38);
            btnFecharPedido.Click += btn_FecharConta_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = SystemColors.Control;
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = Properties.Resources.btnVisualizar;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(5);
            btnVisualizar.Size = new Size(38, 38);
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnFaturamento
            // 
            btnFaturamento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFaturamento.Enabled = false;
            btnFaturamento.Image = (Image)resources.GetObject("btnFaturamento.Image");
            btnFaturamento.ImageScaling = ToolStripItemImageScaling.None;
            btnFaturamento.ImageTransparentColor = Color.Magenta;
            btnFaturamento.Name = "btnFaturamento";
            btnFaturamento.Padding = new Padding(5);
            btnFaturamento.Size = new Size(38, 38);
            btnFaturamento.Click += btn_Faturamento_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(1088, 501);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 595);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Bar";
            FormClosed += TelaPrincipalForm_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnRemover;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnVisualizar;
        private ToolStripMenuItem garcomToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem mesaToolStripMenuItem;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripButton btnFecharPedido;
        private ToolStripButton btnRegistrarPedido;
        private ToolStripButton btnFaturamento;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}
