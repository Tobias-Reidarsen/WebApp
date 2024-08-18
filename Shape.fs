module shape

type Shape =
    | Circle of radius: float
    | EquilateralTriangle of double
    | Square of double
    | Rectangle of width: double * length: double


let getShapeWidth shape = 
    match shape with
    | Rectangle(width,_) -> Some(width)
    | _ -> None