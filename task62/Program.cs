using static System.Console;
Clear();
int n = 4;
int m = 4;
int[,] matrix = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
while (k <= n1 * m1) 
{ 
    for (i = t; i < n; i++)
    { 
    matrix[j, i] = k++; 
    }
    j = n - 1;
    for (i = t + 1; i < m; i++) 
    {
    matrix[i, j] = k++; 
    }
    j = m - 1;
    
    for (i = n - 2; i >= t; i--)
    { 
    matrix[j, i] = k++; 
    }
    j = t;
    for (i = m - 2; i > t; i--)
    {
    matrix[i, j] = k++;
    } 
    n--; 
    m--; 
    t++; 
    j = t; 
} 
for (i = 0; i < matrix.GetLength(0); i++) 
{ 
for (j = 0; j < matrix.GetLength(1); j++) 
Write("{0,2} ", matrix[i, j]); 
WriteLine(); 
} 
 

