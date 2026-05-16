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
}
