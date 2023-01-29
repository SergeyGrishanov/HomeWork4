// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.Clear();

void PrintArray(int[] array)
{
    string ourArray = "";    
    for (int i = 0; i < array.Length; i++)
    {
        ourArray += array[i];    
        if (i != array.Length - 1) ourArray += ", ";
    }
    Console.WriteLine(ourArray);
}
int[] getArray()
{
    int[] myArray = new int[8];

    for (int i = 0; i < myArray.Length; i++)
    {
        int num = new Random().Next(0, 10);
        myArray[i] = num;
    }
    return myArray;
}
void main()
{
    int[] array = getArray();
    Console.WriteLine("Вывод массива: ");
    Console.WriteLine(String.Join(", ", array));
}
main();
    