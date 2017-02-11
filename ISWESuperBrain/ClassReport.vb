Public Class ClassReport
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ISWEDataSet._Class' table. You can move, or remove it, as needed.
        Me.ClassTableAdapter.Fill(Me.ISWEDataSet._Class)

    End Sub
End Class