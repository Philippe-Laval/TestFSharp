module TestFSharp.TestFunction

// F# Language Reference
// https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/


// Values that are intended to be constants can be marked with the Literal attribute.
// This attribute has the effect of causing a value to be compiled as a constant.
// In pattern matching expressions, identifiers that begin with lowercase characters are always treated as variables
// to be bound, rather than as literals, so you should generally use initial capitals when you define literals.

[<Literal>]
let Literal1 = "a" + "b"

[<Literal>]
let FileLocation =   __SOURCE_DIRECTORY__ + "/" + __SOURCE_FILE__


// Using a verbatim string
let xmlFragment1 = @"<book author=""Milton, John"" title=""Paradise Lost"">"

// Using a triple-quoted string
let xmlFragment2 = """<book author="Milton, John" title="Paradise Lost">"""


let name = "Phillip"
let age = 30
printfn $"Name: {name}, Age: {age}"

printfn $"I think {3.0 + 0.14} is close to {System.Math.PI}!"

// At any level of scope other than module scope, it is not an error to reuse a value or function name.
let function1 () =
   let list1 = [1; 2; 3]
   let a = list1[0]
   let list1 = [a]
   list1

let CoolPrint x = printf $"{x}"

let f x = x + 1

let f2 (x : int) = x + 1

let f3 x = (x, x)

// let cylinderVolume (radius : float) (length : float) : float
let cylinderVolume radius length =
    // Define a local value pi.
    let pi = 3.14159
    length * pi * radius * radius

//Calling a Function
let vol = cylinderVolume 2.0 3.0

// Partial Application of Arguments
let smallPipeRadius = 2.0
let bigPipeRadius = 3.0

// These define functions that take the length as a remaining
// argument:

let smallPipeVolume = cylinderVolume smallPipeRadius
let bigPipeVolume = cylinderVolume bigPipeRadius

let length1 = 30.0
let length2 = 40.0
let smallPipeVol1 = smallPipeVolume length1
let smallPipeVol2 = smallPipeVolume length2
let bigPipeVol1 = bigPipeVolume length1
let bigPipeVol2 = bigPipeVolume length2

// Recursive Functions

