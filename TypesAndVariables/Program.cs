// See https://aka.ms/new-console-template for more information
//Value Types
Console.WriteLine("Hello, World!");

//int
int number1 = 2147483647; //MAX pozitif
//int number2 = -2147483648 //Max negatif
Console.WriteLine("Number1 is {0}", number1);

//long
long number2 = 9223372036854775807; //MAX pozitif
//long number2 = -9223372036854775808; //MAX negatif
Console.WriteLine("Number2 is {0}", number2);

//short
short number3 = 32767;
Console.WriteLine("Number3 is {0}", number3);

// byte
byte number4 = 255;
Console.WriteLine("Number4 is {0}", number4);

//bool
bool condition = false;

//char
char character = 'a';
Console.WriteLine("Character is {0}", (int)character);

//double
double number5 = 10.4;
Console.WriteLine("Number5 is {0}", number5);

//decimal
decimal number6 = 10.4m;


//var
var number7 = 10;
number7 = 'A';
Console.WriteLine("Number7 is {0}", number7);

//enum
Console.WriteLine(Days.Friday);
enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}


