namespace A1
{
    partial class A1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A1));
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.QuitProgram = new System.Windows.Forms.Button();
            this.DialogOpenPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectPicture.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSelectPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicture.Location = new System.Drawing.Point(2, 328);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(99, 23);
            this.btnSelectPicture.TabIndex = 0;
            this.btnSelectPicture.Text = "Select Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(2, 7);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(470, 315);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // QuitProgram
            // 
            this.QuitProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuitProgram.BackColor = System.Drawing.Color.Crimson;
            this.QuitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitProgram.Location = new System.Drawing.Point(107, 328);
            this.QuitProgram.Name = "QuitProgram";
            this.QuitProgram.Size = new System.Drawing.Size(90, 23);
            this.QuitProgram.TabIndex = 2;
            this.QuitProgram.Text = "Quit";
            this.QuitProgram.UseVisualStyleBackColor = false;
            this.QuitProgram.Click += new System.EventHandler(this.QuitProgram_Click);
            // 
            // DialogOpenPicture
            // 
            this.DialogOpenPicture.Filter = "Windows Bitmaps|*.BMP|JPEG|*.JPG";
            this.DialogOpenPicture.Title = "Select Picture";
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDrawBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawBorder.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDrawBorder.Location = new System.Drawing.Point(203, 328);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(90, 23);
            this.btnDrawBorder.TabIndex = 6;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = true;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLarge.BackColor = System.Drawing.Color.Turquoise;
            this.btnLarge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLarge.BackgroundImage")));
            this.btnLarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLarge.Location = new System.Drawing.Point(409, 328);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(30, 26);
            this.btnLarge.TabIndex = 7;
            this.btnLarge.UseVisualStyleBackColor = false;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShrink.BackColor = System.Drawing.Color.Turquoise;
            this.btnShrink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShrink.BackgroundImage")));
            this.btnShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShrink.Location = new System.Drawing.Point(445, 328);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(30, 26);
            this.btnShrink.TabIndex = 8;
            this.btnShrink.UseVisualStyleBackColor = false;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // LabelX
            // 
            this.LabelX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(299, 333);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(53, 13);
            this.LabelX.TabIndex = 9;
            this.LabelX.Text = "X = N/A";
            // 
            // LabelY
            // 
            this.LabelY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelY.AutoSize = true;
            this.LabelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelY.Location = new System.Drawing.Point(350, 333);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(53, 13);
            this.LabelY.TabIndex = 10;
            this.LabelY.Text = "Y = N/A";
            // 
            // A1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 355);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.QuitProgram);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.btnSelectPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "A1";
            this.Text = "A1 Buffet";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button QuitProgram;
        private System.Windows.Forms.OpenFileDialog DialogOpenPicture;
        private System.Windows.Forms.Button btnDrawBorder;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Label LabelX;
        private System.Windows.Forms.Label LabelY;


    }
}

