using System;
////Microsoft Learn excercises

//Random dice = new();
//int roll1 = dice.Next();
//int roll2 = dice.Next(101);
//int roll3 = dice.Next(50, 101);

//Console.WriteLine($"First roll:  {roll1}");
//Console.WriteLine($"Second roll: {roll2}");
//Console.WriteLine($"Third roll: {roll3}");

//int firstValue = 500;
//int secondValue = 600;
//int largerValue = Math.Max(firstValue, secondValue);


//Console.WriteLine(largerValue);

//Add decision logic to your code using `if`, `else`, and `else if` statements in C#

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if (total < 14)
using System.Runtime.CompilerServices;

{
	//Console.WriteLine("You win!");
}
//else if (total > 15)
{
	//Console.WriteLine("You lost :( ");
}

//if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
{
	//Console.WriteLine("Bonus!");
	//total += 2;
	//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
}

//Excercise Create nested decision logic with if, else if, and else

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
	if ((roll1 == roll2) && (roll2 == roll3))
	{
		//Console.WriteLine("You rolled triples! +6 bonus to total!");
		total += 6;
	}
	else
	{
		//Console.WriteLine("You rolled doubles! +2 bonus to total!");
		total += 2;
	}

}

if (total >= 15)
{
	//Console.WriteLine("You win!");
}
else
{
	//Console.WriteLine("Sorry, you lose.");
}

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
	//Console.WriteLine(name);
}
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int item in inventory)
{
	//Console.WriteLine(item);
	sum += item;
}
//Console.WriteLine($"We have {sum} items in inventory.");

string[] list = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string item in list)
{
	if (item.StartsWith("C"))
	{
		//Console.WriteLine(item);
	}

}


//------------------------------------------------------------------------------------------------------------
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);
int x = 0;

foreach (char i in message)
{
	if (i == 'o')
	{
		x++;
	}
}

string newMessage = new String(message);

//Console.WriteLine(newMessage);
//Console.WriteLine($"'o' appears {x} times.");

//------------------------------------------------------------------------------------------------
int currentAssignments = 5;

int[] jensScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] jesperScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] johnScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] joseScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] students = new string[] { "Jens", "Jesper", "John", "Jose", "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

//Console.WriteLine("Student\t\tGrade\n");
foreach (string student in students)
{
	string currentStudent = student;
	if (currentStudent == "Jens")
		studentScores = jensScores;
	else if (currentStudent == "Jesper")
		studentScores = jesperScores;
	else if (currentStudent == "John")
		studentScores = johnScores;
	else if (currentStudent == "Jose")
		studentScores = joseScores;
	else if(currentStudent == "Sophia")
		studentScores = sophiaScores;
	else if (currentStudent == "Andrew")
		studentScores = andrewScores;
	else if (currentStudent == "Emma")
		studentScores = emmaScores;
	else if (currentStudent == "Logan")
		studentScores = loganScores;
	else if (currentStudent == "Becky")
		studentScores = beckyScores;
	else if (currentStudent == "Chris")
		studentScores = chrisScores;
	else if (currentStudent == "Eric")
		studentScores = ericScores;
	else if (currentStudent == "Gregor")
		studentScores = gregorScores;
	else
		continue;



	int sumAssignmentScores = 0;
	decimal currentStudentGrade = 0;
	int extraScores = 0;
	string exam = "";

	foreach (int score in studentScores)
	{
		extraScores += 1;

		if (extraScores <= currentAssignments)
			sumAssignmentScores += score;
		else
			sumAssignmentScores += score / 10;
	}

	currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;
	
	if (currentStudentGrade <= 59)
	{
		exam = "F";
	}
	else if (currentStudentGrade >= 60 && currentStudentGrade <= 62)
	{
		exam = "D-";
	}
	else if (currentStudentGrade >= 63 && currentStudentGrade <= 66)
	{
		exam = "D";
	}
	else if (currentStudentGrade >= 67 && currentStudentGrade <= 69)
	{
		exam = "D+";
	}
	else if (currentStudentGrade >= 70 && currentStudentGrade <= 72)
	{
		exam = "C-";
	}
	else if (currentStudentGrade >= 73 && currentStudentGrade <= 76)
	{
		exam = "C";
	}
	else if (currentStudentGrade >= 77 && currentStudentGrade <= 79)
	{
		exam = "C+";
	}
	else if (currentStudentGrade >= 80 && currentStudentGrade <= 82)
	{
		exam = "B-";
	}
	else if (currentStudentGrade >= 83 && currentStudentGrade <= 86)
	{
		exam = "B";
	}
	else if (currentStudentGrade >= 87 && currentStudentGrade <= 89)
	{
		exam = "B+";
	}
	else if (currentStudentGrade >= 90 && currentStudentGrade <= 92)
	{
		exam = "A-";
	}
	else if (currentStudentGrade >= 93 && currentStudentGrade <= 96)
	{
		exam = "A";
	}
	else
	{
		exam = "A+";
	}

	//Console.WriteLine($"{currentStudent}:\t\t {currentStudentGrade}\t{exam}");

}
//Console.WriteLine("Press the Enter key to continue");
//Console.ReadKey();
//----------------------------------------------------------------------------------------------------
//string value1 = "A";
//string value2 = "a ";
//Console.WriteLine(value1.ToLower() == value2.Trim());
//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

int saleAmount = 50;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50 )}");


Random coin = new Random();
//int side = coin.Next(0, 2);

//Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

//___________________________________________________________________
//___________________________________________________________________

//int[] times = { 800, 1200, 1600, 2000 };
//int diff = 0;

//Console.WriteLine("Enter current GMT");
//int currentGMT = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Current Medicine Schedule:");
//DisplayTimes();


//Console.WriteLine("Enter new GMT");
//int newGMT = Convert.ToInt32(Console.ReadLine());

//if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//{
//	Console.WriteLine("Invalid GMT");
//}
//else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//{
//	diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//	AdjustTimes();
//}
//else
//{
//	diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//	AdjustTimes();
//}

//Console.WriteLine("New Medicine Schedule:");
//DisplayTimes();

//Console.WriteLine();

//void DisplayTimes()
//{
//	/* Format and display medicine times */
//	foreach (int val in times)
//	{
//		string time = val.ToString();
//		int len = time.Length;

//		if (len >= 3)
//		{
//			time = time.Insert(len - 2, ":");
//		}
//		else if (len == 2)
//		{
//			time = time.Insert(0, "0:");
//		}
//		else
//		{
//			time = time.Insert(0, "0:0");
//		}

//		Console.Write($"{time} ");
//	}

//	Console.WriteLine();
//}
//void AdjustTimes()
//{
//	/* Adjust the times by adding the difference, keeping the value within 24 hours */
//	for (int i = 0; i < times.Length; i++)
//	{
//		times[i] = ((times[i] + diff)) % 2400;
//	}
//}



//Console.ReadKey();

//CountTo(5);

//void CountTo(int max)
//{
//	for (int i = 0; i < max; i++)
//	{
//		Console.Write($"{i}, ");
//	}
//}

//int[] schedule = { 800, 1200, 1600, 2000 };
//DisplayAdjustedTimes(schedule, 6, -6);

//void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
//{
//	int diff = 0;
//	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//	{
//		Console.WriteLine("Invalid GMT.");
//	}
//	else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//	{
//		diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//	}
//	else
//	{
//		diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//	}
//}

//string[] students1 = { "Jenna", "Ayesha", "Carlos", "Viktor" };

//DisplayStudents(students1);
//DisplayStudents(new string[] { "Robert", "Vanya" });

//void DisplayStudents(string[] students1)
//{
//	foreach (string student in students1)
//	{
//		Console.Write($"{student}, ");
//	}
//	Console.WriteLine();
//}

string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", false);
RSVP("Nadia", 2, "nuts", true);
RSVP("Noor", 1, "none", true);
RSVP("Jonte", 3, "gluten", false);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
ShowRSVPs();
void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
	if (inviteOnly)
	{
		bool found = false;
		foreach (string guest in guestList)
		{
			if (guest.Equals(name))
			{
				found = true;
				break;
			}
		}
		if (!found)
		{
			Console.WriteLine($"Sorry, {name} is not on the guest list");
			return;
		}
	}

	rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
	count++;
}

void ShowRSVPs()
{
	Console.WriteLine("\nTotal RSVPs:");
	for (int i = 0; i < count; i++)
	{
		Console.WriteLine(rsvps[i]);
	}
}