//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int evenNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");

//     if (array[i] % 2 == 0)
//     {
//         evenNum++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine(evenNum);




// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];
// int sumNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,100);
//     Console.Write(array[i] + " ");

//     if (i % 2 != 0)
//     {
//         sumNum += array[i];
//     }
// }

// System.Console.WriteLine();
// System.Console.WriteLine(sumNum);




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


System.Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
for(int i = 0; i < array.Length; i++)
{
    Random x = new Random();
    double r = Convert.ToDouble(x.Next(0, 100) / 100.00);
    array[i] = new Random().Next(0, 100) * r;
    if(i == 0)
    {
        System.Console.Write("[");
    }
    System.Console.Write(Math.Round(array[i], 2));
    if(i != array.Length-1)
    {
        System.Console.Write("; ");
    }
    else if(i == array.Length-1)
    {
        System.Console.Write("]");
    }
}
double max = array[0];
double min = array[0];
for(int j = 0; j < array.Length; j++)
{
    if(max < array[j])
    {
        max = array[j];
    }
    if(min > array[j])
    {
        min = array[j];
    }
}
System.Console.WriteLine("");
System.Console.WriteLine($"Максимальный элемент в массиве -> {Math.Round(max, 2)}, а минимальный -> {Math.Round(min, 2)}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве -> {Math.Round(max - min, 2)}");