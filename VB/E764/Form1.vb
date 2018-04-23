Imports Microsoft.VisualBasic
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
		Inherits System.Windows.Forms.Form
		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.AllowDrop = True
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(419, 310)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
'			Me.gridControl1.DragOver += New System.Windows.Forms.DragEventHandler(Me.gridControl1_DragOver);
'			Me.gridControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.gridControl1_DragDrop);
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
'			Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove);
'			Me.gridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseDown);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "ID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Keyword"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Order"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(425, 12)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(62, 20)
			Me.button1.TabIndex = 1
			Me.button1.Text = "&Up"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(425, 46)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(62, 20)
			Me.button2.TabIndex = 2
			Me.button2.Text = "&Down"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(499, 310)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub FillDataSet()
			dataTable1.Rows.Add(New Object() { 1, "abstract", 1 })
			dataTable1.Rows.Add(New Object() { 2, "event", 2 })
			dataTable1.Rows.Add(New Object() { 3, "new", 3 })
			dataTable1.Rows.Add(New Object() { 4, "struct", 4 })
			dataTable1.Rows.Add(New Object() { 5, "as", 5 })
			dataTable1.Rows.Add(New Object() { 6, "explicit", 6 })
			dataTable1.Rows.Add(New Object() { 7, "null", 7 })
			dataTable1.Rows.Add(New Object() { 8, "switch", 8 })
			dataTable1.Rows.Add(New Object() { 9, "base", 9 })
			dataTable1.Rows.Add(New Object() { 10, "extern", 10 })
			dataTable1.Rows.Add(New Object() { 11, "object", 11 })
			dataTable1.Rows.Add(New Object() { 12, "this", 12 })
			dataTable1.Rows.Add(New Object() { 13, "bool", 13 })
			dataTable1.Rows.Add(New Object() { 14, "false", 14 })
			dataTable1.Rows.Add(New Object() { 15, "operator", 15 })
			dataTable1.Rows.Add(New Object() { 16, "throw", 16 })
			dataTable1.Rows.Add(New Object() { 17, "break", 17 })
			dataTable1.AcceptChanges()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillDataSet()
			gridControl1.DataSource = dataTable1
			gridView1.PopulateColumns()
			gridView1.Columns(OrderFieldName).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
			gridView1.OptionsCustomization.AllowSort = False
			gridView1.OptionsView.ShowGroupPanel = False
		End Sub

		Private Const OrderFieldName As String = "Order"

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Dim view As GridView = gridView1
			view.GridControl.Focus()
			Dim index As Integer = view.FocusedRowHandle
			If index <= 0 Then
				Return
			End If

			Dim row1 As DataRow = view.GetDataRow(index)
			Dim row2 As DataRow = view.GetDataRow(index - 1)
			Dim val1 As Object = row1(OrderFieldName)
			Dim val2 As Object = row2(OrderFieldName)
			row1(OrderFieldName) = val2
			row2(OrderFieldName) = val1

			view.FocusedRowHandle = index - 1
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Dim view As GridView = gridView1
			view.GridControl.Focus()
			Dim index As Integer = view.FocusedRowHandle
			If index >= view.DataRowCount - 1 Then
				Return
			End If

			Dim row1 As DataRow = view.GetDataRow(index)
			Dim row2 As DataRow = view.GetDataRow(index + 1)
			Dim val1 As Object = row1(OrderFieldName)
			Dim val2 As Object = row2(OrderFieldName)
			row1(OrderFieldName) = val2
			row2(OrderFieldName) = val1

			view.FocusedRowHandle = index + 1
		End Sub

		Private downHitInfo As GridHitInfo = Nothing

		Private Sub gridView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView1.MouseDown
			Dim view As GridView = TryCast(sender, GridView)
			downHitInfo = Nothing

			Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
			If Control.ModifierKeys <> Keys.None Then
				Return
			End If
			If e.Button = MouseButtons.Left AndAlso hitInfo.InRow AndAlso hitInfo.RowHandle <> GridControl.NewItemRowHandle Then
				downHitInfo = hitInfo
			End If
		End Sub

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView1.MouseMove
			Dim view As GridView = TryCast(sender, GridView)
			If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
				Dim dragSize As Size = SystemInformation.DragSize
				Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width \ 2, downHitInfo.HitPoint.Y - dragSize.Height \ 2), dragSize)

				If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
					view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All)
					downHitInfo = Nothing
				End If
			End If
		End Sub

		Private Sub gridControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles gridControl1.DragOver
			If e.Data.GetDataPresent(GetType(GridHitInfo)) Then
				Dim downHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
				If downHitInfo Is Nothing Then
					Return
				End If

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

		Private Sub gridControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gridControl1.DragDrop
			Dim grid As GridControl = TryCast(sender, GridControl)
			Dim view As GridView = TryCast(grid.MainView, GridView)
			Dim srcHitInfo As GridHitInfo = TryCast(e.Data.GetData(GetType(GridHitInfo)), GridHitInfo)
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
			Dim sourceRow As Integer = srcHitInfo.RowHandle
			Dim targetRow As Integer = hitInfo.RowHandle
			MoveRow(sourceRow, targetRow)
		End Sub

		Private Sub MoveRow(ByVal sourceRow As Integer, ByVal targetRow As Integer)
			If sourceRow = targetRow OrElse sourceRow = targetRow + 1 Then
				Return
			End If

			Dim view As GridView = gridView1
			Dim row1 As DataRow = view.GetDataRow(targetRow)
			Dim row2 As DataRow = view.GetDataRow(targetRow + 1)
			Dim dragRow As DataRow = view.GetDataRow(sourceRow)
			Dim val1 As Decimal = CDec(row1(OrderFieldName))
			If row2 Is Nothing Then
				dragRow(OrderFieldName) = val1 + 1
			Else
				Dim val2 As Decimal = CDec(row2(OrderFieldName))
				dragRow(OrderFieldName) = (val1 + val2) / 2
			End If
		End Sub
	End Class
End Namespace
