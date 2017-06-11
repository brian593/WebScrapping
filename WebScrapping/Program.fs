open System
open System.IO
open FSharp.Data

type GoogleSearchResultPage = HtmlProvider<"https://www.google.com/search?q=brian593">

let firstPage = GoogleSearchResultPage.Load("https://www.google.com/search?q=brian593")
let secondPage = GoogleSearchResultPage.Load("https://www.google.com/search?q=brian593&start=10")

firstPage.Html.Descendants()
|> Seq.filter (fun n -> n.HasName("h3") && n.HasClass("r"))
|> Seq.iter (fun n -> printfn "%s" (n.InnerText()))
printfn "---Aqui comienza la segunda página ;) ----"
secondPage.Html.Descendants()
|> Seq.filter (fun n -> n.HasName("h3") && n.HasClass("r"))
|> Seq.iter (fun n -> printfn "%s" (n.InnerText()))

Console.ReadLine() |> ignore
0

