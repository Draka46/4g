printf "Enter n (table n) printing: "
let input = float (System.Console.ReadLine())
let n = (int) input

let str_len k : int = k.ToString().Length
let prnt_spaces max k : string = let mutable spac = "" in for j = 1 to (max - str_len(k)) do spac <- spac + " " done; spac

let table n (len_array : _ array) circ_omk : string =
    let spaces_max = (if (str_len(circ_omk) > str_len("cirkel omkreds")) then str_len(circ_omk) else str_len("cirkel omkreds")) + 2
    
    let mutable s = "  "
    do s <- s + prnt_spaces spaces_max "n" + "n"
    do s <- s + prnt_spaces spaces_max "længde" + "længde"
    do s <- s + prnt_spaces spaces_max "cirkel omkreds" + "cirkel omkreds\n"
    
    for i = 1 to n do
        s <- s + "  "
        let len = len_array.[i].ToString()
        let omkS = circ_omk.ToString()
        s <- s + (prnt_spaces spaces_max i) + i.ToString() + (prnt_spaces spaces_max len) + len + (prnt_spaces spaces_max omkS) + omkS + "\n"

    s

printfn "%s" (table n [| 1;2;3;4;5;6;7;8;9;10;100;1000 |] 1)