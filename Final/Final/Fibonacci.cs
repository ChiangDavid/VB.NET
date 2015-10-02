/**********************************************************
*Fibonacci.cs
*
* Implementing the calculator for user input the length of the number, and the calculator will display the fibonacci number by requesting number
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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }
        //When the start to run button click
        private void btnStart_Click(object sender, EventArgs e)
        {
            //We change the texbox length to the integer form
            int length = int.Parse(txbLength.Text);
            //I use long for store the fibonacci numbers because the fibonacci numbers will grow really fast 
            long[] fibonacci = new long[length];

            //Create the loop to until the number that we assigned
            for (int i=0; i<length; i++)
            {
                //if the i is a 0 or 1 will store as 1
                if (i == 0 || i == 1)
                    fibonacci[i] = 1;
                else
                    //Otherwise, fill to the index for i-2 or i-1
                    fibonacci[i] = fibonacci[i-2] + fibonacci[i-1];
            }
            //Really have to clean the items before run again or it will be very messy
            listAll.Items.Clear();
            //add the fibonacci number tthat we find, put into the listbox and display
            for (int i = 0; i < length; i++)
                listAll.Items.Add(fibonacci[i]);
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            txbLength.Text = "0";
            //so when re compile the code, it will show 0
            //for both input textbox
        }

    }
}
