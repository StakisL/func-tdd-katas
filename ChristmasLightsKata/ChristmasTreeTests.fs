module ChristmasLightsKata.UnitTest1

open NUnit.Framework
open ChristmasTree

[<TestFixture>]
type ChristmasTreeTests() = 
  
    [<Test>]
    member this.ChristmasTree_ShouldCreateDisabledChristmasTree () =
        let christmasTree = ChristmasTree(1000,1000)
        Assert.IsTrue(christmasTree.IsLightsOff)
