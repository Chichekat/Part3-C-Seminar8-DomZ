// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine());
int col = size;

int[,] matr1 = GetMatrix(size, col);
PrintMatrix(matr1);
Console.WriteLine();
int[,] matr2 = GetMatrix(size, col);
PrintMatrix(matr2);
Console.WriteLine();
int[,] temp = MultipMatrix(matr1, matr2);
PrintMatrix(temp);

int[,] GetMatrix (int size, int colomn){
    int[,] result = new int[size, colomn];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintMatrix (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + " ");
        }
        Console.WriteLine(" ");
    }
}

int[,] MultipMatrix (int[,] matrix1, int[,] matrix2){
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++){
            for (int j = 0; j < matrix1.GetLength(0); j++)
            {
                for (int k = 0; k < matrix2.GetLength(1); k++)
                {
                    res[i, j] = matrix1[i, k] * matrix2[k, j];
                }
            }
    }
    return res;
}