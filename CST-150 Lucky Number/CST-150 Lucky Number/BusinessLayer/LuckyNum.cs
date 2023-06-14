/* Suyeon Park
 * CST-150
 * 04/30/23
 * Activity 15
 * Alli Adam
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Lucky_Number.BusinessLayer
{
    internal class LuckyNum
    {


        /// <summary>
        /// Populates the Bith Year comboBox
        /// </summary>
        public List<string> PopulateYears()
        {
            // Declare and Initialize variables
            // List of years
            List<string> years = new List<string>();

            // Progmatially populate the List
            for(int i = 1960; i < DateTime.Now.Year; i++)
            {
                // Add the year to the years list
                years.Add(i.ToString());
            }

            // Return the populated List
            return years;
        }


        /// <summary>
        /// Populates the Birth Day comboBox
        /// </summary>
        /// <param name="month"></param>
        public List<int> PopulateDays(string month)
        {
            // Declare and Initialize variables
            // List of months
            List<int> days = new List<int>();

            // Progmatially Populate the number of days in the month
            // using esle if Statement
            // month with 29 days (including leap years)

            if(month == "February")
            {
                // Clear the list before populating
                days.Clear();

                // Add the number of days to the List
                for (int i = 1; i <= 29; i++)
                {
                    // Add days to the days list
                    days.Add(i);
                }
            }

            // months with 31 days
            else if(month == "January" || month == "March" || month == "May" || month == "July" || month == "August" || month == "October" || month == "December")
            {
                // Clear the list before populating
                days.Clear();

                // Add the number of days to the List
                for (int i = 1; i <= 31; i++)
                {
                    // Add days to the days list
                    days.Add(i);
                }
            }

            // months with 30 days
            else if (month == "April" || month == "June" || month == "September" || month == "November")
            {
                // Clear the list before populating
                days.Clear();

                // Add the number of days to the List
                for (int i = 1; i <= 30; i++)
                {
                    // Add days to the days list
                    days.Add(i);
                }
            }


            // Return the populated List
            return days;
        }


        /// <summary>
        /// Utility that returns false if the parameter string is null, empty, or just contains whitte spaces
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns>bool</returns>
        public bool NotNull(string textToTest)
        {
            // Check if the string is empty, null, or contains only whitespace
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Test to determine if a valid double was entered. 
        /// If true, the string is converted to double and true is retrned. 
        /// If the string cannot be converted to double, 0 is returned as double and false for bool.
        /// This returnes a type called Tuple
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns>int, bool</returns>
        public (int intValue, bool isConverted) ValidInt(string valueToTest)
        {
            // Declare and Initialize
            int convertValue = 0;

            // Test to see if the string can be parsed to a double
            if (int.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (convertValue, false);
        }


       
        /// <summary>
        /// Calculates the Lucky Number
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="color"></param>
        /// <param name="date"></param>
        /// <returns>int</returns>
        public int CalculateLuckyNumber(int year, string month, int day, string color, string date)
        {
            // Declare and Initialize variables
            int luckyNum = 0;

            int year1 = 0;
            int year2 = 0;
            int year3 = 0;
            int year4 = 0;
            int monthNum = 0;
            int dayNum = day/5;
            int colorNum = color.Length;
            int dateNum = 0;

            // Get each digit of the year
            year4 = (year % 10);
            year3 = (year / 10) % 10;
            year2 = (year / 100) % 10;
            year1 = (year / 1000) % 10;

            // Check the seasons of the month
            // Spring
            if(month == "March" || month == "April" || month == "March")
            {
                monthNum = 1;
            }
            // Summer
            else if(month == "June" || month == "July" || month == "August")
            {
                monthNum = 2;
            }
            // Fall
            else if (month == "September" || month == "October" || month == "November")
            {
                monthNum = 3;
            }
            // Winter
            else if (month == "December" || month == "January" || month == "February")
            {
                monthNum = 4;
            }

            // Convert bool for date into assignend number
            if(date == "Yes:3")
            {
                dateNum = 4;
            }

            // Calculate the Lucky Number using the converted inputs
            luckyNum = ((year1 + year2 + year3 + year4) / monthNum) - dayNum + colorNum - dateNum;

            // Return the calculated lucky number
            return luckyNum;
        }

    }
}
