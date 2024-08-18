module EmailAddress



type EmailAddress = | EmailAddress of string 
    with
        member this.Value = 
            let (EmailAddress value) = this
            value


let EmailAddress (a: string) =
    //let address = EmailAddres a
    match System.Text.RegularExpressions.Regex.IsMatch(a,@"^\S+@\S+\.\S+$") with
    | true -> Some(EmailAddress a)
    | false -> None


// type EmailAddress = private EmailAddress of string
//     with 
//         member this.Value = 
//             let (EmailAddress e) = this
//             e
//         static member New(e: string) = 
//             match System.Text.RegularExpressions.Regex.IsMatch(e,@"^\S+@\S+\.\S+$") with
//             | true -> Some(EmailAddress e)
//             | false -> None


// let a = EmailAddress.EmailAddress "blabla"

// let b = a.Value


// // wrap
// let create (s: string) = 
//     match System.Text.RegularExpressions.Regex.IsMatch(s,@"^\S+@\S+\.\S+$") with
//     | true -> Some(EmailAddress s)
//     | false -> None

// // unwrap
// let value (EmailAddress e) = e