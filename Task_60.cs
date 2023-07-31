
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Задаем размеры массива
    Console.WriteLine ("Введите размеры трехмерного массива X x Y x Z:");
    Console.Write ("X = ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Y = ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Z = ");
    int z = Convert.ToInt32(Console.ReadLine());
// Задаем одномерный массив с количеством элементов равным количеству элементов трехмерного массива
    int a = x*y*z;
    int[] nums1 = new int[a];
    Console.WriteLine();
    for (int i = 0; i < nums1.GetLength(0); i++)
    {
        nums1[i] = new Random().Next(10, 100);
        Console.Write(nums1[i] + " ");
    }
    Console.WriteLine ();
// Проверяем элементы массива на повторяемость, в случае совпадения - меняем элемент на другой произвольный
    for (int i = 0; i < nums1.GetLength(0); i++){
        if (i>0){
            for (int j = 0; j < i; j++){
                    while (nums1[i]==nums1[j]) {
                        nums1[i] = new Random().Next(10, 100);
                        j=0;
                        
                    }
                    
            }
        }
        Console.Write(nums1[i] + " ");   
    }

    Console.WriteLine();
    Console.WriteLine();
    
// Заводим трехмерный массив и заполняем его элементами
    int count=0;
    int[,,] nums3D = new int[x,y,z];
    for (int k = 0; k < nums3D.GetLength(2); k++) {
        for (int j = 0; j < nums3D.GetLength(1); j++) {
            for (int i = 0; i < nums3D.GetLength(0); i++) {
               nums3D[i,j,k] = nums1[count];
               Console.Write($"{nums3D[i,j,k]} ({i},{j},{k}) ");
               count=count+1;
            }
        Console.WriteLine();
        }    
    }        

