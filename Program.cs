using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()+=-_<>,.?/';";
    
      Console.WriteLine("Please enter your password");
      string password = Console.ReadLine();

      int score = 0;

      if(password.Length >= minLength) {
        score += 1;
      }
      if (Tools.Contains(password, uppercase)) {
        score += 1;
      }
      if (Tools.Contains(password, lowercase)) {
        score += 1;
      }
      if (Tools.Contains(password, digits)) {
        score += 1;
      }
      if (Tools.Contains(password, specialChars)) {
        score += 1;
      }
    //Console.WriteLine(score);

    switch(score)
    {
      case 5:
        Console.WriteLine($"Your password score is {score}. You have an extremely strong password");
        break;
      case 4:
        Console.WriteLine($"Your password score is {score}. You have an extremely strong password");
        break;
      case 3:
        Console.WriteLine($"Your password score is {score}. You have a strong password");
        break;
      case 2:
        Console.WriteLine($"Your password score is {score}. You have a medium password");
        break;
      case 1:
        Console.WriteLine($"Your password score is {score}. You have an weak password");
        break;
      default:
        Console.WriteLine("Your password does not meet any of the standards");
        break;
    }
    
    }
  }
}
