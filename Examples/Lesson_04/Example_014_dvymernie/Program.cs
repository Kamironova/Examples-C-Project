// Пример создания двуиерного массива

Console.Clear();

//int[,] matrix = new int[3,4];  // где 3 это количество строк, а 4 - столбцов

void PrintArray(int[,] matr)  // метод для создания двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // matr(matrix)GetLength(0), 0 означает длину строки
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // 1 - длина столбца
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
    
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
} 

int[,] matrix = new int[3,4];

PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);