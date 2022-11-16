Console.WriteLine("Введите число number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
    Console.WriteLine("ДА");
else
    Console.WriteLine("НЕТ");