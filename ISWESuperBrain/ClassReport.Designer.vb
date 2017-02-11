<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ISWEDataSet = New ISWESuperBrain.ISWEDataSet()
        Me.ClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassTableAdapter = New ISWESuperBrain.ISWEDataSetTableAdapters.ClassTableAdapter()
        Me.ClassroomNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISWEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClassroomNameDataGridViewTextBoxColumn, Me.TeacherNameDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.PeriodDateDataGridViewTextBoxColumn, Me.PeriodTimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClassBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1183, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'ISWEDataSet
        '
        Me.ISWEDataSet.DataSetName = "ISWEDataSet"
        Me.ISWEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassBindingSource
        '
        Me.ClassBindingSource.DataMember = "Class"
        Me.ClassBindingSource.DataSource = Me.ISWEDataSet
        '
        'ClassTableAdapter
        '
        Me.ClassTableAdapter.ClearBeforeFill = True
        '
        'ClassroomNameDataGridViewTextBoxColumn
        '
        Me.ClassroomNameDataGridViewTextBoxColumn.DataPropertyName = "ClassroomName"
        Me.ClassroomNameDataGridViewTextBoxColumn.HeaderText = "ClassroomName"
        Me.ClassroomNameDataGridViewTextBoxColumn.Name = "ClassroomNameDataGridViewTextBoxColumn"
        '
        'TeacherNameDataGridViewTextBoxColumn
        '
        Me.TeacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName"
        Me.TeacherNameDataGridViewTextBoxColumn.Name = "TeacherNameDataGridViewTextBoxColumn"
        Me.TeacherNameDataGridViewTextBoxColumn.Width = 150
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        Me.StudentNameDataGridViewTextBoxColumn.Width = 550
        '
        'PeriodDateDataGridViewTextBoxColumn
        '
        Me.PeriodDateDataGridViewTextBoxColumn.DataPropertyName = "PeriodDate"
        Me.PeriodDateDataGridViewTextBoxColumn.HeaderText = "PeriodDate"
        Me.PeriodDateDataGridViewTextBoxColumn.Name = "PeriodDateDataGridViewTextBoxColumn"
        '
        'PeriodTimeDataGridViewTextBoxColumn
        '
        Me.PeriodTimeDataGridViewTextBoxColumn.DataPropertyName = "PeriodTime"
        Me.PeriodTimeDataGridViewTextBoxColumn.HeaderText = "PeriodTime"
        Me.PeriodTimeDataGridViewTextBoxColumn.Name = "PeriodTimeDataGridViewTextBoxColumn"
        Me.PeriodTimeDataGridViewTextBoxColumn.Width = 140
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 261)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISWEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ISWEDataSet As ISWEDataSet
    Friend WithEvents ClassBindingSource As BindingSource
    Friend WithEvents ClassTableAdapter As ISWEDataSetTableAdapters.ClassTableAdapter
    Friend WithEvents ClassroomNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeriodTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
