using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1
{
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
           //Show the open file dialog box
            if (DialogOpenPicture.ShowDialog() == DialogResult.OK)
            {
                // Load the picture into the picture box
                PictureBox.Image = Image.FromFile(DialogOpenPicture.FileName);
                // Show the name of the file in the form’s caption
                this.Text = string.Concat("A1 Buffet(" + DialogOpenPicture.FileName + ")");
            }
        }
        //Just close the program when you click the Quit buttom
        private void QuitProgram_Click(object sender, EventArgs e)
        {
            //Close function
            this.Close();
        }
        //This function will draw the border that you created
        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            //Create an instance of an objectdrawborder and assign to null
            Graphics objDrawBorder = null;
            //Add a method to this instance of our object
            objDrawBorder = this.CreateGraphics();
            //Need to clear the form color and replace it with whatever Windows is currently using for System Colors
            objDrawBorder.Clear(SystemColors.Control);
            //We draw the rectangle
            objDrawBorder.DrawRectangle(Pens.Coral, PictureBox.Left - 1, PictureBox.Top - 1, PictureBox.Width + 1, PictureBox.Height + 1);
            //We have to releasing any resource once the method is complete
            objDrawBorder.Dispose();
        }
        //The Enlarge function each time will add 10 to width and height
        private void btnLarge_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 10;
            this.Height = this.Height + 10;
        }
        //The Shrink function each time will add 10 to width and height
        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 10;
            this.Height = this.Height - 10;
        }
        //set the even handler related to the picture box
        //When the mouse move inside the picture box, it will track the X and Y cordinate
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            LabelX.Text = "X: " + e.X.ToString();
            LabelY.Text = "Y: " + e.Y.ToString();
        }
        //When the mouse move outside the picture box, it will show N/A means that the mouse is not in box, and not able to track the mouse location
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            LabelX.Text = "X: N/A";
            LabelY.Text = "Y: N/A";
        }

    }
}
