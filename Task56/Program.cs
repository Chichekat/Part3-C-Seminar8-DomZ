// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

Console.WriteLine("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns);
PrintArray(arr);
Console.WriteLine();

int minSum = 0;
int minLine = SumElements(arr, 0);
for (int i = 0; i < arr.GetLength(0); i++)
{
    if (SumElements(arr, i) < minSum) 
    minSum = SumElements(arr, i);
    minLine = i+1;
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {minLine}");


int[,] GetArray (int rows, int columns){
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}

int SumElements (int[,] array, int i){
    int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    return sum;
}