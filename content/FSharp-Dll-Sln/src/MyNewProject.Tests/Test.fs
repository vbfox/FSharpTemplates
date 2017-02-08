module MyNewProject

open NUnit.Framework

[<Test>]
let SomeTest () =
    Assert.AreEqual(1+1, 2)
