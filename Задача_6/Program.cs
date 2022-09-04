Console.WriteLine("Введите любое число:");

string number = Console.ReadLine();

int numberA = int.Parse(number);

if (numberA % 2 == 0 ) {
    Console.WriteLine($"{numberA} - четное число!");
}
else {
   Console.WriteLine($"{numberA} - нечетное число!");
}