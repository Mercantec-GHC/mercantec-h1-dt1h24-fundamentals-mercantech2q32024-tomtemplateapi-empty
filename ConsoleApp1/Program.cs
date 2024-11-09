using System;

class Program
{
	static void Main()
	{
		Console.OutputEncoding = System.Text.Encoding.UTF8;

		Console.WriteLine("A cat is hiding in one of the five boxes.\n" +
			"The boxes are numbered one to five and are all lined up in order.\n" +
			"Each night, the sneaky little cat hides in an adjacent box,\n" +
			"exactly one box away from the box it’s in during the day.\n" +
			"Each morning, you can open exactly one box to see if the cat is in there.\n" +
			"Can you say with certainty that you will find the cat? ");
		for (int i = 1; i <= 5; i++)
		{
			DisplayBoxes(i);
		}
		UsersGuessInput();
	}

	static void DisplayBoxes(int num)
	{
		string top = "---------";
		string side = "|";


		Console.Write($"{top}\n{side}\t{side}\n{side}   {num}   {side}\n{side}\t{side}\n{top}\n");
	}

	static void UsersGuessInput()
	{
		int usersGuess = 0;
		int boxWithCat = GetBoxWIthCat();

		while (true)
		{
			Console.WriteLine("Guess where the cat is today? Choose one number from 1 to 5.");
			string usersInput = Console.ReadLine();

			// Console.WriteLine("Cat is in the box #" + boxWithCat);
			
			if (int.TryParse(usersInput, out usersGuess))
			{
				if (usersGuess <= 0 || usersGuess > 5)
				{
					Console.WriteLine("Wrong input. Try again.");
				}

				else
				{

					if (usersGuess == boxWithCat)
					{
						Console.WriteLine("You found a cat!");
						Console.WriteLine(ShowTheCat());
						break;
					}

					else
					{
						Console.WriteLine(@"Nope...  ¯_(ツ)_/¯   Cat is hiding in another box. Try again tomorrow.");
						Console.WriteLine();
						boxWithCat++;
					}
				}
			}
		}
	}
	static int GetBoxWIthCat()
	{
		int[] boxes = { 1, 2, 3, 4, 5 };

		Random random = new Random();
		int boxWithCat = random.Next(1, 6);

		return boxWithCat;

	}
	static string ShowTheCat()
	{

		string cat2 = @"    /\___/\
   /       \
  l  u   u  l
--l----*----l--
   \   w   /     - Meow!
     ======
   /       \ __
   l        l\ \
   l        l/ / 
   l  l l   l /
   \ ml lm /_/";
		return cat2;
	}
}