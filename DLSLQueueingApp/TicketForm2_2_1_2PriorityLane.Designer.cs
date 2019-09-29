namespace DLSLQueueingApp
{
    partial class TicketForm2_2_1_2PriorityLane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm2_2_1_2PriorityLane));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketForm2_2_1_2BackBtn = new System.Windows.Forms.Button();
            this.ticketForm2_2_1_2CollegeBtn = new DLSLQueueingApp.CircularButton();
            this.ticketForm2_2_1_2OthersBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ticketForm2_2_1_2BackBtn
            // 
            this.ticketForm2_2_1_2BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm2_2_1_2BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm2_2_1_2BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_2BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_2BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm2_2_1_2BackBtn.Name = "ticketForm2_2_1_2BackBtn";
            this.ticketForm2_2_1_2BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm2_2_1_2BackBtn.TabIndex = 14;
            this.ticketForm2_2_1_2BackBtn.Text = "⮜- BACK";
            this.ticketForm2_2_1_2BackBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_2BackBtn.Click += new System.EventHandler(this.ticketForm2_2_1_2BackBtn_Click);
            // 
            // ticketForm2_2_1_2CollegeBtn
            // 
            this.ticketForm2_2_1_2CollegeBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_2CollegeBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_2CollegeBtn.Location = new System.Drawing.Point(500, 550);
            this.ticketForm2_2_1_2CollegeBtn.Name = "ticketForm2_2_1_2CollegeBtn";
            this.ticketForm2_2_1_2CollegeBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm2_2_1_2CollegeBtn.TabIndex = 15;
            this.ticketForm2_2_1_2CollegeBtn.Text = "COLLEGE";
            this.ticketForm2_2_1_2CollegeBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_2CollegeBtn.Click += new System.EventHandler(this.ticketForm2_2_1_2CollegeBtn_Click);
            // 
            // ticketForm2_2_1_2OthersBtn
            // 
            this.ticketForm2_2_1_2OthersBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_2OthersBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_2OthersBtn.Location = new System.Drawing.Point(500, 800);
            this.ticketForm2_2_1_2OthersBtn.Name = "ticketForm2_2_1_2OthersBtn";
            this.ticketForm2_2_1_2OthersBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm2_2_1_2OthersBtn.TabIndex = 16;
            this.ticketForm2_2_1_2OthersBtn.Text = "OTHERS";
            this.ticketForm2_2_1_2OthersBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_2OthersBtn.Click += new System.EventHandler(this.ticketForm2_2_1_2OthersBtn_Click);
            // 
            // TicketForm2_2_1_2PriorityLane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketForm2_2_1_2OthersBtn);
            this.Controls.Add(this.ticketForm2_2_1_2CollegeBtn);
            this.Controls.Add(this.ticketForm2_2_1_2BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm2_2_1_2PriorityLane";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm2_2_1_2PriorityLane_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button ticketForm2_2_1_2BackBtn;
        private CircularButton ticketForm2_2_1_2CollegeBtn;
        private CircularButton ticketForm2_2_1_2OthersBtn;
    }
}