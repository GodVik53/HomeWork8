// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//Задаем размеры массива
    Console.WriteLine ("Введите размеры квадратного массива X x X");
    Console.Write ("X = ");
    int x = Convert.ToInt32(Console.ReadLine());

// Задаем массив и заполняем его по спирали 
    int [,] nums = new int [x,x];
    int num = 1;
    int i = 0;
    int j = 0;
    
    while (num <= nums.GetLength(0)*nums.GetLength(1)) {
        nums [i,j]=num;
        num=num+1;
          if (i <= j + 1 && i + j < nums.GetLength(1) - 1){
            j++;
          }
            else { 
                if (i < j && i + j >= nums.GetLength(0) - 1) {
                 i++;
                }
                else {
                    if (i >= j && i + j > nums.GetLength(1) - 1) {
                        j--;
                    }    
                    else {
                        i--;
                    }
                }
            }    

        
    }
// Выводим результат

    for (int k = 0; k < nums.GetLength(0); k++) {
        for (int l = 0; l < nums.GetLength(1); l++) {
               if (nums[k,l]/10<1) {
                   Console.Write($"0{nums[k,l]} ");
               }
               else {
                   Console.Write($"{nums[k,l]} ");
               }
            }
        Console.WriteLine();
        }    
        




