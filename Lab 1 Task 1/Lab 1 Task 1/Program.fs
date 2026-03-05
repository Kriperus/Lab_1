open System //Стандартные библиотеки
open Microsoft.FSharp.Core

let result list = 
    list |> List.map(fun x -> x + 1)

[<EntryPoint>]  // Заздание "Основной функции"
let main args =
    printf "Введите размер списка: "    // Интерфейс для пользователя
    let size = int(Console.ReadLine())  // Ввод количества элементов
    let list = [    // Ввод элементов в список со значением +1 к вводимому
        for i in 1..size do
            printf "Введите элемент списка: "
            let value = int(Console.ReadLine())
            yield value
    ]

    printfn "Ваш список: %A" (result list) // Вывод ответа
    0