// // Задание 1

// #region Первые мои попытки сделать через цикл
//     // bool IsPalindrom(int pAN)
//     // {
//     //     int current, buffer;

//     //     for (int i = 0; i < 5; i++)
//     //     {
//     //         current = pAN / 10000;

//     //     }
//     //     return false;
//     // }

//     // if(Math.Round(num / 10000) != 0){
//     //     for (int firstS = 10000, endS = 10; endS <= 100000; endS *= 10, firstS /= 10){
        
//     //         if(Math.Round(num / firstS, 0) == Math.Round(num % endS)){
//     //             Console.WriteLine(Math.Round(num / firstS, 0) + " => " + Math.Round(num % endS));
//     //         }
//     //         else{
//     //             Console.WriteLine("Нет");
//     //         }
//     //     }
//     // }
//     // else{
//     //     Console.WriteLine("Ошибка: Вы ввели слишко малое число!");
//     // }
// #endregion

// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());

// double first,end,first1,end1;
// bool category_1, category_2, category_3;

// if(num.ToString().Length == 5){

//     #region Проверка 1 разряда чисел
//     double first_one = Math.Round(num / 10000, 0);
//     double end_one = Math.Round(num %  10, 0);

//     Console.WriteLine(first_one + " " + first_one); //Тут дэбаг

//     if(first_one == end_one){ category_1 = true;} else{category_1 = false;}
//     #endregion

//     #region Проверка 2 разряда чисел
//         first = Math.Round(num / 1000, 0);
//         end = Math.Round(num % 100, 0);

//         first1 = Math.Round(first % 10, 0);
//         end1 = Math.Round(end / 10, 0);

//         Console.WriteLine(first + " " +  first1 + " " + " | " + end + " -> " + end1); //Тут дэбаг

//         if(first1 == end1){ category_2 = true;} else{category_2 = false;}
//     #endregion

//     #region Проверка 3 разряда чисел
//         first = Math.Round(num / 100, 0);
//         end = Math.Round(num % 1000, 0);

//         first1 = Math.Round(first % 10, 0);
//         end1 = Math.Round(end / 100, 0);

//         if(first1 == end1){category_3 = true;} else{category_3 = false;}
//     #endregion

// if (category_1 == true && category_2 == true && category_3 == true) Console.WriteLine("Введенное число палиндромом!"); else {Console.WriteLine("Введенное число не палиндром!");}
// }
// else Console.WriteLine("[Ошибка] - Вы ввели некорректное число!");

int revers = 0;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num;

while (current != 0)
{
    revers = revers * 10;
    revers = revers + current % 10;
    current = current / 10;
}
if(num == revers) Console.WriteLine("Это палиндром.");
else Console.WriteLine("Это не палиндром.");