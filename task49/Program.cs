// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

for(int i = 0; i < row; i = i + 2)
{
    for(int j = 0; j < column; j = j + 2)
    {
        matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
}
PrintMatrix(matrix, row, column);


            