open System
open Microsoft.FSharp.Core

let rec summ x : int =  // Функция вычисления произведения нечетных цифр
     if x % 2 = 0   // Проверка на четность цифры числа
     then if x = 0  // Вычисление произведения
          then 1
          else summ(x/10)  // Рекурсивный уход
     else x % 10 * summ(x/10)
     
[<EntryPoint>]  // Основная функция
let main args =
    printf "Введите число: "    // Запрос исходного числа
    let x = int(Console.ReadLine()) // Ввод исходного числа
    if (summ x) = 1 // Если все цифры числа четные
    then printf "Произведение нечетных цифр числа %i: 0" x  
    else printf "Произведение нечетных цифр числа %i: %i" x (summ x)
    0
