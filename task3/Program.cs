/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double [] FillArray ()
{
    int size = new Random().Next(4, 11);
    double [] array = new double [size];
    for (int i = 0; i<size; i++)
    {
        array [i] = new Random().Next(10, 51) + new Random().NextDouble();
        array [i] = Math.Round(array[i], 2);
    }
    return array;
}
void PrintArray (double [] array)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i<array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine("\b\b.");
}
double Min (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array [i] < min) min = array[i];
    return min;
}
double Max (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array [i] > max) max = array[i];
    return max;
}
double [] newArray = FillArray();
PrintArray (newArray);
Console.Write($"Difference between Min and Max in array is {Max(newArray) - Min (newArray)}");