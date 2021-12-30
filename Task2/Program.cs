// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел

int[] arr = new int[10];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.Write(arr[i] + " ");
}
    Console.ReadKey();
    Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) Console.Write(arr[i] + " ");
    else Console.Write(" ");
}
