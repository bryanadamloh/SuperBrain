Imports System.Data
Imports System.Data.OleDb
Public Class AssignSubjectToClass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert Into Class (ClassroomName, Subject) Values (@ClassroomName, @Subject)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ClassroomName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Subject", TextBox3.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Subject has been assigned into the Class!")
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"

    End Sub
End Class