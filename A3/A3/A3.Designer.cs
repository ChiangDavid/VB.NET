namespace A3
{
    partial class A3
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
            this.btQuit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.lbNumber1 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.lbNumber2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btplus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.btLarger = new System.Windows.Forms.Button();
            this.btSmaller = new System.Windows.Forms.Button();
            this.btNotEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(510, 12);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 0;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(510, 41);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbNumber1
            // 
            this.lbNumber1.AutoSize = true;
            this.lbNumber1.Location = new System.Drawing.Point(12, 25);
            this.lbNumber1.Name = "lbNumber1";
            this.lbNumber1.Size = new System.Drawing.Size(56, 13);
            this.lbNumber1.TabIndex = 2;
            this.lbNumber1.Text = "Number 1:";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(74, 22);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(404, 20);
            this.tbNumber1.TabIndex = 3;
            this.tbNumber1.Leave += new System.EventHandler(this.tbNumber1_Leave);
            this.tbNumber1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumber1_MouseDown);
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(74, 68);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(404, 20);
            this.tbNumber2.TabIndex = 4;
            this.tbNumber2.Leave += new System.EventHandler(this.tbNumber2_Leave_1);
            this.tbNumber2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumber2_MouseDown);
            // 
            // lbNumber2
            // 
            this.lbNumber2.AutoSize = true;
            this.lbNumber2.Location = new System.Drawing.Point(12, 71);
            this.lbNumber2.Name = "lbNumber2";
            this.lbNumber2.Size = new System.Drawing.Size(56, 13);
            this.lbNumber2.TabIndex = 5;
            this.lbNumber2.Text = "Number 2:";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(28, 110);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(40, 13);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "Result:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(74, 107);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(404, 20);
            this.tbResult.TabIndex = 7;
            // 
            // btplus
            // 
            this.btplus.Location = new System.Drawing.Point(31, 153);
            this.btplus.Name = "btplus";
            this.btplus.Size = new System.Drawing.Size(91, 23);
            this.btplus.TabIndex = 8;
            this.btplus.Text = "＋";
            this.btplus.UseVisualStyleBackColor = true;
            this.btplus.Click += new System.EventHandler(this.btplus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(159, 153);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(91, 23);
            this.btMinus.TabIndex = 9;
            this.btMinus.Text = "一";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(278, 153);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(91, 23);
            this.btMul.TabIndex = 10;
            this.btMul.Text = "Ｘ";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(387, 153);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(91, 23);
            this.btDiv.TabIndex = 11;
            this.btDiv.Text = "／";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btEqual
            // 
            this.btEqual.Location = new System.Drawing.Point(31, 217);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(91, 23);
            this.btEqual.TabIndex = 12;
            this.btEqual.Text = "Equal?";
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // btLarger
            // 
            this.btLarger.Location = new System.Drawing.Point(159, 217);
            this.btLarger.Name = "btLarger";
            this.btLarger.Size = new System.Drawing.Size(91, 23);
            this.btLarger.TabIndex = 13;
            this.btLarger.Text = "Larger?";
            this.btLarger.UseVisualStyleBackColor = true;
            this.btLarger.Click += new System.EventHandler(this.btLarger_Click);
            // 
            // btSmaller
            // 
            this.btSmaller.Location = new System.Drawing.Point(278, 217);
            this.btSmaller.Name = "btSmaller";
            this.btSmaller.Size = new System.Drawing.Size(91, 23);
            this.btSmaller.TabIndex = 14;
            this.btSmaller.Text = "Smaller?";
            this.btSmaller.UseVisualStyleBackColor = true;
            this.btSmaller.Click += new System.EventHandler(this.btSmaller_Click);
            // 
            // btNotEqual
            // 
            this.btNotEqual.Location = new System.Drawing.Point(387, 217);
            this.btNotEqual.Name = "btNotEqual";
            this.btNotEqual.Size = new System.Drawing.Size(91, 23);
            this.btNotEqual.TabIndex = 15;
            this.btNotEqual.Text = "NotEqual?";
            this.btNotEqual.UseVisualStyleBackColor = true;
            this.btNotEqual.Click += new System.EventHandler(this.btNotEqual_Click);
            // 
            // A3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.btNotEqual);
            this.Controls.Add(this.btSmaller);
            this.Controls.Add(this.btLarger);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btplus);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbNumber2);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lbNumber1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btQuit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(613, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(613, 300);
            this.Name = "A3";
            this.Text = "A3 Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.A3_FormClosing);
            this.Load += new System.EventHandler(this.A3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label lbNumber1;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Label lbNumber2;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btplus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btLarger;
        private System.Windows.Forms.Button btSmaller;
        private System.Windows.Forms.Button btNotEqual;
    }
}

