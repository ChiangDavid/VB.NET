namespace Final
{
    partial class GCDLCD
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
            this.lblInteger1 = new System.Windows.Forms.Label();
            this.txbInteger1 = new System.Windows.Forms.TextBox();
            this.txbInteger2 = new System.Windows.Forms.TextBox();
            this.lblInteger2 = new System.Windows.Forms.Label();
            this.txbGCD = new System.Windows.Forms.TextBox();
            this.lblGCD = new System.Windows.Forms.Label();
            this.txbLCD = new System.Windows.Forms.TextBox();
            this.lblLCD = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInteger1
            // 
            this.lblInteger1.AutoSize = true;
            this.lblInteger1.Location = new System.Drawing.Point(40, 9);
            this.lblInteger1.Name = "lblInteger1";
            this.lblInteger1.Size = new System.Drawing.Size(65, 13);
            this.lblInteger1.TabIndex = 0;
            this.lblInteger1.Text = "First Integer:";
            // 
            // txbInteger1
            // 
            this.txbInteger1.Location = new System.Drawing.Point(129, 6);
            this.txbInteger1.Name = "txbInteger1";
            this.txbInteger1.Size = new System.Drawing.Size(100, 20);
            this.txbInteger1.TabIndex = 1;
            // 
            // txbInteger2
            // 
            this.txbInteger2.Location = new System.Drawing.Point(409, 6);
            this.txbInteger2.Name = "txbInteger2";
            this.txbInteger2.Size = new System.Drawing.Size(100, 20);
            this.txbInteger2.TabIndex = 3;
            // 
            // lblInteger2
            // 
            this.lblInteger2.AutoSize = true;
            this.lblInteger2.Location = new System.Drawing.Point(320, 9);
            this.lblInteger2.Name = "lblInteger2";
            this.lblInteger2.Size = new System.Drawing.Size(83, 13);
            this.lblInteger2.TabIndex = 2;
            this.lblInteger2.Text = "Second Integer:";
            // 
            // txbGCD
            // 
            this.txbGCD.Location = new System.Drawing.Point(129, 90);
            this.txbGCD.Name = "txbGCD";
            this.txbGCD.Size = new System.Drawing.Size(100, 20);
            this.txbGCD.TabIndex = 5;
            // 
            // lblGCD
            // 
            this.lblGCD.AutoSize = true;
            this.lblGCD.Location = new System.Drawing.Point(-1, 93);
            this.lblGCD.Name = "lblGCD";
            this.lblGCD.Size = new System.Drawing.Size(124, 13);
            this.lblGCD.TabIndex = 4;
            this.lblGCD.Text = "Greater Common Divisor:";
            // 
            // txbLCD
            // 
            this.txbLCD.Location = new System.Drawing.Point(409, 90);
            this.txbLCD.Name = "txbLCD";
            this.txbLCD.Size = new System.Drawing.Size(100, 20);
            this.txbLCD.TabIndex = 7;
            // 
            // lblLCD
            // 
            this.lblLCD.AutoSize = true;
            this.lblLCD.Location = new System.Drawing.Point(260, 93);
            this.lblLCD.Name = "lblLCD";
            this.lblLCD.Size = new System.Drawing.Size(143, 13);
            this.lblLCD.TabIndex = 6;
            this.lblLCD.Text = "Least Common Denominator:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 45);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(494, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate Result";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // GCDLCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 115);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbLCD);
            this.Controls.Add(this.lblLCD);
            this.Controls.Add(this.txbGCD);
            this.Controls.Add(this.lblGCD);
            this.Controls.Add(this.txbInteger2);
            this.Controls.Add(this.lblInteger2);
            this.Controls.Add(this.txbInteger1);
            this.Controls.Add(this.lblInteger1);
            this.Location = new System.Drawing.Point(549, 154);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 154);
            this.MinimizeBox = false;
            this.Name = "GCDLCD";
            this.Text = "GCDLCD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInteger1;
        private System.Windows.Forms.TextBox txbInteger1;
        private System.Windows.Forms.TextBox txbInteger2;
        private System.Windows.Forms.Label lblInteger2;
        private System.Windows.Forms.TextBox txbGCD;
        private System.Windows.Forms.Label lblGCD;
        private System.Windows.Forms.TextBox txbLCD;
        private System.Windows.Forms.Label lblLCD;
        private System.Windows.Forms.Button btnCalculate;
    }
}