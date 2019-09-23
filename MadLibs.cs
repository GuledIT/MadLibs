using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a Mad Lib game
      Author: Guled Yusuf 
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Let the game start!");

      // Give the Mad Lib a title:
      string title = "Fun times";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter your name: ");
      string name = Console.ReadLine();
      
      Console.WriteLine("Your favorite color is: ");
      string favColor = Console.ReadLine();
      
       Console.WriteLine("How do you feel today: ");
      string feeling = Console.ReadLine();
      
       Console.WriteLine("Sewers smells: ");
      string smells = Console.ReadLine();
      
      Console.WriteLine("You see a naked man touching you, what do you do: ");
      string oneVerb = Console.ReadLine();
      
      Console.WriteLine("Insert your gender: ");
      string gender = Console.ReadLine();

      Console.WriteLine("What do you sleep in: ");
      string bed = Console.ReadLine();
      
      Console.WriteLine("Write the name of an animal: ");
      string animal = Console.ReadLine();
      
      Console.WriteLine("A food you like: ");
      string food = Console.ReadLine();
      
      Console.WriteLine("A fruit: ");
      string fruit = Console.ReadLine();
      
      Console.WriteLine("A superhero: ");
      string hero = Console.ReadLine();
      
      Console.WriteLine("A country: ");
      string country = Console.ReadLine();
      
      Console.WriteLine("A dessert: ");
      string dessert = Console.ReadLine();
      
      Console.WriteLine("A year you like: ");
      string year = Console.ReadLine();
      
      
 
      
      // The template for the story:

      string story = $"This morning {name} woke up feeling {favColor}. 'It is going to be a {feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to{oneVerb} to the rhythm of the {gender}, which made all the {fruit}s very {smells}. Concerned,{name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {bed}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
