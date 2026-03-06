open System
open Microsoft.FSharp.Core

let rec summ x : int =  // произведение нечетных цифр
     if x % 2 = 0  then // Проверка четности цифрs
        if x = 0 then 
            1
        else 
            summ(x/10)
     else 
        x % 10 * summ(x/10)
     
[<EntryPoint>]
let main args =

    printf "Введите число: "
    let x = int(Console.ReadLine())
    
    if (summ x) = 1 then // Вывести 0 если все цифры четные
        printf "Произведение нечетных цифр числа %i: 0" x  
    else 
        printf "Произведение нечетных цифр числа %i: %i" x (summ x)

    0
