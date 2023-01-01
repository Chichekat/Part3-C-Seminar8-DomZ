// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);

int[,] GetArray (int m, int n){
    int numbers = 1;
    int[,] result = new int [m, n];
    for (int y = 0; y < n; y++){ 
        result[0, y] = numbers;
        numbers++;
        }
    for (int x = 1; x < m; x++){ 
        result[x, n - 1] = numbers;
        numbers++;
        }
    for (int y = n - 2; y >= 0; y--){ 
        result[m - 1, y] = numbers;
        numbers++;
        }
    for (int x = m - 2; x > 0; x--){
        result[x, 0] = numbers;
        numbers++;
        }

    int c = 1;
    int d = 1;
 
    while (numbers < m * n) {
        while (result[c, d + 1] == 0) { //вправо
                result[c, d] = numbers;
                numbers++;
                d++;
            }
        while (result[c + 1, d] == 0) { //вниз
                result[c, d] = numbers;
                numbers++;
                c++;
            }
        while (result[c, d - 1] == 0) { //влево
                result[c, d] = numbers;
                numbers++;
                d--;
            }
        while (result[c - 1, d] == 0) { //вверх
                result[c, d] = numbers;
                numbers++;
                c--;
            }
        }
        for (int x = 0; x < m; x++) { //центр
            for (int y = 0; y < n; y++) {
                if (result[x, y] == 0) {
                    result[x, y] = numbers;
                }
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
