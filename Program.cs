// Примеры форматирования
// string name = "Name";
// int age = 99;
// Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);

// f - float - дробное число
// f + число - например f5 - округление до знака
// int number = 23;
// string result = string.Format("{0:f}", number);
// Console.WriteLine(result);

// string name = "Name";
// int age = 99;
// Console.WriteLine($"Имя: {name}  Возраст: {age}");

// int x = 7;
// int y = 8;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Name";
// int age = 99;
// Console.WriteLine($"Имя: {name, 10}  Возраст: {age}"); // пробелы до
// Console.WriteLine($"Имя: {name, -15}  Возраст: {age}"); // пробелы после

// Задать массив из 12 элементов, заполненный числами от -9 до 9. Найти сумму отрицательных и положительных элементов массива.
// int[] GenerateRandomArray(int[] RandomArray)
// {
//     for (int i = 0; i < 12; i++)
//     {
//         RandomArray[i] = new Random().Next(-9, 10);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +" ");
//  }   
//     Console.WriteLine();
// }

// int[] myArray = new int[12];
// GenerateRandomArray(myArray);
// ShowArray(myArray);

// int pos = 0;
// int neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         pos += myArray[i];
//     else
//         neg += myArray[i];    
// }
// Console.WriteLine($"Сумма положительных: {pos}, Сумма отрицательных: {neg}");

// Замена положительных элементов на отрицательные и наоборот
// int [] GenerateRandomArray(int size, int min, int max)
// {
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max+1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +", ");
//  }  
// }

// int[] myArray = GenerateRandomArray(12, -9, 9);
// ShowArray(myArray);

// Console.Write(" -> ");
// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = myArray[i]*(-1);
//     Console.Write($"{myArray[i]}, ");
// }

// Отпределить присутствует ли заданное число в массиве
// int [] GenerateRandomArray(int size, int min, int max)
// {
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max+1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +", ");
//  }  
// }

// int[] myArray = GenerateRandomArray(12, -9, 9);
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{num}; массив [");
// ShowArray(myArray);
// Console.Write($"] -> ");

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] == num)
//         Console.Write("да");
//     else Console.Write("нет");
//     break;
// }

// Задать одномерный массив из 123 случайных чисел. Найти кол-во элементов массива, значения которых лежат в отрезке [10, 99]
// int [] GenerateRandomArray(int min, int max)
// {
//     int[] RandomArray = new int[123];
//     for (int i = 0; i < 123; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max+1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +", ");
//  }  
// }

// int[] myArray = GenerateRandomArray(-9, 200);
// ShowArray(myArray);
// int count = 0;
// for (int i = 0; i < 123; i++)
// {
//     if (myArray[i] > 9 && myArray[i] < 100)
//         count = count +1;
// }
// Console.Write($" -> {count}");

// Найти произведение пар чисел в одномерно массиве. Пара - первый и последний элемент. Результат записать в новом массиве

// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +", ");
//  }  
// }

// int[] myArray = new int[10];
//     for (int count = 0; count < myArray.Length; count++)
//     {
//         myArray[count] = new Random().Next(-9, 10);
//     }
// ShowArray(myArray);
// int [] newArray = new int [5];
// int i = 0;
// while (i < 5)
//     {for (int index = 0; index < newArray.Length; index++)
//         {
//             newArray[index] = myArray[i] * myArray[myArray.Length - i];
//             i++;
//         }
//     }
// ShowArray(newArray);

// Домашнее задание

// Задать массив, заполненный случайными положительными трехзначными числами. Программа показывает количество четных чисел в массиве
// int[] GenerateRandomArray(int[] RandomArray)
// {
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(100, 1000);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +" ");
//  } 
// }
// void EvenNumbers(int[] newArray)
// {int even = 0;
// for (int i = 0; i < newArray.Length; i++)
// {
//     if (newArray[i] % 2 == 0)
//         even = even + 1;   
// }
// Console.Write(even);
// }

// int[] myArray = new int[12];
// GenerateRandomArray(myArray);
// Console.Write("[ ");
// ShowArray(myArray);
// Console.Write("] -> ");
// EvenNumbers(myArray);

// Задать одномерный массив, заполненный случайными числами. Найти сумму нечетных элементов
// int[] GenerateRandomArray(int[] RandomArray)
// {
//     for (int i = 0; i < RandomArray.Length; i++)
//     {
//         RandomArray[i] = new Random().Next(1, 10);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//  for (int i = 0; i < array.Length; i++)
//  {
//      Console.Write(array[i] +" ");
//  }   
// }
// void NegSum(int[] newArray)
// {int neg = 0;
// for (int i = 0; i < newArray.Length; i++)
// {
//     if (newArray[i] % 2 != 0)
//         neg = neg + newArray[i];   
// }
// Console.Write(neg);
// }

// int[] myArray = new int[5];
// GenerateRandomArray(myArray);
// Console.Write("[ ");
// ShowArray(myArray);
// Console.Write("] -> ");
// NegSum(myArray);

// Задать массив вещественных чисел.Найти разницу между максимальным и минимальным элементом массива
int[] GenerateRandomArray(int[] RandomArray)
{
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(1, 10);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
 for (int i = 0; i < array.Length; i++)
 {
     Console.Write(array[i] +" ");
 }   
}
void MinMax(int[] newArray)
{
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        int minPosition = i;
        

        for (int count = i + 1; count < newArray.Length; count++)
        {
            if (newArray[count] < newArray[minPosition]) 
            minPosition = count;
        }
        int temporary = newArray [i];
        newArray[i] = newArray[minPosition];
        newArray[minPosition] = temporary;
    }
}

int[] myArray = new int[5];
GenerateRandomArray(myArray);
Console.Write("[ ");
ShowArray(myArray);
Console.Write("] -> ");
MinMax(myArray);