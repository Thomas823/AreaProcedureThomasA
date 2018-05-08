/*
 * Created by: Thomas Aubin
 * Created on: 8 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Area Procedure
 * This program calculates the area using procedures
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

namespace AreaProcedureThomasA
{
    public partial class frmAreaProcedure : Form
    {
        public frmAreaProcedure()
        {
            InitializeComponent();
        }

        // Procedure to calculate the area
        // Takes length and width values
        public void CalculateArea(int length, int width)
        {
            // Create local varibles
            int area;

            // Calculate area
            area = length * width;

            // Display message box with calcualted area
            MessageBox.Show("The area is: " + area + " square units.", "Area Answer");
        }

        // Procedure called when btnCalculate is pressed
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Create local variables
            int userLength;
            int userWidth;

            // Get users length and width values
            userLength = Convert.ToInt16(txtLength.Text);
            userWidth = Convert.ToInt16(txtWidth.Text);

            // Call Calculate Area procedure
            CalculateArea(userLength, userWidth);
        }
    }
}
