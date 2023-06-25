//  Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

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
int result = FindSum(array);
PrintSum(result);

int[] GetArray(int size)

{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i ++)
    {
        result[i] = new Random().Next(0,50);
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
int FindSum (int[] array)
{
    int i = 0;
    int min = array[i];
    int max = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if ( array[i] < min)
        {
            min = array[i];
            i ++;
        }
        else if (array[i] > max)
        {
            max = array[i];
            i ++;
        }
        else
        {
            i ++;
        }
    }
    sum = max - min;
    return sum;
}
void PrintSum(int sum)
{
    Console.Write(sum);
}