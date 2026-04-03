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
//OUTPUT//
//To output values or print text in C#, you can use the WriteLine() method:
Console.WriteLine("Hello World!");

//You can also output numbers, and perform mathematical calculations:
Console.WriteLine(3 + 3);

//There is also a Write() method, which is similar to WriteLine().
//The only difference is that it does not insert a new line at the end of the output:
Console.Write("Hello World! ");
Console.Write("I will print on the same line.");

//COMMENTS//
//Single - line comments start with two forward slashes (//).
//Any text between // and the end of the line is ignored by C# (will not be executed).
//This example uses a single-line comment before a line of code:
// This very line is a comment
Console.WriteLine("Hello World!");

//This example uses a single-line comment at the end of a line of code:
Console.WriteLine("Hello World!");  // This is a comment

//Multi - line comments start with /* and ends with */.
//Any text between /* and */ will be ignored by C#.
//This example uses a multi-line comment (a comment block) to explain the code:
/* The code below will print the words Hello World
to the screen, and it is amazing */
Console.WriteLine("Hello World!");

//VARIABLES//
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
myNum1 = 30;
Console.WriteLine(myNum1);

//Compiler Error CS0128
//A local variable named 'variable' is already defined in this scope
//The compiler detected declarations of two local variables with the same name.

//Change the value of myNum to 300:
int myNum2 = 300;
myNum2 = 777; // myNum is now 77
Console.WriteLine(myNum2);

//A demonstration of how to declare variables of other types:
int myNum3 = 3;
double myDoubleNum = 3.99D;
char myLetter = 'G';
bool myBool = true;
string myText = "Bismillah";

//CONSTANTS//
const int myNum4 = 3;
//myNum4 = 10; // error
//Compiler Error CS0131:
//the left-hand side of an assignment must be a variable, property or indexer
//In an assignment statement, the value of the right-hand side is assigned to the left-hand side.
//The left-hand side must be a variable, property, or indexer.

//DISPLAYING VARIABLES//
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

//IDENTIFIERS//
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

//DATA TYPES//
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
//String interpolation
int a = 4, b = 2, c = 10;
Console.WriteLine(
    "First is: " + a + ", second is: " + b + ", third is: " + c);

Console.WriteLine(
    $"First is: {a}, second is: {b}, third is: {c}");

Console.WriteLine(
    $"Sum is: {a + b + c}, second is: {b}, third is: {c}");

//TYPE CASTING//
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
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9
*/

/*
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

//USER INPUT//
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
//OR//
string numberAsText = "123";
int parsedToInt = int.Parse(numberAsText); //would not work if input was, for example, "abc"
//Note: If you enter wrong input (e.g. text in a numerical input), you will get an exception/error message (like System.FormatException: 'Input string was not in a correct format.').

//OPERATORS//
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

//MATH//
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

//STRINGS//
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
Console.WriteLine(myString[0]);  // Outputs "H"

//You can access the characters in a string by referring to its index number inside square brackets [].
//This example prints the first character in myString:
string myString2 = "Hello";
Console.WriteLine(myString2[4]);  // Outputs "o"

//Note: String indexes start with 0: [0] is the first character. [1] is the second character, etc.
//This example prints the second character (1) in myString:
string myString3 = "Hello";
Console.WriteLine(myString3[1]);  // Outputs "e"

//You can also find the index position of a specific character in a string, by using the IndexOf() method:
string myString4 = "Hello";
Console.WriteLine(myString4.IndexOf("e"));  // Outputs "1"

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
//Syntax error, 'char' expected
//The compiler will generate this error for any one of several error conditions. 
//Review your code to find the syntax error.
//The following sample generates CS1003:
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

//BOOLEANS//
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

//IF...ELSE//
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

//SHORT-HAND IF ELSE(TERNARY OPERATOR)//
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

//SWITCH//
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

//LOOPS//
//Loops can execute a block of code as long as a specified condition is reached.
//Loops are handy because they save time, reduce errors, and they make code more readable.
//WHILE LOOP//
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

//DO-WHILE//
//The do/while loop is a variant of the while loop.
//This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.
do
{
    // code block to be executed
}
while (condition);

//The example below uses a do/while loop.
//The loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested:
int g = 0;
do
{
    Console.WriteLine(g);
    g++;
}
while (g < 5);
//Do not forget to increase the variable used in the condition, otherwise the loop will never end!

//FOR LOOP//
//When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:
//for (statement 1; statement 2; statement 3) 
//{
//  // code block to be executed
//}
//Statement 1 is executed (one time) before the execution of the code block.
//Statement 2 defines the condition for executing the code block.
//Statement 3 is executed (every time) after the code block has been executed.

//The example below will print the numbers 0 to 4:
for (int f = 0; f < 5; f++)
{
    Console.WriteLine(f);
}
//Statement 1 sets a variable before the loop starts (int i = 0).
//Statement 2 defines the condition for the loop to run (i must be less than 5). If the condition is true, the loop will start over again, if it is false, the loop will end.
//Statement 3 increases a value (i++) each time the code block in the loop has been executed.

//This example will only print even values between 0 and 10:
for (int t = 0; t <= 10; t = t + 2)
{
    Console.WriteLine(t);
}

//It is also possible to place a loop inside another loop. This is called a nested loop.
//The "inner loop" will be executed one time for each iteration of the "outer loop":
// Outer loop
for (int r = 1; r <= 2; ++r)
{
    Console.WriteLine("Outer: " + r);  // Executes 2 times

    // Inner loop
    for (int s = 1; s <= 3; s++)
    {
        Console.WriteLine(" Inner: " + s); // Executes 6 times (2 * 3)
    }
}

//FOREACH//
//There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):
//foreach (type variableName in arrayName) 
//{
//  // code block to be executed
//}
//The following example outputs all elements in the cars array, using a foreach loop:
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string c in cars)
{
    Console.WriteLine(c);
}

//BREAK & CONTINUE//
//You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.
//The break statement can also be used to jump out of a loop.
//This example jumps out of the loop when i is equal to 4:
for (int b = 0; b < 10; b++)
{
    if (b == 4)
    {
        break;
    }
    Console.WriteLine(b);
}

//The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
//This example skips the value of 4:
for (int c = 0; c < 10; c++)
{
    if (c == 4)
    {
        continue;
    }
    Console.WriteLine(c);
}
//You can also use break and continue in while loops:
int d = 0;
while (d < 10)
{
    Console.WriteLine(d);
    d++;
    if (d == 4)
    {
        break;
    }
}

int e = 0;
while (e < 10)
{
    if (e == 4)
    {
        e++;
        continue;
    }
    Console.WriteLine(e);
    e++;
}

//ARRAYS//
//Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
//To declare an array, define the variable type with square brackets:
string[] carsCollection;
//We have now declared a variable that holds an array of strings.

//To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces:
string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };

//To create an array of integers, you could write:
int[] myNums = { 10, 20, 30, 40 };
//You access an array element by referring to the index number.

//This statement accesses the value of the first element in cars:
string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars2[0]);
// Outputs Volvo
//Note: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

//To change the value of a specific element, refer to the index number:
cars[0] = "Opel";

string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
cars[0] = "Opel";
Console.WriteLine(cars3[0]);
// Now outputs Opel instead of Volvo

//To find out how many elements an array has, use the Length property:
string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars.Length);
// Outputs 4

//If you are familiar with C#, you might have seen arrays created with the new keyword,
//and perhaps you have seen arrays with a specified size as well. In C#, there are different ways to create an array:
// Create an array of four elements, and add values later
string[] cars5 = new string[4];

// Create an array of four elements and add values right away 
string[] cars6 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements without specifying the size 
string[] cars7 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars8 = { "Volvo", "BMW", "Ford", "Mazda" };

//However, you should note that if you declare an array and initialize it later, you have to use the new keyword:
// Declare an array
string[] cars9;

// Add values, using new
cars = new string[] { "Volvo", "BMW", "Ford" };

// Add values without using new (this will cause an error)
//cars = { "Volvo", "BMW", "Ford"};

var numbers = new int[] { 1, 2, 4, 7, 2 };
numbers[2] = 10;
var firstFromEnd1 = numbers[numbers.Length - 1];
var firstFromEnd2 = numbers[^1];
var secondFromEnd1 = numbers[numbers.Length - 2];
var secondFromEnd2 = numbers[^2];

int sumOfNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sumOfNumbers += numbers[i];
}


//Compiler Error CS1525: Invalid expression term 'term'
//The compiler detected an invalid term in an expression. 
//This error can be caused by a missing expression where one is expected, leading to subsequent tokens being wrongly parsed as an expression, 
//or an invalid construct is used within an expression. Common root causes include unmatched tokens, missing semicolon or excess delimiters.
class MyClass
{
    public static void Method(int number) { }

    public static void Main()
    {
        int i = 0;
        i = i + 'c' + 1 + (2);   // OK
        i = i + void + throw;    // CS1525, these keywords are not valid in this expression

        Method(123,);            // CS1525, excess trailing comma

        goto EmptyLabel;
    EmptyLabel:              // CS1525, empty label
        // Add something here to resolve the error, for example:
        // System.Console.WriteLine("Hello!");
    }
}

//Compiler Error CS1002: ; expected
//The compiler detected a missing semicolon. A semicolon is required at the end of every statement in C#. 
//A statement may span more than one line.

//You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.
//The following example outputs all elements in the cars array:
string[] cars10 = { "Volvo", "BMW", "Ford", "Mazda" };
for (int i1 = 0; i1 < cars10.Length; i1++)
{
    Console.WriteLine(cars[i1]);
}

//There is also a foreach loop, which is used exclusively to loop through elements in an array:
//foreach (type variableName in arrayName) 
//{
//  // code block to be executed
//}
//The following example outputs all elements in the cars array, using a foreach loop:
string[] cars11 = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i2 in cars)
{
    Console.WriteLine(i2);
}
//The example above can be read like this: for each string element(called i - as in index) in cars, print out the value of i.
//If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.

//There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:
// Sort a string
string[] cars12 = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(cars12);
foreach (string i3 in cars12)
{
    Console.WriteLine(i3);
}

// Sort an int
int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);
foreach (int i4 in myNumbers)
{
    Console.WriteLine(i4);
}

//Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:
//using System;
//using System.ComponentModel;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Reflection.Metadata;
//using System.Runtime.Intrinsics.Arm;
//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] myNumbers = { 5, 1, 8, 9 };
//            Console.WriteLine(myNumbers.Max());  // returns the largest value
//            Console.WriteLine(myNumbers.Min());  // returns the smallest value
//            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
//        }
//    }
//}

//A multidimensional array is basically an array of arrays.
//Arrays can have any number of dimensions.The most common are two-dimensional arrays(2D).
//To create a 2D array, add each array within its own set of curly braces, and insert a comma(,) inside the square brackets:
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var letters2 = new char[,]
{
    {'A', 'B','C' },
    {'D', 'E','F' },
};

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine($"Height is {height}.");
Console.WriteLine($"Width is {width}");

for (int i = 0; i < height; i++)
{
    Console.WriteLine($"i is {i}");
    for (int j = 0; j < width; j++)
    {
        Console.WriteLine($"j is {j}");
        Console.WriteLine(
            $"element is {letters[i, j]}");
    }
}

//Good to know: The single comma[,] specifies that the array is two - dimensional.A three-dimensional array would have two commas: int[,,].
//numbers is now an array with two arrays as its elements.The first array element contains three elements: 1, 4 and 2, while the second array element contains 3, 6 and 8. To visualize it, think of the array as a table with rows and columns:
//To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array.Or better yet, with the table visualization in mind; one for the row and one for the column(see example below).
//This statement accesses the value of the element in the first row(0) and third column(2) of the numbers array:
int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine(numbers[0, 2]);  // Outputs 2
//Remember that: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.

//You can also change the value of an element.
//The following example will change the value of the element in the first row (0) and first column(0):
int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
numbers2[0, 0] = 5;  // Change value to 5
Console.WriteLine(numbers2[0, 0]); // Outputs 5 instead of 1

//You can easily loop through the elements of a two - dimensional array with a foreach loop:
int[,] numbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };
foreach (int i5 in numbers)
{
    Console.WriteLine(i5);
}

//You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.
//Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
int[,] numbers4 = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i6 = 0; i6 < numbers4.GetLength(0); i6++)
{
    for (int j1 = 0; j1 < numbers4.GetLength(1); j1++)
    {
        Console.WriteLine(numbers[i6, j1]);
    }
}

//LISTS
var someWords = new List<string>
{
    "one", "two"
};
someWords.Add("three");
someWords.AddRange(new[] { "four", "five" });
someWords.Remove("three");
someWords.RemoveAt(0);
var indexOfFive = someWords.IndexOf("five");
bool containsOne = someWords.Contains("one");
someWords.Clear();

//METHODS//
//A method is a block of code which only runs when it is called.
//You can pass data, known as parameters, into a method.
//Methods are used to perform certain actions, and they are also known as functions.
//Why use methods? To reuse code: define the code once, and use it many times.
//A method is defined with the name of the method, followed by parentheses ().
//C# provides some pre-defined methods, which you already are familiar with, such as Main(), but you can also create your own methods to perform certain actions:

//Create a method inside the Program class:
//class Program
//{
//    static void MyMethod()
//    {
//        // code to be executed
//    }
//}
//MyMethod() is the name of the method
//static means that the method belongs to the Program class and not an object of the Program class. You will learn more about objects and how to access methods through objects later in this tutorial.
//void means that this method does not have a return value. You will learn more about return values later in this chapter
//Note: In C#, it is good practice to start with an uppercase letter when naming methods, as it makes the code easier to read.

//To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;
//In the following example, MyMethod() is used to print a text (the action), when it is called:
//Inside Main(), call the myMethod() method:
//static void MyMethod()
//{
//    Console.WriteLine("I just got executed!");
//}

//static void Main(string[] args)
//{
//    MyMethod();
//}

// Outputs "I just got executed!"

//A method can be called multiple times:
static void MyMethod()
{
    Console.WriteLine("I just got executed!");
}
static void Main(string[] args)
{
    MyMethod();
    MyMethod();
    MyMethod();
}
// I just got executed!
// I just got executed!
// I just got executed!

//Information can be passed to methods as parameter. Parameters act as variables inside the method.
//They are specified after the method name, inside the parentheses. You can add as many parameters as you want, just separate them with a comma.

//The following example has a method that takes a string called fname as parameter. When the method is called, we pass along a first name, which is used inside the method to print the full name:
//static void MyMethod(string fname)
//{
//    Console.WriteLine(fname + " Refsnes");
//}
//static void Main(string[] args)
//{
//    MyMethod("Liam");
//    MyMethod("Jenny");
//    MyMethod("Anja");
//}
// Liam Refsnes
// Jenny Refsnes
// Anja Refsnes

//When a parameter is passed to the method, it is called an argument. So, from the example above: fname is a parameter, while Liam, Jenny and Anja are arguments.
//You can have as many parameters as you like, just separate them with commas:
//static void MyMethod(string fname, int age)
//{
//    Console.WriteLine(fname + " is " + age);
//}
//static void Main(string[] args)
//{
//    MyMethod("Liam", 5);
//    MyMethod("Jenny", 8);
//    MyMethod("Anja", 31);
//}
// Liam is 5
// Jenny is 8
// Anja is 31

//Compiler Error CS1503:
//Argument 'argument' cannot convert from TypeA to TypeB
//The type of one argument in a method does not match the type that was passed when the class was instantiated.
//namespace x
//{
//    public class a
//    {
//        public a(char i)
//        // try the following constructor instead
//        // public a(int i)
//        {
//        }

//        public static void Main()
//        {
//            a aa = new a(2222);   // CS1503
//        }
//    }
//}
//Note that when you are working with multiple parameters, the method call must have the same number of arguments as there are parameters, and the arguments must be passed in the same order.
//You can also use a default parameter value, by using the equals sign(=).
//If we call the method without an argument, it uses the default value ("Norway"):
//static void MyMethod(string country = "Norway")
//{
//    Console.WriteLine(country);
//}
//static void Main(string[] args)
//{
//    MyMethod("Sweden");
//    MyMethod("India");
//    MyMethod();
//    MyMethod("USA");
//}
// Sweden
// India
// Norway
// USA

//A parameter with a default value, is often known as an "optional parameter". From the example above, country is an optional parameter and "Norway" is the default value.
//In the previous page, we used the void keyword in all examples, which indicates that the method should not return a value.
//If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method:
//static int MyMethod(int x)
//{
//    return 5 + x;
//}
//static void Main(string[] args)
//{
//    Console.WriteLine(MyMethod(3));
//}
// Outputs 8 (5 + 3)

//This example returns the sum of a method's two parameters:
//static int MyMethod(int x, int y)
//{
//    return x + y;
//}
//static void Main(string[] args)
//{
//    Console.WriteLine(MyMethod(5, 3));
//}
// Outputs 8 (5 + 3)

//You can also store the result in a variable (recommended, as it is easier to read and maintain):
//static int MyMethod(int x, int y)
//{
//    return x + y;
//}
//static void Main(string[] args)
//{
//    int z = MyMethod(5, 3);
//    Console.WriteLine(z);
//}
// Outputs 8 (5 + 3)

//It is also possible to send arguments with the key: value syntax.
//That way, the order of the arguments does not matter:
//static void MyMethod(string child1, string child2, string child3)
//{
//    Console.WriteLine("The youngest child is: " + child3);
//}
//static void Main(string[] args)
//{
//    MyMethod(child3: "John", child1: "Liam", child2: "Liam");
//}

// The youngest child is: John
//With method overloading, multiple methods can have the same name with different parameters:
//int MyMethod(int x)
//float MyMethod(float x)
//double MyMethod(double x, double y)
//Consider the following example, which has two methods that add numbers of different types:
static int PlusMethodInt(int x, int y)
{
    return x + y;
}
static double PlusMethodDouble(double x, double y)
{
    return x + y;
}
//static void Main(string[] args)
//{
//    int myNum1 = PlusMethodInt(8, 5);
//    double myNum2 = PlusMethodDouble(4.3, 6.26);
//    Console.WriteLine("Int: " + myNum1);
//    Console.WriteLine("Double: " + myNum2);
//}

//Compiler Error CS0161:
//'method'- not all code paths return a value
//A method that returns a value must have a return statement in all code paths. For more information, see Methods.
public static int Main()
{
    int i = 5;
    if (i < 10)
    {
        return i; // Returns a value if condition is true
    }
    // No return statement here for other paths
}

//Instead of defining two methods that should do the same thing, it is better to overload one.
//In the example below, we overload the PlusMethod method to work for both int and double:
//static int PlusMethod(int x, int y)
//{
//    return x + y;
//}
//static double PlusMethod(double x, double y)
//{
//    return x + y;
//}
//static void Main(string[] args)
//{
//    int myNum1 = PlusMethod(8, 5);
//    double myNum2 = PlusMethod(4.3, 6.26);
//    Console.WriteLine("Int: " + myNum1);
//    Console.WriteLine("Double: " + myNum2);
//}
//Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.

//Compiler Error CS0029:
//Cannot implicitly convert type 'type' to 'type'
//The compiler requires an explicit conversion. For example, you may need to cast an r-value to be the same type as an l-value. Or, you must provide conversion routines to support certain operator overloads.
//Conversions must occur when assigning a variable of one type to a variable of a different type. When making an assignment between variables of different types, the compiler must convert the type on the right-hand side of the assignment operator to the type on the left-hand side of the assignment operator. Take the following the code:
/*
int i = 50;
long lng = 100;
i = lng;
*/

//Out parameter
var variousNumbers = new int[] { 10, -8, 2, 12, -17 };
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(
    numbers, out countOfNonPositiveNumbers);
//The out keyword causes arguments to be passed by reference.
//It also allows a method to return multiple values.

List<int> GetOnlyPositive(
    int[] numbers, out int countOfNonPositive)
{
    var result = new List<int>();
    countOfNonPositive = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            ++countOfNonPositive;
        }
    }
    return result;
}
//OR//
bool isParsed = int.TryParse(
    userInput, out int userInputParsedToInt);
//The TryParse method attempts to parse a string into an integer.
//It returns true if the parsing is successful, and false if it fails. The parsed integer value is stored in the out parameter userInputParsedToInt if the parsing is successful.
//If the parsing fails, userInputParsedToInt will be set to 0.
if (isParsed)
{
    Console.WriteLine(
        "Parsed successfully, the result is: " + userInputParsedToInt);
}
else
{
    Console.WriteLine(
        $"Could not parse '{userInput}' to int");
}

//System.FormatException: 
//Format specifier was invalid.
//The exception that is thrown when the format of an argument is invalid, or when a composite format string is not well formed.
public static void Main()
{
    decimal price = 169.32m;
    Console.WriteLine("The cost is {0:Q2}.", price);
}

//Switch expressions were introduced in C# 8.0 and provide a more concise syntax for performing pattern matching and returning values based on conditions.
char ConvertPointsToGrade(int points)
{
    switch (points)
    {
        case 10:
        case 9:
            return 'A';
        case 8:
        case 7:
        case 6:
            return 'B';
        case 5:
        case 4:
        case 3:
            return 'C';
        case 2:
        case 1:
            return 'D';
        case 0:
            return 'E';
        default:
            return '!';
    }
}
//VS//
char ConvertPointsToGrade(int points) => points switch
{
    10 or 9 => 'A',
    8 or 7 or 6 => 'B',
    5 or 4 or 3 => 'C',
    2 or 1 => 'D',
    0 => 'E',
    _ => '!',
};
//pattern matching is a powerful feature that allows us to check a value against specific patterns rather than just exact matches.//
char ConvertPointsToGrade(int points) => points switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 50 => 'C',
    _ => 'D',//anything below 50 gets a D
};

//WHILE LOOP PRACTICE//
var number = 0;

while (number < 10)//the loop will continue to run as long as the condition is true
{
    //number = number + 1;
    number += 1; //we can also use -=, *=, /=, etc. for other operations
    number++; //-- decrements the value by 1, ++ increments the value by 1
    Console.WriteLine("Number is: " + number);
}
Console.WriteLine("The loop is finished.");

Console.WriteLine("Enter a word: ");
var userInput = Console.ReadLine();

while (userInput.Length < 15)
{
    userInput += 'a';
    userInput = Console.ReadLine();
}

//FOR LOOP PRACTICE//
for (int i = 0; i < 5; i++)//initialization; condition; increment/decrement
{
    Console.WriteLine("Hello");
}
for (int i = 0; i < 5; ++i)//initialization; condition; increment/decrement
{
    Console.WriteLine($"Loop run: {i}");
}
for (int i = 10; i > 5; i--)//initialization; condition; increment/decrement
{
    Console.WriteLine($"Loop run: {i}");
}
Console.WriteLine("The loop is finished.");
//i++(Postfix): The variable comes first, so the value is used first, then it increments.
//++i (Prefix): The++ comes first, so it increments first, then the value is used.

int userNumber;
do
{
    Console.WriteLine("Enter a number larger than 10: ");
    var userInput = Console.ReadLine();
    userNumber = int.Parse(userInput);
} while (userNumber < 10);


//the break keyword immediately stops the execution of a loop
for (var i = 0; i < 100; i++)
{
    Console.WriteLine($"i is {i}.");
    if (i > 25)
    {
        break;
    }
}

//the continue keyword finishes the current iteration early & moves on to the next one
for (var i = 0; i < 20; i++)
{
    if (i % 3 != 0)
    {
        continue;
    }
    Console.WriteLine($"is: {i}.");
}


//NESTED LOOPS PRACTICE//
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"i is: {i} & j is: {j}.");

    }
}

//ARRAYS PRACTICE//
int[] numbers = new int[3]; //with no defined elements this array currently holds 3 zero's(the default for int)
Console.WriteLine($"Element  at index 0 is: {numbers[0]}");
Console.WriteLine($"Element  at index 1 is: {numbers[1]}");
Console.WriteLine($"Element  at index 2 is: {numbers[2]}");
//initializing elements of the array with user-defined values
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[20] = 7;// System.IndexOutOfRangeException

//we can also modify existing elements via their index
numbers[1] = 3;

int[] numbers = new int[5];

numbers[0] = 5;
numbers[1] = 6;
numbers[2] = 7;
numbers[3] = 17;
numbers[4] = 22;
var firstFromEnd = numbers[^1];
var secondFromEnd = numbers[^2];
//var firstFromEnd = numbers[numbers.Length - 1];
//var secondFromEnd = numbers[numbers.Length - 2];
Console.WriteLine("First from end: " + firstFromEnd);
Console.WriteLine("Second from end: " + secondFromEnd);

int[] numbers = new int[] { 2, 3, 4, 5, 6, 19 };

for (var i = 0; i < numbers.Length; i++)
{
    sumOfNumbers += numbers[i];
}

//MULTI-DIMENSIONAL ARRAYS PRACTICE//
char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine($"Height is: {height}.");
Console.WriteLine($"Width is: {width}.");
for (var i = 0; i < height; i++)
{
    Console.WriteLine($"i(outer loop/row) is: {i}");
    for (var j = 0; j < width; j++)
    {
        Console.WriteLine($"j(inner loop/column) is: {j}");
        Console.WriteLine($"Element at row {i} and column {j} is: {letters[i, j]}.");
    }
}

var letters2 = new char[,]
{
    {'A', 'B','C' },
    {'D', 'E','F' },
};


var words = new[] { "one", "two", "three" };
for (var i = 0; i < words.Length; i++)
{
    Console.WriteLine($"Element at index {i} is: {words[i]}.");
}
//VS
foreach (var word in words)
{
    Console.WriteLine($"Element is: {word}.");
}

//LISTS PRACTICE//
List<string> words = new List<string>();
Console.WriteLine($"Count of elements is: {words.Count}");

words.Add("Hello");
Console.WriteLine($"Count of elements is: {words.Count}");

var words = new List<string>
{
    "one",
    "two",
};

foreach (var word in words)
{
    Console.WriteLine($"Element is: {word}.");
}
//OR
for (var i = 0; i < words.Count; i++)
{
    Console.WriteLine($"Element at index {i} is: {words[i]}.");
}
words[0] = "uno";
words[1] = "dos";
words[2] = "tres";//this will cause an IndexOutOfRangeException, as the list currently only has 2 elements (at index 0 and 1)

Console.WriteLine("Removing an item");
words.Remove("thirty");//the Remove method returns false if the item to be removed is not found in the list

words.AddRange(new[] { "three", "four", "five" });//AddRange adds the elements of the specified collection to the end of the list
words.IndexOf("three");//IndexOf returns the zero-based index of the first occurrence of a specific object in the list, or -1 if it is not found
words.Contains("three");//Contains returns true if the list contains a specific element, otherwise false
words.Clear();//Clear removes all elements from the list

//THE OUT PARAMETER PRACTICE//
var numbers = new[] { 10, -8, 2, 12, -17 };
int nonPositiveCount;
var onlyPositive = GetOnlyPositive(numbers, out countOfNonPositive);
foreach (var positiveNumber in onlyPositive)
{
    Console.WriteLine($"Positive number: {positiveNumber}.");
}


List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    //Compiler Error CS0177:
    //The out parameter 'parameter' must be assigned to before control leaves the current method
    //A parameter marked with the out keyword was not assigned a value in the method body.

    var result = new List<int>();
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}


//TRY PARSE PRACTICE//
Console.WriteLine("Enter a number: ");
var userInput = Console.ReadLine();
int asNumber = int.Parse(userInput);//if the user input cannot be parsed to an int, this will throw a FormatException

bool isParsingSuccessful = int.TryParse(userInput, out int userInputParsedToInt);
if (isParsingSuccessful)
{
    Console.WriteLine($"Parsed successfully, the result is: {userInputParsedToInt}.");
}
else
{
    Console.WriteLine($"Could not parse '{userInput}' to int.");
}


















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
//Top-level statements replace the explicit Main method as the program's entry point.
//Top-level statements must precede namespace and type declarations.
//Place all top - level statements before any namespace or type declarations in the file, because the compiler requires top-level statements to appear first.
//Consider the following code snippet that triggers the CS8803 error:
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
public class Exercise3
{
    public static string IsElseConditionalStatement()
    {
        int number = 0;
        string result;

        if (number < 0)
        {
            result = "negative";
        }
        else if (number == 0)
        {
            result = "zero";
        }
        else
        {
            result = "positive";
        }
        return result;
    }
}

public class Exercise4
{
    public static int AbsoluteOfSum(int num1, int num2)
    {
        return Math.Abs(num1 + num2);
    }
}

public class Exercise5
{
    public static string FormatDate(int year, int month, int day)
    {
        return $"{year}/{month}/{day}";
    }
}

public class Exercise6
{
    public static string DescribeDay(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return "Working day";
            case 6:
            case 7:
                return "Weekend";
            default:
                return "Invalid day number";
        }
    }
}

public class Exercise7
{
    public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
    {
        int currentNumber = firstNumber;
        int sum = 0;
        while (currentNumber <= lastNumber)
        {
            sum += currentNumber;
            currentNumber++;
        }
        return sum;
        Console.ReadLine();
    }
}

public class Exercise8
{
    public static string RepeatCharacter(char character, int targetLength)
    {
        string result = "";
        int count = 0;
        do
        {
            result += character;
            count++;
        }
        while (count < targetLength);
        return result;
    }
}

public class Exercise9
{
    public static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
            Console.WriteLine($"N! = {result}.");
        }
        return result;
    }
}

public class Exercise10
{
    public static string BuildHelloString()
    {
        char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
        var result = "";
        for (int i = 0; i < letters.Length; ++i)
        {
            result += letters[i];
        }
        return result;
    }
}

public class Exercise11
{
    public static int FindMax(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);

        if (rows == 0 || columns == 0)
        {
            return -1;
        }

        var max = numbers[0, 0];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                Console.WriteLine($"i/row is: {i} | j/column is: {j}.");
                if (numbers[i, j] > max)
                {
                    max = numbers[i, j];
                }
            }
        }

        return max;
    }
}

public class Exercise12
{
    public static bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length)
            {
                return true;
            }
        }
        return false;
    }
}

public class Exercise13
{
    public List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        List<string> result = new List<string>();
        foreach (var word in words)
        {
            if (result.Contains(word))
            {
                continue;
            }
            bool isAllUpper = true;

            if (word.Length == 0)
            {
                isAllUpper = false;
            }
            foreach (var letter in word)
            {
                if (!char.IsUpper(letter))
                {
                    isAllUpper = false;
                    break;
                }
            }
            if (isAllUpper)
            {
                result.Add(word);
            }
        }
        return result;
    }
}

Console.WriteLine("Press any key to close");
Console.ReadKey();