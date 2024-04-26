#region  task 1
//int[,] array =
//{
//    {200, 300, 400 },
//    {20, 30, 40 },
//    {50, 60, 90 },
//};
//for ( int i = 0; i < array.GetLength (0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write (array[i,y] + " ");
//    }
//Console.WriteLine();
//}
#endregion

#region task 2
//int sum = 0;
//int[,] array =
//{
//    {200, 300, 400 },
//    {20, 30, 40 },
//    {50, 60, 90 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[i, y];
//    }
//}
//Console.WriteLine(sum);
#endregion

#region task3
//int sum = 0;
//int[,] array =
//{
//    {1, 2, 3 },
//    {4, 5, 6 },
//    {7, 8, 9 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    { 
//        if (y == 0)
//        {
//            sum += array[i,y];
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion

#region task 4
//int[,] array =
//{
//    {1, -2, 3 },
//    {4, 5, 6 },
//    {5, -6, 7},
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (array[i,y] < 0)
//        {
//            Console.WriteLine(array[i, y]);
//        }
//    }
//}
#endregion


#region task 5
//int[,] array =
//{
//     {11, 2, 3 },
//     {4, 5, 6 },
//     {7, 8, 9 },
//};
//int max = array[0, 0];
//int min = array[0, 0];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (array[i, y] > max)
//        {
//            max = array[i, y];
//        }
//        else if (array[i, y] < min) 
//        {
//            min = array[i, y]; 
//        }

//    }

//}
//Console.WriteLine($"max: {max}");
//Console.WriteLine($"min: {min}");
#endregion

#region task 6
//int[,] array =
//{
//     {11, -2, 3 },
//     {-4, -5, 6 },
//     {7, -8, 0 },
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (array[i, y] < 0)
//        {
//            if (array[i, y] % 2 == 0)
//            {
//                array[i, y] = -2;
//            }
//            else if (array[i, y] % 2 == -1)
//            {
//                array[i, y] = -1;
//            }
//        }
//        else if (array[i, y] == 0)
//        {
//            continue;
//        }
//        else
//        {
//            if (array[i, y] % 2 == 0)
//            {
//                array[i, y] = 2;
//            }
//            else if (array[i, y] % 2 == 1)
//            {
//                array[i, y] = 1;
//            }
//        }
//    }

//}
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}
#endregion


#region task 7
//int[,] array =
//{
//     {11, 2, 3, 5 },
//     {4, 5, 6, 8 },
//     {7, 8, 0, 9 },
//     {4, 3, 5, 6 },
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (i == 1)
//        {
//            array[1, y] = 0;
//        }
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}
#endregion


#region task 8
//int[,] array =
//{
//     {11, 2, 3},
//     {4, 5, 6},
//     {7, 8, 0},
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (y == 2)
//        {
//            array[i, 2] = 0;
//        }
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}
#endregion

#region task 9
//int[,] array =
//{
//     {11, 2, 3},
//     {4, 5, 6},
//     {7, 8, 0},
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (i == y)
//        {
//            sum += array[i, y];
//        }
//    }
//}
//    Console.WriteLine(sum);
#endregion


#region task 10
//int[,] array =
//{
//     {11, 2, 3, 5},
//     {4, 5, 6, 5 },
//     {7, 8, 0, 8 },
//     {2, 3, 6, 8 }
//};
//int sum = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if ( y + i == array.GetLength(0)-1)
//        {
//            sum += array[i, y];
//        }
//    }
//}
//Console.WriteLine(sum);
#endregion

#region task 11
//int[,] array =
//{
//     {1, 2, 3, 5, 5},
//     {4, 5, 6, 5, 1},
//     {7, 8, 0, 8, 2},
//     {2, 3, 6, 8, 6},
//     {3, 4, 7, 6, 8}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (i>y)
//        {
//            array[i, y] = 0;
//        }
//    Console.Write (array[i,y] + " ");
//    }
//Console.WriteLine();
//}
#endregion

#region task 12
//int[,] array =
//{
//     {1, 2, 3, 5, 5},
//     {4, 5, 6, 5, 1},
//     {7, 8, 0, 8, 2},
//     {2, 3, 6, 8, 6},
//     {3, 4, 7, 6, 8}
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        if (i < y)
//        {
//            array[i, y] = 0;
//        }
//        Console.Write(array[i, y] + " ");
//    }
//    Console.WriteLine();
//}
#endregion


#region task 13
//int[,] array1 =
//{
//     {1, 5, 8 },
//     { 3, 12, 7 },
//     { 6, 7, 8 },
//};
//int[,] array2 =
//{
//     {11, 2, 3 },
//     { 4, 5, 6 },
//     { 7, 8, 9 },
//};
//int[,] array3 = new int[3,3];
//for (int i = 0; i < array3.GetLength(0); i++)
//{
//    for (int y = 0; y < array3.GetLength(1); y++)
//    {
//        array3[i, y] = array1[i, y] + array2[i, y];
//        {
//            Console.Write(array3[i, y] + " ");
//        }
//    }
//    Console.WriteLine();
//}
#endregion



#region task14
//int[,] array =
//{
//     {1, 5, 8 },
//     { 3, 12, 7 },
//     { 6, 7, 8 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;

//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[i,y];
//    }
//    Console.WriteLine(sum);
//}
#endregion

#region task15
//int[,] array =
//{
//     {1, 5, 8 },
//     { 3, 12, 7 },
//     { 6, 7, 8 },
//};
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    int sum = 0;

//    for (int y = 0; y < array.GetLength(1); y++)
//    {
//        sum += array[y, i];
//    }
//    Console.WriteLine(sum);
//}
#endregion

#region task17
//int[,] array1 =
//{
//    { 1, 5, 8 },
//     { 3, 12, 7 },
//     { 6, 7, 8 },
//};
//int[,] array2 =
//{
//     {11, 2, 3 },
//     { 4, 5, 6 },
//     { 7, 8, 9 },
//};
//int[,] array3 = new int[3, 3];
//for (int i = 0; i < array3.GetLength(0); i++)
//{
//    for (int y = 0; y < array3.GetLength(1); y++)
//    {
//        array3[i, y] = array1[i, y] * array2[i, y];
//        {
//            Console.Write(array3[i, y] + " ");
//        }
//    }
//    Console.WriteLine();
//}
#endregion

#region task 16
//int[,] array =
//{
//    {1, 1, 5},
//   {1, 1, 2},
//   {1, 1, 3},
//};

//int shift = 2;
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int y= array.GetLength(1)-1; y>=0; y--)
//        {
//            if (y - shift >= 0)
//            {
//                array[i, y] = array[i, y - shift];
//            }
//            else
//            {
//                array[i, y] = 0;
//            }
//        }
//    }
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int y = 0; y < array.GetLength(1); y++)
//        {
//            Console.Write($"{array[i, y]}");
//        }
//        Console.WriteLine();
//    }
#endregion




#region task 18
//bool iscomplex = false;
//int[,] array =
//{
//{ 1, 2, 4 },
//{ 4, 5, 6 },
//{ 7, 8, 9 },
//};

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//       if (array[i,j] ==1 || array[i,j] < 0)
//        {
//            continue;
//        }
//       else
//        {
//            iscomplex = false;
//            int squareroot=Convert.ToInt32(Math.Sqrt(array[i,j]));
//            for (int k=2; k<=squareroot; k++)
//            {
//                if (array[i, j] % k == 0)
//                {
//                    iscomplex = true;
//                }
//            }
//            if (! iscomplex)
//            {
//                Console.WriteLine(array[i,j]);
//            }
//        }
//    }
    
//}
#endregion