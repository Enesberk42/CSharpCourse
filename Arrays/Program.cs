string[] students = new string[3] { "Birinci", "İkinci", "Üçüncü" };


string[] students2 = { "Birinci1", "İkinci2", "Üçüncü3" };

foreach (var student in students2)
{
    Console.WriteLine(student);
}

string[,] regions = new string[5, 3]
{
    {"A","B","C" },
    {"D","E","F" },
    {"G","H","I" },
    {"J","K","L" },
    {"M","N","O" },
};

for (int i = 0; i < regions.GetUpperBound(0); i++) 
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++) 
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("**********");
}
Console.ReadLine();