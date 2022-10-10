using static System.Console;
Clear();
Write("введите количество строк, столбцов, минимальный и максимальное значение матрицы через пробел: ");
int[] parametrs1 = GetArrayFromString(ReadLine()!);
Write("введите количество строк, столбцов, минимальный и максимальное значение матрицы через пробел: ");
int[] parametrs2 = GetArrayFromString(ReadLine()!);
if (parametrs1[1]!= parametrs2[0]) 
{
    WriteLine("Произвести умножение данных матриц невозможно");
    return;
}
int[,] matrix1 = GetMatrixArray(parametrs1[0], parametrs1[1], parametrs1[2], parametrs1[3]);
int[,] matrix2 = GetMatrixArray(parametrs2[0], parametrs2[1], parametrs2[2], parametrs2[3]);
PrinttMatrix(matrix1);
PrinttMatrix(matrix2);
int[,] resultmatrix = MultiplikationOfMatrix(matrix1,matrix2);
PrinttMatrix(resultmatrix);















int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}
void PrinttMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}
int[] GetArrayFromString(string parameters)
{
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}


int[,] MultiplikationOfMatrix(int[,] matr1, int[,] matr2)
{
    int [,] result = new int[matr1.GetLength(0),matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
              result[i,j]+=matr1[i,k]*matr2[k,j];
            }
        }   
    }
return result;
}
