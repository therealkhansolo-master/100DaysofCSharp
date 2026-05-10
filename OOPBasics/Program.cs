var internationalPizzaDay26 = new DateTime(2026, 5, 2);
Console.WriteLine($"year is {internationalPizzaDay26.Year}");
Console.WriteLine($"month is {internationalPizzaDay26.Month}");
Console.WriteLine($"day is {internationalPizzaDay26.Day}");
Console.WriteLine($"day of week is {internationalPizzaDay26.DayOfWeek}");

var internationalPizzaDay27 = internationalPizzaDay26.AddYears(1);
Console.WriteLine($"new year is {internationalPizzaDay27.Year}");
Console.WriteLine($"new month is {internationalPizzaDay27.Month}");
Console.WriteLine($"new day is {internationalPizzaDay27.Day}");
Console.WriteLine($"new day of week is {internationalPizzaDay27.DayOfWeek}");

var rectangle1 = new Rectangle(5, 10);// this will not compile because there is no constructor defined in the Rectangle class
var rect1Area = new ShapesMeasurementsCalculator().CalculateArea(rectangle1);
var rect1Perimeter = new ShapesMeasurementsCalculator().CalculatePerimeter(rectangle1);
Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Height is {rectangle1.Height}");
Console.WriteLine($"Area is {rect1Area}");
Console.WriteLine($"Perimeter is {rect1Perimeter}");
rectangle1.Width = -3;//PROBLEMATIC; caused by the Public access modifier

var rectangle2 = new Rectangle(10, 20);
var rect2Area = new ShapesMeasurementsCalculator().CalculateArea(rectangle2);
var rect2Perimeter = new ShapesMeasurementsCalculator().CalculatePerimeter(rectangle2);
Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle2.Height}");
Console.WriteLine($"Area is {rect2Area}");
Console.WriteLine($"Perimeter is {rect2Perimeter}");

var medicalAppointment = new MedicalAppointment("Bruce Banner", new DateTime(2024, 7, 15));

Console.ReadKey();

class Rectangle
{
    public int Width;
    public int Height;
    //private int _width;
    //private int _height;

    public Rectangle(int width, int height)
    {
        int defaultValueIfNonPositive = 1;
        if (width <= 0)
        {
            Console.WriteLine("Width must be a positive number.");
            Width = defaultValueIfNonPositive;
        }
        Width = width;
        Height = height;
    }

    public int CalculatePerimeter() => 2 * (Width + Height);
}

class ShapesMeasurementsCalculator
{
    //expression-bodied method
    //public int CalculatePerimeter(Rectangle rectangle) => 2 * (rectangle.Width + rectangle.Height)
    public int CalculatePerimeter(Rectangle rectangle)
    {
        return 2 * (rectangle.Width + rectangle.Height);
    }

    public int CalculateArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

class MedicalAppointmentPrinter();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _appointmentDate;
    public MedicalAppointment(string patientName, DateTime appointmentDate)
    {
        _patientName = patientName;
        _appointmentDate = appointmentDate;
    }
    public MedicalAppointment(string patientName) : this(patientName, 7)
    {
    }

    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _appointmentDate = DateTime.Now.AddDays(daysFromNow);
    }
    public void Reschedule(DateTime newDate)
    {
        _appointmentDate = newDate;
    }
    public void OverwriteMonthAndDay(int month, int day)
    {
        _appointmentDate = new DateTime(_appointmentDate.Year, month, day);
    }
    public void MovebyMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _appointmentDate = new DateTime(_appointmentDate.Year, 
            _appointmentDate.Month, 
            _appointmentDate.Day)
            .AddMonths(monthsToAdd)
            .AddDays(daysToAdd);
    }
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