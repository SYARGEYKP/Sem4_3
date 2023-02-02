// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int[] CreatArray(int X)
{
    int[] array = new int[X];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 15);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length-1; j++)
    {
        Console.Write($" {array[j]},");
    }
    Console.Write($" {array[array.Length-1]}");
}
int X =InputInt("Введите размер массива");
int[]array = CreatArray(X);
ShowArray(array);




