module ChristmasLightsKata.UnitTest1

open NUnit.Framework
open ChristmasTree

[<TestFixture>]
type ChristmasTreeTests() =
    
    [<DefaultValue>] val mutable christmasTree : ChristmasTree
    
    [<SetUp>]
    member this.Init () =
        this.christmasTree <- ChristmasTree(1000,1000)
        
    [<Test>]
    member this.ChristmasTree_ShouldCreateDisabledChristmasTree () =
        //act & assert
        Assert.IsTrue(this.christmasTree.IsLightsOff)

    [<Test>]
    member this.ChristmasTree_ShouldTurnOnEveryLightOnTree () =
        //arrange
        Assert.IsTrue(this.christmasTree.IsLightsOff)
        
        //act
        let turnedOnTree = this.christmasTree.TurnOnAll
        
        //assert
        for i in 0 .. turnedOnTree.Length - 1 do
            Assert.IsTrue(turnedOnTree.[i])
            
    [<Test>]
    member this.ChristmasTree_ShouldTurnOnFirstRowOnTree () =
        //arrange
        let rowLenght = 1000

        //act
        let result = this.christmasTree.TurnOnFirstRow
        
        //assert
        for i in 0 .. rowLenght - 1 do
            Assert.IsTrue(result.[i])
            
        for i in rowLenght .. result.Length - 1 do
            Assert.IsFalse(result.[i])

    [<Test>]
    member this.ChristmasTree_GetTree_ShouldReturnChristmasTree () =
        //act
        let lights = this.christmasTree.GetTree
        
        //assert
        Assert.AreEqual(lights.Length, 1000000)
       
//    [<Test>]
//    member this.ChristmasTree_ShouldTurnOffOnlyFourMiddleLights () =
//        //arrange
//        let christmasTree = ChristmasTree(1000,1000)
//        
//        //act
//        
//        
//        //assert