// // Задача 64: Задайте значение N. Напишите программу, которая
// // выведет все натуральные числа в промежутке от N до 1. 
// // Выполнить с помощью рекурсии.

// int n = InputInt("Введите натуральное число N: ");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Это отрицательное число");
// }
// Console.WriteLine(Number(n, m));

// int Number(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{Number(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine()!);
// }





// // Задача 66: Задайте значения M и N. Напишите программу,
// // которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(PrintNumbers(M,N));

// int PrintNumbers(int M, int N)
// {
//     if(M == N) return M;
//     return(M += PrintNumbers(M + 1, N));
// }





// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// АБСОЛЮТНО НЕ ПОНЯЛ НИЧЕГО ПРО ФУНКЦИЮ АККЕРМАНА, ПОЭТОМУ НИКАКОГО РЕШЕНИЯ
// ЭТОЙ ЗАДАЧИ ПРИВЕСТИ НЕ МОГУ
