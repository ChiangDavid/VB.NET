namespace Final
{
    partial class Final
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnGCDLCD = new System.Windows.Forms.Button();
            this.btnPrime = new System.Windows.Forms.Button();
            this.btnFib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(82, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(193, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome To Calculator Section Menu!!";
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(31, 81);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(105, 49);
            this.btnBasic.TabIndex = 1;
            this.btnBasic.Text = "Basic Calculator";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnGCDLCD
            // 
            this.btnGCDLCD.Location = new System.Drawing.Point(199, 81);
            this.btnGCDLCD.Name = "btnGCDLCD";
            this.btnGCDLCD.Size = new System.Drawing.Size(105, 49);
            this.btnGCDLCD.TabIndex = 2;
            this.btnGCDLCD.Text = "GCD/LCD";
            this.btnGCDLCD.UseVisualStyleBackColor = true;
            this.btnGCDLCD.Click += new System.EventHandler(this.btnGCDLCD_Click);
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(31, 174);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(105, 49);
            this.btnPrime.TabIndex = 3;
            this.btnPrime.Text = "Prime Checker";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(199, 174);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(105, 49);
            this.btnFib.TabIndex = 4;
            this.btnFib.Text = "Fibonacci Generator";
            this.btnFib.UseVisualStyleBackColor = true;
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.btnFib);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.btnGCDLCD);
            this.Controls.Add(this.btnBasic);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 300);
            this.Name = "Final";
            this.Text = "Calculator Selection Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Final_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnGCDLCD;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.Button btnFib;
    }
}

