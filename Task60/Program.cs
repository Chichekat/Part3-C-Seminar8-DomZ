// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите количество строк в массиве: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int y = int.Parse(Console.ReadLine());
int z = x;

int[,,] arr = GetArray(x, y, z);
PrintArray(arr);

int[,,] GetArray (int x, int y, int z){
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(10, 100);
                if (result[i, j, k] == element) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

void PrintArray (int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
              Console.Write($"{array[i, j, k]}" + $"({i}, {j}, {k}) ");  
            }
          Console.WriteLine();  
        }
    }
}