module ChristmasLightsKata.UnitTest1

open NUnit.Framework
open ChristmasTree

[<TestFixture>]
type ChristmasTreeTests() = 
  
    [<Test>]
    member this.ChristmasTree_ShouldCreateDisabledChristmasTree () =
        let christmasTree = ChristmasTree(1000,1000)
        Assert.IsTrue(christmasTree.IsLightsOff)

    [<Test>]
    member this.ChristmasTree_ShouldTurnOnEveryLightOnTree () =
        let christmasTree = ChristmasTree(1000,1000)
        let turnedOnTree = christmasTree.TurnOnAll
        for i in 0 .. turnedOnTree.Length - 1 do
            Assert.IsTrue(turnedOnTree.[i] = true)