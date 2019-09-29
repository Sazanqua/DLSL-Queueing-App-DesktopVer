namespace DLSLQueueingApp
{
    partial class TicketForm3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm3_1));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketForm3_1CollegeBtn = new DLSLQueueingApp.CircularButton();
            this.ticketForm3_1BackBtn = new System.Windows.Forms.Button();
            this.ticketForm3_1OthersBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ticketForm3_1CollegeBtn
            // 
            this.ticketForm3_1CollegeBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_1CollegeBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_1CollegeBtn.Location = new System.Drawing.Point(500, 550);
            this.ticketForm3_1CollegeBtn.Name = "ticketForm3_1CollegeBtn";
            this.ticketForm3_1CollegeBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm3_1CollegeBtn.TabIndex = 11;
            this.ticketForm3_1CollegeBtn.Text = "COLLEGE";
            this.ticketForm3_1CollegeBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_1CollegeBtn.Click += new System.EventHandler(this.ticketForm3_1CollegeBtn_Click);
            // 
            // ticketForm3_1BackBtn
            // 
            this.ticketForm3_1BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm3_1BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm3_1BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_1BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_1BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm3_1BackBtn.Name = "ticketForm3_1BackBtn";
            this.ticketForm3_1BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm3_1BackBtn.TabIndex = 12;
            this.ticketForm3_1BackBtn.Text = "⮜- BACK";
            this.ticketForm3_1BackBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_1BackBtn.Click += new System.EventHandler(this.ticketForm3_1BackBtn_Click);
            // 
            // ticketForm3_1OthersBtn
            // 
            this.ticketForm3_1OthersBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm3_1OthersBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm3_1OthersBtn.Location = new System.Drawing.Point(500, 800);
            this.ticketForm3_1OthersBtn.Name = "ticketForm3_1OthersBtn";
            this.ticketForm3_1OthersBtn.Size = new System.Drawing.Size(900, 180);
            this.ticketForm3_1OthersBtn.TabIndex = 13;
            this.ticketForm3_1OthersBtn.Text = "OTHERS";
            this.ticketForm3_1OthersBtn.UseVisualStyleBackColor = true;
            this.ticketForm3_1OthersBtn.Click += new System.EventHandler(this.ticketForm3_1OthersBtn_Click);
            // 
            // TicketForm3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketForm3_1OthersBtn);
            this.Controls.Add(this.ticketForm3_1BackBtn);
            this.Controls.Add(this.ticketForm3_1CollegeBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm3_1";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm3_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private CircularButton ticketForm3_1CollegeBtn;
        private System.Windows.Forms.Button ticketForm3_1BackBtn;
        private CircularButton ticketForm3_1OthersBtn;
    }
}