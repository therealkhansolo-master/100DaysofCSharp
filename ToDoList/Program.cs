Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all ToDos");
Console.WriteLine("[A]dd a ToDo");
Console.WriteLine("[R]emove a ToDo");
Console.WriteLine("[E]xit");
Console.WriteLine();


List<string> ToDos = new List<string>();
string userInput = Console.ReadLine() ?? string.Empty;

if (userInput == "S" || userInput == "s")
{
    Console.WriteLine($"You selected: {userInput}");
    if (ToDos.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet.");
    }
    else if (ToDos.Count >= 1)
    {
        for (int i = 1; i < ToDos.Count; i++)
        {
            Console.WriteLine($"{i}. {ToDos[i]}");
            i++;
        }
    }
}
else if (userInput == "A" || userInput == "a")
{
    Console.Write("Enter the ToDo description: ");
    string newToDo = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(newToDo))
    {
        Console.WriteLine("The ToDo description cannot be empty.");
        Console.Write("Enter the ToDo description: ");
    }
    else if (ToDos.Contains(newToDo))
    {
        Console.WriteLine("The description must be unique.");
        Console.Write("Enter the ToDo description: ");
    }
    ToDos.Add(newToDo);
    Console.WriteLine($"ToDo successfully added: {newToDo}");
}

else if (userInput == "R" || userInput == "r")
{
    Console.WriteLine("Select the index of the ToDo you want to remove: ");
    Console.WriteLine(ToDos);
    if (ToDos.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet.");
    }

    string indexInput = Console.ReadLine() ?? string.Empty;
    if (int.TryParse(indexInput, out int index))
    {
        if (index >= 1 && index <= ToDos.Count)
        {
            string removedToDo = ToDos[index - 1];
            ToDos.RemoveAt(index - 1);
            Console.WriteLine($"ToDo successfully removed: {removedToDo}");
            Console.WriteLine("What else do you want to do?");
        }
        else if (string.IsNullOrEmpty(indexInput) || index < 1 || index > ToDos.Count)
        {
            Console.WriteLine("Selected index cannot be empty.");
            Console.WriteLine("Select the index of the ToDo you want to remove: ");
            Console.WriteLine(ToDos);
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

else if (userInput == "E" || userInput == "e")
{
    Console.WriteLine("Shutting down the program...");
}
else
{
    Console.WriteLine("Invalid input.");
}

Console.ReadKey();






