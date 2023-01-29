// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArrayWithRandom(double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random(). NextDouble() + new Random().Next(0,9), 1);
    }
    return array;
}
double[] array = new double[4];
FillArrayWithRandom(array);
double maxArray = array[0];
double minArray = array[0];
for(int i = 0;i < array.Length; i++)
{
    if(maxArray <= array[i])
    {
        maxArray = array[i];
    }
    else if(minArray > array[i])
    {
        minArray = array[i];
    }
}
double result = Math.Round((maxArray - minArray), 1);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join("; ", array));
Console.WriteLine("Мин: " + minArray);
Console.WriteLine("Макс: " + maxArray);
Console.WriteLine("Разница между максимальным и минимальным значениями массива равна: " + result);