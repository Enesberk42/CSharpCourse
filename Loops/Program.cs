// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();

if (IsPrimeNumber(6)) 
{
    Console.WriteLine("This is prime number");
}
else
{
    Console.WriteLine("This is not prime number");
}
Console.ReadLine();

static bool IsPrimeNumber(int number) 
{
    bool result =true;
    for (int i = 2; i < number-1; i++) 
    {
        if (number%i==0)
        {
            result = false;
            i=number;
        }
    }
    return result;
}


static void ForLoop()
{
    for (int i = 1; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
}

static void ForEachLoop()
{
    string[] students = new string[3] { "Birinci", "İkinci", "Üçüncü" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}