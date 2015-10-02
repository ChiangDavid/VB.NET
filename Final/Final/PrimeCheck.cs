/**********************************************************
*PrimeCheck.cs
*
* Implementing the calculator for determine if the number is prime or not
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
    public partial class PrimeCheck : Form
    {
        public PrimeCheck()
        {
            InitializeComponent();
        }
        //Check button click
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //when click, the result box will change to analyzing....
            txbResult.Text = "Analyzing....";
            //then taking the user input from text(string) to integer
            int input = int.Parse(txbInput.Text);

            //create a new variable to store the user input 
            int ceiling = input;
            //loop from 2 until user input
            for (int i = 2; i<ceiling; i++)
            {
                //if we get the input remainder is a zero, so we can just break(stop the program)
                if (input%i == 0)
                {
                    //Print the result to user
                    txbResult.Text = "Can get divided by" + i;
                    break;
                }
                else
                {
                    //or just return input /i
                    ceiling = input / i;
                }
            }
            //if it is a 1
            if (input == 1)
                //just say it is not a prime number(because in math, 1 is not a prime number)
                txbResult.Text = "1 is not a prime number";
                //but if the textbox for result is same as the beginning. I means that we cannot find any number can divided
            else if (txbResult.Text == "Analyzing....")
                //so we print the number is a prime number
                txbResult.Text = "This is a prime number";
        }
    }
}
