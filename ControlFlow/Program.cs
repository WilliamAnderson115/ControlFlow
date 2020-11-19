using System;

namespace ControlFlow
{
    public static class ControlFlow
    {
        // 1 - Write a method that accepts an integer. The integer should be more than 1 but less
        // than 10. If the user enters a valid integer, return "Valid". Otherwise, return "Invalid".
        // (This logic is used a lot in applications where values entered into input boxes need to
        // be validated.)
        public static string AreYouValid(int number)
        {
            return (number > 1 && number < 10) ? "Valid" : "Invalid";
        }

        // 2 - Write a method which takes two integers and returns the maximum of the two. If they
        // are the same, return either one.
        public static int Maximum(int number1, int number2)
        {
            return (number1 > number2) ? number1 : number2;
        }

        // 3 - Write a method which takes two integers, the width and height of an image. Then
        // return a string to tell if the image is "Landscape" or "Portrait". Return "Square" if
        // they are equal. Assume non-negative values.
        public static string LandscapeOrPortrait(int width, int height)
        {
            return default;
        }

        // 4 - Your job is to write a program for a speed camera. For simplicity, ignore the details
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
        // If the number of demerit points is above 12, the program should display "License
        // Suspended" instead.
        public static string SpeedTrap(int speedLimit, int speedCar)
        {
            return default;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
