// See https://aka.ms/new-console-template for more information
// writes line for first name
Console.WriteLine("What is your first name");

// makes firstname a variable
string firstname = Console.ReadLine();

// writes line for the last name
Console.WriteLine("What is your last name");

// makes lastname a variable
string lastname = Console.ReadLine();

// writes line for the age
Console.WriteLine("What is your age");

// makes age a variable
string age = Console.ReadLine();

// writes line for their favorite color
Console.WriteLine("What is your favorite color");

// makes color a variable
string color = Console.ReadLine();

// this puts the string and text together
Console.WriteLine("Hello, " + firstname + " " + lastname + ("! You are " + age + (" years old and your favorite color is ") + color));

// makes code come together
Console.Read();

