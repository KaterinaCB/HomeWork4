void stAB()
{
    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число В: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a;

    for (int i = 1; i < b; i++)
    {
        c = c * a;
    }
    Console.WriteLine($"Число А с степени числа В равно: {c}");
}
stAB();