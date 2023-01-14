//Программа вывода квадрата случайного натурального числа от 1 до 5
Console.Clear();
Console.WriteLine("Программа вывода квадрата случайного натурального числа в диапазоне от 1 до 5 ");
Console.WriteLine("Сгенерированное случайное натуральное число в диапазоне от 1 до 5: ");
int a = new Random().Next(1, 5);
Console.WriteLine(a);
int square = a * a;
Console.WriteLine("Данное число в квадрате: ");
Console.WriteLine(square);