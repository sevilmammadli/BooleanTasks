#region Practice
//int number = 5432;
//int count = 0;

//while (number > 0)
//{
//    number = number / 10;
//    count++;
//    Console.WriteLine($"Number: {number} Count: {count}");
//}

//int someNumber = 0;
//while(someNumber < 10)
//{
//    Console.Write("Enter the number : ");
//    someNumber = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine($"{someNumber} is greater than 10");


//start:
//Console.Write("Enter the number : ");
// int someNumber = Convert.ToInt32(Console.ReadLine());

//if (someNumber < 10)
//{
//    goto start;
//}
//Console.WriteLine($"{someNumber} is greater than 10");


//string searchedWord = "Boolean";
//Console.WriteLine("| Welcome to Word game |");
//string enteredWord = string.Empty;
//int limit = 3 , count = 0;
//bool result = false;

//do
//{
//    Console.Write("Please enter the word: ");
//    enteredWord = Console.ReadLine();
//    count++;
//    if(count == limit)
//    {
//        result = true;
//      // Just we can use BREAK keyword without any RESULT value and additional AND operation
//    }

//}
//while (searchedWord != enteredWord && !result);

//if  (result is false)
//{
//    Console.WriteLine($"Victory! your attempts: {count}, and searched word: {searchedWord}");
//}
//else
//{
//    Console.WriteLine($"Game Over! your attempts: {count},  and searched word: {searchedWord}");
//}

//for (int i = 1; i < 10; i++)
//{
//	for (int j= 1; j <=10 ; j++)
//	{
//        Console.WriteLine($"{i} x {j} = {i*j}");
//    }
//    Console.WriteLine("-------------------------------------");
//}
#endregion

#region Tasks
/////////////////////////Task1/////////////////////////

//double product = 1;

//for (int i = 1; i < 50; i += 3)
//{
//    Console.WriteLine(i);
//    product = product * i;
//}
//Console.WriteLine(product);

/////////////////////////Task2/////////////////////////

//int sum = 0;
//int count = 0;
//double product = 1;

//for (int i = -30; i <= 28; i++)
//{ 
//    if (i % 2 != 0) 
//    {
//        count++;
//    }
//    else if (i % 2 == 0 && i % 3 == 0) 
//    {
//        sum += i;
//    }
//    else if (i % 2 == 0 || i % 5 == 0)
//    {
//        product *= i;
//    }

//}
//Console.WriteLine($"The count of numbers which are odd: {count}");
//Console.WriteLine($"The sum of numbers which is divided by 3 and 6: {sum}");
//Console.WriteLine($"The product of numbers which is divided by 2 or 5: {product}");

/////////////////////////Task3/////////////////////////

//int number = 304001;
//int q = 0;
//int sum = 0;
//int count = 0;

//while (number > 0)
//{
//    q = number % 10;
//    sum += q;
//    number = number / 10;
//    if(q == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"The sum numbers which are digits of 304001: {sum}");
//Console.WriteLine($"The count of number which are either odd or even: {count}");

/////////////////////////Task4/////////////////////////


//string trueLogin = "booleanteach";
//string enteredLogin = string.Empty;
//Console.Write("Enter your Login: ");
//enteredLogin = Console.ReadLine();
//int limit = 2, countLogin = 0, countPsw = 0;
//bool resultLogin = false, resultPsw = false;

//while ((trueLogin != enteredLogin && !resultLogin))
//{

//    Console.WriteLine("Login is false! ");
//    Console.Write("Please, again enter your Login: ");
//    enteredLogin = Console.ReadLine();
//    countLogin++;
//    if (limit == countLogin)
//    {
//        resultLogin = true;
//        Console.WriteLine("System is blocked");
//    }

//}
//string truePassword = "booleanms13";
//string enteredPassword = string.Empty;
//Console.Write("Enter your Password: ");
//enteredPassword = Console.ReadLine();

//while (truePassword != enteredPassword && !resultPsw)
//{
//    Console.WriteLine("Password is false! ");
//    Console.Write("Please, again enter your Password: ");
//    enteredPassword = Console.ReadLine();
//    countPsw++;
//    if (limit == countPsw)
//    {
//        resultPsw = true;
//        Console.WriteLine("System is blocked");
//    }
//}
//if ((trueLogin != enteredLogin && truePassword != enteredPassword)) 
//{
//    Console.WriteLine("Both of them are false!");
//}
//else
//{
//    Console.WriteLine("You are entered the System! ");
//}

#endregion
