// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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


void Finder(int[,] matrix) 
{

                Console.WriteLine("Введите число row2: ");
                int row2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число column2: ");
                int column2 = Convert.ToInt32(Console.ReadLine());
                
                if(row2 < row && column2 < column)
                {
                    Console.Write($"Значение  соотвествует элементу массива {matrix[row2, column2]}");
                }
                else
                {
                    Console.Write($"Элелемент с данными индексами отсутствует в массиве");
                }
            
}

Finder(matrix);
