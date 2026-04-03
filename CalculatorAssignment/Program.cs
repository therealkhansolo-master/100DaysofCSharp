static int Addition(int num1, int num2, string @operator)
{
    int sum = num1 + num2;
    Console.WriteLine($"{num1} + {@operator} + {num2} = {sum}");
    return sum;
}
static int Subtraction(int num1, int num2, string @operator)
{
    int difference = num1 - num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {difference}");
    return difference;
}
static int Multiplication(int num1, int num2, string @operator)
{
    int product = num1 * num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {product}");
    return product;
}
static int Division(int num1, int num2, string @operator)
{
    int quotient = num1 / num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {quotient}");
    return quotient;
}
bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

Console.WriteLine("Hello! Welcome to Mr Khan's calculator app.");
Console.Write("Input the first number: ");
int inputNum1 = int.Parse(Console.ReadLine());
Console.Write("Input the second number: ");
int inputNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("Enter your choice here: ");
string userChoice = Console.ReadLine();
int finalResult;

//if (EqualsCaseInsensitive(userChoice, "A"))
//{
//    finalResult = Addition(inputNum1, inputNum2, "+");
//}
//else if (EqualsCaseInsensitive(userChoice, "S"))
//{
//    finalResult = Subtraction(inputNum1, inputNum2, "-");
//}
//else if (EqualsCaseInsensitive(userChoice, "M"))
//{
//    finalResult = Multiplication(inputNum1, inputNum2, "*");
//}
//else
//{
//    Console.WriteLine("Invalid choice!");
//}

switch (userChoice)
{
    case "A":
    case "a":
        int sum = inputNum1 + inputNum2;
        Addition(inputNum1, inputNum2, "+");
        break;
    case "S":
    case "s":
        int difference = inputNum1 - inputNum2; 
        Subtraction(inputNum1, inputNum2, "-");
        break;
    case "M":
    case "m":
        int product = inputNum1 * inputNum2;
        Multiplication(inputNum1, inputNum2, "*");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}

Console.WriteLine("Press any key to close......");
Console.ReadKey();
