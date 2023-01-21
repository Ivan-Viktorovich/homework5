// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0,10);
    }
    return array;
}

int[] array = new int[5];
FillArrayWithRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(string.Join(",", array));

int sum = 0;
for(int i = 1; i < array.Length; i = i + 2)
{
    sum = array[i] + sum;
}
Console.WriteLine("Сумма чисел, стоящих на нечетных индексах равна: " + sum);