// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

int result(int A, int B)
{
    int num = A;
    for(int i = 1; i < B; i++)
    {
        num = num*A;
    }
       
    return num;
    
}
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(result(A, B));