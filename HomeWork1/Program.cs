/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("введите число а");  //вводим первое число
int a = int.Parse(Console.ReadLine( ));  // считываем первое число
Console.WriteLine ("введите число b");  //вводим второе число
int b = int.Parse (Console.ReadLine( ));   // считываем второе число
if ( a < b );  // если а меньше б 
{
    Console.WriteLine("Число a меньше b");  // пишем  "Число a меньше b"
}
else (b < a);    // проверяем еще если б меньше а
{
    Console.WriteLine("Число b меньше числа a"); // пишем Число b меньше числа a
}
/*
D:\C#\HomeWork1\Program.cs(15,2): error CS8641: "else" не может запускать оператор. [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1003: Синтаксическая ошибка, требуется "(" [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1525: Недопустимый термин "else" в выражении [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1026: Требуется ")" [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1002: Требуется ";". [D:\C#\HomeWork1\HomeWork1.csproj]
*/