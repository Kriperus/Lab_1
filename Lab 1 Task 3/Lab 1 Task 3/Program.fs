open System
open Microsoft.FSharp.Core

let addToList element list = element :: list  // Добавление элемента в лист

let rec delFromList element list =  // Удаление элемента из списка
    if List.isEmpty list then
        []
    else if list.Head = element then
        list.Tail
    else
        list.Head :: delFromList element list.Tail

let rec findInList element list =   // Поиск значения в списке
    match list with
    | [] -> 
        printfn "Элемент не найден"
    | head :: tail ->
        if head = element then 
            printfn "Элемент \"%s\" найден" element
        else
            findInList element tail

let combineLists list1 list2 = list1 @ list2    // Сцепка списков

let elemFromList index list =
    if index < 0 || index >= List.length list then
        printfn "Индекс %d не корректен" index
    else
        let elem = List.item index list
        printfn "Элемент по индексу %d: \"%s\"" index elem

let rec createList () = // Создание списка
    let element = Console.ReadLine()
    if element = "" then
        []
    else
        element :: createList()

[<EntryPoint>]
let main args =

    printfn "Введите элементы вашего списка: "
    let list = createList()
    printfn "Введеный список: %A" list

    printf "Введите добавляемый элемент: "
    let AddedElem = Console.ReadLine()
    let AddingElem = addToList AddedElem list
    printfn "Обновленный список: %A" AddingElem

    printf "Введите значение удаляемого элемента: "
    let RemovedElem = Console.ReadLine()
    let RemovingElem = delFromList RemovedElem AddingElem
    printfn "Обновленный список: %A" RemovingElem

    printf "Введите искомый элемент: "
    let find = Console.ReadLine()
    findInList find RemovingElem

    printfn "Введите сцепляемый список: "
    let ListToComb = createList()
    let combinedList = combineLists RemovingElem ListToComb
    printfn "Обновленный список: %A" combinedList

    printf "Введите индекс искомого элемента: "
    let index = Console.ReadLine() |> int
    elemFromList index combinedList

    0﻿open System
open Microsoft.FSharp.Core

let addToList element list = element :: list  // Добавление элемента в лист

let rec delFromList element list =  // Функция удаления элемента из списка
    if List.isEmpty list then   // Проверка на пустоты
        []
    else if list.Head = element then    // Проверка нужный ли элемент
        list.Tail
    else
        list.Head :: delFromList element list.Tail  // Если не тот элемент вызов рекурсивной функции без 1 элемента списка

let rec findInList element list =   // Поиск значения по списку
    match list with // Проверка по паттернам
    | [] ->     // Если список пуст
        printfn "Элемент не найден"
    | head :: tail ->
        if head = element then  // Проверка на нужный элемент
            printfn "Элемент \"%s\" найден" element
        else
            findInList element tail // Если не искомый элемент уход на рекурсивный запуск

let combineLists list1 list2 = list1 @ list2    // Сцепка 2 разных листов

let elemFromList index list =   // Поиск элемента по индексу
    if index < 0 || index >= List.length list then  // Проверка на корректность индекса
        printfn "Индекс %d не корректен" index
    else
        let elem = List.item index list
        printfn "Элемент по индексу %d: \"%s\"" index elem    // Вывод элемента с заданным индексом

let rec createList () = // Создание списка
    let element = Console.ReadLine()    // Задания значений списка
    if element = "" then    // Если введена пустота то создается пустой список
        []
    else
        element :: createList() // Рекурсивный вызов

[<EntryPoint>]  // Основная функция
let main args =

    printfn "Введите элементы вашего списка: "  // Функция для создание списка
    let list = createList()
    printfn "Введеный список: %A" list

    printf "Введите добавляемый элемент: " // Функция для добавления элемента
    let AddedElem = Console.ReadLine()
    let AddingElem = addToList AddedElem list
    printfn "Обновленный список: %A" AddingElem

    printf "Введите значение удаляемого элемента: " // Функция для удаления элемента из списка
    let RemovedElem = Console.ReadLine()
    let RemovingElem = delFromList RemovedElem AddingElem
    printfn "Обновленный список: %A" RemovingElem

    printf "Введите искомый элемент: "  // Функция для поиска элемента по значению
    let find = Console.ReadLine()
    findInList find RemovingElem

    printfn "Введите сцепляемый список: "   // Функция для сцепки двух списков
    let ListToComb = createList()
    let combinedList = combineLists RemovingElem ListToComb
    printfn "Обновленный список: %A" combinedList

    printf "Введите индекс искомого элемента: " // Функция поиска по индексу элемента
    let index = Console.ReadLine() |> int
    elemFromList index combinedList

    0

