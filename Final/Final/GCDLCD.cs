/**********************************************************
*GCDLCD.cs
*
* Implementing the calculator for calculating the GCD and LCD
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
    public partial class GCDLCD : Form
    {
        public GCDLCD()
        {
            InitializeComponent();
        }
        //button click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //user input on textbox 1 for first integer string number into integer number
            int integer1 = Convert.ToInt32(txbInteger1.Text);
            //user input on textbox 1 for second integer string number into integer number
            int integer2 = Convert.ToInt32(txbInteger2.Text);
            //Use the math thinking,(a,b) = (b,r)
            //r = remainder of a%b
            for (int remainder = integer1 % integer2; remainder !=0;)
            {
                //store the integer 2 into integer 1
                integer1 = integer2;
                //assign remainder to integer 2
                integer2 = remainder;
                //then remainder = int 1 % int 2 and will get GCD
                remainder = integer1 % integer2;
            }
            //Create the gcd and int 2 assign to it
            int gcd = integer2;
            //print the GCD answer
            txbGCD.Text = gcd.ToString();
            //We want to get the LCD by using integer 1 times integer 2 and divide gcd and we will get the LCD
            int LCD = Convert.ToInt32(txbInteger1.Text) * Convert.ToInt32(txbInteger2.Text) / gcd;
            //print it out
            txbLCD.Text = LCD.ToString(); 
        }
    }
}
