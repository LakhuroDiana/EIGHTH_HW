// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

void create(float[,] array, int a)
{
    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < a; ++j)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

void output(float[,] array, int a)
{
    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < a; ++j)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.Write("\n");
    }
}

System.Console.WriteLine("Введите размер !квадратных! матриц");
int n = Convert.ToInt32(Console.ReadLine());
float[,] array_1 = new float[n, n];
float[,] array_2 = new float[n, n];
float[,] array_3 = new float[n, n];
create(array_1, n);
create(array_2, n);
System.Console.Write("\n");
output(array_1, n);
System.Console.Write("\n");
output(array_2, n);
System.Console.Write("\n");

for (int i = 0; i < n; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        for (int k = 0; k < n; ++k)
        {
            array_3[i, j] = array_3[i, j] + array_1[i, k] * array_2[k, j];
        }
    }
}

output(array_3, n);