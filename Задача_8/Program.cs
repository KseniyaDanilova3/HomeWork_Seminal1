Console.WriteLine("Введите число: ");

string number = Console.ReadLine();

int n = int.Parse(number);
if (n < 2) {
    Console.Write($" Укажите число больше 1 ");
}

for ( int i = 2 ; i <= n; i = i + 1) {
    if (i % 2 == 0) {
        Console.Write($" {i} ");
    }
}