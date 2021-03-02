namespace FsWpf

open System.Windows
open FsWpf.ViewModels

module MainWindow =
  let initialize (window: Window) =
    window.DataContext <- MainWindowViewModel()
    ()
