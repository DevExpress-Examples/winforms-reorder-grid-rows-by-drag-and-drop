Imports DevExpress.Utils.DragDrop
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace E764
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            SetUpGrid(Me.gridControl1, FillTable())
            HandleBehaviorDragDropEvents()
        End Sub
        Public Function FillTable() As DataTable
            Dim table As New DataTable()
            table.Columns.Add("ID", GetType(Integer))
            table.Columns.Add("Keyword")
            table.Columns.Add("Order", GetType(Decimal))
            table.Rows.Add(New Object() { 1, "abstract", 1 })
            table.Rows.Add(New Object() { 2, "event", 2 })
            table.Rows.Add(New Object() { 3, "new", 3 })
            table.Rows.Add(New Object() { 4, "struct", 4 })
            table.Rows.Add(New Object() { 5, "as", 5 })
            table.Rows.Add(New Object() { 6, "explicit", 6 })
            table.Rows.Add(New Object() { 7, "null", 7 })
            table.Rows.Add(New Object() { 8, "switch", 8 })
            table.Rows.Add(New Object() { 9, "base", 9 })
            table.Rows.Add(New Object() { 10, "extern", 10 })
            table.Rows.Add(New Object() { 11, "object", 11 })
            table.Rows.Add(New Object() { 12, "this", 12 })
            table.Rows.Add(New Object() { 13, "bool", 13 })
            table.Rows.Add(New Object() { 14, "false", 14 })
            table.Rows.Add(New Object() { 15, "operator", 15 })
            table.Rows.Add(New Object() { 16, "throw", 16 })
            table.Rows.Add(New Object() { 17, "break", 17 })
            Return table
        End Function
        Public Sub SetUpGrid(ByVal grid As GridControl, ByVal table As DataTable)
            Dim view As GridView = TryCast(grid.MainView, GridView)
            grid.DataSource = table
            view.OptionsBehavior.Editable = False
        End Sub
        Public Sub HandleBehaviorDragDropEvents()
            Dim gridControlBehavior As DragDropBehavior = behaviorManager1.GetBehavior(Of DragDropBehavior)(Me.gridView1)
            AddHandler gridControlBehavior.DragDrop, AddressOf Behavior_DragDrop
            AddHandler gridControlBehavior.DragOver, AddressOf Behavior_DragOver
        End Sub
        Private Sub Behavior_DragOver(ByVal sender As Object, ByVal e As DragOverEventArgs)
            Dim args As DragOverGridEventArgs = DragOverGridEventArgs.GetDragOverGridEventArgs(e)
            e.InsertType = args.InsertType
            e.InsertIndicatorLocation = args.InsertIndicatorLocation
            e.Action = args.Action
            Cursor.Current = args.Cursor
            args.Handled = True
        End Sub
        Private Sub Behavior_DragDrop(ByVal sender As Object, ByVal e As DevExpress.Utils.DragDrop.DragDropEventArgs)
            Dim targetGrid As GridView = TryCast(e.Target, GridView)
            Dim sourceGrid As GridView = TryCast(e.Source, GridView)
            If e.Action = DragDropActions.None OrElse targetGrid IsNot sourceGrid Then
                Return
            End If
            Dim sourceTable As DataTable = TryCast(sourceGrid.GridControl.DataSource, DataTable)

            Dim hitPoint As Point = targetGrid.GridControl.PointToClient(Cursor.Position)
            Dim hitInfo As GridHitInfo = targetGrid.CalcHitInfo(hitPoint)

            Dim sourceHandles() As Integer = e.GetData(Of Integer())()

            Dim targetRowHandle As Integer = hitInfo.RowHandle
            Dim targetRowIndex As Integer = targetGrid.GetDataSourceRowIndex(targetRowHandle)

            Dim draggedRows As New List(Of DataRow)()
            For Each sourceHandle As Integer In sourceHandles
                Dim oldRowIndex As Integer = sourceGrid.GetDataSourceRowIndex(sourceHandle)
                Dim oldRow As DataRow = sourceTable.Rows(oldRowIndex)
                draggedRows.Add(oldRow)
            Next sourceHandle

            Dim newRowIndex As Integer

            Select Case e.InsertType
                Case InsertType.Before
                    newRowIndex = If(targetRowIndex > sourceHandles(sourceHandles.Length - 1), targetRowIndex - 1, targetRowIndex)
                    For i As Integer = draggedRows.Count - 1 To 0 Step -1
                        Dim oldRow As DataRow = draggedRows(i)
                        Dim newRow As DataRow = sourceTable.NewRow()
                        newRow.ItemArray = oldRow.ItemArray
                        sourceTable.Rows.Remove(oldRow)
                        sourceTable.Rows.InsertAt(newRow, newRowIndex)
                    Next i
                Case InsertType.After
                    newRowIndex = If(targetRowIndex < sourceHandles(0), targetRowIndex + 1, targetRowIndex)
                    For i As Integer = 0 To draggedRows.Count - 1
                        Dim oldRow As DataRow = draggedRows(i)
                        Dim newRow As DataRow = sourceTable.NewRow()
                        newRow.ItemArray = oldRow.ItemArray
                        sourceTable.Rows.Remove(oldRow)
                        sourceTable.Rows.InsertAt(newRow, newRowIndex)
                    Next i
                Case Else
                    newRowIndex = -1
            End Select
            Dim insertedIndex As Integer = targetGrid.GetRowHandle(newRowIndex)
            targetGrid.FocusedRowHandle = insertedIndex
            targetGrid.SelectRow(targetGrid.FocusedRowHandle)
        End Sub
    End Class
End Namespace