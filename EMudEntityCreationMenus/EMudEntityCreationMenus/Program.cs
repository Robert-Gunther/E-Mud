using System;

namespace EMudEntityCreationMenus
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//string HelpMe;
			//ifstream HelpFile("Help.txt");

			//Get.GetMain();

			Console.WriteLine("Welcome to E-MUD, the Exceptional MUD engine! For a list of starting commands, input 'Help.'");
			Console.WriteLine(" ");

			string ModuleChoice = Console.ReadLine();

			if (ModuleChoice == "Creature")
			{
				CreatureCreation creation = new CreatureCreation();
			}
			else if (ModuleChoice == "Item")
			{
				ItemCreation creation = new ItemCreation();
			}
			//Console.ReadLine(ModuleChoice);



			/*while (ModuleChoice != "Exit")
            {


                if (ModuleChoice == "Creature")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        cout << "\n";
                    }

                    MakeCreature.Creature();

                }
                else if (ModuleChoice == "Item")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        cout << "\n";
                    }

                    MakeItems.Item();

                }


                if (ModuleChoice == "Help")
                {
                    if (HelpFile.is_open())
                    {
                        while (!HelpFile.eof())
                        {
                            for (int read = 0; read < 4; read++)
                            {
                                getline(HelpFile, HelpMe);
                                cout << HelpMe << endl;
                            }
                            HelpFile.close();
                        }

                    }
                    else
                    {
                        cout << "Unable to open help file. The file may be corrupt or missing." << endl;
                        break;
                    }
                }

            }*/

			//return 0;
		}
	}
}
