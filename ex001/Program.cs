int[] arr = new int[10];
int k = 0;
Random rnd = new Random();

Console.WriteLine("Рандомный массив");
for (int i = 0; i < 10; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write("{0} ", arr[i]);
}

foreach (int element in arr)
{
    if (element % 2 == 0)
    {
        k++;

    }
}

Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}", k);