public class Person
{
    public string Name { get; }
    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        if (name is null)
        {
            throw new ArgumentNullException("The name cannot be null.");
        }
        if (name == string.Empty)
        {
            throw new ArgumentException("The name cannot be empty.");
        }
        if (yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
        {
            throw new ArgumentOutOfRangeException("The year of birth must be " +
                "between 1900 and the current year.");
        }

        Name = name;
        YearOfBirth = yearOfBirth;
    }
}


public interface IPeopleRepository
{
    Person Read(int personId);
}

public interface ILogger
{
    void Log(Exception ex);
}

public class PersonDataReader
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly ILogger _logger;

    public PersonDataReader(
        IPeopleRepository personRepository,
        ILogger logger)
    {
        _peopleRepository = personRepository;
        _logger = logger;
    }

    public Person ReadPersonData(int personId)
    {
        try
        {
            return _peopleRepository.Read(personId);
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            throw;
        }
    }
}

using System.Runtime.Serialization;
[Serializable]
public class CustomException : Exception
{
    public int StatusCode { get; }

    protected CustomException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {

    }

    public CustomException()
    {

    }

    public CustomException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }

    public CustomException(
        string message,
        int statusCode,
        Exception innerException) : base(message, innerException)
    {
        StatusCode = statusCode;
    }

    public CustomException(string message) : base(message)
    {

    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}

class HttpRequestException : Exception
{
    public HttpRequestException()
    {

    }

    public HttpRequestException(string message) : base(message)
    {

    }

    public HttpRequestException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}

class InvalidPasswordException : Exception
{
    public InvalidPasswordException()
    {

    }

    public InvalidPasswordException(string message) : base(message)
    {

    }

    public InvalidPasswordException(string message, Exception innerException)
        : base(message, innerException)
    {

    }
}

Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
try
{
int number = int.Parse(input);
var result = 10 / number;
Console.WriteLine($"10 / {number} is {result}");
}
catch (FormatException ex)
{
Console.WriteLine(
    "Wrong format. Input string was not parsable to int. " +
    "Exception message: " + ex.Message);
}
catch (DivideByZeroException ex)
{
Console.WriteLine(
    "Division by zero is an invalid operation. " +
    "Exception message: " + ex.Message);
}
catch (Exception ex)
{
Console.WriteLine(
    "Unexpected exception occurred. " +
    "Exception message: " + ex.Message);
}
finally
{
Console.WriteLine("Executing finally block.");
}


var logger = new Logger();

try
{
Run();
}
catch (Exception ex)
{
Console.WriteLine(
    "Sorry. The application has experienced " +
    "an error. The error message: " + ex.Message);
logger.Log(ex);
}

GotoShowcase();
Console.WriteLine("Press any key to close.");
Console.ReadKey();


int GetFirstElement(IEnumerable<int> numbers)
{
foreach (var number in numbers)
{
return number;
}

throw new InvalidOperationException(
    "The collection cannot be empty.");
}

bool IsFirstElementPositive(IEnumerable<int> numbers)
{
try
{
var firstElement = GetFirstElement(numbers);
return firstElement > 0;
}
catch (InvalidOperationException ex)
{
Console.WriteLine("The collection is empty!");
return true;
}
catch (NullReferenceException ex)
{
Console.WriteLine("Sorry! The application experienced " +
    "an unexpected error.");
//alternatively, we can just rethrow the original exception:
//throw;
throw new ArgumentNullException("The collection is null.", ex);
}
}

//Exception filters
try
{
var dataFromWeb = SendHttpRequest("www.someAddress.com/get/someResource");
}
catch (HttpRequestException ex) when (ex.Message == "403")
{
Console.WriteLine("It was forbidden to access the resource.");
throw;
}
catch (HttpRequestException ex) when (ex.Message == "404")
{
Console.WriteLine("The resource was not found.");
throw;
}
catch (HttpRequestException ex) when (ex.Message.StartsWith("4"))
{
Console.WriteLine("Some kind of client error.");
throw;
}
catch (HttpRequestException ex) when (ex.Message == "500")
{
Console.WriteLine("The server has experienced an internal error.");
throw;
}

object SendHttpRequest(string url)
{
//send the request
return null;
}

bool ValidatePassword(string password)
{
return password == "admin";
}

void ValidatePasswordWithException(string password)
{
if (password != "admin")
{
throw new InvalidPasswordException(
    $"{password} is not a valid password.");
}
}

void RecursiveMethod(int counter)
{
Console.WriteLine("I'm going to call myself. Counter is: " + counter);
if (counter < 10)
{
RecursiveMethod(counter + 1);
}
}

void Run()
{
try
{
Console.WriteLine("Enter a word");
var word = Console.ReadLine();
Console.WriteLine("Count of characters is " + word.Length);
}
catch (NullReferenceException ex)
{
Console.WriteLine(
    "The input is null, and its length cannot be calculated. " +
    "Did you press CTRL+Z in the console?");
logger.Log(ex);
throw;
}
}

void GotoShowcase()
{
//goto
int someNumber = 0;
if (someNumber < 0)
{
goto NegativeNumber;
}

Console.WriteLine("The number is positive or zero.");
return;

NegativeNumber:
Console.WriteLine("The number is negative.");
}

class Logger
{
    public void Log(Exception ex)
    {
        Console.WriteLine("Writing the exception to a file with a message: " + ex.Message);
    }
}

//EXERCISE 28
public static class ExceptionsDivisionExercise
{
    public static int DivideNumbers(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Division by zero.");
            return 0;
        }
        finally
        {
            Console.WriteLine("The DivideNumbers method ends.");
        }
    }
}

//EXERCISE 29
public static class ExceptionsRethrowing
{
    public static int GetMaxValue(List<int> numbers)
    {

        try
        {
            return numbers.Max();
        }
        catch (ArgumentNullException ex)
        {
            throw new ArgumentNullException("The numbers list cannot be null.", ex);

        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("The numbers list cannot be empty.");
            throw;

        }
    }
}

//EXERCISE 30
public class InvalidTransactionException : Exception
{
    public TransactionData TransactionData { get; }

    public InvalidTransactionException()
    {

    }

    public InvalidTransactionException(string message) : base(message)
    {

    }

    public InvalidTransactionException(string message, Exception innerexception) : base(message, innerexception)
    {

    }

    public InvalidTransactionException(string message, TransactionData transactionData) : base(message)
    {
        TransactionData = transactionData;
    }

    public InvalidTransactionException(string message, TransactionData transactionData, Exception innerException) : base(message, innerException)
    {
        TransactionData = transactionData;
    }
}

public class TransactionData
{
    public string Sender { get; init; }
    public string Receiver { get; init; }
    public decimal Amount { get; init; }
}