// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void create(float[,] array, int a, int b)
{
    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < b; ++j)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

void output(float[,] array, int a, int b)
{
    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < b; ++j)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.Write("\n");
    }
}

void sum(float[,] array, float[] S, int a, int b)
{
    for (int k = 0; k < a; ++k)
        S[k] = 0;
    for (int i = 0; i < a; ++i)
    {
        for (int j = 0; j < b; ++j)
        {
            S[i] = array[i, j] + S[i];
        }
    }
}

void output1(float[] array, int a)
{
    for (int i = 0; i < a; ++i)
    {
        System.Console.Write(array[i] + "\t");
    }
}

float max(float[] array, int a)
{
    float Max = array[0];
    int index = 0;
    for (int i = 0; i < a; ++i)
    {
        if (array[i] > Max)
        {
            Max = array[i];
            index = i;
        }
    }
    return index;
}

System.Console.WriteLine("Введите размер прямоугольного массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
float[,] massive = new float[n, m];
float[] Sum = new float[n];
create(massive, n, m);
output(massive, n, m);
System.Console.Write("\n");
sum(massive, Sum, n, m);
output1(Sum, n);
System.Console.Write("\n" + "Номер строки с наибольшей суммой:");
System.Console.Write(max(Sum, n));