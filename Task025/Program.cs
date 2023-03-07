// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

double InputNumber(string msgToUser)
{
    Console.Write(msgToUser);
    double result = 0;
    if (double.TryParse(Console.ReadLine(), out result))
    {
        return result;
    }
    else
    {
        throw new Exception("Waiting a real number! Restart the program!");
    }
}

double Exp(double numA, double numB)
{
    double expNum = 1;
    for (int i = 0; i < numB; i++)
    {
        expNum *= numA;
    }
    return expNum;
}

double number = InputNumber("Enter an integer: ");
double exponent = InputNumber("Enter a number to exponentiate: ");

Console.WriteLine($"{number}, {exponent} -> {Exp(number, exponent)}");