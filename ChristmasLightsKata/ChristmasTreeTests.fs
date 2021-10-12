module ChristmasLightsKata.UnitTest1

open System
open NUnit.Framework
open ChristmasTree

[<TestFixture>]
type ChristmasTreeTests() =
    
    [<DefaultValue>] val mutable christmasTree : ChristmasTree
    [<DefaultValue>] val mutable width : int
    [<DefaultValue>] val mutable height : int
     
    [<SetUp>]
    member this.Init () =
        this.width <- 1000
        this.height <- 1000
        this.christmasTree <- ChristmasTree(this.width, this.height)
        
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
       
    [<Test>]
    member this.ChristmasTree_ShouldTurnOffOnlyFourMiddleLights () =
        //arrange & act
        let lights = this.christmasTree.TurnOnAtRange (499, 499, 500, 500)
         
        for i in 0 .. lights.Length - 1 do
            //I know that it can be written much better
            if (i >= 499 * this.width + 499 && i <= 499 * this.width + 500) ||
               (i >= 500 * this.width + 499 && i <= 500 * this.width + 500) then
                Assert.IsTrue(lights.[i])
            else
                Assert.IsFalse(lights.[i])