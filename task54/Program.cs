using static System.Console;
Clear();
Write("введите размер матрицы и минимальный и максимальное значение через пробел: ");
int[] parametrs = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1], parametrs[2], parametrs[3]);
PrinttMatrix(matrix);
FiltredMatrix(matrix);
WriteLine();
PrinttMatrix(matrix);













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

void FiltredMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1)-1; j++)
      {
        for (int k = j+1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i,j]<matrix[i,k])
            {
             int temp = matrix[i,j];
             matrix[i,j] =matrix[i,k] ;
             matrix[i,k]= temp;
            }
         
        }
      }   
    }
    
}

