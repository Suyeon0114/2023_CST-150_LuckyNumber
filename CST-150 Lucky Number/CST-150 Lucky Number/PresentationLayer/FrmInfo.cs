/* Suyeon Park
 * CST-150
 * 04/30/23
 * Activity 15
 * Alli Adam
 * Reference
 * https://stackoverflow.com/questions/3890956/how-to-get-current-month-and-year
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CST_150_Lucky_Number.BusinessLayer;

namespace CST_150_Lucky_Number.PresentationLayer
{
    public partial class FrmInfo : Form
    {
        // Class Level Variables
        public static int luckyNum = 0;

        public FrmInfo()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Load Event Handler to populate the Birth Year comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateYear_LoadEventHandler(object sender, EventArgs e)
        {
            // Instantiate the BusinessLayer
            LuckyNum method = new LuckyNum();

            // Call the method
            cmbYear.DataSource = method.PopulateYears();
        }


        /// <summary>
        /// Drop Down Closed Event Handler to populate the Birth Day comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateDays_DropDownClosedEventHandler(object sender, EventArgs e)
        {
            // Instantiate the BusinessLayer
            LuckyNum method = new LuckyNum();

            // Call the method
            cmbDay.DataSource = method.PopulateDays(cmbMonth.Text);
        }



        /// <summary>
        /// Click Event Handler that check for the vaild enteries and 
        /// calculates the Lucky Number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetLuckyNumber_ClickEventHandler(object sender, EventArgs e)
        {
            // Declare and Intialize
            // Flag that tracks that all entries are all valid
            bool isValidEntries = true;
            int intNum = 0;

            // Flag to varify parsing double is true or false
            bool isValid = false;

            // Instantiate our LuckyNum class so we can use it.
            LuckyNum method = new LuckyNum();

            //--------------------------------------------------------
            //        Verify all boxes have correct inputs
            //--------------------------------------------------------
            // We will be using a Utility / Helper Class to verify the inputs

            // Check if all the input data types are valid
            if (!method.NotNull(cmbYear.Text) || !method.NotNull(cmbMonth.Text) || !method.NotNull(cmbDay.Text) || !method.NotNull(cmbDate.Text) || !method.NotNull(cmbColor.Text))
            {
                isValidEntries = false;
            }

            // Now test the text box for vaild int amount
            // If valid the amount will convert the bool parse
            (intNum, isValid) = method.ValidInt(cmbYear.Text);
            if (!isValid)
            {
                isValidEntries = false;
            }

            // Now test the text box for vaild int amount
            // If valid the amount will convert the bool parse
            (intNum, isValid) = method.ValidInt(cmbDay.Text);
            if (!isValid)
            {
                isValidEntries = false;
            }

            //--------------------------------------------------------
            //     End - Verify all boxes have correct inputs
            //--------------------------------------------------------

            // If our isValidEntries is still true, we can calculate the Lucky Number
            // else display error message
            if (isValidEntries)
            {
                // Calculate the Lucky Number 
                luckyNum = method.CalculateLuckyNumber(Convert.ToUInt16(cmbYear.Text), cmbMonth.Text, Convert.ToUInt16(cmbDay.Text), cmbColor.Text, cmbDate.Text);

                // Show the secondary form
                FrmLucky frmLucky = new FrmLucky();
                frmLucky.Show();
            }
            else
            {
                // If we are here, there is a problem with an entry
                // Show the error message
                MessageBox.Show("Please check all the inputs and try again:)");
            }
        }
    }
}
