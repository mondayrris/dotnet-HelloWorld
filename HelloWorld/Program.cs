// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main is the application entry point, the method that's called automatically by the runtime when it launches the application.
            // Any command-line arguments supplied when the application is launched are available in the args array.
            //Console.WriteLine("Hello World!");

            // Press ⌥⌘↵ (option+command+enter) to run the app without debugging.
            // Close the Terminal window.

            // For enhanced HelloWorld app, comment line 14 and start coding below.

            // This code displays a prompt in the console window and waits until the user enters a string followed by the enter key.
            // It stores this string in a variable named name.
            // It also retrieves the value of the DateTime.Now property, which contains the current local time,
            // and assigns it to a variable named currentDate.
            // And it displays these values in the console window.
            // Finally, it displays a prompt in the console window and calls the Console.ReadKey(Boolean) method to wait for user input.
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;

            // NewLine is a platform-independent and language-independent way to represent a line break.
            // Alternatives are \n in C# and vbCrLf in Visual Basic.

            // The dollar sign ($) in front of a string
            // lets you put expressions such as variable names in curly braces in the string.
            // The expression value is inserted into the string in place of the expression.
            // This syntax is referred to as interpolated strings.

            // You may set the below line as the breakpoint by ctrl+\, and ctrl+click, select "Edit Breakpoint"
            // Add the following condition is true and select "Apply"
            // String.IsNullOrEmpty(name)

            // Press ⌘↵ (command+enter) to start debugging.
            // Press ⇧⌘I (shift+command+I) or select Run > Step Into to advance one line.
            // Press ⇧⌘U (shift+command+U) or select Run > Step Out.
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}