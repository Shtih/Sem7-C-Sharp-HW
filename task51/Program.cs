// Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] RandomMantrix (int row, int column)
{
        int[,] matrix = new int [row, column];
        Random rnd = new Random();
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                matrix[i, j] = rnd.Next(0, 10);
            }
        }
        return matrix;
}

void PrintMatrix(int[,] matrix, int row, int column) 
{
    for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
               Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
}

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = RandomMantrix(row, column);
PrintMatrix(matrix, row, column);
Console.WriteLine();

// int sum(int[,] matrix)
// {
//     int sum = 0;
//     for(int i = 0; i < row; i++)
//     {
//         for(int j = 0; j < column; j++)
//         {
//             if(i == j)
//             {
//                 sum = sum + matrix[0,0];
//             }
//         }
//     }
//     return sum;
// }

int Sum(int[,] matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (i == j)
{
sum += matrix[i, j];
}
}
}
return sum;
}
Console.WriteLine(Sum(matrix));
