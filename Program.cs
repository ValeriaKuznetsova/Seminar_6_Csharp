// Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] ArrayFromString(string arrayFromString) //функция создания массива из строки
// {
// string[] numbers = arrayFromString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
// int[] result = new int[numbers.Length];
// for (int i = 0; i < result.Length; i++)
// {
// result[i] = int.Parse(numbers[i]);
// Console.Write(result[i]);
// Console.Write(' ');
// }
// return result;
// }

// int CountPositiveNumbersByReadline(int[] array) // функция, возвращающая количество позитивн
// {
// int count = 0;
// foreach (var item in array)
// {
// if (item > 0)
// count++;
// }
// return count;
// }

// Console.WriteLine("Enter the numbers separated by a space: ");
// int[] array = ArrayFromString(Console.ReadLine());
// int count = CountPositiveNumbersByReadline(array);
// Console.WriteLine(' ');
// Console.WriteLine($"The count of positive nimbers in string is: {count} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("y = k1 * x + b1");
// Console.WriteLine("y = k2 * x + b2");
// Console.WriteLine("Please, enter the numbers k1, b1, k2, b2 separated by a space: ");
// string[] functionVariables = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// double k1 = double.Parse(functionVariables[0]);
// double b1 = double.Parse(functionVariables[1]);
// double k2 = double.Parse(functionVariables[2]);
// double b2 = double.Parse(functionVariables[3]);

// double[] GetPointOfCrossLines(double a1, double b1, double a2, double b2)
// {
// double[] coordinates = new double[2];
// coordinates[0] = (a1 - a2) / (b2 - b1);
// coordinates[1] = a1 * coordinates[0] - b1;
// return coordinates;
// }
// if (b1 == b2 && k1 == k2)
// {
// Console.WriteLine($"The point of crosse is infinity. ");
// }
// else

// if (k1 == k2)
// {
// Console.WriteLine("No points of cross. The lines are parallel");
// }
// else

// if (b1 == b2)
// {
// Console.WriteLine($"The point of crosse is: ( 0, {b1} ) ");
// }

// else
// {
// Console.WriteLine(String.Join(' ', GetPointOfCrossLines(k1, b1, k2, b2)));
// }