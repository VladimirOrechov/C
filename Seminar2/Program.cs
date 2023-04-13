int a = 5;

int b = 6;

int c = 7;

int g = 8;

int result1 = Calculete(a,b);
int result2 = Calculete(c,g);

Console.WriteLine(result1);
Console.WriteLine(result2);

int Calculete (int a, int b)
{
    return a * (a * b);
}

void Show (int a, int b)
{
    Console.WriteLine($"{a}, {b}");
}

