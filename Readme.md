<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631130/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E764)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/E764/Form1.cs) (VB: [Form1.vb](./VB/E764/Form1.vb))**
<!-- default file list end -->
# How to reorder grid rows by drag and drop


<p>This example extends the example provided in the <a href="https://www.devexpress.com/Support/Center/p/A2343">How to allow an end-user to move the rows in a grid up and down if the grid is bound to a DataTable</a> article and illustrates how to reorder rows by drag and drop.<br><br>Starting with version 17.2.4, you can attach <a href="https://documentation.devexpress.com/WindowsForms/118656/Common-Features/Behaviors/Drag-And-Drop-Behavior">Drag And Drop Behavior</a> to GridControl to implement reordering. For this, handle the <strong>DragOver</strong> and <strong>DragDrop</strong> events of the corresponding behavior using the following code:</p>


```cs
DragDropBehavior gridControlBehavior = behaviorManager1.GetBehavior<DragDropBehavior>(gridView);
gridControlBehavior.DragDrop += Behavior_DragDrop;
gridControlBehavior.DragOver += Behavior_DragOver;

```


<p> </p>


```vb
Dim gridControlBehavior As DragDropBehavior = behaviorManager1.GetBehavior(Of DragDropBehavior)(Me.gridView1)
AddHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
AddHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
```


<p>In the <strong>DragOver</strong> event handler, calculate drag-drop parameters (<strong>InsertType,</strong> <strong>InsertIndicatorLocation, Action</strong> and<strong> Cursor</strong>) using the static <strong>DragOverGridEventArgs.GetDragOverGridEventArgs </strong>method:</p>


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


<p>Data Source reordering logic should be implemented in the <strong>DragDrop</strong> event handler.<br><br>In older versions, reordering is implemented using the standard Drag events.</p>

<br/>


