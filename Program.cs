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

// int [] GenerateRandomArray(int min, int max)
// {
//     int[] RandomArray = new int[10];
//     for (int i = 0; i < 10; i++)
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
// int [] newArray = new int [5];
// int index = 0;
// for (int i = 0; i < newArray.Length; i++)
// {
//     newArray[index] = myArray[i] * myArray[myArray.Length - i];
// }
// ShowArray(newArray);
