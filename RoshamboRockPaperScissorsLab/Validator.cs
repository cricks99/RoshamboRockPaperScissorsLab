namespace RoshamboRockPaperScissorsLab
{
    public static class Validator
    {
        public static string GetPlayerName(string suggestedName)
        {
            string name = "";

            while (name == "")
            {
                if (suggestedName != "")
                    Console.Write($"What name would you like to use for {suggestedName} (leave blank to use the same name)? ");
                else
                    Console.Write("\nWas is your name? ");
                
                name = Console.ReadLine();

                if (name == "")
                    if (suggestedName == "")
                        Console.WriteLine("I'd really like to know your name, please.");
                    else
                        name = suggestedName;
            }

            return name;
        }

        public static Roshambo GetRoshambo()
        {
            while (true)
            {
                Console.WriteLine("\nWhich do you choose?");
                Console.Write("(R)ock, (p)aper, or (s)cissors? ");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "r":
                    case "rock":
                        return Roshambo.Rock;
                    case "p":
                    case "paper":
                        return Roshambo.Paper;
                    case "s":
                    case "scissors":
                        return Roshambo.Scissors;
                    default:
                        Console.WriteLine("You did not enter a valid choice.");
                        break;
                }
            }
        }

        public static Player GetOtherPlayer(Player[] player)
        {
            int choice = 0;
            bool isValid = false;
            
            while (!isValid)
            {
                for (int i = 0; i < player.Length; i++)
                    Console.WriteLine($"{i + 1}. {player[i].PlayerName}");

                Console.Write("\nWho would you like to play against? ");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    if (!(isValid = choice >= 1 && choice <= player.Length))
                        Console.WriteLine("Please choose only a player number.");
                }

                catch(FormatException)
                {
                    Console.WriteLine("That's not a valid choice.  Choose a player number.");
                }
            }
            
            return player[choice - 1];
        }

        public static bool PlayAgain()
        {
            while (true)
            {
                Console.Write("\nPlay again [Y]/n? ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "y" || choice == "yes" || choice == "")
                    return true;
                if (choice == "n" || choice == "no")
                    return false;

                Console.WriteLine("I don't understand.  Choose Y or N.");
            }
        }
    }
}