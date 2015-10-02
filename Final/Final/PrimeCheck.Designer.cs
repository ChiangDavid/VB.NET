namespace Final
{
    partial class PrimeCheck
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(162, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 16);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number:";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(56, 13);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(100, 20);
            this.txbInput.TabIndex = 2;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(243, 13);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(170, 20);
            this.txbResult.TabIndex = 3;
            // 
            // PrimeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 44);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCheck);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 83);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 83);
            this.Name = "PrimeCheck";
            this.Text = "PrimeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.TextBox txbResult;
    }
}