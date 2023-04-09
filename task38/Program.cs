
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
void Main()
{
    Console.Clear();
    int size = UserInput("Введите размер массива");
    int minValue = UserInput("Введите минимальное значение элементов массива");
    int maxValue = UserInput("Введите максимальное значение элементов массива");
    double[] array = GetArray(size, minValue, maxValue);
    PrintArray(array);
    double result = Difference(array);
    PrintResult(result);
}
int UserInput(string text)
{
    Console.Write($"{text}: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    // Console.WriteLine(String.Join(", ", array));
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f4} ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    result = max - min;
    return result;
}

void PrintResult(double result)
{
    Console.WriteLine($"Разницу между максимальным и минимальным  элементов массива {result:f4}");

}

Main();