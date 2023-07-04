/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] FillArray ()
{
    int size = new Random().Next(4, 16);
    int [] array = new int [size];
    for (int i = 0; i<size; i++)
        array [i] = new Random().Next(10, 150);
    return array;
}
void PrintArray (int [] array)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine("\b\b.");
}
int SumOfNechet (int [] array)
{
    int sum = 0;
    for (int i = 1; i<array.Length; i++)
        if (i % 2 != 0) sum = sum + array [i];
    return sum;
}
int [] newArray = FillArray();
PrintArray (newArray);
Console.WriteLine ($"Sum = {SumOfNechet(newArray)}");