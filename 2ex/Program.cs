//  Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int size = Prompt("Введите размер массива: ");
int[] array = GetArray(size);
PrintArray(array);
Console.WriteLine();
FindSum(array);

int[] GetArray(int size)

{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i ++)
    {
        result[i] = new Random().Next(-10,50);
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i ++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void FindSum(int []array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        Sum += array[i];
    } 
Console.WriteLine(Sum);
}
