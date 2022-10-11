using static System.Console;
Clear();
Write("введите количество размеры матрицы через пробел: ");
int[] parametrs1 = GetArrayFromString(ReadLine()!);
int[,,] matrix1 = GetMatrixArray(parametrs1[0], parametrs1[1], parametrs1[2]);
PrinttMatrix(matrix1);




int[,,] GetMatrixArray(int rows, int columns, int str1)
{
    int[] arrayofnums= new int[rows*columns*str1+1];
    int[,,] resultMatrix = new int[rows, columns,str1];
    int index = 1;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(2); k++)
            {
                int num = new Random().Next(10,100);
                arrayofnums[index]=num;
                for (int g = 0; g < index; g++)
                {
                  if (num == arrayofnums[g]) 
                  {
                    index=index-1;
                    k=k-1;
                    break;
                  }
                resultMatrix[i,j,k]=num;
                }
                index++;
            }
        }
    }
    return resultMatrix;
}
void PrinttMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(2); k++)
            {
               Write($"{inMatrix[i, j,k]}  ({i},{j},{k})"); 
            } 
         WriteLine();
        }
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
