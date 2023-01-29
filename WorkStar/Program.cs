// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
Console.Clear();

Console.Write("Введите число: ");
int heigth = int.Parse(Console.ReadLine()!);

for (int i = 0; i < heigth; i = i + 2)
{
    Console.SetCursorPosition(heigth - i, i + 1);
   
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
}