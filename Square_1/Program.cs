Console.Clear();
Console.WriteLine("Является-ли первое из заданных чисел квадратом второго? ");
int num1 = new Random().Next(1, 100);
//int num1 = 25;
Console.WriteLine("Первое случайное натуральное число: ");
Console.WriteLine(num1);
int num2 = new Random().Next(1, 100);
//int num2 = 5;
Console.WriteLine("Второе случайное натуральное число: ");
Console.WriteLine(num2);
if (num1 == Math.Pow(num2, 2))
{
    Console.WriteLine("Первое число является квадратом второго ");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго ");
}
