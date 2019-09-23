namespace DLSLQueueingApp
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.startFormPanel = new System.Windows.Forms.Panel();
            this.imageLoader = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startFormUsernameTxtbox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.startFormPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.startFormLoginBtn = new System.Windows.Forms.Button();
            this.startFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // startFormPanel
            // 
            this.startFormPanel.Controls.Add(this.imageLoader);
            this.startFormPanel.Controls.Add(this.headerPanel);
            this.startFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startFormPanel.Location = new System.Drawing.Point(0, 0);
            this.startFormPanel.Name = "startFormPanel";
            this.startFormPanel.Size = new System.Drawing.Size(500, 400);
            this.startFormPanel.TabIndex = 0;
            // 
            // imageLoader
            // 
            this.imageLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageLoader.Image = ((System.Drawing.Image)(resources.GetObject("imageLoader.Image")));
            this.imageLoader.Location = new System.Drawing.Point(0, 100);
            this.imageLoader.Name = "imageLoader";
            this.imageLoader.Size = new System.Drawing.Size(500, 300);
            this.imageLoader.TabIndex = 1;
            this.imageLoader.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPanel.BackgroundImage")));
            this.headerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 100);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(50, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 1;
            // 
            // startFormUsernameTxtbox
            // 
            this.startFormUsernameTxtbox.BackColor = System.Drawing.SystemColors.Control;
            this.startFormUsernameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startFormUsernameTxtbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFormUsernameTxtbox.Location = new System.Drawing.Point(50, 479);
            this.startFormUsernameTxtbox.Name = "startFormUsernameTxtbox";
            this.startFormUsernameTxtbox.Size = new System.Drawing.Size(407, 30);
            this.startFormUsernameTxtbox.TabIndex = 2;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.usernameLbl.Location = new System.Drawing.Point(45, 452);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(95, 24);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.passwordLbl.Location = new System.Drawing.Point(45, 561);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(89, 24);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // startFormPasswordTxtbox
            // 
            this.startFormPasswordTxtbox.BackColor = System.Drawing.SystemColors.Control;
            this.startFormPasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startFormPasswordTxtbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFormPasswordTxtbox.Location = new System.Drawing.Point(49, 588);
            this.startFormPasswordTxtbox.Name = "startFormPasswordTxtbox";
            this.startFormPasswordTxtbox.Size = new System.Drawing.Size(407, 30);
            this.startFormPasswordTxtbox.TabIndex = 5;
            this.startFormPasswordTxtbox.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(49, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 4;
            // 
            // startFormLoginBtn
            // 
            this.startFormLoginBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startFormLoginBtn.FlatAppearance.BorderSize = 0;
            this.startFormLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startFormLoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.startFormLoginBtn.Location = new System.Drawing.Point(50, 652);
            this.startFormLoginBtn.Name = "startFormLoginBtn";
            this.startFormLoginBtn.Size = new System.Drawing.Size(407, 40);
            this.startFormLoginBtn.TabIndex = 7;
            this.startFormLoginBtn.Text = "LOGIN";
            this.startFormLoginBtn.UseVisualStyleBackColor = false;
            this.startFormLoginBtn.Click += new System.EventHandler(this.startFormLoginBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 720);
            this.Controls.Add(this.startFormLoginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.startFormPasswordTxtbox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.startFormUsernameTxtbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.startFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 750);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.startFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel startFormPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox startFormUsernameTxtbox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox startFormPasswordTxtbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button startFormLoginBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox imageLoader;
    }
}