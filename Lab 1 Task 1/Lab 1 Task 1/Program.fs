open System
open Microsoft.FSharp.Core

let сreateList size =
    let list = [    // список со значениями +1
        for i in 1..size do
            printf "Введите элемент списка: "
            let value = int(Console.ReadLine())
            yield value + 1
    ]
    
    list
    
[<EntryPoint>]
let main args =

    printf "Введите размер списка: "
    
    let size = int(Console.ReadLine())
    let list = сreateList size

    printfn "Искомый список: %A" list
    0
