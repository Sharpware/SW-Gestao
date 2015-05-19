namespace TelasSharpWare
{
    partial class ModoDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoDePagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModoLbl = new System.Windows.Forms.Label();
            this.botaoDinheiro1 = new TelasSharpWare.Botoes.BotaoDinheiro();
            this.botaoCartao1 = new TelasSharpWare.Botoes.BotaoCartao();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modo de pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(164)))), ((int)(((byte)(180)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ModoLbl);
            this.panel1.Location = new System.Drawing.Point(84, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 3;
            // 
            // ModoLbl
            // 
            this.ModoLbl.AutoSize = true;
            this.ModoLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModoLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModoLbl.Location = new System.Drawing.Point(3, 5);
            this.ModoLbl.Name = "ModoLbl";
            this.ModoLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModoLbl.Size = new System.Drawing.Size(24, 16);
            this.ModoLbl.TabIndex = 0;
            this.ModoLbl.Text = "lbl";
            // 
            // botaoDinheiro1
            // 
            this.botaoDinheiro1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoDinheiro1.BackgroundImage")));
            this.botaoDinheiro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoDinheiro1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoDinheiro1.Location = new System.Drawing.Point(200, 70);
            this.botaoDinheiro1.Name = "botaoDinheiro1";
            this.botaoDinheiro1.Size = new System.Drawing.Size(120, 120);
            this.botaoDinheiro1.TabIndex = 1;
            this.botaoDinheiro1.Click += new System.EventHandler(this.botaoDinheiro1_Click);
            this.botaoDinheiro1.MouseEnter += new System.EventHandler(this.botaoDinheiro1_MouseEnter);
            this.botaoDinheiro1.MouseLeave += new System.EventHandler(this.botaoDinheiro1_MouseLeave);
            // 
            // botaoCartao1
            // 
            this.botaoCartao1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoCartao1.BackgroundImage")));
            this.botaoCartao1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoCartao1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCartao1.Location = new System.Drawing.Point(49, 70);
            this.botaoCartao1.Name = "botaoCartao1";
            this.botaoCartao1.Size = new System.Drawing.Size(120, 120);
            this.botaoCartao1.TabIndex = 0;
            this.botaoCartao1.Click += new System.EventHandler(this.botaoCartao1_Click);
            this.botaoCartao1.MouseEnter += new System.EventHandler(this.botaoCartao1_MouseEnter);
            this.botaoCartao1.MouseLeave += new System.EventHandler(this.botaoCartao1_MouseLeave);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(344, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModoDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoDinheiro1);
            this.Controls.Add(this.botaoCartao1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModoDePagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModoDePagamento";
            this.Load += new System.EventHandler(this.ModoDePagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Botoes.BotaoCartao botaoCartao1;
        private Botoes.BotaoDinheiro botaoDinheiro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ModoLbl;
        private System.Windows.Forms.Button button1;
    }
}