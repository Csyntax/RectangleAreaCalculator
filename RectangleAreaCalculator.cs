/*
Algorithm
Start
Prompt the user to enter the length of the rectangle.
Read the user input for the length.
Prompt the user to enter the width of the rectangle.
Read the user input for the width.
Validate the inputs to ensure they are positive numbers.
Calculate the area of the rectangle using the formula: Area = Length * Width.
Display the calculated area to the user.
End
*/

using System;
class RectangleAreaCalculator
{
    static void Main()
    {
        // Prompt the user to enter the length of the rectangle
        Console.Write("Enter the length of the rectangle: ");
        double length;
        // Read the user input and try to parse it as a double, storing the result in 'length'
        bool isLengthValid = double.TryParse(Console.ReadLine(), out length); 

        // Prompt the user to enter the width of the rectangle
        Console.Write("Enter the width of the rectangle: ");
        double width;
          // Read the user input and try to parse it as a double, storing the result in 'width'
        bool isWidthValid = double.TryParse(Console.ReadLine(), out width);

         // Validate the inputs to ensure they are both valid doubles and positive numbers
         if(!isLengthValid || !isWidthValid || length <= 0 || width <= 0 )
         {
            Console.WriteLine("Invalid input. Length and width must be positive numbers. ");
            return;
         }
         // Calculate the area of the rectangle using the formula: Area = Length * Width
         double area = length * width;

         // Display the calculated area to the user
         Console.WriteLine("The area of the rectangle is: " + area);

    }       
}
