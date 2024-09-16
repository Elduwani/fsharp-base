type RegisteredCustomer = { Id: string; IsEligible: bool }
type UnregisteredCustomer = { Id: string }

type Customer =
    | Registered of RegisteredCustomer
    | Guest of UnregisteredCustomer

let calculateTotal customer spend =
    let discount =
        match customer with
        | Registered c when c.IsEligible && spend >= 100.0M -> spend * 0.1M
        | _ -> 0.0M

    spend - discount
