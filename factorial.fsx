// Calculo de factorial en F#, programacion funcional
let rec factorial num = if num = 0 then 1 else num * (factorial (num - 1))

// Se pide al usuario un numero para realizar el calculo
printf("Insert a number:")
let number = System.Convert.ToInt32(System.Console.ReadLine())
let fact = factorial number
printfn "%i" fact