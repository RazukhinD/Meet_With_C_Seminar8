// **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


using static System.Console;

Clear();
WriteLine ("Введи размер массива, минимальное и максимальное значение через пробел:");
int [] parameters = FillParameters(ReadLine()!);
int[,] matrixstart = FillArray(parameters[0],parameters[1],parameters[2],parameters[3]);
WriteLine();
PrintMatrix(matrixstart);
WriteLine();
int[,] matrixinvert = MatrixInvert(matrixstart);
PrintMatrix(matrixinvert);






int[] FillParameters (string Parameters)
{
    int [] result = new int[Parameters.Length];
    string[] param=Parameters.Split(' ', System.StringSplitOptions.RemoveEmptyEntries); 
    for (int i = 0; i < param.Length; i++)
    {
        result[i]=Convert.ToInt32(param[i]);
    }
    return result;
}


int[,] FillArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] resultarray = new int[rows,columns];
    for (int i = 0; i < resultarray.GetLength(0) ;i++)    
    {
        for (int j = 0; j < resultarray.GetLength(1); j++)
        {
            resultarray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return resultarray;
}


void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
        WriteLine();
    }
}

int[,] MatrixInvert(int[,] matrix)
{
     int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j]= temp;
    }
    return matrix;

}