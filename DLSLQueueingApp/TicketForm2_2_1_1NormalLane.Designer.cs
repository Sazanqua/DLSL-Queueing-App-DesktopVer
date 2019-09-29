namespace DLSLQueueingApp
{
    partial class TicketForm2_2_1_1NormalLane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm2_2_1_1NormalLane));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketForm2_2_1_1BackBtn = new System.Windows.Forms.Button();
            this.ticketForm2_2_1_1CollegeBtn = new DLSLQueueingApp.CircularButton();
            this.ticketForm2_2_1_1OthersBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ticketForm2_2_1_1BackBtn
            // 
            this.ticketForm2_2_1_1BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm2_2_1_1BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm2_2_1_1BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_1BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_1BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm2_2_1_1BackBtn.Name = "ticketForm2_2_1_1BackBtn";
            this.ticketForm2_2_1_1BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm2_2_1_1BackBtn.TabIndex = 13;
            this.ticketForm2_2_1_1BackBtn.Text = "⮜- BACK";
            this.ticketForm2_2_1_1BackBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_1BackBtn.Click += new System.EventHandler(this.ticketForm2_2_1_1BackBtn_Click);
            // 
            // ticketForm2_2_1_1CollegeBtn
            // 
            this.ticketForm2_2_1_1CollegeBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_1CollegeBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_1CollegeBtn.Location = new System.Drawing.Point(500, 550);
            this.ticketForm2_2_1_1CollegeBtn.Name = "ticketForm2_2_1_1CollegeBtn";
            this.ticketForm2_2_1_1CollegeBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm2_2_1_1CollegeBtn.TabIndex = 14;
            this.ticketForm2_2_1_1CollegeBtn.Text = "COLLEGE";
            this.ticketForm2_2_1_1CollegeBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_1CollegeBtn.Click += new System.EventHandler(this.ticketForm2_2_1_1CollegeBtn_Click);
            // 
            // ticketForm2_2_1_1OthersBtn
            // 
            this.ticketForm2_2_1_1OthersBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2_1_1OthersBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2_1_1OthersBtn.Location = new System.Drawing.Point(500, 800);
            this.ticketForm2_2_1_1OthersBtn.Name = "ticketForm2_2_1_1OthersBtn";
            this.ticketForm2_2_1_1OthersBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm2_2_1_1OthersBtn.TabIndex = 15;
            this.ticketForm2_2_1_1OthersBtn.Text = "OTHERS";
            this.ticketForm2_2_1_1OthersBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_2_1_1OthersBtn.Click += new System.EventHandler(this.ticketForm2_2_1_1OthersBtn_Click);
            // 
            // TicketForm2_2_1_1NormalLane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketForm2_2_1_1OthersBtn);
            this.Controls.Add(this.ticketForm2_2_1_1CollegeBtn);
            this.Controls.Add(this.ticketForm2_2_1_1BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm2_2_1_1NormalLane";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm2_2_1_1NormalLane_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button ticketForm2_2_1_1BackBtn;
        private CircularButton ticketForm2_2_1_1CollegeBtn;
        private CircularButton ticketForm2_2_1_1OthersBtn;
    }
}