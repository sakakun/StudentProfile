/*
 * Program Name:    StudentProfile (ICE 2)
 * Program Author:  Matthew Bate
 * Date:            January 31, 2018
 * 
 * Description:     The program will display student data including name, program, and years
 *                  to completion.
 * Date Modified:   N/A
 * Modified by:     N/A
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            const int miniumYearsToGraduation = 1;                              // interger for miniumYearsToGraduation
            const int maximumYearsToGraduation = 1;                             // interger for maximumYearsToGraduation

            string userInput = string.Empty;                                    // string for user input

            string studentName;                                                 // String for Student Name
            string programName;                                                 // String for Program Name
            int yearsToCompletion;                                              // interger for Years to completion

            Console.Write("Please enter your name: ");                          // Prompt the user for their name
            userInput = Console.ReadLine();                                     // Read user input

            if (userInput.Trim().Length > 0)
            { studentName = userInput; }
            else { Console.Write("Error: What you entered {0} is not a name. Please try again", userInput); }


            Console.WriteLine("Name: " + studentName);                          // Output Student Name
            Console.WriteLine("Program: " + programName);                       // Output Program Name
            Console.WriteLine("Years to Completion: " + yearsToCompletion.ToString());     // Output Years to completion
            Console.Write("\nPress Any Key to Exit...");                        // Display Any Key Message
            Console.ReadKey();                                                  // Hold for Any Key
        } //Program
    } // Program
} // StudentProfile
