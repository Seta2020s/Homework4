// Напишите программу,которая принимает на вход число
// и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CalculateDigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int inputNumber = GetInput("Введите число: ");
int digitSum = CalculateDigitSum(inputNumber);
Console.WriteLine($"Сумма цифр числа {inputNumber} равна {digitSum}");
