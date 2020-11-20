using System;

namespace ControlFlow
{
    public static class ControlFlow
    {
        // Part 1, Control Flow, Don't Worry about input validation.

        // 1.1 - Write a method that accepts an integer. The integer should be more than 1 but less
        // than 10. If the user enters a valid integer, return "Valid". Otherwise, return "Invalid".
        // (This logic is used a lot in applications where values entered into input boxes need to
        // be validated).  Negative numbers should return "Invalid".
        public static string AreYouValid(int number)
        {
            var result = string.Empty;
            if (number > 1 && number < 10)
            {
                result = "Valid";
            }
            else
            {
                result = "Invalid";
            }

            return result;
        }

        // 1.2 - Write a method which takes two integers and returns the maximum of the two. If they
        // are the same, return either one.
        public static int Maximum(int number1, int number2)
        {
            return (number2 < number1) ? number2 : number1;

            // This is a ternary statement, it follows the format 
            // (Question) ? Result if Question is True : Result if question if false
        }

        // 1.3 - Write a method which takes two integers, the width and height of an image. Then
        // return a string to tell if the image is "Landscape" or "Portrait". Return "Square" if
        // they are equal. Assume non-negative values.
        public static string LandscapeOrPortrait(int width, int height)
        {
            return default;
        }

        // 1.4 - Your job is to write a program for a speed camera. For simplicity, ignore the details
        // such as camera, sensors, etc and focus purely on the logic.
        //
        // Write a method that asks for a speed limit and for the speed of a car.
        //
        // If the speed of the car is a value less than the speed limit, method should return "Okay".
        //
        // If the value is above the speed limit, the program should calculate the number of demerit
        // points. For every 5 above the speed limit, 1 demerit points should be incurred and
        // returned as a string.
        //
        // If the number of demerit points is greater than 12, the program should display "License
        // Suspended" instead. Don't Worry about input validation.
        public static string SpeedTrap(int speedLimit, int speedCar)
        {
            return default;
        }

        // Part 2, Control Flow. Come back to this section after completing the For/Foreach/While loops.

        // 2.1 - Write a method to count how many integers between two numbers are divisible by a divider with
        // no remainder. Return the count. For example, if minNumber = 1 and maxNumber = 6, and the divider is 3 then
        // output should be 2. Don't Worry about input validation.
        public static int DivisibleByNumber(int minNumber, int maxNumber, int divider)
        {
            return default;
        }

        // 2.2 - Write a method to calculate the sum of all the integers and return it. For example if
        // the program enters (2, 3, 5, 1) then the return should be 11. Don't Worry about input validation.
        public static int SumIntegers(params int[] numbers)
        {
            return default;
        }

        // 2.3 - Write a method to compute the factorial of an integer return it. For example, if the
        // user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and return it as 120. Make sure
        // that 0! = 1.
        public static int FindFactorial(int number)
        {
            return default;
        }

        // 2.4 - Write a method that takes a series of integers separated by commas. Then find the
        // maximum of the numbers and return it. For example, if the numbers are “5, 3, 8, 1, 4",
        // the program should return 8.
        public static int MaximumNumber(params int[] numbers)
        {
            return default;
        }
    }

    class Program
    {
        static void Main()
        {
            // This is intentionally left empty
        }
    }
}
