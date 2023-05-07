#region Practice

// Geriye deyer donderen ve dondermeyen metodlar
//void WelcomeService()
//{
//    Console.WriteLine("Hello World!");
//    Console.WriteLine("Welcome to Programming World");
//}

//WelcomeService();

//string SayMyName()
//{
//    return "Sevil Mammadli";
//}

//Console.WriteLine(SayMyName()); 

//void CalcVoid()
//{
//    int numberOne = 12, numberTwo = 13;
//    Console.WriteLine(numberOne + numberTwo);
//}
//CalcVoid();
//int CalcShort()
//{
//    int numberOne = 12, numberTwo = 13;

//    //Console.WriteLine(numberOne + numberTwo); // Her ikisinde CW istifade oluna bler

//    return numberOne + numberTwo;
//}
//int calculationValue = CalcShort();

//if (calculationValue < 30)
//{
//    Console.WriteLine($"{calculationValue} is less than 30");
//}


//Parametri olan ve olmayan metodlar

//int Calc (int numberOne, int numberTwo)
//{
//    return numberOne + numberTwo;
//}

//int calcValue = Calc(12, 13);
//Console.WriteLine(calcValue);
////Console.WriteLine(Calc(12,11));

//void PrintMessage(string message)
//{
//    Console.WriteLine($"*******************{message}*******************");
//}

//string messageFromCmd = Console.ReadLine();
//PrintMessage(messageFromCmd);


//////////////////////////////////////////////////
//int count = 0;
//void Counter()
//{
//    count++;
//    Console.WriteLine(count);
//}

//Counter();
//Counter();
//Counter();
//Counter();

/////////////Params//////////////////////

//int GetSum(string not, params int[] numbers)
//{
//    Console.WriteLine(not);
//    int sum = 0;
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        sum += numbers[i];
//    }
//    return sum;
//}

//Console.WriteLine(GetSum("Sum", 12, 23, 24, 53, 53));


///////////////////Project/////////////
int CalculationForArray(char operationMath, params int[] numbers)
{
    if (operationMath == '+')
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    else if (operationMath == '*')
    {
        int multiply = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            multiply *= numbers[i];
        }
        return multiply;
    }
    else
    {
        return 0;
    }
}
void PrintByMath(char operationMath, int result)
{
    if (operationMath == '+')
    {
        Console.WriteLine($"Sum: {result}");
    }
    else if (operationMath == '*')
    {
        Console.WriteLine($"Multiply: {result}");
    }
    else
    {
        Console.WriteLine("There is no any result!");
    }

}
void Calculator(char operationMath, params int[] numbers)
{
    switch (operationMath)
    {
        case '+':
            PrintByMath('+', CalculationForArray('+', numbers));
            break;
        case '*':
            PrintByMath('*', CalculationForArray('*', numbers));
            break;
    }
}
Calculator('+', 12, 23, 34, 45);
Calculator('*', 12, 1);

#endregion

