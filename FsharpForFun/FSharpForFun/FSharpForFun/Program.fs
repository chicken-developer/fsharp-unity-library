let a = 10

let items = [1..10]
List.append items [6]

let prefix prefixStr baseStr =
    prefixStr + "," + baseStr
    
let names = ["David"; "Bob" ; "Alice"]

names
|> Seq.map (prefix "hello") 