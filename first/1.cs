//  Задайте двумерный массив.
//  Напишите программу, которая упорядочивает
//  по убыванию элементы каждой строки двумерного массива.
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


void Sort(float[,] array, int a, int b)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < b; k++)
            {
                if (array[i, j] < array[i, k])
                {
                    float tmp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }
    }
}

System.Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
float[,] massive = new float[n, m];
create(massive, n, m);
output(massive, n, m);
System.Console.Write("\n");
Sort(massive, n, m);
output(massive, n, m);

