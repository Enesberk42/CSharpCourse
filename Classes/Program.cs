using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Adı";
customer.LastName = "Soyadı";
customer.City = "Şehir";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.FirstName = "Adı2";
customer2.LastName = "Soyadı2";
customer2.City = "Şehir2";

Console.WriteLine(customer2.FirstName);

Console.ReadLine();