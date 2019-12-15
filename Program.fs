// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.
namespace Main

open  System
open System.Windows.Forms
open Game
module Main=
    open Main
    [<EntryPoint>]
    let main argv =
        let form = new Form(Text = "F# form")
        let button = new Button(Text = "Click me to close!", Dock = DockStyle.Fill)

        button.Click.Add(fun _ -> Application.Exit() |> ignore)
        form.Controls.Add(button)
        // form.Show()
        Application.Run(form)
        0
    
