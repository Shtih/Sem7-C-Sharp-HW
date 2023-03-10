// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] RandomMantrix (int row, int column)
{
        int[,] matrix = new int [row, column];
        //Random rnd = new Random();
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < column; j++)
            {
                matrix[i, j] = i + j;
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