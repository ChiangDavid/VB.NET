namespace Final
{
    partial class Fibonacci
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
            this.txbLength = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.listAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(13, 13);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(100, 20);
            this.txbLength.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.Location = new System.Drawing.Point(130, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Run";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // listAll
            // 
            this.listAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAll.FormattingEnabled = true;
            this.listAll.Location = new System.Drawing.Point(13, 39);
            this.listAll.Name = "listAll";
            this.listAll.Size = new System.Drawing.Size(192, 173);
            this.listAll.TabIndex = 2;
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 216);
            this.Controls.Add(this.listAll);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbLength);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(237, 255);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(237, 255);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Fibonacci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listAll;
    }
}