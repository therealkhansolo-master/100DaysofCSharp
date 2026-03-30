static int Addition(int num1, int num2, int sum, string @operator)
{
    sum = num1 + num2;
    Console.WriteLine($"{num1} + {@operator} + {num2} = {sum}");
    return sum;
}
static int Subtraction(int num1, int num2, int difference, string @operator)
{
    difference = num1 - num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {difference}");
    return difference;
}
static int Multiplication(int num1, int num2, int product, string @operator)
{
    product = num1 * num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {product}");
    return product;
}
static int Division(int num1, int num2, int quotient, string @operator)
{
    quotient = num1 / num2;
    Console.WriteLine($"{num1} {@operator} {num2} = {quotient}");
    return quotient;
}
bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

Console.WriteLine("Hello!");
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

if (EqualsCaseInsensitive(userChoice, "A"))
{
    int sum = inputNum1 + inputNum2;
    Addition(inputNum1, inputNum2, sum, "+");
}
else if (EqualsCaseInsensitive(userChoice, "S"))
{
    int difference = inputNum1 - inputNum2; 
    Subtraction(inputNum1, inputNum2, difference, "-");
}
else if (EqualsCaseInsensitive(userChoice, "M"))
{
    int product = inputNum1 * inputNum2;
    Multiplication(inputNum1, inputNum2, product, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close......");
Console.ReadKey();
