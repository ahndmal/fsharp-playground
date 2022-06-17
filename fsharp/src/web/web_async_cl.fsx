open System.Net
open System.Text
open System
 
let client = new WebClient()
 
let res = client.AsyncDownloadData(Uri("https://www.w3.org")) |> Async.RunSynchronously |> Encoding.ASCII.GetString

printfn $"{res}"