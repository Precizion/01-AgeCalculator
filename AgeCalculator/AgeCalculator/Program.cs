using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {

        

        static void Main(string[] args)
        {

            while (true)
            {
                try
                {

                    // Get the current date by asking the user to enter their birthday in the correct format.

                    Console.WriteLine("What is your Birthday? (Enter date in format MM/DD/YYYY)");

                    // The computer will read and capture the input from the user.
                    // Then the input the user entered will now be defined as a string that is called DateOfBirth.

                    Console.ReadLine();
                    string DateOfBirth = Console.ReadLine();

                    // I am now converting the input of the user into a DateTime format that I can use and access.

                    DateTime dateOfBirth = DateTime.Parse(DateOfBirth);

                    // I am naming today's actually information and values in a DateTime that I have named todaysDate.

                    DateTime todaysDate = DateTime.Today;

                    // In the TimeSpan format I am calling the difference between today (todaysDate) and the user's input (DateOfBirth).

                    TimeSpan theDifference = todaysDate.Subtract(dateOfBirth);

                    // I am now taking the total number of days (today minus the user) and converting it into a double (using decimal points) 
                    //in order to carry out math.

                    double totalDays = theDifference.Days;

                    // I am taking the difference of today minus the user's birthday and dividing it by 365.25 (which includes leap years) in
                    // order to find out the total number of years.
                    // Then I will use Math.Floor to round my "years" down.
                    // Finally, I will now convert the double "wholeyears" to an int (egar).

                    double years = totalDays / 365.25;
                    double wholeyears = Math.Floor(years);
                    int pubyears = Convert.ToInt32(wholeyears);



                    // I am using the modulo (%) in order to gain the remainder (left overs) from the last equation.
                    // I will now take the remainder from the last equation in order to find out how many weeks there are.
                    // Then I will use Math.Floor to round my "weeks" down.
                    // Finally, I will now convert the double to an int (egar).

                    double yearsRemainder = totalDays % 365.25;
                    double weeks = yearsRemainder / 7;
                    double wholeweeks = Math.Floor(weeks);
                    int pubweeks = Convert.ToInt32(wholeweeks);


                    // I am using the modulo (%) in order to gain the remainder (left overs) from the last equation.
                    // I am using the previous modulo (%) in order to gain the left over days.
                    // Then I will use Math.Floor to round my "days" down.
                    // Finally, I will now convert the double to an int (egar).

                    double weeksRemainder = weeks % 7;
                    double days = weeksRemainder / 24;
                    double wholedays = Math.Floor(days);
                    int pubdays = Convert.ToInt32(wholedays);

                    // this will be the final print out of where the user's age in years, weeks, and days will be displayed

                    Console.WriteLine("Your are " + pubyears + " years, " + pubweeks + " weeks, " + pubdays + " days old.");

                    // Adding a Console.Read() to keep the console from closing

                    Console.Read();


                }

                // I am making a catch that will "activate" when the conditions within "try" have not been met.   

                catch (Exception e)
                {

                    // I am creating a line that will be shown to the user when the format is incorrectly entered.

                    Console.WriteLine("Unfortunately, you have entered the wrong format for your Birthday." +
                        " Please try again and enter your birthday in the MM/DD/YYYY format.");

                    // By entering Console.Read() I am keeping the program from closing - however, I am not sure if the While "loop" will make 
                    // this redundant.

                    Console.Read();
                }
            }
        }
    }
}
