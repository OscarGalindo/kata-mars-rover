namespace Tests

open NUnit.Framework

[<TestClass>]
type TestClass () =

    [<Test>]
    member this.TestMethodPassing() =
        Assert.True(true)

    [<Test>]
    member this.Test1 () =
        Assert.Pass()
