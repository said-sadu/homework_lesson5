class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] d = new int[15];
        int max = 0, min = 100;
        for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);    //заполнение массива случайными числами
        for (int i = 0; i < d.Length; i++)
        {
            if (d[i] > max) max = d[i];   //нахождение максимального эллемента массива
            if (d[i] < min) min = d[i];   //нахождение минимального эллемента массива
        }

        for (int i = 0; i < d.Length; i++)
            Console.Write("," + d[i]);       //выводим массив
        Console.WriteLine();
        Console.WriteLine("max:  " + max);
        Console.WriteLine("min  " + min);
        Console.WriteLine("Разница максимального и минимального:  " + (max - min));
        Console.ReadKey();
    }
}