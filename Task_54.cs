
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





int[,] nums = new int[3, 4];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}
Console.WriteLine("Начальный массив:");
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Массив с отсортированными строками (элементы по убыванию):");
int per1 = 0;
int count =0;
while (count<nums.GetLength(1)-1) {
for (int i = 0; i < nums.GetLength(0); i++)
{

    for (int j = 0; j < nums.GetLength(1)-1; j++)
    {
        if (nums[i, j]<nums[i,j+1]){
        per1=nums[i,j];
        nums[i,j]=nums[i,j+1];
        nums[i,j+1]=per1;
        }
    }
    
}
count++;
}
//выводим массив
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
