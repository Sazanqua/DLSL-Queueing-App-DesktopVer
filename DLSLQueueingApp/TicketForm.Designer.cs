namespace DLSLQueueingApp
{
    partial class TicketForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.mobileAppQueueBtn = new DLSLQueueingApp.CircularButton();
            this.manualQueueBtn = new DLSLQueueingApp.CircularButton();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mobileAppQueueBtn
            // 
            this.mobileAppQueueBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileAppQueueBtn.ForeColor = System.Drawing.Color.White;
            this.mobileAppQueueBtn.Location = new System.Drawing.Point(500, 800);
            this.mobileAppQueueBtn.Name = "mobileAppQueueBtn";
            this.mobileAppQueueBtn.Size = new System.Drawing.Size(900, 180);
            this.mobileAppQueueBtn.TabIndex = 6;
            this.mobileAppQueueBtn.Text = "MOBILE APP QUEUE";
            this.mobileAppQueueBtn.UseVisualStyleBackColor = true;
            this.mobileAppQueueBtn.Click += new System.EventHandler(this.mobileAppQueueBtn_Click);
            // 
            // manualQueueBtn
            // 
            this.manualQueueBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualQueueBtn.ForeColor = System.Drawing.Color.White;
            this.manualQueueBtn.Location = new System.Drawing.Point(500, 550);
            this.manualQueueBtn.Name = "manualQueueBtn";
            this.manualQueueBtn.Size = new System.Drawing.Size(900, 180);
            this.manualQueueBtn.TabIndex = 5;
            this.manualQueueBtn.Text = "MANUAL QUEUE";
            this.manualQueueBtn.UseVisualStyleBackColor = true;
            this.manualQueueBtn.Click += new System.EventHandler(this.manualQueueBtn_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.mobileAppQueueBtn);
            this.Controls.Add(this.manualQueueBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TicketForm";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton manualQueueBtn;
        private CircularButton mobileAppQueueBtn;
        private System.Windows.Forms.Timer animationTimer;
    }
}

