using Interfaces;
//InterfacesIntro();
//Demo();

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};
foreach (var customerDal in customerDals) 
{
    customerDal.Add();
}

Console.ReadLine();

static void InterfacesIntro()
{
    PersonManager manager = new PersonManager();
    manager.Add(new Customer { Id = 1, FirstName = "İsim", LastName = "Soyisim", Address = "Adres" });
    manager.Add(new Student { Id = 1, FirstName = "İsim", LastName = "Soyisim", Departman = "Departman" });
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new OracleCustomerDal());
}

interface Iperson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}
class Customer : Iperson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : Iperson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departman { get; set; }
}

class PersonManager
{
    public void Add(Iperson person)
    {
        Console.WriteLine(person.FirstName);
    }
}