namespace DLSLQueueingApp
{
    partial class Page4
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
            this.page4BackBtn = new System.Windows.Forms.Button();
            this.page4OthersBtn = new DLSLQueueingApp.CircularButton();
            this.page4CollegeBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // page4BackBtn
            // 
            this.page4BackBtn.FlatAppearance.BorderSize = 0;
            this.page4BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page4BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page4BackBtn.ForeColor = System.Drawing.Color.White;
            this.page4BackBtn.Location = new System.Drawing.Point(135, 35);
            this.page4BackBtn.Name = "page4BackBtn";
            this.page4BackBtn.Size = new System.Drawing.Size(230, 84);
            this.page4BackBtn.TabIndex = 9;
            this.page4BackBtn.Text = "⮜- BACK";
            this.page4BackBtn.UseVisualStyleBackColor = true;
            this.page4BackBtn.Click += new System.EventHandler(this.page4BackBtn_Click);
            // 
            // page4OthersBtn
            // 
            this.page4OthersBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page4OthersBtn.ForeColor = System.Drawing.Color.White;
            this.page4OthersBtn.Location = new System.Drawing.Point(500, 383);
            this.page4OthersBtn.Name = "page4OthersBtn";
            this.page4OthersBtn.Size = new System.Drawing.Size(900, 180);
            this.page4OthersBtn.TabIndex = 11;
            this.page4OthersBtn.Text = "OTHERS";
            this.page4OthersBtn.UseVisualStyleBackColor = true;
            // 
            // page4CollegeBtn
            // 
            this.page4CollegeBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page4CollegeBtn.ForeColor = System.Drawing.Color.White;
            this.page4CollegeBtn.Location = new System.Drawing.Point(500, 143);
            this.page4CollegeBtn.Name = "page4CollegeBtn";
            this.page4CollegeBtn.Size = new System.Drawing.Size(900, 180);
            this.page4CollegeBtn.TabIndex = 10;
            this.page4CollegeBtn.Text = "COLLEGE";
            this.page4CollegeBtn.UseVisualStyleBackColor = true;
            this.page4CollegeBtn.Click += new System.EventHandler(this.collegeBtn_Click);
            // 
            // Page4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.page4OthersBtn);
            this.Controls.Add(this.page4CollegeBtn);
            this.Controls.Add(this.page4BackBtn);
            this.Name = "Page4";
            this.Size = new System.Drawing.Size(1897, 608);
            this.Load += new System.EventHandler(this.Page4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button page4BackBtn;
        private CircularButton page4CollegeBtn;
        private CircularButton page4OthersBtn;
    }
}
