// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Вводим элементы в строчку через пробел
Console.Write("Введите цифры(через пробел): "); 
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
//count принимаем как 0, следовательно цикл будет отбирать каждый 
//последующий элемент и сравнивать его с 0
int count = 0; 
  for (int i = 0; i < arr.Length; i++)
   {     
        if (arr[i] > 0)  
            {    
             count++;   
            }
    }
      Console.WriteLine($"Количество цифр больше 0: {count}");

// Вариант 2: Когда задаем кол-во чисел и предел значений. 
// Числа генерятся рандомно.

// using System;
// using System.Linq;
// namespace ConsoleApp6
// {     class Program    
//     {         static void Main(string[] args)    
//        {            
//           Random num = new Random(); 
//           //задаем параметр кол-ва чисел 20 и параметр значений от -100 до 100.       
//           int[] numbers = Enumerable.Repeat(0, 20).Select(i => num.Next(-1000, 1000)).ToArray();
//           //сами числа генерятся случайным образом от -1000 до 1000        
//           Console.WriteLine("Массив чисел отображается рандомно: " + String.Join(", ", numbers));   
//           //вводим любое число в указанном диапазоне, чтобы определить сколько цифр больше
//           Console.Write("Введите число в диапазоне от -1000 до 1000: ");        
//           int k = int.Parse(Console.ReadLine());      
//           int res = numbers.Where(i => i > k).Count();
//           //выводим на экран кол-во чисел чисел больше введеного числа 
//           Console.WriteLine($"Количество чисел больше введенного значения равно: {res}");   
//           Console.ReadLine();    
//         }  
//     }
// }      