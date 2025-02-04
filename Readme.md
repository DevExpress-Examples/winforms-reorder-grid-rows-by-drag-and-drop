<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631130/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E764)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->


# WinForms Data Grid - How to reorder rows using drag-and-drop

> **Note**:
> In v23.2+, the `GridView` supports the following drag-and-drop operations out of the box:
>
> * Move selected rows to another Grid control.
> * Reorder selected rows within the GridView (supported data sources: `IList`, `DataTable`, `DataView`).
>
> Use the [GridView.OptionsDragDrop](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.OptionsDragDrop?v=23.2) property to configure drag-and-drop operations that users can perform within the GridView.

This example demonstrates how to attach the [Drag-and-Drop Behavior](https://docs.devexpress.com/WindowsForms/118656/common-features/behaviors/drag-and-drop-behavior) to the WinForms Grid Control and handle drag-drop-related events to allow users to reorder data rows using drag-and-drop.

The Behavior describes a functional aspect of a DevExpress WinForms UI control. Read the following help topic for more information: [Behaviors](https://docs.devexpress.com/WindowsForms/117235/common-features/behaviors).

## Attach Drag-and-Drop Behavior to GridView

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

## Handle the DragOver Event

The [DragOver](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragOver) event is handled to display the insert indicator and update the mouse pointer. The `DragOverGridEventArgs.GetDragOverGridEventArgs` static method is used to calculate drag-and-drop settings (state). These settings are used to specify appropriate event arguments for activating the drag-and-drop functionality:

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

## Handle the DragDrop Event

The [DragDrop](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.DragDrop.DragDropEvents.DragDrop) event is handled to reorder data rows in the data source.

<!-- default file list -->
## Files to Review

* [Form1.cs](./CS/E764/Form1.cs) (VB: [Form1.vb](./VB/E764/Form1.vb))
* [Program.cs](./CS/E764/Program.cs) (VB: [Program.vb](./VB/E764/Program.vb))
<!-- default file list end -->

## Documentation
- [Drag-and-Drop Behavior](https://documentation.devexpress.com/WindowsForms/118656/Common-Features/Behaviors/Drag-And-Drop-Behavior)
- [Drag-and-Drop Grid Rows](https://docs.devexpress.com/WindowsForms/401989/controls-and-libraries/data-grid/drag-and-drop)

## See Also
- [DevExpress WinForms Cheat Sheet - Drag-and-Drop Within/Between Controls](https://go.devexpress.com/CheatSheets_WinForms_Examples_T949086.aspx)
- [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)





<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-reorder-rows-drag-drop&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-reorder-rows-drag-drop&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
