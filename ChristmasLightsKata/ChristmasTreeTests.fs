module ChristmasLightsKata.UnitTest1

open NUnit.Framework
open ChristmasTree

[<TestFixture>]
type ChristmasTreeTests() = 
  
    [<Test>]
    member this.ChristmasTree_ShouldCreateDisabledChristmasTree () =
        //arrange
        let christmasTree = ChristmasTree(1000,1000)
        
        //act & assert
        Assert.IsTrue(christmasTree.IsLightsOff)

    [<Test>]
    member this.ChristmasTree_ShouldTurnOnEveryLightOnTree () =
        //arrange
        let christmasTree = ChristmasTree(1000,1000)
        Assert.IsTrue(christmasTree.IsLightsOff)
        
        //act
        let turnedOnTree = christmasTree.TurnOnAll
        
        //assert
        for i in 0 .. turnedOnTree.Length - 1 do
            Assert.IsTrue(turnedOnTree.[i])
            
    [<Test>]
    member this.ChristmasTree_ShouldTurnOnFirstRowOnTree () =
        //arrange
        let christmasTree = ChristmasTree(1000,1000)
        
        //act
        let result = christmasTree.TurnOnFirstRow
        
        //assert
        let rowLenght = result.GetLength 0
        
        for i in 0 .. rowLenght - 1 do
            Assert.IsTrue(result.[i])
            
        for i in rowLenght .. result.Length - 1 do
            Assert.IsFalse(result.[i])
        
    //todo for next kata time
    //make special type for tree
    //split tree type with functions