namespace DLSLQueueingApp
{
    partial class Page3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page3));
            this.page3BackBtn = new System.Windows.Forms.Button();
            this.normalLaneBtn = new DLSLQueueingApp.CircularButton();
            this.priorityLaneBtn = new DLSLQueueingApp.CircularButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // page3BackBtn
            // 
            this.page3BackBtn.FlatAppearance.BorderSize = 0;
            this.page3BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page3BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page3BackBtn.ForeColor = System.Drawing.Color.White;
            this.page3BackBtn.Location = new System.Drawing.Point(135, 35);
            this.page3BackBtn.Name = "page3BackBtn";
            this.page3BackBtn.Size = new System.Drawing.Size(230, 84);
            this.page3BackBtn.TabIndex = 8;
            this.page3BackBtn.Text = "⮜- BACK";
            this.page3BackBtn.UseVisualStyleBackColor = true;
            this.page3BackBtn.Click += new System.EventHandler(this.page3BackBtn_Click_1);
            // 
            // normalLaneBtn
            // 
            this.normalLaneBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalLaneBtn.ForeColor = System.Drawing.Color.White;
            this.normalLaneBtn.Location = new System.Drawing.Point(500, 63);
            this.normalLaneBtn.Name = "normalLaneBtn";
            this.normalLaneBtn.Size = new System.Drawing.Size(900, 110);
            this.normalLaneBtn.TabIndex = 6;
            this.normalLaneBtn.Text = "NORMAL LANE";
            this.normalLaneBtn.UseVisualStyleBackColor = true;
            this.normalLaneBtn.Click += new System.EventHandler(this.normalLaneBtn_Click);
            // 
            // priorityLaneBtn
            // 
            this.priorityLaneBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLaneBtn.ForeColor = System.Drawing.Color.White;
            this.priorityLaneBtn.Location = new System.Drawing.Point(500, 203);
            this.priorityLaneBtn.Name = "priorityLaneBtn";
            this.priorityLaneBtn.Size = new System.Drawing.Size(900, 110);
            this.priorityLaneBtn.TabIndex = 5;
            this.priorityLaneBtn.Text = "PRIORITY LANE";
            this.priorityLaneBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(600, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Priority Lane is for:";
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.page3BackBtn);
            this.Controls.Add(this.normalLaneBtn);
            this.Controls.Add(this.priorityLaneBtn);
            this.Name = "Page3";
            this.Size = new System.Drawing.Size(1897, 608);
            this.Load += new System.EventHandler(this.Page3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularButton normalLaneBtn;
        private CircularButton priorityLaneBtn;
        private System.Windows.Forms.Button page3BackBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
