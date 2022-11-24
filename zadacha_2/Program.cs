//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");

int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");

int c = int.Parse(Console.ReadLine());
if (a > b)
{
    
  if (a > c)
     {
         Console.Write($"Максимальное {a}");
     }
  else
     { 
         Console.Write($"Максимальное {c}");
     }
}
else
{
   if (b>c)
   {
     Console.Write($"Максимальное {b}");
    
   }
   else
   {
    Console.Write($"Максимальное {c}");
   }
}

