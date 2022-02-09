<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631130/17.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E764)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


# Data Grid for WinForms - How to reorder grid rows by drag-and-drop

[Drag-and-Drop Behavior](https://documentation.devexpress.com/WindowsForms/118656/Common-Features/Behaviors/Drag-And-Drop-Behavior) allows you to implement row drag-and-drop for [GridControls](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl). This example handles the [Drag-and-Drop Behavior](https://documentation.devexpress.com/WindowsForms/118656/Common-Features/Behaviors/Drag-And-Drop-Behavior)'s [DragOver](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragOver) and [DragDrop](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragDrop) events to implement row drag-and-drop within a grid control.

```cs
DragDropBehavior gridControlBehavior = behaviorManager1.GetBehavior<DragDropBehavior>(gridView);
gridControlBehavior.DragDrop += Behavior_DragDrop;
gridControlBehavior.DragOver += Behavior_DragOver;

```
```vb
Dim gridControlBehavior As DragDropBehavior = behaviorManager1.GetBehavior(Of DragDropBehavior)(Me.gridView1)
AddHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
AddHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
```


A [DragOver](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragOver) event handler uses the static `DragOverGridEventArgs.GetDragOverGridEventArgs` method to calculate a drag-and-drop operation's settings (state). These settings are then assigned to event arguments to activate the drag-and-drop functionality:


```cs
private void Behavior_DragOver(object sender, DragOverEventArgs e) {
    DragOverGridEventArgs args = DragOverGridEventArgs.GetDragOverGridEventArgs(e);
    e.InsertType = args.InsertType;
    e.InsertIndicatorLocation = args.InsertIndicatorLocation;
    e.Action = args.Action;
    Cursor.Current = args.Cursor;
    args.Handled = true;
} 
```

```vb
Private Sub Behavior_DragOver(ByVal sender As Object, ByVal e As DragOverEventArgs)
    Dim args As DragOverGridEventArgs = DragOverGridEventArgs.GetDragOverGridEventArgs(e)
    e.InsertType = args.InsertType
    e.InsertIndicatorLocation = args.InsertIndicatorLocation
    e.Action = args.Action
    Cursor.Current = args.Cursor
    args.Handled = True
End Sub
```

A [DragDrop](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragDrop) event handler reorders rows on the data source level.


<!-- default file list -->
## Files to Look At

* [Form1.cs](./CS/E764/Form1.cs) (VB: [Form1.vb](./VB/E764/Form1.vb))
* [Program.cs](./CS/E764/Program.cs) (VB: [Program.vb](./VB/E764/Program.vb))
<!-- default file list end -->

## Documentation
- [Drag And Drop Behavior](https://documentation.devexpress.com/WindowsForms/118656/Common-Features/Behaviors/Drag-And-Drop-Behavior)

## See Also

- [DevExpress WinForms Cheat Sheet - Drag-and-Drop Within/Between Controls](https://go.devexpress.com/CheatSheets_WinForms_Examples_T949086.aspx)
- [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)





