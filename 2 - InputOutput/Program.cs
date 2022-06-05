// In this example, i'm taking advantage of the "new" top-level statements 
// functionality of dotnet.  Here, dotnet will handle all of the ceremonial boilerplate we need to make our
// program work.  We don't have to worry about the usings, namespace, class, etc... 

// In this example program, lets ask the user a couple of questions and get back some responses from 
// the command line.  We will use this to learn how to do some very simple I/O.

// First, let's prompt the user for some input
Console.WriteLine("Hello, Welcome to our awesome program.\nWhat is your Name?");

// Next, let's grab our user's response from the console.
// We declare a local string variable 'userName' to hold our user's input.  
// Note, for local variables, we want to use camel Case, that is, the first word
// is lowercase and each subsequent word in our variable name is capitalized.

string userName = Console.ReadLine();

// Now, let's echo our user's name back to them in an attempt to impress them.
// Here, we've used a different way of expressing a string.  By putting the '@' before our string, 
// we are making a 'verbatim' string... our whitespace and new line are respected.
// I did it here to show you an example and to make my line a little easier to read.
Console.WriteLine(@"Hello, {0}! So glad you could join us. 
These little programs are dumb, but sometimes it do be like that.", userName);

