using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SwapRows
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if ( disposing )
			{
				if ( components != null )
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.dataSet1 = new System.Data.DataSet();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.AllowDrop = true;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(419, 310);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			this.gridControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragOver);
			this.gridControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridControl1_DragDrop);
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
			this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
			// 
			// dataTable1
			// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
			this.dataTable1.TableName = "Table1";
			// 
			// dataColumn1
			// 
			this.dataColumn1.ColumnName = "ID";
			this.dataColumn1.DataType = typeof(int);
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "Keyword";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "Order";
			this.dataColumn3.DataType = typeof(decimal);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(425, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 20);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Up";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(425, 46);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 20);
			this.button2.TabIndex = 2;
			this.button2.Text = "&Down";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(499, 310);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		void FillDataSet()
		{
			dataTable1.Rows.Add(new object[] { 1, "abstract", 1 });
			dataTable1.Rows.Add(new object[] { 2, "event", 2 });
			dataTable1.Rows.Add(new object[] { 3, "new", 3 });
			dataTable1.Rows.Add(new object[] { 4, "struct", 4 });
			dataTable1.Rows.Add(new object[] { 5, "as", 5 });
			dataTable1.Rows.Add(new object[] { 6, "explicit", 6 });
			dataTable1.Rows.Add(new object[] { 7, "null", 7 });
			dataTable1.Rows.Add(new object[] { 8, "switch", 8 });
			dataTable1.Rows.Add(new object[] { 9, "base", 9 });
			dataTable1.Rows.Add(new object[] { 10, "extern", 10 });
			dataTable1.Rows.Add(new object[] { 11, "object", 11 });
			dataTable1.Rows.Add(new object[] { 12, "this", 12 });
			dataTable1.Rows.Add(new object[] { 13, "bool", 13 });
			dataTable1.Rows.Add(new object[] { 14, "false", 14 });
			dataTable1.Rows.Add(new object[] { 15, "operator", 15 });
			dataTable1.Rows.Add(new object[] { 16, "throw", 16 });
			dataTable1.Rows.Add(new object[] { 17, "break", 17 });
			dataTable1.AcceptChanges();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			FillDataSet();
			gridControl1.DataSource = dataTable1;
			gridView1.PopulateColumns();
			gridView1.Columns[OrderFieldName].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
			gridView1.OptionsCustomization.AllowSort = false;
			gridView1.OptionsView.ShowGroupPanel = false;
		}

		const string OrderFieldName = "Order";

		private void button1_Click(object sender, System.EventArgs e)
		{
			GridView view = gridView1;
			view.GridControl.Focus();
			int index = view.FocusedRowHandle;
			if ( index <= 0 )
				return;

			DataRow row1 = view.GetDataRow(index);
			DataRow row2 = view.GetDataRow(index - 1);
			object val1 = row1[OrderFieldName];
			object val2 = row2[OrderFieldName];
			row1[OrderFieldName] = val2;
			row2[OrderFieldName] = val1;

			view.FocusedRowHandle = index - 1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			GridView view = gridView1;
			view.GridControl.Focus();
			int index = view.FocusedRowHandle;
			if ( index >= view.DataRowCount - 1 )
				return;

			DataRow row1 = view.GetDataRow(index);
			DataRow row2 = view.GetDataRow(index + 1);
			object val1 = row1[OrderFieldName];
			object val2 = row2[OrderFieldName];
			row1[OrderFieldName] = val2;
			row2[OrderFieldName] = val1;

			view.FocusedRowHandle = index + 1;
		}

		GridHitInfo downHitInfo = null;

		private void gridView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			GridView view = sender as GridView;
			downHitInfo = null;

			GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
			if ( Control.ModifierKeys != Keys.None )
				return;
			if ( e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle )
				downHitInfo = hitInfo;
		}

		private void gridView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			GridView view = sender as GridView;
			if ( e.Button == MouseButtons.Left && downHitInfo != null )
			{
				Size dragSize = SystemInformation.DragSize;
				Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
					downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

				if ( !dragRect.Contains(new Point(e.X, e.Y)) )
				{
					view.GridControl.DoDragDrop(downHitInfo, DragDropEffects.All);
					downHitInfo = null;
				}
			}
		}

		private void gridControl1_DragOver(object sender, DragEventArgs e)
		{
			if ( e.Data.GetDataPresent(typeof(GridHitInfo)) )
			{
				GridHitInfo downHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
				if ( downHitInfo == null )
					return;

				GridControl grid = sender as GridControl;
				GridView view = grid.MainView as GridView;
				GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
				if ( hitInfo.InRow && hitInfo.RowHandle != downHitInfo.RowHandle && hitInfo.RowHandle != GridControl.NewItemRowHandle )
					e.Effect = DragDropEffects.Move;
				else
					e.Effect = DragDropEffects.None;
			}
		}

		private void gridControl1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			GridControl grid = sender as GridControl;
			GridView view = grid.MainView as GridView;
			GridHitInfo srcHitInfo = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
			GridHitInfo hitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
			int sourceRow = srcHitInfo.RowHandle;
			int targetRow = hitInfo.RowHandle;
			MoveRow(sourceRow, targetRow);
		}

		private void MoveRow(int sourceRow, int targetRow)
		{
			if ( sourceRow == targetRow || sourceRow == targetRow + 1 )
				return;

			GridView view = gridView1;
			DataRow row1 = view.GetDataRow(targetRow);
			DataRow row2 = view.GetDataRow(targetRow + 1);
			DataRow dragRow = view.GetDataRow(sourceRow);
			decimal val1 = (decimal)row1[OrderFieldName];
			if ( row2 == null )
				dragRow[OrderFieldName] = val1 + 1;
			else
			{
				decimal val2 = (decimal)row2[OrderFieldName];
				dragRow[OrderFieldName] = (val1 + val2) / 2;
			}
		}
	}
}
