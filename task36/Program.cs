// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void Main()
{
    Console.Clear();
    int size = UserInput("Введите размер массива");
    int minValue = UserInput("Введите минимальное значение элементов массива");
    int maxValue = UserInput("Введите максимальное значение элементов массива");
    int[] array = GetArray(size, minValue, maxValue);
    PrintArray(array);
    int result = SumOddElemet(array);
    PrintResult(result);
}
int UserInput(string text)
{
    Console.Write($"{text}: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(", ", array));

}

int SumOddElemet(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length ; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

void PrintResult(int result)
{
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {result}");
    
}

Main();