Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
