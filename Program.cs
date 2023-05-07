//                     Task 1

//Console.Write("Please enter your department: ");
//string department = Console.ReadLine();
//if (department == "HR")
//{
//    Console.WriteLine("Department of Human Resource");
//}
//else if (department == "IT")
//{
//    Console.WriteLine("Department of Information Technologies");
//}
//else if (department == "Finance")
//{
//    Console.WriteLine("Department of Finance");
//}
//else
//{
//    Console.WriteLine("There is not department like this");
//}

//                     Task 2

//Console.Write("Please enter your experience: ");
//int experience = Convert.ToInt32(Console.ReadLine());
//int salary = default;

//if(experience > 0 && experience <= 2)
//{
//    salary = 2000;
//}
//else if (experience >= 3 && experience < 5)
//{
//    salary = 5000;
//}
//else if (experience >= 5 && experience < 10)
//{
//    salary = 7000;
//}
//else if (experience >= 10)
//{
//    salary = 10000;
//}

//Console.WriteLine($"Your salary is: {salary}");

//                     Task 3


#region MenuProject(Switch)
Console.WriteLine("1. Isti Yemekler");
Console.WriteLine("2. Qazan Yemekleri");
Console.WriteLine("3. Ichkiler");
Console.WriteLine("4. Desertler");

Console.Write("Please enter your choice: ");
short choice = Convert.ToInt16(Console.ReadLine());
string a = default(string);

switch (choice)
{
    case 1:
        Console.WriteLine("1. Dolma");
        Console.WriteLine("2. Kartof");
        Console.WriteLine("3. Shaurma");
        Console.WriteLine("4. Iskender");
        Console.Write("Please enter your option: ");
        short option1 = Convert.ToInt16(Console.ReadLine());
        switch (option1)
        {
            case 1:
                a = "Dolma";
                break;
            case 2:
                a = "Kartof";
                break;
            case 3:
                a = "Shaurma";
                break;
            case 4:
                a = "Isgender";
                break;
            default:
                Console.WriteLine("There is not meal like this");
                break;
        }
        Console.WriteLine($"{a} is ordered");
        break;
    case 2:
        Console.WriteLine("1. Bozmash");
        Console.WriteLine("2. Sheki Pitisi");
        Console.WriteLine("3. Quzu Soyutma");
        Console.WriteLine("4. Buglama");
        Console.Write("Please enter your option: ");
        short option2 = Convert.ToInt16(Console.ReadLine());
        switch (option2)
        {
            case 1:
                a = "Bozbash";
                break;
            case 2:
                a = "Sheki Pitisi";
                break;
            case 3:
                a = "Quzu Soyutma";
                break;
            case 4:
                a = "Buglama";
                break;
            default:
                Console.WriteLine("There is not meal like this");
                break;
        }
        Console.WriteLine($"{a} is ordered");
        break;
    case 3:
        Console.WriteLine("1. Coca-Cola");
        Console.WriteLine("2. Fanta");
        Console.WriteLine("3. Dushes");
        Console.WriteLine("4. Kompot");
        Console.Write("Please enter your option: ");
        int option3 = Convert.ToInt32(Console.ReadLine());
        switch (option3)
        {
            case 1:
                a = "Coca-Cola";
                break;
            case 2:
                a = "Fanta";
                break;
            case 3:
                a = "Dushes";
                break;
            case 4:
                a = "Kompot";
                break;
            default:
                Console.WriteLine("There is not drink like this");
                break;
        }
        Console.WriteLine($"{a} is ordered");
        break;  
    case 4:
        Console.WriteLine("1. CheeseCake");
        Console.WriteLine("2. Tiramisu");
        Console.WriteLine("3. Sufle");
        Console.WriteLine("4. Paxlava");
        Console.Write("Please enter your option: ");
        int option4 = Convert.ToInt32(Console.ReadLine());
        switch (option4)
        {
            case 1:
                a = "CheeseCake";
                break;
            case 2:
                a = "Tiramisu";
                break;
            case 3:
                a = "Sufle";
                break;
            case 4:
                a = "Paxlava";
                break;
            default:
                Console.WriteLine("There is not desert like this");
                break;
        }
        Console.WriteLine($"{a} is ordered");
        break;
    default:
        Console.WriteLine("There is not choice like this");
        break;
}
#endregion


#region MenuProject(IF)

//if (choice == 1)
//{
//    Console.WriteLine("1. Dolma");
//    Console.WriteLine("2. Kartof");
//    Console.WriteLine("3. Shaurma");
//    Console.WriteLine("4. Iskender");
//    Console.Write("Please enter your option: ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    if (option == 1)
//    {
//        a = "Dolma";
//    }
//    else if (option == 2)
//    {
//        a = "Kartof";
//    }
//    else if (option == 3)
//    {
//        a = "Shaurma";
//    }
//    else if (option == 4) 
//    {
//        a = "Isgender";
//    }
//}
//else if (choice == 2)
//{
//    Console.WriteLine("1. Bozmash");
//    Console.WriteLine("2. Sheki Pitisi");
//    Console.WriteLine("3. Quzu Soyutma");
//    Console.WriteLine("4. Buglama");
//    Console.Write("Please enter your option: ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    if (option == 1)
//    {
//        a = "Bozmash";
//    }
//    else if (option == 2)
//    {
//        a = "Sheki Pitisi";
//    }
//    else if (option == 3)
//    {
//        a = "Quzu Soyutma";
//    }
//    else if (option == 4)
//    {
//        a = "Buglama";
//    }
//}
//else if (choice == 3)
//{
//    Console.WriteLine("1. Coca-Cola");
//    Console.WriteLine("2. Fanta");
//    Console.WriteLine("3. Dushes");
//    Console.WriteLine("4. Kompot");
//    Console.Write("Please enter your option: ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    if (option == 1)
//    {
//        a = "Coca-Cola";
//    }
//    else if (option == 2)
//    {
//        a = "Fanta";
//    }
//    else if (option == 3)
//    {
//        a = "Dushes";
//    }
//    else if (option == 4)
//    {
//        a = "Kompot";
//    }
//}
//else if (choice == 4)
//{
//    Console.WriteLine("1. CheeseCake");
//    Console.WriteLine("2. Tiramisu");
//    Console.WriteLine("3. Sufle");
//    Console.WriteLine("4. Paxlava");
//    Console.Write("Please enter your option: ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    if (option == 1)
//    {
//        a = "CheeseCake";
//    }
//    else if (option == 2)
//    {
//        a = "Tiramisu";
//    }
//    else if (option == 3)
//    {
//        a = "Sufle";
//    }
//    else if (option == 4)
//    {
//        a = "Paxlava";
//    }
//}
//Console.WriteLine($"{a} is ordered");

#endregion