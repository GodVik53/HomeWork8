// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

//просим ввести параметры матриц
Console.WriteLine ("Введите число строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число столбцов первой матрицы (и количество строк второй матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());
int[,] nums1 = new int[m, n];
Console.WriteLine();

//Заполняем и выводим на экран случайными числами от 0 до 10 первую матрицу
Console.WriteLine("Первая матрица:");
for (int i = 0; i < nums1.GetLength(0); i++)
{
    for (int j = 0; j < nums1.GetLength(1); j++)
    {
        nums1[i, j] = new Random().Next(0, 10);
        Console.Write(nums1[i, j] + " ");
    }
    Console.WriteLine();
}

//Заполняем и выводим случайными числами от 0 до 10 вторую матрицу

int[,] nums2 = new int[n, p];
Console.WriteLine("Вторая матрица:");
for (int i = 0; i < nums2.GetLength(0); i++)
{
    for (int j = 0; j < nums2.GetLength(1); j++)
    {
        nums2[i, j] = new Random().Next(0, 10);
        Console.Write(nums2[i, j] + " ");
    }
    Console.WriteLine();
}


int[,] result = new int[m, p];
int sum = 0;
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
for (int i=0; i<m; i++){
    for (int j=0; j < p;j++){
        sum=0;
        for (int r=0; r < m; r++){
            sum += nums1[i,r]*nums2[r,j];
        }
        result[i,j]= sum;
        Console.Write($"{result[i,j]} ");
    }
    Console.WriteLine();
}
