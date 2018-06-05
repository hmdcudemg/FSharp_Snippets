// Este metodo sirve para hacer la secuencia fibonacci
let rec fibonacci ant nex max tot=
    if ant == nex then
        printf "%i" ant
        printf "%i" nex
    printf "%i" (ant+nex)
    let tot = tot + 1
    if tot < max then
        fibonacci nex (ant+nex) max tot

printf "Insert a number:"
let max = System.Convert.ToInt32(System.Console.ReadLine())

fibonacci 1 1 max 0