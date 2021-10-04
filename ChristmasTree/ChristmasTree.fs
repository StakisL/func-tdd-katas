module ChristmasTree

type ChristmasTree(heightIn : int, widthIn : int) as self =
    let height = heightIn
    let width = widthIn
    let grid : seq<bool> = seq{ for _row in 0 .. width - 1 do
                                for _col in 0 .. height - 1 -> false }
    
    member this.IsLightsOff() : bool = grid |> Seq.exists (fun i -> i = false)
        
