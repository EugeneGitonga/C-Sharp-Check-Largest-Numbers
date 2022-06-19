using System;

class Larger
{
   static void Main(string[] args) 
   {
      double first, second;

      Console.Write("Enter the first number -> ");
      first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      second = Convert.ToDouble(Console.ReadLine());

      if (first > second)
         Console.Write(first + " is larger than " + second);
      else if (first < second)
         Console.Write(second + " is larger than " + first);
      else
         Console.Write(first + " is equal to " + second);
   }
}