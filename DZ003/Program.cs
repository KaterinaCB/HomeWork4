int [] array = new int [8];

void FillArray (int [] mass)
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass [index] = new Random().Next(0,100);
        index++;
    }
}
void PrintArray (int [] mass)
{
    int count = mass.Length;
    for (int position = 0; position < count; position++)
    {
        if (position != count - 1)
        Console.Write($"{mass[position]}, ");
        else Console.Write($"{mass[position]}");
        
    }
}
FillArray(array);
PrintArray(array);