// -------------------------------------------------->

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int count = 1;
// int var = a;

// while(count < b)
// {
//     var = var * a;
//     count++;
// }

// Console.WriteLine(var);


// -------------------------------------------------->


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int num = int.Parse(Console.ReadLine());
// int sum = 0;
// while(num != 0)
// {
//     sum += num % 10;
//     num /= 10;
// }
// Console.WriteLine(sum);


// -------------------------------------------------->


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int [] array = new int[size];

// for(int i = 0; i < size; i++)
// {
//     Console.Write("Введите " + (i+1) + "-й элемент массива: ");
//     array[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine();
// PrintArray(array);


// void PrintArray(int[]collection)
// {
//     int count = collection.Length;
//     int position = 0;
//     while(position < count)
//     {
//         Console.Write(collection[position] + " ");
//         position++;
//     }
// }


// -------------------------------------------------->