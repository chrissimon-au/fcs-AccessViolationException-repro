open Amazon.CDK
open AccessviolationexceptionRepro

[<EntryPoint>]
let main _ =
    let app = App(null)

    AccessviolationexceptionReproStack(app, "AccessviolationexceptionReproStack", StackProps()) |> ignore

    app.Synth() |> ignore
    0
