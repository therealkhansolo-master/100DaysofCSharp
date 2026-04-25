bool shallExit = false;
List<string> ToDos = new List<string>();
Console.WriteLine("Hello!");
string currentPrompt = "What do you want to do?";
while (!shallExit)
{
    Console.WriteLine();
    PrintMenu(currentPrompt);
    string userInput = Console.ReadLine() ?? string.Empty;

    // Using a switch statement to handle the menu choices
    // The case labels handle both upper and lowercase letters
    switch (userInput)
    {
        case "S":
        case "s":
            SeeAllToDos();
            currentPrompt = "What else do you want to do?";
            break;
        case "A":
        case "a":
            AddTodo();
            currentPrompt = "What else do you want to do?";
            break;
        case "R":
        case "r":
            RemoveToDo();
            currentPrompt = "What else do you want to do?";
            break;
        case "E":
        case "e":
            // Setting the flag to true will stop the while loop and exit the app
            shallExit = true;
            Console.WriteLine("Shutting down the program........");
            Environment.Exit(0);
            break;
        default:
            // Requirement: If input is invalid or empty, print "Incorrect input" and repeat
            Console.WriteLine("Incorrect input.");
            break;
    }
}

void PrintMenu(string prompt)
{
    Console.WriteLine();
    Console.WriteLine(prompt);
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void SeeAllToDos()
{
    // Requirement: Check if the list is empty first
    if (ToDos.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet.");
        return;
    }
    // Printing each TODO prefixed with an index starting from 1
    for (int i = 1; i <= ToDos.Count; i++)
    {
        Console.WriteLine($"{i}. {ToDos[i - 1]}");
    }
}

void AddTodo()
{
    bool isDescriptionValid = false;
    // Loop until the user provides a unique and non-empty description
    while (!isDescriptionValid)
    {
        Console.Write("Enter the ToDo Description: ");
        string description = Console.ReadLine() ?? string.Empty;

        // Check for empty input
        if (string.IsNullOrEmpty(description))
        {
            Console.WriteLine("The description cannot be empty.");
        }
        // Check if the TODO already exists to ensure uniqueness
        else if (ToDos.Contains(description))
        {
            Console.WriteLine("The description must be unique.");
        }
        else
        {
            // If valid, add it to the list and break the validation loop
            isDescriptionValid = true;
            ToDos.Add(description);
            Console.WriteLine($"ToDo successfully added: {description}");
        }
    }
}

void RemoveToDo()
{
    // Requirement: If no TODOs exist, print message and return to menu
    if (ToDos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    bool isIndexValid = false;
    // Loop until the user provides a correct index
    while (!isIndexValid)
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        // Re-print the list so the user can see the indices
        SeeAllToDos();

        string input = Console.ReadLine() ?? string.Empty;
        // Check if user input is empty
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Selected index cannot be empty.");
            continue;
        }

        // Try to parse the input into a number
        // Subtract 1 from the input because the internal List is 0-indexed 
        if (int.TryParse(input, out int index) && index >= 1 && index <= ToDos.Count)
        {
            // Store description for the success message
            string removedDescription = ToDos[index - 1];
            ToDos.RemoveAt(index - 1);
            Console.WriteLine($"TODO removed: {removedDescription}");
            isIndexValid = true; // Ends the removal loop
        }
        else
        {
            // If not a number or out of range
            Console.WriteLine("The given index is not valid.");
        }
    }
}







































//Compiler Error CS8070
//Control cannot fall out of switch from final case label ('label')
//This error occurs when the last case or default case of a switch statement doesn't end with a jump statement such as:
//break
//return
//throw

// CS8070.cs example
//public class MyClass
//{
//    public static void Main()
//    {
//        int i = 2;
//        int j = 0;

//        switch (i)
//        {
//            case 1:
//                i++;
//                break;

//            // Compiler error CS8070 is reported on the following line.
//            case 2:
//                i += 2;
//                // To resolve the error, uncomment one of the following example statements.  
//                // break;
//                // return;
//                // throw new Exception("Fin");
//        }

//        switch (j)
//        {
//            case 1:
//                j++;
//                break;

//            case 2:
//                j += 2;
//                break;

//            // Compiler error CS8070 is reported on the following line.
//            default:
//                Console.WriteLine("Default");
//                // To resolve the error, uncomment the following line:
//                // break;
//        }
//    }
//}

//Compiler Error CS0163
//Control cannot fall through from one case label ('label') to another
//When a switch statement contains more than one switch section, you must explicitly terminate each section, including the last one, by using one of the following keywords:
//return
//goto
//break
//throw
//If you want to implement "fall through" behavior from one section to the next, use goto case #.

//// CS0163.cs example
//public class MyClass
//{
//    public static void Main()
//    {
//        int i = 0;

//        switch (i)   // CS0163  
//        {
//            // Compiler error CS0163 is reported on the following line.  
//            case 1:
//                i++;
//            // To resolve the error, uncomment one of the following example statements.  
//            // return;  
//            // break;  
//            // goto case 3;  

//            case 2:
//                i++;
//                return;

//            case 3:
//                i = 0;
//                break;

//            default:
//                Console.WriteLine("Default");
//                break;
//        }
//    }
//}

//Note that it is correct to have several cases for one implementation, like in the following snippet:
//public class MyClass
//{
//    public static void Main()
//    {
//        int i = 0;

//        switch (i)
//        {
//            case 1:
//            case 2:    // No CS0163
//                i++
//                break;

//            default:
//                break;
//        }
//    }
//}


//if (userInput == "S" || userInput == "s")
//{
//    Console.WriteLine($"You selected: {userInput}");
//    if (ToDos.Count == 0)
//    {
//        Console.WriteLine("No ToDos have been added yet.");
//    }
//    else if (ToDos.Count >= 1)
//    {
//        for (int i = 1; i < ToDos.Count; i++)
//        {
//            Console.WriteLine($"{i}. {ToDos[i]}");
//            i++;
//        }
//    }
//}
//else if (userInput == "A" || userInput == "a")
//{
//    Console.Write("Enter the ToDo description: ");
//    string newToDo = Console.ReadLine() ?? string.Empty;
//    if (string.IsNullOrWhiteSpace(newToDo))
//    {
//        Console.WriteLine("The ToDo description cannot be empty.");
//        Console.Write("Enter the ToDo description: ");
//    }
//    else if (ToDos.Contains(newToDo))
//    {
//        Console.WriteLine("The description must be unique.");
//        Console.Write("Enter the ToDo description: ");
//    }
//    ToDos.Add(newToDo);
//    Console.WriteLine($"ToDo successfully added: {newToDo}");
//}

//else if (userInput == "R" || userInput == "r")
//{
//    Console.WriteLine("Select the index of the ToDo you want to remove: ");
//    Console.WriteLine(ToDos);
//    if (ToDos.Count == 0)
//    {
//        Console.WriteLine("No ToDos have been added yet.");
//    }

//    string indexInput = Console.ReadLine() ?? string.Empty;
//    if (int.TryParse(indexInput, out int index))
//    {
//        if (index >= 1 && index <= ToDos.Count)
//        {
//            string removedToDo = ToDos[index - 1];
//            ToDos.RemoveAt(index - 1);
//            Console.WriteLine($"ToDo successfully removed: {removedToDo}");
//            Console.WriteLine("What else do you want to do?");
//        }
//        else if (string.IsNullOrEmpty(indexInput) || index < 1 || index > ToDos.Count)
//        {
//            Console.WriteLine("Selected index cannot be empty.");
//            Console.WriteLine("Select the index of the ToDo you want to remove: ");
//            Console.WriteLine(ToDos);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input.");
//    }
//}

//else if (userInput == "E" || userInput == "e")
//{
//    Console.WriteLine("Shutting down the program...");
//}
//else
//{
//    Console.WriteLine("Invalid input.");
//}

Console.ReadKey();






