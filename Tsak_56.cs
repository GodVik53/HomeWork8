// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




int[,] nums = new int[4,4];
for(int i = 0;i < nums.GetLength(0);i++){
   for(int j = 0;j < nums.GetLength(1);j++){
       nums[i,j] = new Random().Next(0, 10);
   }
}

for(int i = 0;i < nums.GetLength(0);i++){
   for(int j = 0;j < nums.GetLength(1);j++){
       Console.Write(nums[i,j] + " ");
       
   }
   Console.WriteLine();
}
Console.WriteLine ();
int allsum=0;
int minsum=int.MaxValue;
int count=0;

 for ( int i=0; i < nums.GetLength(0); i++) {
    allsum=0;
    for(int j = 0;j < nums.GetLength(1);j++){
        allsum = allsum + nums[i,j];
    }
  
    if (minsum>allsum) {
        minsum=allsum;
        count = i;
 }
 }
    
Console.WriteLine ();
Console.WriteLine ($"Минимальная сумма элементов в строке: {count+1}");
