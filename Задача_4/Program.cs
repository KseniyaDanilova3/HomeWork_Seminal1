Console.WriteLine("Введите первое число");

string number_1 = Console.ReadLine();

int a = int.Parse(number_1);

Console.WriteLine("Введите второе число");

string number_2= Console.ReadLine();

int b = int.Parse(number_2);

Console.WriteLine("Введите третье число");

string number_3 = Console.ReadLine();

int c = int.Parse(number_3);

if (a > b && b > c) {
    Console.WriteLine($"Максимальное число: {a}");
}
else if (b > a && a > c) {
    Console.WriteLine($"Максимальное число: {b}");
}
else
{
    Console.WriteLine($"Максимальное число: {c}");
}