namespace DLSLQueueingApp
{
    partial class sample
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
            this.aaaa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.page21 = new DLSLQueueingApp.Page2();
            this.SuspendLayout();
            // 
            // aaaa
            // 
            this.aaaa.BackColor = System.Drawing.Color.Maroon;
            this.aaaa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aaaa.Location = new System.Drawing.Point(0, 230);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(800, 220);
            this.aaaa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.page21.Location = new System.Drawing.Point(166, 151);
            this.page21.MobileQueuePage1 = null;
            this.page21.Name = "page21";
            this.page21.Page3 = null;
            this.page21.Size = new System.Drawing.Size(50, 50);
            this.page21.TabIndex = 2;
            // 
            // sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.page21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aaaa);
            this.Name = "sample";
            this.Text = "sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel aaaa;
        private System.Windows.Forms.Button button1;
        private Page2 page21;
    }
}