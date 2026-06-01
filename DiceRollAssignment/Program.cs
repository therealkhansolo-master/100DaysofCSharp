using DiceRollAssignment;

Console.WriteLine("Hello there! Welcome to the dice rolling game.");
Random random = new Random();
bool keepPlaying = true;

while (keepPlaying)
{
    var dice = new Die(random);
    var guessingEngine = new GuessingEngine(dice);

    guessingEngine.Play();

    Console.WriteLine();
    Console.Write("Would you like to play again? (y/n):");

    string userResponse = Console.ReadLine() ?? string.Empty;
    if (userResponse.ToLower() != "y")
    {
        keepPlaying = false;
    }
}
Console.WriteLine("Thanks for playing! Press any key to exit.");
Console.ReadKey();