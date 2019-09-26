namespace DLSLQueueingApp
{
    partial class MonitorUserControl4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cashierLabel = new System.Windows.Forms.Label();
            this.queueNumber = new System.Windows.Forms.Label();
            this.queueType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cashier";
            // 
            // cashierLabel
            // 
            this.cashierLabel.AutoSize = true;
            this.cashierLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLabel.Location = new System.Drawing.Point(300, 10);
            this.cashierLabel.Name = "cashierLabel";
            this.cashierLabel.Size = new System.Drawing.Size(59, 68);
            this.cashierLabel.TabIndex = 4;
            this.cashierLabel.Text = "#";
            // 
            // queueNumber
            // 
            this.queueNumber.AutoSize = true;
            this.queueNumber.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber.Location = new System.Drawing.Point(110, 120);
            this.queueNumber.Name = "queueNumber";
            this.queueNumber.Size = new System.Drawing.Size(98, 114);
            this.queueNumber.TabIndex = 5;
            this.queueNumber.Text = "#";
            // 
            // queueType
            // 
            this.queueType.AutoSize = true;
            this.queueType.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueType.Location = new System.Drawing.Point(120, 270);
            this.queueType.Name = "queueType";
            this.queueType.Size = new System.Drawing.Size(151, 57);
            this.queueType.TabIndex = 6;
            this.queueType.Text = "TYPE";
            // 
            // MonitorUserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queueType);
            this.Controls.Add(this.queueNumber);
            this.Controls.Add(this.cashierLabel);
            this.Controls.Add(this.label1);
            this.Name = "MonitorUserControl4";
            this.Size = new System.Drawing.Size(445, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierLabel;
        private System.Windows.Forms.Label queueNumber;
        private System.Windows.Forms.Label queueType;
    }
}
