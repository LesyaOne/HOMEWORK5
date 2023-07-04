/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int [] FillArray ()
{
    int size = new Random().Next(5, 16);
    int [] array = new int [size];
    for (int i = 0; i<size; i++)
        array [i] = new Random().Next(100, 1000);
    return array;
}
void PrintArray (int [] array)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine("\b\b.");
}
int Chetnye (int [] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i] % 2 == 0) count ++;
    return count;
}
int [] newArray = FillArray();
PrintArray(newArray);
Console.WriteLine ($"There are {Chetnye(newArray)} even numbers in array");