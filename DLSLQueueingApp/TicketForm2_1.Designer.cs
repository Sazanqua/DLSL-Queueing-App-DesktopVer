namespace DLSLQueueingApp
{
    partial class TicketForm2_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm2_1));
            this.ticketForm2_1BackBtn = new System.Windows.Forms.Button();
            this.normalLaneBtn = new DLSLQueueingApp.CircularButton();
            this.priorityLaneBtn = new DLSLQueueingApp.CircularButton();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.pblbl = new System.Windows.Forms.Label();
            this.priorityLanePb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.priorityLanePb)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketForm2_1BackBtn
            // 
            this.ticketForm2_1BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm2_1BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm2_1BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_1BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_1BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm2_1BackBtn.Name = "ticketForm2_1BackBtn";
            this.ticketForm2_1BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm2_1BackBtn.TabIndex = 9;
            this.ticketForm2_1BackBtn.Text = "⮜- BACK";
            this.ticketForm2_1BackBtn.UseVisualStyleBackColor = true;
            this.ticketForm2_1BackBtn.Click += new System.EventHandler(this.ticketForm2BackBtn_Click);
            // 
            // normalLaneBtn
            // 
            this.normalLaneBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalLaneBtn.ForeColor = System.Drawing.Color.White;
            this.normalLaneBtn.Location = new System.Drawing.Point(500, 500);
            this.normalLaneBtn.Name = "normalLaneBtn";
            this.normalLaneBtn.Size = new System.Drawing.Size(900, 110);
            this.normalLaneBtn.TabIndex = 10;
            this.normalLaneBtn.Text = "REGULAR LANE";
            this.normalLaneBtn.UseVisualStyleBackColor = true;
            this.normalLaneBtn.Click += new System.EventHandler(this.normalLaneBtn_Click);
            // 
            // priorityLaneBtn
            // 
            this.priorityLaneBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLaneBtn.ForeColor = System.Drawing.Color.White;
            this.priorityLaneBtn.Location = new System.Drawing.Point(500, 650);
            this.priorityLaneBtn.Name = "priorityLaneBtn";
            this.priorityLaneBtn.Size = new System.Drawing.Size(900, 110);
            this.priorityLaneBtn.TabIndex = 11;
            this.priorityLaneBtn.Text = "PRIORITY LANE";
            this.priorityLaneBtn.UseVisualStyleBackColor = true;
            this.priorityLaneBtn.Click += new System.EventHandler(this.priorityLaneBtn_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // pblbl
            // 
            this.pblbl.AutoSize = true;
            this.pblbl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblbl.ForeColor = System.Drawing.Color.White;
            this.pblbl.Location = new System.Drawing.Point(225, 825);
            this.pblbl.Name = "pblbl";
            this.pblbl.Size = new System.Drawing.Size(328, 46);
            this.pblbl.TabIndex = 12;
            this.pblbl.Text = "Priority Lane is for:";
            // 
            // priorityLanePb
            // 
            this.priorityLanePb.Image = ((System.Drawing.Image)(resources.GetObject("priorityLanePb.Image")));
            this.priorityLanePb.Location = new System.Drawing.Point(500, 870);
            this.priorityLanePb.Name = "priorityLanePb";
            this.priorityLanePb.Size = new System.Drawing.Size(950, 230);
            this.priorityLanePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.priorityLanePb.TabIndex = 13;
            this.priorityLanePb.TabStop = false;
            // 
            // TicketForm2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.priorityLanePb);
            this.Controls.Add(this.pblbl);
            this.Controls.Add(this.priorityLaneBtn);
            this.Controls.Add(this.normalLaneBtn);
            this.Controls.Add(this.ticketForm2_1BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm2_1";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priorityLanePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ticketForm2_1BackBtn;
        private CircularButton normalLaneBtn;
        private CircularButton priorityLaneBtn;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Label pblbl;
        private System.Windows.Forms.PictureBox priorityLanePb;
    }
}