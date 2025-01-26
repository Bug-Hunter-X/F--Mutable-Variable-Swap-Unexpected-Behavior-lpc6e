let x = 10
let y = 20

let swap x y =
    let temp = x
    let newX = y
    let newY = temp
    (newX, newY)

let (newX, newY) = swap x y
printfn "%d %d" x y //Prints 10 20
printfn "%d %d" newX newY //Prints 20 10