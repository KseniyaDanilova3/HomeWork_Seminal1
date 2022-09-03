Console.WriteLine("Введите первое число");

string number_1 = Console.ReadLine();

int number_one = int.Parse(number_1);

Console.WriteLine("Введите второе число");

string number_2= Console.ReadLine();

int number_two = int.Parse(number_2);

if (number_one > number_two) {

    Console.WriteLine($"Первое число: {number_one} больше второго числа: {number_two}");
}

else if (number_one ==number_two) {
    Console.WriteLine($"Первое число: {number_one} и второе число: {number_two} равны");
}
else {

    Console.WriteLine($"Второе число: {number_two} больше первого числа: {number_one}");
}