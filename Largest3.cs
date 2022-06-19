using System;

class LargestThree
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
      else
         largest = second;
      
      if(third > largest)
         largest = third;

      Console.WriteLine("The largest number is " + largest);
   }
}