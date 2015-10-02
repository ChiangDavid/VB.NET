/**********************************************************
*Calculator Menu.cs
*
* Implementing the calculator menu for the user to choose which mathmatic operation he or she wants to perform
* Author: David Chiang
* Date Created: 12/8/14
* Last Modified by: David Chiang
* Date Last Modified: 12/12/14
* Assignment: Final Project
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            Basic BasicDialog = new Basic();
            BasicDialog.Show();
        }
        //When you trying to close the form, it will ask you if you really want to close the program or not
        //YES --> Close the math calculator selection menu
        //NO --> Return to the math calculator selection menu
        private void Final_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You really want to close the program?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnGCDLCD_Click(object sender, EventArgs e)
        {
            GCDLCD GCDLCDDialog = new GCDLCD();
            GCDLCDDialog.Show();
        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            PrimeCheck PrimeCheckDialog = new PrimeCheck();
            PrimeCheckDialog.Show();
        }

        private void btnFib_Click(object sender, EventArgs e)
        {
            Fibonacci FibonacciDialog = new Fibonacci();
            FibonacciDialog.Show();
        }
    }
}
