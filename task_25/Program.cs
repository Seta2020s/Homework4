//Напишите цикл,который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

int CalculatePower(int baseNumber, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= baseNumber;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int power = CalculatePower(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно {power}");
