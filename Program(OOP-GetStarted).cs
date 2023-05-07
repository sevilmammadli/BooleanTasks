#region Practice

//Employee employee1 = new Employee();
//employee1.fullName = "Sevil Mammadli";
//employee1.address = "Suraxani Zeynalov-15";
//employee1.salary = 5000;
//employee1.Register();

//Employee employee2 = new Employee();
//employee2.fullName = "Gunel Hashimova";
//employee2.address = "Hokmeni";
//employee2.salary = 10000;
//employee2.Register();

//Order order = new Order();
//order.orderNumber = "100001";
//order.orderDate = DateTime.Now;
//order.price = 2000;
//order.Ordered();



//class Employee
//{
//    public string fullName;
//    public string address;
//    public int salary;

//    public void Register()
//    {
//        Console.WriteLine($" {fullName} is registered!");
//    }

//    public int CalcSalary()
//    {
//        return salary;
//    }
//}

#endregion


#region Task

Phone phone1 = new Phone();
phone1.name = "IPhone";
phone1.model = "13 Pro";
phone1.price = 3000;
phone1.ShowNameAnModel();
int payment1 = phone1.CalcCredit(6,5);
Console.WriteLine($"The customer should pay {payment1} for every month ");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

Phone phone2 = new Phone();
phone2.name = "Samsung";
phone2.model = "Galaxy S23";
phone2.price = 2600;
phone2.ShowNameAnModel();
int payment2 = phone2.CalcCredit(12, 10);
Console.WriteLine($"The customer should pay {payment2} for every month ");

class Phone
{
    public string name;
    public string model;
    public int price;

    public void ShowNameAnModel()
    {
        Console.WriteLine($"Name of Phone: {name} ");
        Console.WriteLine($"Model of Phone: {model}");
    }
    public int CalcCredit(int month, int pertentage)
    {
        return  (price * pertentage/ 100 + price)/ month ;
    }
}




#endregion