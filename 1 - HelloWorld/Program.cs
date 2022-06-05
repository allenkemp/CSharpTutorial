/*
    Using Statements
    Where we include the modules and other source code objects we
    want to be able to reference things from in our program.
    "using System;" is almost always going to be here if nothing else when 
    we are working in dotnet
*/
using System;

/*
    Namespace Declaration

    Namespaces keep our code from colliding with the code of others
    As a convention, I have my namespace match my program name, here "HelloWorld"
    For namespaces, i use capitallized Pascal case (first letter of each word capitalized, no underscores)
*/
namespace HelloWorld
{
    /*
        Program Class
        the class that contains our Program and its main method.
    */

    internal class Program
    {
        /* 
            Main Method

            The entrypoint into our program.  We must have a Main method for our program to work properly

            The [] args are string array of command line arguments.
            Note that Main is a void function, it doesn't return anything.
        */
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); //  The only line of our program, Just outputs 'old faithful' out
                                                //  to the terminal.
                                                //  I put these comments here just to show you they can pretty much
                                                //  go anywhere we want.
        }
    }    
}
