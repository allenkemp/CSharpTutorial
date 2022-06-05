﻿// In this example, we are going to utilize command line arguments to 
// create a fun little magic 8 ball program.
// Yes, fun, damn it. 

// In c# and dotnet console applications, we have access to a special array of strings called 'args'
// 'args' holds any command line arguments supplied by our user when they run our program.
// For instance --
// c:\SampleCode.exe /B data.txt -A 123
// If we had a program, "SampleCode.exe",  then the args array from the above example would be
// Array Postion - Value
//      0           "/B"
//      1           "data.txt"
//      2           "-A"
//      3           "123"

// Because we are using the top-level statements functionality of dotnet, we don't have to explicitely
// define 'args', it is done for us by dotnet when we build our program.

// What we want to do in this program is allow the user to give us a question on the command line
// and then respond with a random, witty, response.

// You might be wondering how to run your program with 'dotnet run' and still provide command line arguments.
// Good Question!  I certainly didn't need to look up the answer.... i totally needed to look up the answer.
// What we do is -  dotnet run -- Command Line Args
// So for example, we might do this for our program: 

// dotnet run --Will I retire from the revenue generated by this program?


// Let's get started with our program by preparing an array that holds some 
// fun responses for us to pick from when we want to respond to the user's question

string[] responses = 
{
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",    "Most likely.",               "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};

// Next, lets randomly pick one of these that will be our answer to the question.
// This code is gonna look a little complex, don't sweat the details here, just know
// we are randomly picking a number between 0 and one less than the length of our array.

int selectedIndex = new Random().Next(responses.Length -1);

// Now, Let's grab our user's question from the command line arguments.
// There are several ways to do this, i'm going to build a string by using a loop.

string question= "";
foreach (var arg in args)
{
    question += (arg + " ");
}

// Now i'm gonna to write the user's question out to the command line, along with our answer.
Console.WriteLine(@"You asked -
{0}
and the magic 8 ball says...
{1}", question, responses[selectedIndex]);