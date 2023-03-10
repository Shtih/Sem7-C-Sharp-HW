//Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
//m = 3, n = 4.




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


// {
// int[] arr = new int [rows];
// int[] arr = new int [colums]; // выделяем память под длину массива
//     Random rnd = new Random(); //
//     for(int i = 0; i < arr.Length; i++) // заполняем массив
//     { // индекс от 0, пока не кончится длина массива, добавляя по еденице
//         arr[i] = rnd.Next(-100, 101); // рандомные числа от - 9 до 9
//     }
//     return arr;
// }
// Console.WriteLine("Введите длину массива: ");
// int lenght = Convert.ToInt32(Console.ReadLine());
// int[] array = RandomArray(lenght);
// Console.WriteLine($"[ {string.Join(", ", array)} ]");
