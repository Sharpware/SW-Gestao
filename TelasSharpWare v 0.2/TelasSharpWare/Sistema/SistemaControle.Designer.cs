namespace TelasSharpWare
{
    partial class SistemaControle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaControle));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ClientePnl = new System.Windows.Forms.Panel();
            this.ProdutosPnl = new System.Windows.Forms.Panel();
            this.FornecedorPnl = new System.Windows.Forms.Panel();
            this.ComprasPnl = new System.Windows.Forms.Panel();
            this.AdministrativoPnl = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botaoAdministrativo1 = new TelasSharpWare.Botoes.BotaoAdministrativo();
            this.botaoPesquisarUsuario1 = new TelasSharpWare.Botoes.BotaoPesquisarUsuario();
            this.botaoAdicionarUsuario1 = new TelasSharpWare.Botoes.BotaoAdicionarUsuario();
            this.botaoRelatorioDeVendas1 = new TelasSharpWare.BotaoRelatorioDeVendas();
            this.botaoFinalizarPedido1 = new TelasSharpWare.BotaoFinalizarPedido();
            this.botaoPesquisarPedido1 = new TelasSharpWare.BotaoPesquisarPedido();
            this.botaoPedidosEmAberto1 = new TelasSharpWare.BotaoPedidosEmAberto();
            this.botaoFazerPedido1 = new TelasSharpWare.BotaoFazerPedido();
            this.botaoPesquisarFornecedor1 = new TelasSharpWare.BotaoPesquisarFornecedor();
            this.botaoAdicionarFornecedor1 = new TelasSharpWare.BotaoAdicionarFornecedor();
            this.botaoPesquisarProduto1 = new TelasSharpWare.BotaoPesquisarProduto();
            this.botaoAdicionaProduto1 = new TelasSharpWare.BotaoAdicionaProduto();
            this.botaoPesquisarCliente1 = new TelasSharpWare.BotaoPesquisarCliente();
            this.botaoAdicionarCliente1 = new TelasSharpWare.BotaoAdicionarCliente();
            this.botaoCompras1 = new TelasSharpWare.BotaoCompras();
            this.botaoFornecedor1 = new TelasSharpWare.BotaoFornecedor();
            this.botaoProduto1 = new TelasSharpWare.BotaoProduto();
            this.botaoCliente1 = new TelasSharpWare.BotaoCliente();
            this.ClientePnl.SuspendLayout();
            this.ProdutosPnl.SuspendLayout();
            this.FornecedorPnl.SuspendLayout();
            this.ComprasPnl.SuspendLayout();
            this.AdministrativoPnl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.SystemColors.Control;
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormPanel.Location = new System.Drawing.Point(268, 56);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(504, 474);
            this.FormPanel.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ClientePnl
            // 
            this.ClientePnl.BackColor = System.Drawing.SystemColors.Control;
            this.ClientePnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientePnl.Controls.Add(this.botaoPesquisarCliente1);
            this.ClientePnl.Controls.Add(this.botaoAdicionarCliente1);
            this.ClientePnl.Location = new System.Drawing.Point(268, 56);
            this.ClientePnl.Name = "ClientePnl";
            this.ClientePnl.Size = new System.Drawing.Size(504, 474);
            this.ClientePnl.TabIndex = 5;
            // 
            // ProdutosPnl
            // 
            this.ProdutosPnl.BackColor = System.Drawing.SystemColors.Control;
            this.ProdutosPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProdutosPnl.Controls.Add(this.botaoPesquisarProduto1);
            this.ProdutosPnl.Controls.Add(this.botaoAdicionaProduto1);
            this.ProdutosPnl.Location = new System.Drawing.Point(268, 56);
            this.ProdutosPnl.Name = "ProdutosPnl";
            this.ProdutosPnl.Size = new System.Drawing.Size(504, 474);
            this.ProdutosPnl.TabIndex = 6;
            // 
            // FornecedorPnl
            // 
            this.FornecedorPnl.BackColor = System.Drawing.SystemColors.Control;
            this.FornecedorPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FornecedorPnl.Controls.Add(this.botaoPesquisarFornecedor1);
            this.FornecedorPnl.Controls.Add(this.botaoAdicionarFornecedor1);
            this.FornecedorPnl.Location = new System.Drawing.Point(268, 56);
            this.FornecedorPnl.Name = "FornecedorPnl";
            this.FornecedorPnl.Size = new System.Drawing.Size(504, 474);
            this.FornecedorPnl.TabIndex = 7;
            // 
            // ComprasPnl
            // 
            this.ComprasPnl.BackColor = System.Drawing.SystemColors.Control;
            this.ComprasPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComprasPnl.Controls.Add(this.botaoFinalizarPedido1);
            this.ComprasPnl.Controls.Add(this.botaoPesquisarPedido1);
            this.ComprasPnl.Controls.Add(this.botaoPedidosEmAberto1);
            this.ComprasPnl.Controls.Add(this.botaoFazerPedido1);
            this.ComprasPnl.Location = new System.Drawing.Point(268, 56);
            this.ComprasPnl.Name = "ComprasPnl";
            this.ComprasPnl.Size = new System.Drawing.Size(504, 474);
            this.ComprasPnl.TabIndex = 8;
            // 
            // AdministrativoPnl
            // 
            this.AdministrativoPnl.BackColor = System.Drawing.SystemColors.Control;
            this.AdministrativoPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdministrativoPnl.Controls.Add(this.botaoPesquisarUsuario1);
            this.AdministrativoPnl.Controls.Add(this.botaoAdicionarUsuario1);
            this.AdministrativoPnl.Controls.Add(this.botaoRelatorioDeVendas1);
            this.AdministrativoPnl.Location = new System.Drawing.Point(268, 56);
            this.AdministrativoPnl.Name = "AdministrativoPnl";
            this.AdministrativoPnl.Size = new System.Drawing.Size(504, 474);
            this.AdministrativoPnl.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(430, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botaoAdministrativo1
            // 
            this.botaoAdministrativo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdministrativo1.BackgroundImage")));
            this.botaoAdministrativo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdministrativo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdministrativo1.Location = new System.Drawing.Point(12, 440);
            this.botaoAdministrativo1.Name = "botaoAdministrativo1";
            this.botaoAdministrativo1.Size = new System.Drawing.Size(250, 90);
            this.botaoAdministrativo1.TabIndex = 12;
            this.botaoAdministrativo1.Click += new System.EventHandler(this.botaoAdministrativo1_Click);
            // 
            // botaoPesquisarUsuario1
            // 
            this.botaoPesquisarUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarUsuario1.BackgroundImage")));
            this.botaoPesquisarUsuario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisarUsuario1.Location = new System.Drawing.Point(-2, 215);
            this.botaoPesquisarUsuario1.Name = "botaoPesquisarUsuario1";
            this.botaoPesquisarUsuario1.Size = new System.Drawing.Size(480, 100);
            this.botaoPesquisarUsuario1.TabIndex = 2;
            // 
            // botaoAdicionarUsuario1
            // 
            this.botaoAdicionarUsuario1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionarUsuario1.BackgroundImage")));
            this.botaoAdicionarUsuario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdicionarUsuario1.Location = new System.Drawing.Point(-2, 109);
            this.botaoAdicionarUsuario1.Name = "botaoAdicionarUsuario1";
            this.botaoAdicionarUsuario1.Size = new System.Drawing.Size(480, 100);
            this.botaoAdicionarUsuario1.TabIndex = 1;
            // 
            // botaoRelatorioDeVendas1
            // 
            this.botaoRelatorioDeVendas1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRelatorioDeVendas1.BackgroundImage")));
            this.botaoRelatorioDeVendas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoRelatorioDeVendas1.Location = new System.Drawing.Point(-2, 3);
            this.botaoRelatorioDeVendas1.Name = "botaoRelatorioDeVendas1";
            this.botaoRelatorioDeVendas1.Size = new System.Drawing.Size(480, 100);
            this.botaoRelatorioDeVendas1.TabIndex = 0;
            // 
            // botaoFinalizarPedido1
            // 
            this.botaoFinalizarPedido1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFinalizarPedido1.BackgroundImage")));
            this.botaoFinalizarPedido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFinalizarPedido1.Location = new System.Drawing.Point(-2, 321);
            this.botaoFinalizarPedido1.Name = "botaoFinalizarPedido1";
            this.botaoFinalizarPedido1.Size = new System.Drawing.Size(480, 100);
            this.botaoFinalizarPedido1.TabIndex = 3;
            // 
            // botaoPesquisarPedido1
            // 
            this.botaoPesquisarPedido1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarPedido1.BackgroundImage")));
            this.botaoPesquisarPedido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisarPedido1.Location = new System.Drawing.Point(-2, 109);
            this.botaoPesquisarPedido1.Name = "botaoPesquisarPedido1";
            this.botaoPesquisarPedido1.Size = new System.Drawing.Size(480, 100);
            this.botaoPesquisarPedido1.TabIndex = 2;
            // 
            // botaoPedidosEmAberto1
            // 
            this.botaoPedidosEmAberto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedidosEmAberto1.BackgroundImage")));
            this.botaoPedidosEmAberto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedidosEmAberto1.Location = new System.Drawing.Point(-2, 215);
            this.botaoPedidosEmAberto1.Name = "botaoPedidosEmAberto1";
            this.botaoPedidosEmAberto1.Size = new System.Drawing.Size(480, 100);
            this.botaoPedidosEmAberto1.TabIndex = 1;
            // 
            // botaoFazerPedido1
            // 
            this.botaoFazerPedido1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFazerPedido1.BackgroundImage")));
            this.botaoFazerPedido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFazerPedido1.Location = new System.Drawing.Point(-2, 3);
            this.botaoFazerPedido1.Name = "botaoFazerPedido1";
            this.botaoFazerPedido1.Size = new System.Drawing.Size(480, 100);
            this.botaoFazerPedido1.TabIndex = 0;
            // 
            // botaoPesquisarFornecedor1
            // 
            this.botaoPesquisarFornecedor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarFornecedor1.BackgroundImage")));
            this.botaoPesquisarFornecedor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisarFornecedor1.Location = new System.Drawing.Point(-2, 109);
            this.botaoPesquisarFornecedor1.Name = "botaoPesquisarFornecedor1";
            this.botaoPesquisarFornecedor1.Size = new System.Drawing.Size(480, 100);
            this.botaoPesquisarFornecedor1.TabIndex = 1;
            // 
            // botaoAdicionarFornecedor1
            // 
            this.botaoAdicionarFornecedor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionarFornecedor1.BackgroundImage")));
            this.botaoAdicionarFornecedor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdicionarFornecedor1.Location = new System.Drawing.Point(-2, 3);
            this.botaoAdicionarFornecedor1.Name = "botaoAdicionarFornecedor1";
            this.botaoAdicionarFornecedor1.Size = new System.Drawing.Size(480, 100);
            this.botaoAdicionarFornecedor1.TabIndex = 0;
            // 
            // botaoPesquisarProduto1
            // 
            this.botaoPesquisarProduto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarProduto1.BackgroundImage")));
            this.botaoPesquisarProduto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisarProduto1.Location = new System.Drawing.Point(-2, 109);
            this.botaoPesquisarProduto1.Name = "botaoPesquisarProduto1";
            this.botaoPesquisarProduto1.Size = new System.Drawing.Size(480, 100);
            this.botaoPesquisarProduto1.TabIndex = 1;
            // 
            // botaoAdicionaProduto1
            // 
            this.botaoAdicionaProduto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionaProduto1.BackgroundImage")));
            this.botaoAdicionaProduto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdicionaProduto1.Location = new System.Drawing.Point(-2, 3);
            this.botaoAdicionaProduto1.Name = "botaoAdicionaProduto1";
            this.botaoAdicionaProduto1.Size = new System.Drawing.Size(480, 100);
            this.botaoAdicionaProduto1.TabIndex = 0;
            // 
            // botaoPesquisarCliente1
            // 
            this.botaoPesquisarCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarCliente1.BackgroundImage")));
            this.botaoPesquisarCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisarCliente1.Location = new System.Drawing.Point(-2, 109);
            this.botaoPesquisarCliente1.Name = "botaoPesquisarCliente1";
            this.botaoPesquisarCliente1.Size = new System.Drawing.Size(480, 100);
            this.botaoPesquisarCliente1.TabIndex = 1;
            // 
            // botaoAdicionarCliente1
            // 
            this.botaoAdicionarCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionarCliente1.BackgroundImage")));
            this.botaoAdicionarCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoAdicionarCliente1.Location = new System.Drawing.Point(-2, 3);
            this.botaoAdicionarCliente1.Name = "botaoAdicionarCliente1";
            this.botaoAdicionarCliente1.Size = new System.Drawing.Size(480, 100);
            this.botaoAdicionarCliente1.TabIndex = 0;
            // 
            // botaoCompras1
            // 
            this.botaoCompras1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCompras1.BackgroundImage")));
            this.botaoCompras1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCompras1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCompras1.Location = new System.Drawing.Point(12, 344);
            this.botaoCompras1.Name = "botaoCompras1";
            this.botaoCompras1.Size = new System.Drawing.Size(250, 90);
            this.botaoCompras1.TabIndex = 5;
            this.botaoCompras1.Click += new System.EventHandler(this.botaoCompras1_Click);
            // 
            // botaoFornecedor1
            // 
            this.botaoFornecedor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoFornecedor1.BackgroundImage")));
            this.botaoFornecedor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoFornecedor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFornecedor1.Location = new System.Drawing.Point(12, 248);
            this.botaoFornecedor1.Name = "botaoFornecedor1";
            this.botaoFornecedor1.Size = new System.Drawing.Size(250, 90);
            this.botaoFornecedor1.TabIndex = 2;
            this.botaoFornecedor1.Click += new System.EventHandler(this.botaoFornecedor1_Click);
            // 
            // botaoProduto1
            // 
            this.botaoProduto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoProduto1.BackgroundImage")));
            this.botaoProduto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoProduto1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoProduto1.Location = new System.Drawing.Point(12, 152);
            this.botaoProduto1.Name = "botaoProduto1";
            this.botaoProduto1.Size = new System.Drawing.Size(250, 90);
            this.botaoProduto1.TabIndex = 1;
            this.botaoProduto1.Click += new System.EventHandler(this.botaoProduto1_Click);
            // 
            // botaoCliente1
            // 
            this.botaoCliente1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCliente1.BackgroundImage")));
            this.botaoCliente1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCliente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCliente1.Location = new System.Drawing.Point(12, 56);
            this.botaoCliente1.Name = "botaoCliente1";
            this.botaoCliente1.Size = new System.Drawing.Size(250, 90);
            this.botaoCliente1.TabIndex = 0;
            this.botaoCliente1.Click += new System.EventHandler(this.botaoCliente1_Click);
            // 
            // SistemaControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.botaoAdministrativo1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdministrativoPnl);
            this.Controls.Add(this.ComprasPnl);
            this.Controls.Add(this.FornecedorPnl);
            this.Controls.Add(this.ProdutosPnl);
            this.Controls.Add(this.ClientePnl);
            this.Controls.Add(this.botaoCompras1);
            this.Controls.Add(this.botaoFornecedor1);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.botaoProduto1);
            this.Controls.Add(this.botaoCliente1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SistemaControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click_1);
            this.ClientePnl.ResumeLayout(false);
            this.ProdutosPnl.ResumeLayout(false);
            this.FornecedorPnl.ResumeLayout(false);
            this.ComprasPnl.ResumeLayout(false);
            this.AdministrativoPnl.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BotaoCliente botaoCliente1;
        private BotaoProduto botaoProduto1;
        private BotaoFornecedor botaoFornecedor1;
        private System.Windows.Forms.Panel FormPanel;
        private BotaoCompras botaoCompras1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel ClientePnl;
        private System.Windows.Forms.Panel ProdutosPnl;
        private BotaoPesquisarProduto botaoPesquisarProduto1;
        private BotaoAdicionaProduto botaoAdicionaProduto1;
        private BotaoPesquisarCliente botaoPesquisarCliente1;
        private BotaoAdicionarCliente botaoAdicionarCliente1;
        private System.Windows.Forms.Panel FornecedorPnl;
        private BotaoPesquisarFornecedor botaoPesquisarFornecedor1;
        private BotaoAdicionarFornecedor botaoAdicionarFornecedor1;
        private System.Windows.Forms.Panel ComprasPnl;
        private System.Windows.Forms.Panel AdministrativoPnl;
        private BotaoRelatorioDeVendas botaoRelatorioDeVendas1;
        private BotaoFinalizarPedido botaoFinalizarPedido1;
        private BotaoPesquisarPedido botaoPesquisarPedido1;
        private BotaoPedidosEmAberto botaoPedidosEmAberto1;
        private BotaoFazerPedido botaoFazerPedido1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private Botoes.BotaoPesquisarUsuario botaoPesquisarUsuario1;
        private Botoes.BotaoAdicionarUsuario botaoAdicionarUsuario1;
        private Botoes.BotaoAdministrativo botaoAdministrativo1;

    }
}

