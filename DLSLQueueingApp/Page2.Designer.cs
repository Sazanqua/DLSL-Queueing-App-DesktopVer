namespace DLSLQueueingApp
{
    partial class Page2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manualQueueBtn = new DLSLQueueingApp.CircularButton();
            this.mobileAppQueueBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // manualQueueBtn
            // 
            this.manualQueueBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualQueueBtn.ForeColor = System.Drawing.Color.White;
            this.manualQueueBtn.Location = new System.Drawing.Point(500, 143);
            this.manualQueueBtn.Name = "manualQueueBtn";
            this.manualQueueBtn.Size = new System.Drawing.Size(900, 180);
            this.manualQueueBtn.TabIndex = 4;
            this.manualQueueBtn.Text = "MANUAL QUEUE";
            this.manualQueueBtn.UseVisualStyleBackColor = true;
            this.manualQueueBtn.Click += new System.EventHandler(this.manualQueueBtn_Click);
            // 
            // mobileAppQueueBtn
            // 
            this.mobileAppQueueBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileAppQueueBtn.ForeColor = System.Drawing.Color.White;
            this.mobileAppQueueBtn.Location = new System.Drawing.Point(500, 383);
            this.mobileAppQueueBtn.Name = "mobileAppQueueBtn";
            this.mobileAppQueueBtn.Size = new System.Drawing.Size(900, 180);
            this.mobileAppQueueBtn.TabIndex = 3;
            this.mobileAppQueueBtn.Text = "MOBILE APP QUEUE";
            this.mobileAppQueueBtn.UseVisualStyleBackColor = true;
            this.mobileAppQueueBtn.Click += new System.EventHandler(this.mobileAppQueueBtn_Click);
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manualQueueBtn);
            this.Controls.Add(this.mobileAppQueueBtn);
            this.Name = "Page2";
            this.Size = new System.Drawing.Size(1897, 608);
            this.Load += new System.EventHandler(this.Page2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton manualQueueBtn;
        private CircularButton mobileAppQueueBtn;
    }
}
