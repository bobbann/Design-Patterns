using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator1
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            IDecoration decoration;

            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            Text originalText = new();
            originalText.Output = Console.ReadLine();

            decoration = originalText;

            Console.WriteLine("Choose a decorator");
            ConsoleKey userInput = new();
            while (true)
            {
                userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        string madrid = decoration.Content();
                        Console.WriteLine(madrid);
                        break;

                    case ConsoleKey.D2:
                        decoration = new Bold(decoration);
                        break;

                    case ConsoleKey.D3:
                        decoration = new Italic(decoration);
                        break;

                    case ConsoleKey.D4:
                        decoration = new Emphasized(decoration);
                        break;

                    case ConsoleKey.D5:
                        decoration = new Important(decoration);
                        break;

                    case ConsoleKey.D6:
                        decoration = new Inserted(decoration);
                        break;

                    case ConsoleKey.D7:
                        decoration = new Marked(decoration);
                        break;

                    case ConsoleKey.D8:
                        decoration = new Smaller(decoration);
                        break;

                    case ConsoleKey.D9:
                        decoration = new SubScript(decoration);
                        break;

                    case ConsoleKey.D0:
                        decoration = new SuperScript(decoration);
                        break;
                }
            }
        }
    }
}