// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int m = InputFunction("Введите количество строк: ");
// int n = InputFunction("Введите количество столбцов: ");
// int[,] num = new int[m, n];
// FillArrayRandom2(num);
// OutputArray2(num);
// Console.WriteLine();
// ArrangeRowDescendingOrder(num);
// OutputArray2(num);
//Заполнение массива рандомными числами от 1 до 9
// void FillArrayRandom2(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }



// // Функция ввода 
// int InputFunction(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция упорядочивания по убыванию элементов каждой строки
// void ArrangeRowDescendingOrder(int[,] arr)
// {
//      for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
         
//             for (int k = 0; k < arr.GetLength(1) - 1; k++)
//                             {
//                                 if (arr[i,k] < arr[i,k+1])
//                                 {
//                                     int t = arr[i,k+1];
//                                     arr[i,k+1] = arr[i,k];
//                                     arr[i,k] = t;
                                    
//                                           }
                                                                 
        
//                                       }
//                                 }
//                             }
//                        }
                     
// //  Функция вывода массива 
// void OutputArray2(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }     
                                
//   Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
// int[,] num = new int [4,4];
// FillArrayRandom2(num);
// OutputArray2(num);
// Console.WriteLine();
// NumberLineMinSum(num);

// void NumberLineMinSum(int[,]arr)
// {
//     int minLine = 0;
//     int minSumLine = 0;
//     int sumLine = 0;
//     for(int i = 0; i < num.GetLength(1); i++)
//     {
//         minLine += num[0,i];
//     }
//     for (int i = 0; i < num.GetLength(0); i++)
//     {
//         for (int j = 0; j < num.GetLength(1); j++) sumLine += num[i, j];
//         if (sumLine < minLine)
//         {
//             minLine = sumLine;
//             minSumLine = i;
//         }
//         sumLine = 0;
//     }
//     Console.Write($"{minSumLine + 1} строка");
// }
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int m = InputFunction("Enter the number of lines : ");
// int n = InputFunction("Enter the number of columns : ");
// int[,] arr = new int [m,n];
// int[,] arr2 = new int [m,n];
// int[,] result = new int [m,n];

// FillArrayRandom2(arr);
// OutputArray2(arr);
// Console.WriteLine();
// FillArrayRandom2(arr2);
// OutputArray2(arr2);
// Console.WriteLine();
// if (arr.GetLength(0) != arr2.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         result[i, j] = 0;
//         for (int k = 0; k < arr.GetLength(1); k++)
//         {
//             result[i, j] += arr[i, k] * arr2[k, j];
//         }
//     }
// }
// OutputArray2(result);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int[,,]arr3D = new int[2, 2, 2];
// FillArray3D(arr3D);
// PrintIndex3D(arr3D);
// // Функция заполнения 3D массива неповторяющимеся числами
// void FillArray3D(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }
// // Функция вывода индекса элементов 3D массива
// void PrintIndex3D(int[,,] arr)
// {
//     for (int i = 0; i < arr3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < arr3D.GetLength(2); k++)
//             {
//                 Console.Write($"{arr3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int[,] spirarr = new int[4, 4];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= spirarr.GetLength(0) * spirarr.GetLength(1))
// {
//   spirarr[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < spirarr.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= spirarr.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > spirarr.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(spirarr);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }