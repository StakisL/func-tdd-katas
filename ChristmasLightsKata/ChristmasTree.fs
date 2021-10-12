module ChristmasTree

type ChristmasTree(heightIn : int, widthIn : int) as self =
    let height = heightIn
    let width = widthIn
    let mutable christmasTree = [| for _i in 0 .. width - 1 do
                                   for _j in 0 .. height - 1 -> false|]
    
    member this.IsLightsOff = christmasTree |> Array.exists (fun i -> i  = false)

    member this.GetTree = christmasTree
    
    member this.TurnOnAll =
        for i in 0 .. christmasTree.Length - 1 do
            Array.set christmasTree i true
        christmasTree
        
    member this.TurnOnFirstRow =
        for i in 0 .. width - 1 do
            Array.set christmasTree i true
        christmasTree
                     
    member this.TurnOnAtRange (sourceRow, sourceColumn, destRow, destColumn) : bool[] =
        for i in sourceRow .. destRow do
            for j in sourceColumn ..destColumn do
                christmasTree.[i * width + j] <- true     
        christmasTree
