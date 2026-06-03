using System.Diagnostics;

var internationalPizzaDay23 = new DateTime(2023, 2, 9);
Console.WriteLine("Year is: " + internationalPizzaDay23.Year);
Console.WriteLine("Month is: " + internationalPizzaDay23.Month);
Console.WriteLine("Day is: " + internationalPizzaDay23.Day);
Console.WriteLine("Day of the week is: " + internationalPizzaDay23.DayOfWeek);
var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle(50, 100);

Console.WriteLine(
    "Count of Rectangle objects is " + Rectangle.CountOfInstances);

Console.WriteLine("Width is " + rectangle1.Width);
Console.WriteLine("Height is " + rectangle1.GetHeight());
Console.WriteLine("Area is " + rectangle1.CalculateArea());
Console.WriteLine("Circumference is " + rectangle1.CalculateCircumference());

Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);
var appointmentOneWeekFromNow = new MedicalAppointment("Margaret Smith");
var appointmentUnknownPatient = new MedicalAppointment();
var nameOnly = new MedicalAppointment("Name only");

//Stopwatch type
Stopwatch stopwatch = Stopwatch.StartNew();
//code to be measured
stopwatch.Stop();
Console.WriteLine("Elapsed time in ms: " + stopwatch.ElapsedMilliseconds);

Console.ReadKey();

static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
}

class Rectangle
{
    //const fields are implicitly static
    public const int NumberOfSides = 4;

    //a static property, belonging to the class as a whole
    public static int CountOfInstances { get; private set; }

    //a static field
    private static DateTime _firstUsed;

    //a static constructor
    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }

    public Rectangle(int width, int height)
    {
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
        ++CountOfInstances;
    }

    //readonly property - can only be set in the constructor
    public int Width { get; }

    //achieving a similar behavior as properties give with using methods
    private int _height;
    public int GetHeight() => _height;

    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueIfNonPositive;
        }
        return length;
    }

    //expression-bodied methods
    //could not be made static as they use the state of an instance (width and height)
    public int CalculateCircumference() => 2 * Width + 2 * _height;

    public int CalculateArea() => Width * _height;

    //a get-only, expression-bodied property
    public string Description => $"A rectangle with width {Width} " +
        $"and height {_height}";

    //a static method, not using any state of an instance
    public static string DescribeGenerally() =>
        $"A plane figure with four straight sides and four right angles.";

    //can be made static
    public string NotUsingAnyState() => "abc";
}

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    //calling one constructor from another
    //commented now, as the below constructor with optional parameters
    //also allows to skip the second parameter
    //public MedicalAppointment(string patientName) :
    //    this(patientName, 7)
    //{
    //}

    public MedicalAppointment(
        string patientName = "Unknown", int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    public DateTime GetDate() => _date;

    public void Reschedule(DateTime date)
    {
        _date = date;
        var printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }

    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd);
    }
}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine(
            "Appointment will take place on " + medicalAppointment.GetDate());
    }
}

//class someClass
//{
//    private int _someField;

//    public static string AsString() => $"Value of field is {_someField}.";
//    //the above will not compile, as static methods cannot access instance fields.
//    //To make it work, we would need to make the field static as well,
//    //but then it would be shared across all instances of the class, which might not be the intended behavior.
//}

//char
using System.Diagnostics;
using System.Globalization;
using System.Text;

char letter = 'a';
char digit = '4';
char symbol = '!';
char newLine = '\n';

var isUppercase = char.IsUpper(letter); //will be false
var isLetter = char.IsLetter(digit); //will be false
var isDigit = char.IsDigit(letter); //will be false
var isWhitespace = char.IsWhiteSpace(newLine); //will give true
var aToUpper = char.ToUpper(letter); //will give 'A'

//chars and ints
char someChar = (char)100;
int asInt = (int)'t';

for (char c = 'A'; c < 'z'; ++c)
{
    Console.Write(c + ", ");
}
Console.WriteLine();

//encoding
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Greek omega letter:");
char omega = 'Ω';
Console.WriteLine(omega);
Console.WriteLine((int)omega);
Console.WriteLine("Arabic dal letter:");
char dal = 'د';
Console.WriteLine(dal);
Console.WriteLine((int)dal);

//immutability of strings
string text1 = "abc";

//the text1 will not be affected in this method
Modify(text1);
Console.WriteLine(text1);

string immutableText = "abc";
immutableText += "d"; //a new string is built here

var upperCase = immutableText.ToUpper();
Console.WriteLine(immutableText);
Console.WriteLine(upperCase);

//StringBuilder

Console.WriteLine("Please wait, testing performance of StringBuilder...");
const int Count = 100_000; //reduce this number if it takes too long

var text = string.Empty;
Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < Count; i++)
{
    text += "a";
}
stopwatch.Stop();
Console.WriteLine(
    $"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
var stringBuilder = new StringBuilder();
for (int i = 0; i < Count; i++)
{
    stringBuilder.Append("a");
}
var text2 = stringBuilder.ToString();
stopwatch.Stop();
Console.WriteLine(
    $"StringBuilder took {stopwatch.ElapsedMilliseconds} ms");

//String interning

string textA = "abc";
string textB = "abc";
Console.WriteLine(object.ReferenceEquals(textA, textB)); //will be true

//Formatting of strings
var number1 = 100;
var number2 = 200;

var formattedText = string.Format(
    "Number 1 is {0}, number 2 is {1,10:C}",
    number1,
    number2);

Console.WriteLine(formattedText);

decimal someDecimal = 1.46m;
Console.WriteLine(
    String.Format("Number is {0:C3}", someDecimal));
Console.WriteLine(
    String.Format("Number is {0:F1}", someDecimal));
Console.WriteLine(
    String.Format("Number is {0:P}", someDecimal));

Console.WriteLine();

DateTime someDate = new DateTime(2024, 5, 6, 12, 54, 12);
Console.WriteLine(
    $"Date is {someDate:d}");
Console.WriteLine(
    $"Date is {someDate:D}");
Console.WriteLine(
    String.Format("Date is {0:MM/yyyy}", someDate));

//Culture-specific string formatting
Console.WriteLine("Enter a number");
var userInput = Console.ReadLine();
decimal result = decimal.Parse(userInput); //uses current culture
Console.WriteLine("Number is " + result);

CultureInfo currentCulture = CultureInfo.CurrentCulture;
Console.WriteLine("en-US culture"); //Current culture may not be en-US different on your machine!

var date = new DateTime(2025, 3, 2, 12, 16, 14);
var number = 1.9m;

Console.WriteLine(date.ToString("d"));
Console.WriteLine(number);

Console.WriteLine("pl-PL culture");
CultureInfo.CurrentCulture = new CultureInfo("pl-PL");
Console.WriteLine(date.ToString("d"));
Console.WriteLine(number);

Console.WriteLine(
    date.ToString(CultureInfo.InvariantCulture)); //should be the same for you as for me


Console.WriteLine("Press any key to close.");
Console.ReadKey();

void Modify(string input)
{
    input += "xyz";
}

using System.Diagnostics;


//numeric overflow
var twoBillion = 2_000_000_000;
Console.WriteLine(
    "Two billion plus two billion is " + (twoBillion + twoBillion));

//this method will throw a NumericOverflow exception
//SomeMethodWithCheckedContext(twoBillion, twoBillion);

//Example when numeric overflow is dangerous
int sumSoFar = 1_900_000_000;
int nextTransaction = 1_000_000_000;
int sumAfterTransaction =
    sumSoFar + nextTransaction;

//to avoid the overflow, we could use long
//long sumAfterTransaction =
//    (long)sumSoFar + (long)nextTransaction;
if (sumAfterTransaction > twoBillion)
{
    Console.WriteLine("Transaction blocked.");
}
else
{
    Console.WriteLine("Transaction executed.");
}

checked
{
    //will be checked
    unchecked
    {
        //will not be checked
    }
}

//floating point numbers

Console.WriteLine(0.3d == (0.2d + 0.1d));
Console.WriteLine(AreEqual(0.3d, 0.2d + 0.1d, 0.000001d));

Console.WriteLine(0d / 0d);
var result = 10d / 0d;

bool AreEqual(double a, double b, double tolerance) =>
    Math.Abs(a - b) < tolerance;

//double vs decimal - performance test

int iterations = 30_000_000;
var resultForDouble = DoubleTest(iterations);
var resultForDecimal = DecimalTest(iterations);

Console.WriteLine($"Calculation of {iterations} elements.");
Console.WriteLine($"For double it took {resultForDouble} ticks.");
Console.WriteLine($"For decimal it took {resultForDecimal} ticks.");
var differenceScaled = (double)resultForDecimal / (double)resultForDouble;
Console.WriteLine($"Decimal took {differenceScaled:00.00} times as much time");

Console.ReadKey();


void SomeMethodWithCheckedContext(int a, int b)
{
    var result = Add(a, b);
}

int Add(int a, int b)
{
    checked
    {
        return a + b;
    }
}

long DoubleTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    double z = 0;
    for (int i = 0; i < iterations; i++)
    {
        double x = i;
        double y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedTicks;
}

long DecimalTest(int iterations)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    decimal z = 0;
    for (int i = 0; i < iterations; i++)
    {
        decimal x = i;
        decimal y = x * i;
        z += y;
    }
    stopwatch.Stop();
    return stopwatch.ElapsedTicks;
}
Console.ReadKey();

//NAMES SRP BEFORE REFACTOR
//var names = new Names();
//var path = names.BuildFilePath();

//if (File.Exists(path))
//{
//    Console.WriteLine("Names file already exists. Loading names.");
//    names.ReadFromTextFile();
//}
//else
//{
//    Console.WriteLine("Names file does not yet exist.");

//    //let's imagine they are given by the user
//    names.AddName("John");
//    names.AddName("not a valid name");
//    names.AddName("Claire");
//    names.AddName("123 definitely not a valid name");

//    Console.WriteLine("Saving names to the file.");
//    names.WriteToTextFile();
//}
//Console.WriteLine(names.Format());
//Console.ReadLine();

//public class Names
//{
//    private readonly List<string> _names = new List<string>();

//    public void AddName(string name)
//    {
//        if (IsValidName(name))
//        {
//            _names.Add(name);
//        }
//    }

//    private bool IsValidName(string name)
//    {
//        return
//            name.Length >= 2 &&
//            name.Length < 25 &&
//            char.IsUpper(name[0]) &&
//            name.All(char.IsLetter);
//    }

//    public void ReadFromTextFile()
//    {
//        var fileContents = File.ReadAllText(BuildFilePath());
//        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
//        foreach (var name in namesFromFile)
//        {
//            AddName(name);
//        }
//    }

//    public void WriteToTextFile() =>
//        File.WriteAllText(BuildFilePath(), Format());

//    public string BuildFilePath()
//    {
//        //we could imagine this is much more complicated
//        //for example that path is provided by the user and validated
//        return "names.txt";
//    }

//    public string Format() =>
//        string.Join(Environment.NewLine, _names);
//}

//NAMES SRP AFTER REFACTOR
//created DataAccess directory in the main solution directory, hence below namespace
namespace _2_NamesAfterRefactorToSRP.DataAccess;

public class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
    }

    public void Write(
        string filePath, List<string> names)
    {
        File.WriteAllText(
            filePath,
            string.Join(Separator, names));
    }
}

public class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddNames(List<string> stringsFromFile)
    {
        foreach (var name in stringsFromFile)
        {
            AddName(name);
        }
    }

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
}
public class NamesValidator
{
    public bool IsValid(string name)
    {
        return
            name.Length >= 2 &&
            name.Length < 25 &&
            char.IsUpper(name[0]) &&
            name.All(char.IsLetter);
    }
}
class NamesFormatter
{
    public string Format(List<string> names) =>
        string.Join(Environment.NewLine, names);
}
public class NamesFilePathBuilder
{
    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt";
    }
}
using _2_NamesAfterRefactorToSRP.DataAccess;

var names = new Names();
var path = new NamesFilePathBuilder().BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadLine();


using Pizzeria;
using System.Text.Json;

var person = new Person
{
FirstName = "John",
LastName = "Smith",
YearOfBirth = 1972
};

var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON:");
Console.WriteLine(asJson);

var personJson =
    "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";

var personFromJson = JsonSerializer.Deserialize<Person>(personJson);

var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = false;

NumbersSumCalculator calculator =
    shallAddPositiveOnly ?
    new PositiveNumbersSumCalculator() :
    new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);
Console.WriteLine("Sum is: " + sum);

Console.ReadKey();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}

//POLYMOPHISM & INHERITENCE
class Animal
{
    public virtual void MakeSound() =>
        Console.WriteLine(
            "Make a generic animal sound.");
}

class HousePet : Animal
{
    public override void MakeSound() =>
            Console.WriteLine(
                "<noises of happines when human comes home>");
}

class Feline : Animal
{
    public override void MakeSound() =>
            Console.WriteLine("purr purr");
}

//cannot be derived from more than one base class
class DomesticCat : Feline //, HousePet
{

}

interface IAnimal
{
    void MakeSound();
}

interface IHousePet : IAnimal
{
    void TakeToVet();
}

interface IFeline : IAnimal
{
    void HideInCardboardBox();
}

class DomesticCatImplementingInterfaces : IFeline, IHousePet
{
    public void HideInCardboardBox() =>
        Console.WriteLine("Hide in any cardboard box in sight.");

    public void MakeSound()
    {
        Console.WriteLine("Purr purr.");
    }

    public void TakeToVet() =>
        Console.WriteLine("Take to Dr. Paws using a carrier.");
}

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine(
            "Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }

    public int PriceIfExtraTopping { get; }

    public override string ToString() => Name;

    public virtual string Name { get; } = "Some ingredient";

    public abstract void Prepare();

    public int PublicField;

    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class.";

    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class.";

    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredient class.";
}

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}

public class Cheddar : Cheese
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths)
        : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine(
            "Constructor from the Cheddar class");
    }

    public override string Name =>
        $"{base.Name}, more specifically, " +
        $"a Cheddar cheese aged for {AgedForMonths} months";

    public int AgedForMonths { get; }

    public override void Prepare() =>
        Console.WriteLine("Grate and sprinkle over pizza.");

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}

public sealed class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }

    public override void Prepare() =>
        Console.WriteLine("Slice thinly and place on top of the pizza.");
}

//public class SpecialMozzarella : Mozzarella
//{

//}
public interface IBakeable
{
    string GetInstructions();
}

public abstract class Dessert { }

public class Panettone : Dessert, IBakeable
{
    public string GetInstructions() =>
        "Bake at 180 degrees Celsius for 35 minutes.";
}

public class Pizza : IBakeable
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) =>
        _ingredients.Add(ingredient);

    public string GetInstructions() =>
        "Bake at 250 degrees Celsius for 10 minutes, " +
        "ideally on a stone";

    public override string ToString() =>
        $"This is a pizza with {string.Join(", ", _ingredients)}";
}

public static class RandomPizzaGenerator
{
    public static Pizza Generate(int howManyIngredients)
    {
        var pizza = new Pizza();
        for (int i = 0; i < howManyIngredients; ++i)
        {
            var randomIngredient = GenerateRandomIngredient();
            pizza.AddIngredient(randomIngredient);
        }
        return pizza;
    }

    private static Ingredient GenerateRandomIngredient()
    {
        var random = new Random();
        var number = random.Next(1, 4);
        if (number == 1) { return new Cheddar(2, 12); }
        if (number == 2) { return new TomatoSauce(1); }
        else return new Mozzarella(2);
    }
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }

    public sealed override void Prepare() =>
        Console.WriteLine("Cook tomatoes with basil, garlic and salt. " +
            "Spread on pizza.");
}
public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    //public override void Prepare() =>
    //    Console.WriteLine("Special tomato sauce");
}

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}
public class PositiveNumbersSumCalculator
    : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}

public interface IFlyable
{
    void Fly();
}

public class Bird : IFlyable
{
    public void Tweet() =>
        Console.WriteLine("Tweet, tweet!");

    public void Fly() =>
        Console.WriteLine("Flying using its wings.");
}

public class Kite : IFlyable
{
    public void Fly() =>
        Console.WriteLine("Flying carried by the wind.");
}

public interface IFuelable
{
    void Fuel();
}

public class Plane : IFlyable, IFuelable
{
    public void Fly() =>
        Console.WriteLine("Flying using jet propulsion.");

    public void Fuel() =>
        Console.WriteLine("Filling tanks with jet fuel.");
}

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
public static class SeasonExtensions
{
    public static Season Next(this Season season)
    {
        int seasonAsInt = (int)season;
        int nextSeason = (seasonAsInt + 1) % 4;
        return (Season)nextSeason;
    }
}
public static class StringExtensions
{
    public static int CountLines(this string input) =>
        input.Split(Environment.NewLine).Length;
}












































//EXERCISE 15
public class HotelBooking
{
    public string GuestName;
    public DateTime StartDate;
    public DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }
}

//EXERCISE 16
public class Triangle
{
    private int _base;
    private int _height;

    public Triangle(int @base, int height)
    {
        _base = @base;
        _height = height;
    }

    public int CalculateArea()
    {
        return ((_base * _height) / 2);
    }

    public string AsString()
    {
        return $"Base is {_base}, Height is {_height}.";
    }
}

//EXERCISE 17
public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight) : this(name, "mixed-breed", weight)
    {
    }
    public string Describe()
    {
        string size;
        if (_weight < 5)
        {
            size = "tiny";
        }
        else if (_weight >= 5 && _weight < 30)
        {
            size = "medium";
        }
        else size = "large";

        return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {size} dog.";
    }
}

//EXERCISE 18
public class Order
{
    public string Item { get; }

    private DateTime _date;
    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (value.Year == DateTime.Now.Year)
            {
                _date = value;
            }
        }
    }

    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;
    }
}


//EXERCISE 19
public class DailyAccountState
{
    public int InitialState { get; }

    public int SumOfOperations { get; }

    public int EndOfDayState => InitialState + SumOfOperations;

    public DailyAccountState(
        int initialState,
        int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    public string Report() => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
}

//EXERCISE 20
public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int dayOfWeek)
    {
        switch (dayOfWeek)
        {
            case 1: return "Monday";
            case 2: return "Tuesday";
            case 3: return "Wednesday";
            case 4: return "Thursday";
            case 5: return "Friday";
            case 6: return "Saturday";
            case 7: return "Sunday";
            default: return "Invalid day of the week";
        }
    }
}

//EXERCISE 21
public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        string originalSeparator,
        string targetSeparator)
    {
        string[] pieces = input.Split(originalSeparator);
        string result = string.Join(targetSeparator, pieces);
        return result;
    }
}
/*
public static string TransformSeparators(string input, string originalSeparator, string targetSeparator)
{
    return string.Join(targetSeparator, input.Split(originalSeparator));
}
*/

//EXERCISE 22
public class Exercise22
{
    public List<int> GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        return result;
    }
}

public class Animal
{
    public virtual int NumberOfLegs { get; set; } = 4;
}

public class Lion : Animal
{
}

public class Tiger : Animal
{
}

public class Duck : Animal
{
    public override int NumberOfLegs { get; set; } = 2;
}

public class Spider : Animal
{
    public override int NumberOfLegs { get; set; } = 8;
}

//EXERCISE 23
public class Exercise23
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }
}

public class StringsProcessor
{
    public virtual List<string> Process(List<string> words)
    {
        var wordList = new List<string>();
        foreach (var word in words)
        {
            wordList.Add(word);
        }
        return wordList;
    }
}

public class StringsUppercaseProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        var upperList = new List<string>();
        foreach (var word in words)
        {
            var upper = word.ToUpper();
            upperList.Add(upper);
        }
        return upperList;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        var trimmedList = new List<string>();
        foreach (var word in words)
        {
            var trimmed = word.Substring(0, word.Length / 2);
            trimmedList.Add(trimmed);
        }
        return trimmedList;
    }
}

//EXERCISE 24
public static class NumericTypesDescriber
    {
        public static string Describe(object someObject)
        {
            if (someObject is int i)
            {
                return $"Int of value {i}";
            }
            if (someObject is double d)
            {
                return $"Double of value {d}";
            }
            if (someObject is decimal m)
            {
                return $"Decimal of value {m}";
            }
            return null;
        }
}

