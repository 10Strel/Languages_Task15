Console.WriteLine("Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.\r\n");

const int weekend0 = 6; 
const int weekend1 = 7;

Console.WriteLine("Введите целое число от 1 до 7:");

bool res = int.TryParse(Console.ReadLine(), out int number);
if (!res || !(number > 0 && number < 8))
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.WriteLine($"Результат: {(number == weekend0 || number == weekend1 ? "выходной" : "рабочий")} день.");