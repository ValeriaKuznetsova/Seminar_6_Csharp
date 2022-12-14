Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] ArrayFromString(string arrayFromString) //функция создания массива из строки
{
string[] numbers = arrayFromString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] result = new int[numbers.Length];
for (int i = 0; i < result.Length; i++)
{
result[i] = int.Parse(numbers[i]);
Console.Write(result[i]);
Console.Write(' ');
}
return result;
}

int CountPositiveNumbersByReadline(int[] array) // функция, возвращающая количество позитивн
{
int count = 0;
foreach (var item in array)
{
if (item > 0)
count++;
}
return count;
}

Console.WriteLine("Enter the numbers separated by a space: ");
int[] array = ArrayFromString(Console.ReadLine());
int count = CountPositiveNumbersByReadline(array);
Console.WriteLine(' ');
Console.WriteLine($"The count of positive nimbers in string is: {count} ");