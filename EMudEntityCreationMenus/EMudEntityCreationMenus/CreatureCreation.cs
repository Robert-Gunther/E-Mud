using System;
namespace EMudEntityCreationMenus
{
	public class CreatureCreation
	{
		public CreatureCreation()
		{
			//string HelpMe;
			//string ModuleChoice;
			//ifstream HelpFile("CreatureHelp.txt");

			string Name = null;
			string Race = null;
			int Constitution = 0;
			int Strength = 0;
			int Charisma = 0;
			int Dexterity = 0;
			int Wisdom = 0;
			int Intelligence = 0;

			Console.WriteLine("Welcome to Creature Creation. For a list of commands for this module, input 'CreatureHelp'. ");
			Console.WriteLine(" ");
			string ModuleChoice = Console.ReadLine();
			//cin >> ModuleChoice;

			while (ModuleChoice != "Return")
			{
				if (ModuleChoice == "CreateCharacter")
				{
					Console.WriteLine("Would you like to create a player character(PC) or non-player character(NPC)?");
					Console.WriteLine("");

					string CharacterChoice = Console.ReadLine();

					if (CharacterChoice == "PC")
					{
						Console.WriteLine("You must enter the following things to create a PC: Name, Race, Constitution, Strength, Charisma, Dexterity, Wisdom, and Intelligence.");
						Console.WriteLine("");

						Console.WriteLine("Name: ");
						Name = Console.ReadLine();

						Console.WriteLine("Race: ");
						Race = Console.ReadLine();

						Console.WriteLine("Constitution: ");
						while (!int.TryParse(Console.ReadLine(), out Constitution))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Strength: ");
						while (!int.TryParse(Console.ReadLine(), out Strength))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Charisma: ");

						while(!int.TryParse(Console.ReadLine(), out Charisma))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Dexterity: ");
						while (!int.TryParse(Console.ReadLine(), out Dexterity))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Wisdom: ");
						while (!int.TryParse(Console.ReadLine(), out Wisdom))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Intelligence: ");
						while (!int.TryParse(Console.ReadLine(), out Intelligence))
						{
							Console.WriteLine("Please input a valid integer.");
						}
					}
					else if (ModuleChoice == "NPC")
					{
						Console.WriteLine("You must enter the following things to create a NPC: Name, Race, Constitution, Strength, Charisma, Dexterity, Wisdom, and Intelligence.");
						Console.WriteLine("");

						Console.WriteLine("Name: ");
						Name = Console.ReadLine();

						Console.WriteLine("Race: ");
						Race = Console.ReadLine();

						Console.WriteLine("Constitution: ");
						while (!int.TryParse(Console.ReadLine(), out Constitution))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Strength: ");
						while (!int.TryParse(Console.ReadLine(), out Strength))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Charisma: ");

						while (!int.TryParse(Console.ReadLine(), out Charisma))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Dexterity: ");
						while (!int.TryParse(Console.ReadLine(), out Dexterity))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Wisdom: ");
						while (!int.TryParse(Console.ReadLine(), out Wisdom))
						{
							Console.WriteLine("Please input a valid integer.");
						}

						Console.WriteLine("Intelligence: ");
						while (!int.TryParse(Console.ReadLine(), out Intelligence))
						{
							Console.WriteLine("Please input a valid integer.");
						}
					}
				}
				else if (ModuleChoice == "CreateMonster")
				{
					Console.WriteLine("You must enter the following things to create a monster: Name, Race, Constitution, Strength, Charisma, Dexterity, Wisdom, and Intelligence.");
					Console.WriteLine("");

					Console.WriteLine("Name: ");
					Name = Console.ReadLine();

					Console.WriteLine("Race: ");
					Race = Console.ReadLine();

					Console.WriteLine("Constitution: ");
					while (!int.TryParse(Console.ReadLine(), out Constitution))
					{
						Console.WriteLine("Please input a valid integer.");
					}

					Console.WriteLine("Strength: ");
					while (!int.TryParse(Console.ReadLine(), out Strength))
					{
						Console.WriteLine("Please input a valid integer.");
					}

					Console.WriteLine("Charisma: ");

					while (!int.TryParse(Console.ReadLine(), out Charisma))
					{
						Console.WriteLine("Please input a valid integer.");
					}

					Console.WriteLine("Dexterity: ");
					while (!int.TryParse(Console.ReadLine(), out Dexterity))
					{
						Console.WriteLine("Please input a valid integer.");
					}

					Console.WriteLine("Wisdom: ");
					while (!int.TryParse(Console.ReadLine(), out Wisdom))
					{
						Console.WriteLine("Please input a valid integer.");
					}

					Console.WriteLine("Intelligence: ");
					while (!int.TryParse(Console.ReadLine(), out Intelligence))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}

				ModuleChoice = Console.ReadLine();
			}
			if (ModuleChoice == "Return")
			{
				MainClass main = new MainClass();
			}
		}
	}
}
