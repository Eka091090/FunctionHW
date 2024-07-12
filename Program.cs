void Main()
{
    string value = userInput();
    System.Console.WriteLine(value);
    ifStop(value);
}


string userInput()
{
    while(true)
    {
        System.Console.Write($"Введите целое число или 'q' для выхода: ");
        string? number = Console.ReadLine();
        // if(number == "q")
        //     break;
        // System.Console.WriteLine(number);
        // return number;
    }
}

void ifStop(string value)
{
    if(value == "q")
        System.Console.WriteLine("[STOP]");
        userInput.break;


}



Main();

// using System;
// class Program
// {
//     static void Main()
//     {
//         while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine(); // Чтение строки ввода пользователя
//             // if (input == "q") // Проверка на ввод 'q' для выхода
//             // {
//             //     Console.WriteLine("[STOP]");
//             //     break;
//             // }
//             // int number;
//             // int sum = 0;
//             // if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
//             //     sum = 0;
//             // while (number > 0) // Вычисление суммы цифр числа
//             // {
//             //     sum += number % 10; // Добавление последней цифры к сумме
//             //     number /= 10; // Удаление последней цифры из числа
//             // }
//             // if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//             // {
//             //     Console.WriteLine("[STOP]");
//             //     break;
//             // }
//         }
//         // else // Если ввод не является числом и не 'q', повторить запрос
//         // {
//         //     Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//         // }
//     }
// }
