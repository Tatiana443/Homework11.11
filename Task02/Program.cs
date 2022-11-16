Console.WriteLine("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("Число a больше числа b");
if (a < b)
    Console.WriteLine("Число b больше числа a");
if (a == b)
    Console.WriteLine("Число a равно числу b");