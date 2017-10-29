using System;
namespace EMudEntityCreationMenus
{
	public class ItemCreation
	{
		public ItemCreation()
		{
			string ModuleChoice = null;

			string Name = null;
			string Type = null;
			string Material = null;
			int Defense = 0;
			int Attack = 0;
			int Weight = 0;

			Console.WriteLine("Welcome to Item Creation.");
			Console.WriteLine("To create a weapon, you will have to name it, assign it a type(melee, ranged, etc), a material (wood, iron, etc), an attack value and weight.");
			Console.WriteLine("To create a piece of armor, you will have to name it, assign it a type (light, medium, etc), material, defense value and weight.");
			Console.WriteLine("For a list of commands for this module, input 'ItemHelp'. ");
			Console.WriteLine("");

			ModuleChoice = Console.ReadLine();

			while (ModuleChoice != "Return")
			{
				if (ModuleChoice == "CreateWeapon")
				{

					Console.WriteLine("Name: ");
					Name = Console.ReadLine();
					Console.WriteLine("Type: ");
					Type = Console.ReadLine(); ;
					Console.WriteLine("Material: ");
					Material = Console.ReadLine();
					Console.WriteLine("Attack: ");
					while (!int.TryParse(Console.ReadLine(), out Attack))
					{
						Console.WriteLine("Please input a valid integer.");
					}
					Console.WriteLine("Weight: ");
					while (!int.TryParse(Console.ReadLine(), out Weight))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}
				else if (ModuleChoice == "BodyArmor")
				{
					Console.WriteLine("Name: ");
					Name = Console.ReadLine();
					Console.WriteLine("Type: ");
					Type = Console.ReadLine(); ;
					Console.WriteLine("Material: ");
					Material = Console.ReadLine();
					Console.WriteLine("Defense: ");
					while (!int.TryParse(Console.ReadLine(), out Defense))
					{
						Console.WriteLine("Please input a valid integer.");
					}
					Console.WriteLine("Weight: ");
					while (!int.TryParse(Console.ReadLine(), out Weight))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}
				else if (ModuleChoice == "Boots")
				{
					Console.WriteLine("Name: ");
					Name = Console.ReadLine();
					Console.WriteLine("Type: ");
					Type = Console.ReadLine(); ;
					Console.WriteLine("Material: ");
					Material = Console.ReadLine();
					Console.WriteLine("Defense: ");
					while (!int.TryParse(Console.ReadLine(), out Defense))
					{
						Console.WriteLine("Please input a valid integer.");
					}
					Console.WriteLine("Weight: ");
					while (!int.TryParse(Console.ReadLine(), out Weight))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}
				else if (ModuleChoice == "Gloves")
				{
					Console.WriteLine("Name: ");
					Name = Console.ReadLine();
					Console.WriteLine("Type: ");
					Type = Console.ReadLine(); ;
					Console.WriteLine("Material: ");
					Material = Console.ReadLine();
					Console.WriteLine("Defense: ");
					while (!int.TryParse(Console.ReadLine(), out Defense))
					{
						Console.WriteLine("Please input a valid integer.");
					}
					Console.WriteLine("Weight: ");
					while (!int.TryParse(Console.ReadLine(), out Weight))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}
				else if (ModuleChoice == "Helmet")
				{
					Console.WriteLine("Name: ");
					Name = Console.ReadLine();
					Console.WriteLine("Type: ");
					Type = Console.ReadLine(); ;
					Console.WriteLine("Material: ");
					Material = Console.ReadLine();
					Console.WriteLine("Defense: ");
					while (!int.TryParse(Console.ReadLine(), out Defense))
					{
						Console.WriteLine("Please input a valid integer.");
					}
					Console.WriteLine("Weight: ");
					while (!int.TryParse(Console.ReadLine(), out Weight))
					{
						Console.WriteLine("Please input a valid integer.");
					}
				}
			}
		}
	}
}
