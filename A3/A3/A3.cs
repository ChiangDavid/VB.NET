﻿/**********************************************************
* A3.cs
*
* Implementing the calculator with 4 more math functions and solve the NaN, and handle the div by 0 result 
* 
* Author: David Chiang
* Date Created: 12/2/14
* Last Modified by: David CHiang
* Date Last Modified: 12/5/14
* Assignment: Assignment 3
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

namespace A3
{
    public partial class A3 : Form
    {
        //User input for first number (double)
        double dblNumber1 = 0;
        //User input for second number (double)
        double dblNumber2 = 0;
        //the answer needs to be double, so we create the dobule for the answer (double)
        double dblResult = 0;

        //Create the string that put into the first number textbox
        string strNumber1 = "0";
        //Create the string that put into the secod number textbox
        string strNumber2 = "0";
        //Create the string that put into the answer textbox
        string strResult = "0";

        string strTest = "0";

        double dblNumCheck = 0;

        //boolean to check if the user input is the number or not
        //YES --> return true;;;;; NO --> return false
        public bool isNum;

        public A3()
        {
            InitializeComponent();
        }
        //initialize the first two TextBoxes when we Load the Main Form, to be sure everything is clean.
        private void A3_Load(object sender, EventArgs e)
        {
            tbNumber1.Text = "0"; 
            tbNumber2.Text = "0"; 
            //so when we clear or re compile the code, it will show 0
            //for both textboxs
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            //when we clear, there will be a 0 inside the box for first number
            tbNumber1.Text = "0";
            //when we clear, there will be a 0 inside the box for first number
            tbNumber2.Text = "0";
            //result box will be empty
            tbResult.Text = "";
            //When we clear the program, the focus will at number1 textbox
            tbNumber1.Focus();
        }
        //When you trying to close the form, it will ask you if you really want to close the program or not
        //YES --> Close the calculator
        //NO --> Return to the calculator(form)
        private void A3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You really want to close the program?", "Program Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
        //When we leave the number 1 text box, will change from string to double 
        private void tbNumber1_Leave(object sender, EventArgs e)
        {
            //Since the box is string object, we need to the enter double convert to string and storing into the textbox for first number
            strNumber1 = tbNumber1.Text.ToString();
            //when we have string for first number, we create/get the copy for the string first number
            strTest = strNumber1;
            //include all the necessary parts of TryParse
            bool isNum = double.TryParse(strTest, out dblNumCheck);
            //isNum will hold the “T” or “F” that is the result of TryParse.
            if (isNum)
            {
                //If “T”, we want to save the string as a double.
                dblNumber1 = double.Parse(strNumber1);
            }
            else
            {
                //If “F”, we need to inform the user of the error.
                tbNumber1.Text = "";
                strNumber1 = "";
                //txbFirstNum.Lines.Initialize();
                MessageBox.Show("Give me the number or you entered is not a number!");
            }
        }
        //When we leave the number 2 text box, will change from string to double 
        private void tbNumber2_Leave_1(object sender, EventArgs e)
        {
            //Since the box is string object, we need to the enter double convert to string and storing into the textbox for first number
            strNumber2 = tbNumber2.Text.ToString();
            //when we have string for first number, we create/get the copy for the string first number
            strTest = strNumber2;
            //include all the necessary parts of TryParse
            bool isNum = double.TryParse(strTest, out dblNumCheck);
            //isNum will hold the “T” or “F” that is the result of TryParse.
            if (isNum)
            {
                //If “T”, we want to save the string as a double.
                dblNumber2 = double.Parse(strNumber2);
            }
            else
            {
                //If “F”, we need to inform the user of the error.
                tbNumber2.Text = "";
                strNumber2 = "";
                //txbFirstNum.Lines.Initialize();
                MessageBox.Show("Give me the number or you entered is not a number!");
            }
        }
        //This method will help us when our mouse click at the first number it will become blank instead of "0"
        private void tbNumber1_MouseDown(object sender, MouseEventArgs e)
        {
            tbNumber1.Text = "";
        }
        //This method will help us when our mouse click at the second number it will become blank instead of "0"
        private void tbNumber2_MouseDown(object sender, MouseEventArgs e)
        {
           tbNumber2.Text = "";
        }
        //Since we know the parse function, we dont need to do the textbox leave event
        //We can just parse the first number and second number, then get the result
        //Later we assign the double number to string and print in the result textbox
        private void btplus_Click(object sender, EventArgs e)
        {
            tbResult.Text = (double.Parse(tbNumber1.Text) + double.Parse(tbNumber2.Text)).ToString();
        }
        //Doing the minus operation
        private void btMinus_Click(object sender, EventArgs e)
        {
            tbResult.Text = (double.Parse(tbNumber1.Text) - double.Parse(tbNumber2.Text)).ToString();
        }
        //Doing the multiply operation
        private void btMul_Click(object sender, EventArgs e)
        {
            tbResult.Text = (double.Parse(tbNumber1.Text) * double.Parse(tbNumber2.Text)).ToString();

        }
        //Doing the division operation
        private void btDiv_Click(object sender, EventArgs e)
        {
                //The only thing we will divide by 0 is second number is 0
                //So if second number is not 0, it will be fine
                if (dblNumber2 != 0)
                {
                    //if second number is not the 0
                    dblResult = (dblNumber1 / dblNumber2);
                    strResult = dblResult.ToString();
                    tbResult.Text = strResult;
                }
                else
                {
                    //If it is a zero at second number, we print the error to user 
                    tbResult.Text = "ERROR!!!!";
                    MessageBox.Show("Sorry,You can't divide by 0", "Error Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //This method is to check if 2 numbers are the same
        private void btEqual_Click(object sender, EventArgs e)
        {
            tbResult.Text = int.Parse(tbNumber1.Text) == int.Parse(tbNumber2.Text) ? "Yes" : "NO";
        }
        //This method is to check if first number is greater to second number
        private void btLarger_Click(object sender, EventArgs e)
        {
            tbResult.Text = int.Parse(tbNumber1.Text) > int.Parse(tbNumber2.Text) ? "Yes" : "NO";
        }
        //This method is to check if first number is smaller to second number
        private void btSmaller_Click(object sender, EventArgs e)
        {
            tbResult.Text = int.Parse(tbNumber1.Text) < int.Parse(tbNumber2.Text) ? "Yes" : "NO";
        }
        //This method is to check if first number is not equal to second number
        private void btNotEqual_Click(object sender, EventArgs e)
        {
            tbResult.Text = int.Parse(tbNumber1.Text) != int.Parse(tbNumber2.Text) ? "Yes" : "NO";
        }
    }

}
