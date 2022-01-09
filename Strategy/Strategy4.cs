using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy4
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            var message = "This is the message";
            MessageHandler messageHandler = new();
            Sms sms = new();
            FacebookMessage facebookMessage = new();
            EmailMessage email = new();

            while (true)
            {
                Console.WriteLine("Choose type of message");
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {

                    case 's':
                        Console.WriteLine("Sms");
                        messageHandler.MessageType = sms;
                        break;

                    case 'e':
                        Console.WriteLine("Email");
                        messageHandler.MessageType = email;
                        break;

                    case 'f':
                        Console.WriteLine("Facebook Message");
                        messageHandler.MessageType = facebookMessage;
                        break;

                    case 'r':
                        messageHandler.run(message);
                        break;
                }
            }

            // What i want to happen to happen is
            //
            // Change type of message to send to sms etc.
            // send message            
        }
    }
}