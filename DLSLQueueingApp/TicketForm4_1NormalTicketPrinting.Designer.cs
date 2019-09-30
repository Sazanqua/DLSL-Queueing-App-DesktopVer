namespace DLSLQueueingApp
{
    partial class TicketForm4_1NormalTicketPrinting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm4_1NormalTicketPrinting));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queueNumber = new System.Windows.Forms.Label();
            this.qnLbl = new System.Windows.Forms.Label();
            this.cLbl = new System.Windows.Forms.Label();
            this.cashierNumber = new System.Windows.Forms.Label();
            this.serviceType = new System.Windows.Forms.Label();
            this.serviceLane = new System.Windows.Forms.Label();
            this.edLbl = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.Label();
            this.confirmBtn = new DLSLQueueingApp.CircularButton();
            this.ticketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.expirationDate);
            this.ticketPanel.Controls.Add(this.edLbl);
            this.ticketPanel.Controls.Add(this.serviceLane);
            this.ticketPanel.Controls.Add(this.serviceType);
            this.ticketPanel.Controls.Add(this.cashierNumber);
            this.ticketPanel.Controls.Add(this.cLbl);
            this.ticketPanel.Controls.Add(this.qnLbl);
            this.ticketPanel.Controls.Add(this.queueNumber);
            this.ticketPanel.Controls.Add(this.pictureBox1);
            this.ticketPanel.Location = new System.Drawing.Point(712, 372);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(500, 500);
            this.ticketPanel.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // queueNumber
            // 
            this.queueNumber.AutoSize = true;
            this.queueNumber.BackColor = System.Drawing.Color.White;
            this.queueNumber.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber.Location = new System.Drawing.Point(211, 35);
            this.queueNumber.Name = "queueNumber";
            this.queueNumber.Size = new System.Drawing.Size(69, 80);
            this.queueNumber.TabIndex = 1;
            this.queueNumber.Text = "#";
            // 
            // qnLbl
            // 
            this.qnLbl.AutoSize = true;
            this.qnLbl.BackColor = System.Drawing.Color.White;
            this.qnLbl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qnLbl.Location = new System.Drawing.Point(110, 130);
            this.qnLbl.Name = "qnLbl";
            this.qnLbl.Size = new System.Drawing.Size(263, 46);
            this.qnLbl.TabIndex = 2;
            this.qnLbl.Text = "Queue Number";
            // 
            // cLbl
            // 
            this.cLbl.AutoSize = true;
            this.cLbl.BackColor = System.Drawing.Color.White;
            this.cLbl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.Location = new System.Drawing.Point(110, 190);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(142, 46);
            this.cLbl.TabIndex = 14;
            this.cLbl.Text = "Cashier";
            // 
            // cashierNumber
            // 
            this.cashierNumber.AutoSize = true;
            this.cashierNumber.BackColor = System.Drawing.Color.White;
            this.cashierNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber.Location = new System.Drawing.Point(240, 190);
            this.cashierNumber.Name = "cashierNumber";
            this.cashierNumber.Size = new System.Drawing.Size(40, 46);
            this.cashierNumber.TabIndex = 15;
            this.cashierNumber.Text = "#";
            // 
            // serviceType
            // 
            this.serviceType.AutoSize = true;
            this.serviceType.BackColor = System.Drawing.Color.White;
            this.serviceType.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType.Location = new System.Drawing.Point(296, 310);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(122, 46);
            this.serviceType.TabIndex = 16;
            this.serviceType.Text = "??????";
            // 
            // serviceLane
            // 
            this.serviceLane.AutoSize = true;
            this.serviceLane.BackColor = System.Drawing.Color.White;
            this.serviceLane.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane.Location = new System.Drawing.Point(70, 310);
            this.serviceLane.Name = "serviceLane";
            this.serviceLane.Size = new System.Drawing.Size(122, 46);
            this.serviceLane.TabIndex = 17;
            this.serviceLane.Text = "??????";
            // 
            // edLbl
            // 
            this.edLbl.AutoSize = true;
            this.edLbl.BackColor = System.Drawing.Color.White;
            this.edLbl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLbl.Location = new System.Drawing.Point(74, 395);
            this.edLbl.Name = "edLbl";
            this.edLbl.Size = new System.Drawing.Size(209, 34);
            this.edLbl.TabIndex = 18;
            this.edLbl.Text = "Expiration Date:";
            // 
            // expirationDate
            // 
            this.expirationDate.AutoSize = true;
            this.expirationDate.BackColor = System.Drawing.Color.White;
            this.expirationDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate.Location = new System.Drawing.Point(300, 395);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(122, 34);
            this.expirationDate.TabIndex = 19;
            this.expirationDate.Text = "?/??/????";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(830, 975);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(300, 70);
            this.confirmBtn.TabIndex = 12;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // TicketForm4_1NormalTicketPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketPanel);
            this.Controls.Add(this.confirmBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm4_1NormalTicketPrinting";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm4_1NormalTicketPrinting_Load);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private CircularButton confirmBtn;
        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label queueNumber;
        private System.Windows.Forms.Label serviceType;
        private System.Windows.Forms.Label cashierNumber;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.Label qnLbl;
        private System.Windows.Forms.Label serviceLane;
        private System.Windows.Forms.Label expirationDate;
        private System.Windows.Forms.Label edLbl;
    }
}