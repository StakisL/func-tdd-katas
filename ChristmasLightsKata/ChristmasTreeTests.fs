module ChristmasLightsKata.UnitTest1

open NUnit.Framework
open ChristmasTree

[<SetUp>]
let Setup () =
    ()

[<Test>]
let IsGridExist () =
    let christmasTree = ChristmasTree(1000,1000)
    let result = christmasTree.IsLightsOff
    Assert.IsTrue(result)
