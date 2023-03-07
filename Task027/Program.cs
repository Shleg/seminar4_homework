// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string msgToUser)
{
    Console.Write(msgToUser);
    int result = 0;
    if (int.TryParse(Console.ReadLine(), out result))
    {
        return result;
    }
    else
    {
        throw new Exception("Waiting a integer number! Restart the program!");
    }
}

int DigitSum(int num)
{
    if (num == 0) return 0;
    return num % 10 + DigitSum(num / 10);
}

int number = InputNumber("Enter an integer number: ");
Console.WriteLine($"{number} -> {DigitSum(number)}");