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
            const int maximumYearsToGraduation = 4;                             // interger for maximumYearsToGraduation

            string userInput = string.Empty;                                    // string for user input

            string studentName;                                                 // String for Student Name
            string programName;                                                 // String for Program Name
            int yearsToCompletion;                                              // interger for Years to completion

            Console.Write("Please enter your name: ");                          // Prompt the user for their name
            userInput = Console.ReadLine();                                     // Read user input
            if (userInput.Trim().Length > 0)
            {
                studentName = userInput;
                Console.Write("Please enter your program name: ");                  // Prompt the user for their name
                userInput = Console.ReadLine();                                     // Read user input
                if (userInput.Trim().Length > 0)
                {
                    programName = userInput;
                    Console.Write("Please enter the number of years to completion for your program: ");                  // Prompt the user for their name
                    userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out yearsToCompletion) &&
                        ((yearsToCompletion >= miniumYearsToGraduation) &&
                        (yearsToCompletion <= maximumYearsToGraduation)))
                    {
                        // Success
                        Console.WriteLine("Years to Completion: " + yearsToCompletion);
                    }
                    else
                    {
                        Console.Write("Error: What you entered {0} is not a number. Expecting a number between {1:n0} and {2:n0}. Please try again", userInput, miniumYearsToGraduation, maximumYearsToGraduation);
                    }
                }
                else
                {
                    Console.Write("Error: What you entered {0} is not a name. Please try again", userInput);
                }
            }
            else {
                Console.Write("Error: What you entered {0} is not a name. Please try again", userInput);
            }

 
            /*
            Console.WriteLine("Name: " + studentName);                          // Output Student Name
            Console.WriteLine("Program: " + programName);                       // Output Program Name
            Console.WriteLine("Years to Completion: " + yearsToCompletion.ToString());     // Output Years to completion
            */
            Console.Write("\nPress Any Key to Exit...");                        // Display Any Key Message
            Console.ReadKey();                                                  // Hold for Any Key
        } //Program
    } // Program
} // StudentProfile
