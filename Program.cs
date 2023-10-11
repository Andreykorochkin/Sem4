// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.

Console.WriteLine($"ВВедите число А: и B: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int Power(int a, int b )
{
    int Power = 1;
    for (int i = 0; i <= b; i++)
    {
         Power *= b;
    }
    return Power;
}

Console.WriteLine($"Число {a} в степени {b} равна {Power(a,b)}");