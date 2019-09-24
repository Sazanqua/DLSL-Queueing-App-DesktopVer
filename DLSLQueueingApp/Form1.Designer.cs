namespace DLSLQueueingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pagePanel = new System.Windows.Forms.Panel();
            this.mobileQueuePage11 = new DLSLQueueingApp.MobileQueuePage1();
            this.page41 = new DLSLQueueingApp.Page4();
            this.page31 = new DLSLQueueingApp.Page3();
            this.page21 = new DLSLQueueingApp.Page2();
            this.SuspendLayout();
            // 
            // pagePanel
            // 
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagePanel.Location = new System.Drawing.Point(0, 416);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(1898, 608);
            this.pagePanel.TabIndex = 4;
            // 
            // mobileQueuePage11
            // 
            this.mobileQueuePage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.mobileQueuePage11.Location = new System.Drawing.Point(111, 258);
            this.mobileQueuePage11.Name = "mobileQueuePage11";
            this.mobileQueuePage11.Size = new System.Drawing.Size(50, 50);
            this.mobileQueuePage11.TabIndex = 3;
            this.mobileQueuePage11.Load += new System.EventHandler(this.mobileQueuePage11_Load);
            // 
            // page41
            // 
            this.page41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.page41.Location = new System.Drawing.Point(211, 249);
            this.page41.Name = "page41";
            this.page41.Size = new System.Drawing.Size(50, 50);
            this.page41.TabIndex = 2;
            // 
            // page31
            // 
            this.page31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.page31.Location = new System.Drawing.Point(301, 249);
            this.page31.Name = "page31";
            this.page31.Page4 = null;
            this.page31.Size = new System.Drawing.Size(50, 50);
            this.page31.TabIndex = 1;
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.page21.Location = new System.Drawing.Point(441, 235);
            this.page21.MobileQueuePage1 = null;
            this.page21.Name = "page21";
            this.page21.Page3 = null;
            this.page21.pagePanel = null;
            this.page21.Size = new System.Drawing.Size(50, 50);
            this.page21.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.mobileQueuePage11);
            this.Controls.Add(this.page41);
            this.Controls.Add(this.page31);
            this.Controls.Add(this.page21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Page2 page21;
        private Page3 page31;
        private Page4 page41;
        private MobileQueuePage1 mobileQueuePage11;
        public System.Windows.Forms.Panel pagePanel;
    }
}

