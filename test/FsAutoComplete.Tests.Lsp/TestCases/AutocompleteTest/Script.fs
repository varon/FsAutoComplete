module X =
    let func z = 34

    let ``sample func`` = 3

module ``Sample module`` =
    let z = 34

X.

Sy

System.

``Sample module``.

open System

type Foo = {
    bar: string
    baz: bool
}

let foo = { bar = "bar"; baz = false }

foo.

type Stub() =
    member val Foo = "" with get, set
    member val Bar = "" with get, set
    member val Baz = "" with get, set

let s = Stub(Foo = "foo", )

let x = [ {| Name = "foo" |} ]

x.[0].
