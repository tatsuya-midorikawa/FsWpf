namespace FsWpf.ViewModels

open System.ComponentModel
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

[<AbstractClass>]
type ViewModel() =
  let propertyChanged = Event<_, _>()
  
  interface INotifyPropertyChanged with
    [<CLIEvent>]
    member __.PropertyChanged = propertyChanged.Publish

  member __.OnPropertyChanged([<CallerMemberName; Optional; DefaultParameterValue("")>] memberName: string) =
    if not(System.String.IsNullOrEmpty(memberName)) then
      propertyChanged.Trigger(__, PropertyChangedEventArgs(memberName))

type MainWindowViewModel() =
  inherit ViewModel()
  let mutable title = "F# Wpf Sample Text"
  
  member __.Title
    with get() = title
    and set(title') = title <- title'; __.OnPropertyChanged()
