// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//if and else if
var number = 10;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

//single if
var number1 = 11;
Console.WriteLine(number1 == 10 ? "Number is 11" : "Number is not 11");

//switch
var number2 = 12;
switch (number2)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

//multiple terms
var number3 = 13;
if (number3 >= 0 && number3 <= 100)

{
    Console.WriteLine("Number is betwwen 0-100");
}
else if (number3 > 100 && number3 <= 200)
{
    Console.WriteLine("Number is betwwen 101-200");
}
else if (number3 > 200 || number3 < 0)
{
    Console.WriteLine("Number is less then 0 or greater then 200");
}

// nested if
var number4 = 14;
if (number4 < 100)
{
    if (number4 >= 90 && number4 < 95)
    {
        Console.WriteLine("Number is betwwen 90-95");
    }
    else
    {
        Console.WriteLine("number is 14");
    }
}


Console.ReadLine();