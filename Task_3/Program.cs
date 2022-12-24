// Задание 3

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int curr = 1;
while (curr <= num)
{
    Console.WriteLine($"{curr} => {curr * curr * curr}");
    curr++;
}