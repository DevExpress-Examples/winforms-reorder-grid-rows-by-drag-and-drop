Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace SwapRows

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private gridControl1 As GridControl

        Private gridView1 As GridView

        Private dataSet1 As DataSet

        Private dataTable1 As DataTable

        Private dataColumn1 As DataColumn

        Private dataColumn2 As DataColumn

        Private dataColumn3 As DataColumn

        Private button1 As Button

        Private button2 As Button

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            gridControl1 = New GridControl()
            gridView1 = New GridView()
            dataSet1 = New DataSet()
            dataTable1 = New DataTable()
            dataColumn1 = New DataColumn()
            dataColumn2 = New DataColumn()
            dataColumn3 = New DataColumn()
            button1 = New Button()
            button2 = New Button()
            CType(gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            gridControl1.AllowDrop = True
            gridControl1.Dock = DockStyle.Left
            gridControl1.Location = New System.Drawing.Point(0, 0)
            gridControl1.MainView = gridView1
            gridControl1.Name = "gridControl1"
            gridControl1.Size = New System.Drawing.Size(419, 310)
            gridControl1.TabIndex = 0
            gridControl1.ViewCollection.AddRange(New Views.Base.BaseView() {gridView1})
            AddHandler gridControl1.DragOver, New DragEventHandler(AddressOf gridControl1_DragOver)
            AddHandler gridControl1.DragDrop, New DragEventHandler(AddressOf gridControl1_DragDrop)
            ' 
            ' gridView1
            ' 
            gridView1.GridControl = gridControl1
            gridView1.Name = "gridView1"
            gridView1.OptionsBehavior.Editable = False
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
            AddHandler gridView1.MouseMove, New MouseEventHandler(AddressOf gridView1_MouseMove)
            AddHandler gridView1.MouseDown, New MouseEventHandler(AddressOf gridView1_MouseDown)
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            dataSet1.Locale = New Globalization.CultureInfo("en-US")
            dataSet1.Tables.AddRange(New DataTable() {dataTable1})
            ' 
            ' dataTable1
            ' 
            dataTable1.Columns.AddRange(New DataColumn() {dataColumn1, dataColumn2, dataColumn3})
            dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            dataColumn1.ColumnName = "ID"
            dataColumn1.DataType = GetType(Integer)
            ' 
            ' dataColumn2
            ' 
            dataColumn2.ColumnName = "Keyword"
            ' 
            ' dataColumn3
            ' 
            dataColumn3.ColumnName = "Order"
            dataColumn3.DataType = GetType(Decimal)
            ' 
            ' button1
            ' 
            button1.Location = New System.Drawing.Point(425, 12)
            button1.Name = "button1"
            button1.Size = New System.Drawing.Size(62, 20)
            button1.TabIndex = 1
            button1.Text = "&Up"
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New System.Drawing.Point(425, 46)
            button2.Name = "button2"
            button2.Size = New System.Drawing.Size(62, 20)
            button2.TabIndex = 2
            button2.Text = "&Down"
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(499, 310)
            Me.Controls.Add(button2)
            Me.Controls.Add(button1)
            Me.Controls.Add(gridControl1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub FillDataSet()
            dataTable1.Rows.Add(New Object() {1, "abstract", 1})
            dataTable1.Rows.Add(New Object() {2, "event", 2})
            dataTable1.Rows.Add(New Object() {3, "new", 3})
            dataTable1.Rows.Add(New Object() {4, "struct", 4})
            dataTable1.Rows.Add(New Object() {5, "as", 5})
            dataTable1.Rows.Add(New Object() {6, "explicit", 6})
            dataTable1.Rows.Add(New Object() {7, "null", 7})
            dataTable1.Rows.Add(New Object() {8, "switch", 8})
            dataTable1.Rows.Add(New Object() {9, "base", 9})
            dataTable1.Rows.Add(New Object() {10, "extern", 10})
            dataTable1.Rows.Add(New Object() {11, "object", 11})
            dataTable1.Rows.Add(New Object() {12, "this", 12})
            dataTable1.Rows.Add(New Object() {13, "bool", 13})
            dataTable1.Rows.Add(New Object() {14, "false", 14})
            dataTable1.Rows.Add(New Object() {15, "operator", 15})
            dataTable1.Rows.Add(New Object() {16, "throw", 16})
            dataTable1.Rows.Add(New Object() {17, "break", 17})
            dataTable1.AcceptChanges()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillDataSet()
            gridControl1.DataSource = dataTable1
            gridView1.PopulateColumns()
            gridView1.Columns(OrderFieldName).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gridView1.OptionsCustomization.AllowSort = False
            gridView1.OptionsView.ShowGroupPanel = False
        End Sub

        Const OrderFieldName As String = "Order"

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As GridView = gridView1
            view.GridControl.Focus()
            Dim index As Integer = view.FocusedRowHandle
            If index <= 0 Then Return
            Dim row1 As DataRow = view.GetDataRow(index)
            Dim row2 As DataRow = view.GetDataRow(index - 1)
            Dim val1 As Object = row1(OrderFieldName)
            Dim val2 As Object = row2(OrderFieldName)
            row1(OrderFieldName) = val2
            row2(OrderFieldName) = val1
            view.FocusedRowHandle = index - 1
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As GridView = gridView1
            view.GridControl.Focus()
            Dim index As Integer = view.FocusedRowHandle
            If index >= view.DataRowCount - 1 Then Return
            Dim row1 As DataRow = view.GetDataRow(index)
            Dim row2 As DataRow = view.GetDataRow(index + 1)
            Dim val1 As Object = row1(OrderFieldName)
            Dim val2 As Object = row2(OrderFieldName)
            row1(OrderFieldName) = val2
            row2(OrderFieldName) = val1
            view.FocusedRowHandle = index + 1
        End Sub

        Private downHitInfo As GridHitInfo = Nothing

        Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            downHitInfo = Nothing
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
            If ModifierKeys <> Keys.None Then Return
            If e.Button = MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.RowHandle <> GridControl.NewItemRowHandle Then downHitInfo = hitInfo
        End Sub

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
                Dim dragSize As Size = SystemInformation.DragSize
                Dim dragRect As Rectangle = New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width \ 2, downHitInfo.HitPoint.Y - dragSize.Height \ 2), dragSize)
                If Not dragRect.Contains(New Point(e.X, e.Y)) Then
                    view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All)
                    downHitInfo = Nothing
                End If
            End If
        End Sub

        Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            If e.Data.GetDataPresent(GetType(GridHitInfo)) Then
                Dim downHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
                If downHitInfo Is Nothing Then Return
                Dim grid As GridControl = TryCast(sender, GridControl)
                Dim view As GridView = TryCast(grid.MainView, GridView)
                Dim hitInfo As GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
                If hitInfo.InRow AndAlso hitInfo.RowHandle <> downHitInfo.RowHandle AndAlso hitInfo.RowHandle <> GridControl.NewItemRowHandle Then
                    e.Effect = DragDropEffects.Move
                Else
                    e.Effect = DragDropEffects.None
                End If
            End If
        End Sub

        Private Sub gridControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Dim grid As GridControl = TryCast(sender, GridControl)
            Dim view As GridView = TryCast(grid.MainView, GridView)
            Dim srcHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
            Dim sourceRow As Integer = srcHitInfo.RowHandle
            Dim targetRow As Integer = hitInfo.RowHandle
            MoveRow(sourceRow, targetRow)
        End Sub

        Private Sub MoveRow(ByVal sourceRow As Integer, ByVal targetRow As Integer)
            If sourceRow = targetRow OrElse sourceRow = targetRow + 1 Then Return
            Dim view As GridView = gridView1
            Dim row1 As DataRow = view.GetDataRow(targetRow)
            Dim row2 As DataRow = view.GetDataRow(targetRow + 1)
            Dim dragRow As DataRow = view.GetDataRow(sourceRow)
            Dim val1 As Decimal = CDec(row1(OrderFieldName))
            If row2 Is Nothing Then
                dragRow(OrderFieldName) = val1 + 1
            Else
                Dim val2 As Decimal = CDec(row2(OrderFieldName))
                dragRow(OrderFieldName) =(val1 + val2) / 2
            End If
        End Sub
    End Class
End Namespace
