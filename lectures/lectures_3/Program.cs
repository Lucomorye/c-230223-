// Функции в программирование
// ВозвращаемыйТипДанных ИмяМетода ([ТипДанныхАргумента1 ИмяАргумента1, ...])
// {
//   Тело метода
//   int result = 1 + 1;
//   return result Значение соответствующее возвращаемому типу данных;    
// }
//
// Первая группа методов ничего не принимают и не чего не возврашают (void)
//void Method1()
//{
//    Console.WriteLine("Автор ...");
//}
//Вызов такого вида метода осуществляется следующим образом
//Method1();
//
// Вторая группа методов могут принимать аргументы но ни чего не возвращать (void)
//void Method2(string message)
//{
//    Console.WriteLine(message);
//}
//Вызов такого вида метода осуществляется следующим образом
//Method2("Текст сообщения");

//Или если метод принимает не один аргумент, а несколько, то выглядеть будет следующим образом
//void Method2_1(string message, int count)
//{
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(message);// 5 min
//        i++;
//    }

//}
//Вызов
//Method2_1("Текст сообщения", 4);//Вариант 1
//Method2_1(message: "Текст сообщения", count: 4);// Вариант 2 используем имена аргументов

// Третья группа методов не принимают аргументов но могут чтото возвращать. Есле мы ожидаем возвращения то нужно указать ожидаемый тип данных.
//int Method3()
//{
//    return DataTime.Now.Year;
//}
//Вызов
//int year = Method3();
//Console.WriteLine(year);

// Четвёртая группа методов наиболее частая что-то принимают что-то возвращают
//string Method4(int count, string text)
//{
//    i = 0;
//    string result = string.Empty;//В эту пуст. переменную положим результат вычесления метода
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}
//Вызов
//string res = Method4(4, "Склеиваемый текст 4 раза");
//Console.WriteLine(res);

//  Классическая демонстрация цикла в цикле расмотрим вывод таблици умножения на экран
//for (i = 2; i <= 10; i++)
//{
//    for (j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i * j}");//Итерполяция строк
//    }
//    Console.WriteLine(); // Создаём эффект разрыва строк, чтоб скопом не было
//}