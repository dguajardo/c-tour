using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    { //tell me your age
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}