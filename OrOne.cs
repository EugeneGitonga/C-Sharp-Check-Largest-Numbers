using System;

class OrOne
{
   static void Main(string[] args) 
   {
      double marks;

      Console.Write("\nEnter the marks the student scored -> ");
      marks = Convert.ToDouble(Console.ReadLine());
      
      if (marks < 0 || marks > 100)
         Console.Write(marks + " is a INVALID mark.\n");
      else
         Console.Write(marks + " is an valid mark.\n");

      Console.ReadKey();
   }
}