Person[] personal = new Person[3]
{
    new Customer{FirstName="İsim1"},
    new Student{FirstName="İsim2"},
    new Person{FirstName="İsim3"}
};
foreach (var person in personal)
{
    Console.WriteLine(person.FirstName);
}
Console.ReadLine();
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Departman { get; set; }

}