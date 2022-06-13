type Name = string
type Fullname = string * string

let fullNameToSting (x: Fullname) =
    let first, second = x in
    first + " " + second

printfn "%s" fullNameToSting Fullname "AA"