// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int Prompt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int size = Prompt("Введите размер массива: ");
int[] array = GetArray(size);
PrintArray(array);
Getrezult(array);
int[] GetArray(int size)

{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i ++)
    {
        result[i] = new Random().Next(100,1000);
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

void Getrezult( int[] array)
{
    int i = 0;
    int rez = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            rez += 1;
            i ++;
        }
        else 
        {
            i ++;
        }
    }
    Console.WriteLine($" -> {rez}");
}