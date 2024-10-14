//Microsoft Learn excercises
//Excercise 1. Write your first C# code
//1.1
using System.Reflection.Metadata;

Console.WriteLine("Hello World!");
//Console.WriteLine("Hello World");
Console.WriteLine();
Console.WriteLine("----------------------------");
//1.2
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code!");

Console.WriteLine();
Console.WriteLine("----------------------------");

Console.WriteLine("Congratulations!");
Console.Write("You wrote your first code.");

Console.WriteLine();
Console.WriteLine("----------------------------");
//1.4.1
Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line.");
//1.4.2
Console.Write("This is the first line.\n");
Console.WriteLine("This is the second line.");
//1.4.3
Console.WriteLine("This is the first line.");

Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");

Console.WriteLine();
Console.WriteLine("----------------------------");
//Excercise 2. Store and retrieve data using literal and variable values in C# 
//2.2
Console.WriteLine('b');//char
Console.WriteLine(8); //int
Console.WriteLine(0.13F);//float
Console.WriteLine(55.864);//double
Console.WriteLine(15.12345678901236540m);//decimal
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("----------------------------");
Console.WriteLine();
//2.4.1
string firstName;
firstName = "Robert";
Console.WriteLine(firstName);
firstName = "Laura";
Console.WriteLine(firstName);
firstName = "Lucky";
Console.WriteLine(firstName);
firstName = "Den";
Console.WriteLine(firstName);

Console.WriteLine("----------------------------");
Console.WriteLine();
//2.4.2
string firstNameInitializing = "Robert";
Console.WriteLine(firstNameInitializing);

Console.WriteLine("----------------------------");
Console.WriteLine();
//2.6
string firstName2 = "Bob";
int numberOfMessages = 3;
double temperatureCelcius = 34.4;
Console.WriteLine("Hello, " + firstName2 + "! You have " + numberOfMessages + " messages in your inbox. The temperature is " + temperatureCelcius + " celsius.");

Console.WriteLine("----------------------------");
Console.WriteLine();
//Excercise 3. Combine strings using character escape sequences
//3.2
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");

Console.WriteLine("----------------------------");
Console.WriteLine();

//3.3
string greeting = "Hello ";
string message = greeting + " " + firstName2 + "!";
Console.WriteLine(message);
Console.WriteLine(greeting + " " + firstName2 + "!");

Console.WriteLine("----------------------------");
Console.WriteLine();

//3.4
Console.WriteLine($"{greeting} {firstName2}!");

string message2 = $"Hello {firstName2}!";
Console.WriteLine(message2);

int updateVersion = 11;
string updateText = "Update to Windows";
string updateMessage = $"{updateText} {updateVersion}";
Console.WriteLine(updateMessage);

Console.WriteLine($"{updateText} {updateVersion}!");

string someProjectName = "Some_Project";
Console.WriteLine($@"C:\Output\{someProjectName}\Data");

Console.WriteLine("----------------------------");
Console.WriteLine();
//3.5
string projectName = "ACME";
string englishMessage = "View English output: ";
Console.WriteLine(englishMessage);
Console.WriteLine($@"c:\Exercise\{projectName}\data.txt");

string russianLanguage = "\u0440\u0443 \u02c9 \u0420\u0423";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine(russianMessage);
Console.WriteLine($@"c:\Exercise\{projectName}\{russianLanguage}\data.txt");

Console.WriteLine("----------------------------");
Console.WriteLine();
//Excercise 4. Perform addition with implicit data conversion
//4.2
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

int widgetsSold = 7;
Console.WriteLine(firstName2 + " sold " + (widgetsSold + 22) + " widgets.");

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//4.4
//int value = 7;

//value = value + 1;
//Console.WriteLine("First increment: " + value);

//value += 1;
//Console.WriteLine("Second increment: " + value);

//value++;
//Console.WriteLine("Third increment: " + value);

//value = value - 1;
//Console.WriteLine("First decrement: " + value);

//value -= 1;
//Console.WriteLine("Second decrement: " + value);

//value--;
//Console.WriteLine("Third decrement: " + value);

int value = 8;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

//4.5
int fahrenheit = 94;
double devided = 5.0 / 9.0;
double celsius = (fahrenheit - 32) * devided;
Console.WriteLine($"The temperature is {celsius} Celsius");

Console.WriteLine("----------------------------");
Console.WriteLine();
