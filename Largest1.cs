using System;

class LargestOne
{
   static void Main(string[] args) 
   {
      double first, second, third;

      Console.Write("\nEnter the first number -> ");
      first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      second = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the third number -> ");
      third = Convert.ToDouble(Console.ReadLine());

      if (first > second && first > third)
         Console.WriteLine("The largest number is " + first);
      else if (second > first && second > third )
         Console.WriteLine("The largest number is " + second);
      else
         Console.WriteLine("The largest number is " + third);
   }
}