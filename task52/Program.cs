// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void AVG(int[,] matrix) // int row, int column) 
{
    
    
    for(int j = 0; j < column; j++)
    {
            double sum = 0;
            for(int i = 0; i < row; i++)
            {
                sum = sum + matrix[i, j];   
            }
            double avg = 0;
            avg = Math.Round(sum / (row), 2);
            Console.WriteLine($"Среднее арифметическое столбца {j} равно {avg}");

            
    }   
}


AVG (matrix);
