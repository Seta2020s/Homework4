// Напишите программу,которая задает массив из 8 элементов
// и выводит их на экран
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]

int[] GenerateArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10);
    }
    return array;
}

int[] numbers = GenerateArray();
string arrayString = "[" + string.Join(",", numbers) + "]";
Console.WriteLine(arrayString);