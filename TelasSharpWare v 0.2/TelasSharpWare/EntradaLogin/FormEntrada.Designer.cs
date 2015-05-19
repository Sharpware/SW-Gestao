namespace TelasSharpWare
{
    partial class FormEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrada));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSistema1 = new TelasSharpWare.BotaoSistema();
            this.botaoPesquisar1 = new TelasSharpWare.BotaoPesquisar();
            this.botaoCaixa1 = new TelasSharpWare.BotaoCaixa();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(127, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 34);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoSistema1
            // 
            this.botaoSistema1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSistema1.BackgroundImage")));
            this.botaoSistema1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoSistema1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSistema1.Location = new System.Drawing.Point(248, 33);
            this.botaoSistema1.Name = "botaoSistema1";
            this.botaoSistema1.Size = new System.Drawing.Size(150, 150);
            this.botaoSistema1.TabIndex = 2;
            this.botaoSistema1.Click += new System.EventHandler(this.botaoSistema1_Click);
            this.botaoSistema1.MouseEnter += new System.EventHandler(this.botaoSistema1_MouseEnter);
            this.botaoSistema1.MouseLeave += new System.EventHandler(this.botaoSistema1_MouseLeave);
            // 
            // botaoPesquisar1
            // 
            this.botaoPesquisar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar1.BackgroundImage")));
            this.botaoPesquisar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPesquisar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar1.Location = new System.Drawing.Point(450, 33);
            this.botaoPesquisar1.Name = "botaoPesquisar1";
            this.botaoPesquisar1.Size = new System.Drawing.Size(150, 150);
            this.botaoPesquisar1.TabIndex = 1;
            this.botaoPesquisar1.MouseEnter += new System.EventHandler(this.botaoPesquisar1_MouseEnter);
            this.botaoPesquisar1.MouseLeave += new System.EventHandler(this.botaoPesquisar1_MouseLeave);
            // 
            // botaoCaixa1
            // 
            this.botaoCaixa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCaixa1.BackgroundImage")));
            this.botaoCaixa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCaixa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCaixa1.Location = new System.Drawing.Point(51, 33);
            this.botaoCaixa1.Name = "botaoCaixa1";
            this.botaoCaixa1.Size = new System.Drawing.Size(150, 150);
            this.botaoCaixa1.TabIndex = 0;
            this.botaoCaixa1.Click += new System.EventHandler(this.botaoCaixa1_Click);
            this.botaoCaixa1.MouseEnter += new System.EventHandler(this.botaoCaixa1_MouseEnter);
            this.botaoCaixa1.MouseLeave += new System.EventHandler(this.botaoCaixa1_MouseLeave);
            // 
            // FormEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(641, 272);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botaoSistema1);
            this.Controls.Add(this.botaoPesquisar1);
            this.Controls.Add(this.botaoCaixa1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormEntrada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotaoCaixa botaoCaixa1;
        private BotaoPesquisar botaoPesquisar1;
        private BotaoSistema botaoSistema1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}