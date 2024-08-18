module Typep

open FSharp.Data
open System
//open Microsoft.FSharp.Data
[<Literal>]
let url = "https://api.met.no/weatherapi/locationforecast/2.0/mini?"
[<Literal>]
let sample = "https://api.met.no/weatherapi/locationforecast/2.0/mini?lat=60.10&lon=9.58"

type Weather = JsonProvider<sample>

let sf = Weather.Load(url + "lat=60.10&lon=9.58")

let a =  sf.Properties.Timeseries



// let address1 = EmailAddress.create "x@example.com"
// let address2 = EmailAddress.create "xexample.com"


// match address1 with
//     | Some e ->EmailAddress.value e |> printfn "The value is %s"
//     | None -> ()

// let email = lazy EmailAddress (Console.ReadLine())

// let printAddress (a: EmailAddress option) = 
//     match a with 
//     | Some(a) -> printfn $"%s{a.Value}"
//     | None -> printfn "INVALID EMAIL!"


// let () = email.Force() |> printAddress

// let () = email.Value |> printfn "%A"


