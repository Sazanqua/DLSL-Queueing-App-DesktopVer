namespace DLSLQueueingApp
{
    partial class TicketForm3_2_PriorityLane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm3_2_PriorityLane));
            this.ticketForm3_2BackBtn = new System.Windows.Forms.Button();
            this.ticketForm3_2CollegeBtn = new DLSLQueueingApp.CircularButton();
            this.ticketForm3_2OthersBtn = new DLSLQueueingApp.CircularButton();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ticketForm3_2BackBtn
            // 
            this.ticketForm3_2BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm3_2BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm3_2BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_2BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_2BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm3_2BackBtn.Name = "ticketForm3_2BackBtn";
            this.ticketForm3_2BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm3_2BackBtn.TabIndex = 13;
            this.ticketForm3_2BackBtn.Text = "⮜- BACK";
            this.ticketForm3_2BackBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_2BackBtn.Click += new System.EventHandler(this.ticketForm3_2BackBtn_Click);
            // 
            // ticketForm3_2CollegeBtn
            // 
            this.ticketForm3_2CollegeBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_2CollegeBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_2CollegeBtn.Location = new System.Drawing.Point(500, 550);
            this.ticketForm3_2CollegeBtn.Name = "ticketForm3_2CollegeBtn";
            this.ticketForm3_2CollegeBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm3_2CollegeBtn.TabIndex = 14;
            this.ticketForm3_2CollegeBtn.Text = "COLLEGE";
            this.ticketForm3_2CollegeBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_2CollegeBtn.Click += new System.EventHandler(this.ticketForm3_2CollegeBtn_Click);
            // 
            // ticketForm3_2OthersBtn
            // 
            this.ticketForm3_2OthersBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_2OthersBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_2OthersBtn.Location = new System.Drawing.Point(500, 800);
            this.ticketForm3_2OthersBtn.Name = "ticketForm3_2OthersBtn";
            this.ticketForm3_2OthersBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm3_2OthersBtn.TabIndex = 15;
            this.ticketForm3_2OthersBtn.Text = "OTHERS";
            this.ticketForm3_2OthersBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_2OthersBtn.Click += new System.EventHandler(this.ticketForm3_2OthersBtn_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // TicketForm3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketForm3_2OthersBtn);
            this.Controls.Add(this.ticketForm3_2CollegeBtn);
            this.Controls.Add(this.ticketForm3_2BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm3_2";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm3_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ticketForm3_2BackBtn;
        private CircularButton ticketForm3_2CollegeBtn;
        private CircularButton ticketForm3_2OthersBtn;
        private System.Windows.Forms.Timer animationTimer;
    }
}