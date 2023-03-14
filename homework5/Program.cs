// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Input array size:");
int numbers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element:");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(numbers, minValue, maxValue);
ShowArray(myArray);
int count = 0;

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] num = new int[numbers];
{
    for (int i = 0; i < num.Length; i++)
        if (num[i] % 2 == 0)
            count++;

}
Console.WriteLine($"Total {num.Length} numbers, {count} of them even");