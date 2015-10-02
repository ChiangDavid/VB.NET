namespace Final
{
    partial class Basic
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
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnLarger = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(67, 83);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(404, 20);
            this.tbResult.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(21, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result:";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(5, 50);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(56, 13);
            this.lblNumber2.TabIndex = 11;
            this.lblNumber2.Text = "Number 2:";
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(67, 47);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(404, 20);
            this.tbNumber2.TabIndex = 10;
            this.tbNumber2.Leave += new System.EventHandler(this.tbNumber2_Leave);
            this.tbNumber2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumber2_MouseDown);
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(67, 12);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(404, 20);
            this.tbNumber1.TabIndex = 9;
            this.tbNumber1.Leave += new System.EventHandler(this.tbNumber1_Leave);
            this.tbNumber1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNumber1_MouseDown);
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(5, 15);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(56, 13);
            this.lblNumber1.TabIndex = 8;
            this.lblNumber1.Text = "Number 1:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(496, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(496, 15);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Location = new System.Drawing.Point(392, 190);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(91, 23);
            this.btnNotEqual.TabIndex = 23;
            this.btnNotEqual.Text = "NotEqual?";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(283, 190);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(91, 23);
            this.btnSmaller.TabIndex = 22;
            this.btnSmaller.Text = "Smaller?";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btnLarger
            // 
            this.btnLarger.Location = new System.Drawing.Point(164, 190);
            this.btnLarger.Name = "btnLarger";
            this.btnLarger.Size = new System.Drawing.Size(91, 23);
            this.btnLarger.TabIndex = 21;
            this.btnLarger.Text = "Larger?";
            this.btnLarger.UseVisualStyleBackColor = true;
            this.btnLarger.Click += new System.EventHandler(this.btnLarger_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(36, 190);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(91, 23);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "Equal?";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(392, 126);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(91, 23);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Text = "／";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(283, 126);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(91, 23);
            this.btnMul.TabIndex = 18;
            this.btnMul.Text = "Ｘ";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(164, 126);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(91, 23);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "一";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(36, 126);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(91, 23);
            this.btnplus.TabIndex = 16;
            this.btnplus.Text = "＋";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 235);
            this.Controls.Add(this.btnNotEqual);
            this.Controls.Add(this.btnSmaller);
            this.Controls.Add(this.btnLarger);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.lblNumber1);
            this.MaximumSize = new System.Drawing.Size(611, 274);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(611, 274);
            this.Name = "Basic";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Basic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnLarger;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnplus;
    }
}