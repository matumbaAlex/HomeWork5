// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Main()
{
    Console.Clear();
    int size = UserInput("Введите размер массива");
    int[] array = GetArray(size);
    PrintArray(array);
    int result = CountEvenElements(array);
    PrintResult(result);
}
int UserInput(string text)
{
    Console.Write($"{text}: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(", ", array));

}

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void PrintResult(int result)
{
    Console.WriteLine($" количество чётных чисел в массиве равно {result} ");
    
}

Main();