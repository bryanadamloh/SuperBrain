Imports System.Data
Imports System.Data.OleDb

Public Class StaffLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select Count(*) From Staff Where StaffName = ? AND StaffPassword = ?"
        Dim result As Integer = 0
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.Parameters.AddWithValue("StaffName", TextBox1.Text)
                cmd.Parameters.AddWithValue("StaffPassword", TextBox2.Text)
                result = DirectCast(cmd.ExecuteScalar(), Integer)
            End Using
        End Using
        If result > 0 Then
            Me.Hide()
            MainMenu.Show()
        Else
            MsgBox("Invalid Username and Password!")
        End If
    End Sub

End Class
