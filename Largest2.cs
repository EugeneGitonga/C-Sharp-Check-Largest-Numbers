using System;

class LargestTwo
{
   static void Main(string[] args) 
   {
      double first, second, third, largest;

      Console.Write("\nEnter the first number -> ");
      first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      second = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the third number -> ");
      third = Convert.ToDouble(Console.ReadLine());

      if (first > second && first > third)
         largest = first;
      else if (second > first && second > third )
         largest = second;
      else
         largest = third;

      Console.WriteLine("The largest number is " + largest);
   }
}