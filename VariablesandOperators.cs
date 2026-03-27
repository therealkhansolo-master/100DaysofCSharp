using Microsoft.VisualBasic;
using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
//To output values or print text in C#, you can use the WriteLine() method:
Console.WriteLine("Hello World!");

//You can also output numbers, and perform mathematical calculations:
Console.WriteLine(3 + 3);

//There is also a Write() method, which is similar to WriteLine().
//The only difference is that it does not insert a new line at the end of the output:
Console.Write("Hello World! ");
Console.Write("I will print on the same line.");


//Single - line comments start with two forward slashes (//).
//Any text between // and the end of the line is ignored by C# (will not be executed).
//This example uses a single-line comment before a line of code:
// This is a comment
Console.WriteLine("Hello World!");

//This example uses a single-line comment at the end of a line of code:
Console.WriteLine("Hello World!");  // This is a comment

//Multi - line comments start with /* and ends with */.
//Any text between /* and */ will be ignored by C#.
//This example uses a multi-line comment (a comment block) to explain the code:
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World!");

/* 
Variables are containers for storing data values.

In C#, there are different types of variables (defined with different keywords), for example:

int - stores integers (whole numbers), without decimals, such as 123 or -123
double - stores floating point numbers, with decimals, such as 19.99 or -19.99
char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
string - stores text, such as "Hello World". String values are surrounded by double quotes
bool - stores values with two states: true or false
*/


//Where type is a C# type (such as int or string), and variableName is the name of the variable (such as x or name). The equal sign is used to assign values to the variable.
//To create a variable that should store text, look at the following example:
//Create a variable called name of type string and assign it the value "Khan":
string name = "Khan";
Console.WriteLine(name);

//Create a variable called myNum of type int and assign it the value 15:
int myNum = 3;
Console.WriteLine(myNum);

//You can also declare a variable without assigning the value, and assign the value later:
int myNum1;
myNum = 30;
Console.WriteLine(myNum);

//Change the value of myNum to 300:
int myNum2 = 300;
myNum = 777; // myNum is now 77
Console.WriteLine(myNum);

//A demonstration of how to declare variables of other types:
int myNum3 = 3;
double myDoubleNum = 3.99D;
char myLetter = 'G';
bool myBool = true;
string myText = "Bismillah";

const int myNum4 = 3;
//myNum4 = 10; // error
//Compiler Error CS0131:
//the left-hand side of an assignment must be a variable, property or indexer
//In an assignment statement, the value of the right-hand side is assigned to the left-hand side.
//The left-hand side must be a variable, property, or indexer.

//The WriteLine() method is often used to display variable values to the console window.
//To combine both text and a variable, use the + character:
string name1 = "Mr Khan";
Console.WriteLine("Hello " + name);

//You can also use the + character to add a variable to another variable:
string firstName = "Mr ";
string lastName = "Khan";
string fullName = firstName + lastName;
Console.WriteLine(fullName);

//For numeric values, the + character works as a mathematical operator (notice that we use int (integer) variables here):
int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y

//To declare more than one variable of the same type, use a comma-separated list:
int i = 5, j = 6, z = 50;
Console.WriteLine(i + j + z);

//You can also assign the same value to multiple variables in one line:
int xx, yy, zz;
xx = yy = zz = 50;
Console.WriteLine(xx + yy + zz);


//All C# variables must be identified with unique names.
//These unique names are called identifiers.
//Identifiers can be short names (like x and y) or more descriptive names (age, sum, totalVolume).
//Note: It is recommended to use descriptive names in order to create understandable and maintainable code:
// Good
int minutesPerHour = 60;

// OK, but not so easy to understand what m actually is
int m = 60;

/*
The general rules for naming variables are:

Names can contain letters, digits and the underscore character (_)
Names must begin with a letter or underscore
Names should start with a lowercase letter, and cannot contain whitespace
Names are case-sensitive ("myVar" and "myvar" are different variables)
Reserved words (like C# keywords, such as int or double) cannot be used as names
*/

//The int data type can store whole numbers from -2147483648 to 2147483647. In general, and in our tutorial, the int data type is the preferred data type when we create variables with a numeric value.
int myNum5 = 100000;
Console.WriteLine(myNum5);

//The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807. This is used when int is not large enough to store the value. Note that you should end the value with an "L":
long myNum6 = 15000000000L;
Console.WriteLine(myNum6);
/*
int myNum = 5;               // Integer (whole number)
double myDoubleNum = 5.99D;  // Floating point number
char myLetter = 'D';         // Character
bool myBool = true;          // Boolean
string myText = "Hello";     // String
 */

/*
Data Type	Size	Description
int	4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 byte	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
 */
/*
You should use a floating point type whenever you need a number with a decimal, such as 9.99 or 3.14515.
The float and double data types can store fractional numbers. Note that you should end the value with an "F" for floats and "D" for doubles:
*/
float myNum7 = 5.75F;
Console.WriteLine(myNum7);

double myNum8 = 19.99D;
Console.WriteLine(myNum8);

/*
Use float or double?
The precision of a floating point value indicates how many digits the value can have after the decimal point. 
The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits. 
Therefore it is safer to use double for most calculations.
*/

/*
A floating point number can also be a scientific number with an "e" to indicate the power of 10:

float f1 = 35e3F;
double d1 = 12E4D;
Console.WriteLine(f1);
Console.WriteLine(d1);
*/

/*
A boolean data type is declared with the bool keyword and can only take the values true or false:

bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False
*/

/*
The char data type is used to store a single character. The character must be surrounded by single quotes, like 'A' or 'c':

char myGrade = 'B';
Console.WriteLine(myGrade);
*/

/*
The string data type is used to store a sequence of characters (text). String values must be surrounded by double quotes:

string greeting = "Hello World";
Console.WriteLine(greeting);
*/

/*
Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double

Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char
 */

/*
Implicit casting is done automatically when passing a smaller size type to a larger size type:

ExampleGet your own C# Server
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
*/

/*
Explicit Casting
Explicit casting must be done manually by placing the type in parentheses in front of the value:

double myDouble = 9.78;
int myInt = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
*/



/*
 It is also possible to convert data types explicitly by using built-in methods, such as
Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
*/

//Many times, there's no need for type conversion. But sometimes you have to.

// Type your username and press enter
Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);

//Console.WriteLine("Enter your age:");
//int age = Console.ReadLine();
//Console.WriteLine("Your age is: " + age);

//Compiler Error CS0029:
/*
 Cannot implicitly convert type 'type' to 'type'
The compiler requires an explicit conversion. For example, you may need to cast an r-value to be the same type as an l-value. 
Or, you must provide conversion routines to support certain operator overloads.

Conversions must occur when assigning a variable of one type to a variable of a different type. When making an assignment between variables of different types, the compiler must convert the type on the right-hand side of the assignment operator to the type on the left-hand side of the assignment operator. 
Take the following the code:
int i = 50;
long lng = 100;
i = lng;
 */
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

//Note: If you enter wrong input (e.g. text in a numerical input), you will get an exception/error message (like System.FormatException: 'Input string was not in a correct format.').

/*
 Operators are used to perform operations on variables and values.

In the example below, we use the + operator to add together two values:

int x = 100 + 50;
 */

/*
Arithmetic operators are used to perform common mathematical operations:

Operator Name	Description	Example	Try it
+	Addition	Adds together two values	x + y	
-	Subtraction	Subtracts one value from another	x - y	
*	Multiplication	Multiplies two values	x * y	
/	Division	Divides one value by another	x / y	
%	Modulus	Returns the division remainder	x % y	
++	Increment	Increases the value of a variable by 1	x++	
--	Decrement	Decreases the value of a variable by 1	x--
*/

/*
 A list of all assignment operators:

Operator	Example	Same As	Try it
=	x = 5	x = 5	
+=	x += 3	x = x + 3	
-=	x -= 3	x = x - 3	
*=	x *= 3	x = x * 3	
/=	x /= 3	x = x / 3	
%=	x %= 3	x = x % 3	
&=	x &= 3	x = x & 3	
|=	x |= 3	x = x | 3	
^=	x ^= 3	x = x ^ 3	
>>=	x >>= 3	x = x >> 3	
<<=	x <<= 3	x = x << 3
 */

/*
 A list of all comparison operators:

Operator	Name	Example	Try it
==	Equal to	x == y	
!=	Not equal	x != y	
>	Greater than	x > y	
<	Less than	x < y	
>=	Greater than or equal to	x >= y	
<=	Less than or equal to	x <= y
 */

/*
As with comparison operators, you can also test for True or False values with logical operators.
Logical operators are used to determine the logic between variables or values:

Operator Name	Description	Example	Try it
&& 	Logical and	Returns True if both statements are true	x < 5 &&  x < 10	
|| 	Logical or	Returns True if one of the statements is true	x < 5 || x < 4	
!	Logical not	Reverse the result, returns False if the result is true	!(x < 5 && x < 10)
*/

/*
The Math.Max(x, y) method can be used to find the highest value of x and y:
Math.Max(5, 10);
*/

/*
 The Math.Min(x,y) method can be used to find the lowest value of of x and y:
Math.Min(5, 10);
 */

/*
The Math.Sqrt(x) method returns the square root of x:
Math.Sqrt(64);
*/

//The Math.Abs(x) method returns the absolute (positive) value of x:
//Math.Abs(-4.7);

//Math.Round() rounds a number to the nearest whole number:
//Math.Round(9.99);

//Strings are used for storing text.
//A string variable contains a collection of characters surrounded by double quotes:
//Create a variable of type string and assign it a value:
string greeting = "Hello";


//A string variable can contain many words, if you want:
string greeting2 = "Nice to meet you!";

//A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

//There are many string methods available, for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:
string txt2 = "Hello World";
Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt2.ToLower());   // Outputs "hello world"


//The + operator can be used between strings to combine them.This is called concatenation:
string firstName2 = "John ";
string lastName2 = "Doe";
string name2 = firstName2 + lastName2;
Console.WriteLine(name2);

//You can also use the string.Concat() method to concatenate two strings:
string firstName3 = "John ";
string lastName3 = "Doe";
string name3 = string.Concat(firstName3, lastName3);
Console.WriteLine(name3);

//WARNING!
//C# uses the + operator for both addition and concatenation.
//Remember: Numbers are added.Strings are concatenated.

//Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:
string firstName4 = "John";
string lastName4 = "Doe";
string name4 = $"My full name is: {firstName4} {lastName4}";
Console.WriteLine(name4);

//You can access the characters in a string by referring to its index number inside square brackets [].

//This example prints the first character in myString:
string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"You can access the characters in a string by referring to its index number inside square brackets [].

//This example prints the first character in myString:
string myString2 = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"

//Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.
//This example prints the second character (1) in myString:
string myString3 = "Hello";
Console.WriteLine(myString[1]);  // Outputs "e"

//You can also find the index position of a specific character in a string, by using the IndexOf() method:
string myString4 = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

//Another useful method is Substring(), which extracts the characters from a string,
//starting from the specified character position/index, and returns a new string.
//This method is often used together with IndexOf() to get the specific character position:
// Full name
string name5 = "John Doe";
// Location of the letter D
int charPos = name5.IndexOf("D");

// Get last name
string lastName5 = name5.Substring(charPos);

// Print the result
Console.WriteLine(lastName5);

//Because strings must be written within quotes, C# will misunderstand this string, and generate an error:
//string txt3 = "We are the so-called "Vikings" from the north.";

//Compiler Error CS1003:
/*
Syntax error, 'char' expected
The compiler will generate this error for any one of several error conditions. 
Review your code to find the syntax error.
The following sample generates CS1003:
// CS1003.cs  
public class b
{
    public static void Main()
    {
        int[] a;
        a[);   // CS1003  
    }
}
*/

//The solution to avoid this problem, is to use the backslash escape character.
//The backslash (\) escape character turns special characters into string characters:
/*
\'	'	Single quote
\"	"	Double quote
\\	\	Backslash
*/
//The sequence \"  inserts a double quote in a string:
//string txt4 = "We are the so-called \"Vikings\" from the north.";

//The sequence \'  inserts a single quote in a string:
string txt5 = "It\'s alright.";

//The sequence \\  inserts a single backslash in a string:
string txt6 = "The character \\ is called backslash.";

/*
Other useful escape characters in C# are:

Code	Result	Try it
\n	New Line	
\t	Tab	
\b	Backspace
*/

//C# has a bool data type, which can take the values true or false.
//A boolean type is declared with the bool keyword and can only take the values true or false:
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

//For example, you can use a comparison operator, such as the greater than (>) operator to find out if an expression (or a variable) is true:
Console.WriteLine(10 > 9); // returns True, because 10 is higher than 9
int xxx = 10;
Console.WriteLine(xxx == 10); // returns True, because the value of x is equal to 10
Console.WriteLine(10 == 15); // returns False, because 10 is not equal to 15

//In the example below, we use the >= comparison operator to find out if the age (25) is greater than OR equal to the voting age limit, which is set to 18:
int myAge = 25;
int votingAge = 18;
Console.WriteLine(myAge >= votingAge);

//Output "Old enough to vote!" if myAge is greater than or equal to 18. Otherwise output "Not old enough to vote.":
int myAge2 = 25;
int votingAge2 = 18;

if (myAge >= votingAge)
{
    Console.WriteLine("Old enough to vote!");
}
else
{
    Console.WriteLine("Not old enough to vote.");
}

//The boolean value of an expression is the basis for all C# comparisons and conditions.

/*
 You already know that C# supports familiar comparison conditions from mathematics, such as:

Less than: a < b
Less than or equal to: a <= b
Greater than: a > b
Greater than or equal to: a >= b
Equal to a == b
Not Equal to: a != b
You can use these conditions to perform different actions for different decisions.

C# has the following conditional statements:

Use if to specify a block of code to be executed, if a specified condition is true
Use else to specify a block of code to be executed, if the same condition is false
Use else if to specify a new condition to test, if the first condition is false
Use switch to specify many alternative blocks of code to be executed
 */

/*
 Use the if statement to specify a block of C# code to be executed if a condition is True.

SyntaxGet your own C# Server
if (condition) 
{
  // block of code to be executed if the condition is True
}
 */
//Note that if is in lowercase letters. Uppercase letters (If or IF) will generate an error.

//In the example below, we test two values to find out if 20 is greater than 18. If the condition is True, print some text:
if (20 > 18)
{
    Console.WriteLine("20 is greater than 18");
}

//We can also test variables:
int x2 = 20;
int y2 = 18;
if (x2 > y2)
{
    Console.WriteLine("x is greater than y");
}

var condition = true;
//Use the else statement to specify a block of code to be executed if the condition is False.
if (condition)
{
    // block of code to be executed if the condition is True
}
else
{
    // block of code to be executed if the condition is False
}

int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

//Use the else if statement to specify a new condition if the first condition is False.
if (condition)
{
    // block of code to be executed if condition1 is True
}
else if (condition)
{
    // block of code to be executed if the condition1 is false and condition2 is True
}
else
{
    // block of code to be executed if the condition1 is false and condition2 is False
}

int time2 = 22;
if (time2 < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time2 < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
// Outputs "Good evening."
//In the example above, time (22) is greater than 10, so the first condition is False.
//The next condition, in the else if statement, is also False, so we move on to the else condition since condition1 and condition2 is both False - and print to the screen "Good evening".
//However, if the time was 14, our program would print "Good day."

//There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. 
//It can be used to replace multiple lines of code with a single line. 
//It is often used to replace simple if else statements:
//variable = (condition) ? expressionTrue :  expressionFalse;
//Instead of writing:
int time3 = 20;
if (time3 < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}

//You can simply write:
int time4 = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
//Use the switch statement to select one of many code blocks to be executed.
//var expression = 3 + 3 + 3;
//switch (expression)
//{
//    case x:
//        // code block
//        break;
//    case y:
//        // code block
//        break;
//    default:
//        // code block
//        break;
//}

//This is how it works:
//The switch expression is evaluated once
//The value of the expression is compared with the values of each case
//If there is a match, the associated block of code is executed
//The break and default keywords will be described later in this chapter
//The example below uses the weekday number to calculate the weekday name:

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}
// Outputs "Thursday" (day 4)

//When C# reaches a break keyword, it breaks out of the switch block.
//This will stop the execution of more code and case testing inside the block.
//When a match is found, and the job is done, it's time for a break. There is no need for more testing.
//A break can save a lot of execution time because it "ignores" the execution of all the rest of the code in the switch block.
//The default keyword is optional and specifies some code to run if there is no case match:

int day2 = 4;
switch (day2)
{
    case 6:
        Console.WriteLine("Today is Saturday.");
        break;
    case 7:
        Console.WriteLine("Today is Sunday.");
        break;
    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}
// Outputs "Looking forward to the Weekend."
//Loops can execute a block of code as long as a specified condition is reached.
//Loops are handy because they save time, reduce errors, and they make code more readable.
//The while loop loops through a block of code as long as a specified condition is True:
//while (condition)
//{
//    code block to be executed
//}

//In the example below, the code in the loop will run, over and over again, as long as a variable (i) is less than 5:
int k = 0;
while (k < 5)
{
    Console.WriteLine(k);
    k++;
};

//Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!




































































public class Exercise1
{
    public static int VariablesAndOperators()
    {
        var a = 5;
        var b = 10;
        var c = 3;

        int result = (a + b) / c;
        return result;
    }
}

//Compiler Error CS8803:
//Top-level statements must precede namespace and type declarations.
/*
public record Person
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
}

int i = 0;
*/

public class Exercise2
{
    public static bool BooleanTypesAndOperators()
    {
        int a = 5;
        int b = 12;
        int sum = a + b;

        bool isSumLargerOrEqualTo17 = ((a + b) >= 17);


        return isSumLargerOrEqualTo17;
    }
}
