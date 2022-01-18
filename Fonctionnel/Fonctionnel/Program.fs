///I
///Exo A1
open System

let five = 5
let seven = 7
let cube (x : int) = x * x * x
printfn "x: %i" (cube(five))
printfn "x: %i" (cube(seven))

///Exo B1 Calcul Taux d'interet

let interestRate (balance: decimal): single =
  match balance with
  | solde when solde < 0m -> 3.213f
  | solde when 0m <= solde && solde <1000m -> 0.5f
  | solde when 1000m <= solde && solde < 5000m -> 1.621f
  | solde when solde > 5000m -> 2.475f
  | _ -> 0f

interestRate (200.75m) |> printfn "%f"

///Exo B2 Calcul Interet


let interest (balance: decimal): decimal =
 System.Convert.ToDecimal (interestRate (200.75m)) * balance / 100m

interest (200.75m) |> printfn "%f"

///Exo B3 Calcul Màj annuelle du solde

let annualBalanceUpdate(balance: decimal): decimal =

 balance + interest(200.75m)


annualBalanceUpdate (200.75m)|> printfn "%f"

///Exo B4 Montant Oeuvre charité

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    int(balance / 100m * decimal(taxFreePercentage) * 2.0m);

let solde = 550.5m;
let taxe = 2.5;

amountToDonate solde taxe |> printfn "Don : %i"

///II
///Exo A1

let message (txt: string): string =
    txt.Substring(txt.IndexOf(':') + 2)

message "[WARNING] : Disque presque plein" |> printfn ("%s")

///Exo A2

let logLevel (txt: string): string =
    txt.Substring(txt.IndexOf('[') + 1, txt.IndexOf(']') - 1).ToLower()

logLevel "[ERREUR] : Disque presque plein" |> printfn ("%s")

///Exo A3

let reformat (txt: string): string =
    message(txt) +  " (" + logLevel(txt) + ")"

reformat("[INFO] : Opération terminée") |> printfn("%s")


///IV
/// Exo A1

let lastWeek = [| 0 ; 2 ; 5 ; 3 ; 7 ; 8 ; 4 |]

/// Exo A2

let visitesHier (data: int[]) :int= 
 let test = data.Length - 2
 data[test] 

visitesHier [| 3 ; 5 ; 0 ; 7 ; 4 ; 1 |] |> printfn ("%i")

/// Exo A3

///lastWeek |> Array.sum |> printfn("ceci est la somme de %d")

let total (data : int[]) =
 data |> Array.sum
 
total [| 3 ; 5 ; 0 ; 7 ; 4 ; 1 |] |> printfn("ceci est la somme de %d")

/// Exo A4

let joursSansVisite (data : int[]) :bool =
[| for i in 1 .. data.Length - 1 -> if data[i] = 0 then true else false|]

joursSansVisite [| 3 ; 5 ; 0 ; 7 ; 4 ; 1 |] |> printf("%b")

/// Exo A5

let birdCount = [| 3 ; 5 ; 0 ; 7 ; 4 ; 1 |] 

let incrementTodaysCount (data :int ) (tab : int[]): int[] =

  tab[tab.Length - 1] = data 


incrementTodaysCount birdCount compte-client


