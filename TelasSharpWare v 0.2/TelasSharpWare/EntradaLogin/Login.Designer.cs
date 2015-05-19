namespace TelasSharpWare
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTbx = new System.Windows.Forms.TextBox();
            this.SenhaTbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoLogin1 = new TelasSharpWare.BotaoLogin();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTbx
            // 
            this.LoginTbx.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTbx.Location = new System.Drawing.Point(21, 66);
            this.LoginTbx.MaxLength = 12;
            this.LoginTbx.Name = "LoginTbx";
            this.LoginTbx.Size = new System.Drawing.Size(194, 26);
            this.LoginTbx.TabIndex = 0;
            // 
            // SenhaTbx
            // 
            this.SenhaTbx.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaTbx.Location = new System.Drawing.Point(21, 142);
            this.SenhaTbx.MaxLength = 6;
            this.SenhaTbx.Name = "SenhaTbx";
            this.SenhaTbx.PasswordChar = '*';
            this.SenhaTbx.Size = new System.Drawing.Size(148, 26);
            this.SenhaTbx.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoLogin1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SenhaTbx);
            this.groupBox1.Controls.Add(this.LoginTbx);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // botaoLogin1
            // 
            this.botaoLogin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoLogin1.BackgroundImage")));
            this.botaoLogin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLogin1.Location = new System.Drawing.Point(195, 171);
            this.botaoLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.botaoLogin1.Name = "botaoLogin1";
            this.botaoLogin1.Size = new System.Drawing.Size(60, 60);
            this.botaoLogin1.TabIndex = 4;
            this.botaoLogin1.Click += new System.EventHandler(this.botaoLogin1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(286, 262);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTbx;
        private System.Windows.Forms.TextBox SenhaTbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BotaoLogin botaoLogin1;
    }
}