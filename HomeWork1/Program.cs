/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("введите число а");
int a = int.Parse(Console.ReadLine( ));
Console.WriteLine ("введите число b");
int b = int.Parse (Console.ReadLine( ));
if ( a < b );
{
    Console.WriteLine("Число a меньше b");
}
else (b < a);
{
    Console.WriteLine("Число b меньше числа a");
}
/*
D:\C#\HomeWork1\Program.cs(15,2): error CS8641: "else" не может запускать оператор. [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1003: Синтаксическая ошибка, требуется "(" [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1525: Недопустимый термин "else" в выражении [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1026: Требуется ")" [D:\C#\HomeWork1\HomeWork1.csproj]
D:\C#\HomeWork1\Program.cs(15,2): error CS1002: Требуется ";". [D:\C#\HomeWork1\HomeWork1.csproj]
*/