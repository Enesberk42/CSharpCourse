﻿//Intro();
string sentence = "My name is Enes";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Enis";

bool result3 = sentence.EndsWith("s");
bool result4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(2,5);
Console.WriteLine(result13);

Console.ReadLine();

static void Intro()
{
    string city = "Ankara";
    //Console.WriteLine(city[0]);

    foreach (var item in city)
    {
        Console.WriteLine(item);
    }

    string city2 = "İstanbul";
    string result = city + city2;

    Console.WriteLine(result);
}