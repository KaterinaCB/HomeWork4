void Summ()
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

    while (x > 0)
    {
        int num = x % 10;
        x = x / 10;
        sum = sum + num;
    }
    Console.WriteLine($"Сумма цифр числа равна: {sum}");
}
Summ();