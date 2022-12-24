// Задание 2

int x1,y1,z1,x2,y2,z2;                                                         //Объявляем переменные
int X,Y,Z;

void ReadXYZ(){                                                                //Функция ввода и подсчета 3d координат
    Console.Write("Введите координату X первой точки: ");
    x1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Y первой точки: ");
    y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Z первой точки: ");
    z1 =  Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату X второй точки: ");
    x2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Y второй точки: ");
    y2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Z второй точки: ");
    z2 = Convert.ToInt32(Console.ReadLine());

                                                                               //Получение разницы кординат
    X = x2 - x1;
    Y = y2 - y1;
    Z = z2 - z1;
}
                                                
ReadXYZ();

double len = Math.Round(Math.Sqrt(X * X + Y *  Y + Z * Z), 3);                 //Получение длины отрезка в 3d пространстве

Console.Clear();                                                               //Очистить консоль
Console.WriteLine($"Длина отрезка: {len}");                                    //Вывести результат  
