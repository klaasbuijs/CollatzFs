// Playing around with F# and recursion
open System

let generateRandomNumbers count =
    let rnd = System.Random()
    List.init count (fun _ -> rnd.Next ())

let checkNumber inputNumber =
    let rec isDivisibleByTwo (i, acc) =
        if i = 1 then acc 
        elif i % 2 = 0 then let i' = i/2 in isDivisibleByTwo (i', i::acc)
        else  let i' = i*3+1 in isDivisibleByTwo (i', i::acc) // i % 2 <> 0 then
    isDivisibleByTwo (inputNumber,[]) |> List.rev

[<EntryPoint>]
let main (argv : string[]) = 
    let setSize = int argv.[0]
    let l = generateRandomNumbers setSize

    for n in l do
        printfn "Integer %i yielded: %A" n (checkNumber n)
    System.Console.ReadKey() |> ignore
    0