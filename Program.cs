//Deliverable 1 Practice
using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args)
  //Ask user to create password.
   {
    Console.WriteLine ("Create a password with at least one lowercase letter, at least one uppercase letter, between 7 and 12 characters,and an exclamation point.");
    string password = Console.ReadLine();
//Check if password has uppercase letter
    if (password.Any(char.IsUpper) &&
//Check if password has lowercase letter
    password.Any(char.IsLower) &&
    //Check if password is at least 7 characters long
    (password.Length >= 7) &&
    //check if password is not over 12 characters long
    (password.Length <= 12) &&
    //check if password has an exclamation point
    password.Contains("!"))
        {
        Console.WriteLine ("Password valid and accepted" );
    }else {
        Console.WriteLine ("Error");
    }

  }
}