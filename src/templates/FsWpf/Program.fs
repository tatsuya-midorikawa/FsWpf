namespace FsWpf

open System
open System.Windows

module Main =
  [<STAThread>]
  [<EntryPoint>]
  let entrypoint(_) =
    let application = 
      Application.LoadComponent(Uri("App.xaml", UriKind.Relative)) 
      :?> Application

    application.Activated
    |> Event.add (fun _ -> MainWindow.initialize application.MainWindow)

    application.Run()
