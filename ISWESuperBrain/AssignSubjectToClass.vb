Imports System.Data
Imports System.Data.OleDb
Public Class AssignSubjectToClass

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Classroom Where ClassroomID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("ClassroomID", TextBox2.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Classroom Where ClassroomName = ?"
                            TextBox3.Text = reader("ClassroomName").ToString()
                        End While
                    Else
                        MsgBox("This classroom does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Class Where ClassID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("ClassID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        Dim SqlString1 As String = "Delete * From Class Where ClassID = ?"
                        Dim cmd1 As OleDbCommand = New OleDbCommand(SqlString1, conn)
                        cmd1.CommandType = CommandType.Text
                        cmd1.Parameters.AddWithValue("ClassID", TextBox1.Text)
                        cmd1.ExecuteNonQuery()
                        MsgBox("Class Information has been successfully deleted!")
                    End If
                End Using
            End Using
            conn.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Insert Into Class (ClassroomID, ClassroomName, Subject) Values (@ClassroomID, @ClassroomName, @Subject)"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@ClassroomID", TextBox2.Text)
                cmd.Parameters.AddWithValue("@ClassroomName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Subject", TextBox4.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Subject has been assigned!")
            End Using
            conn.Close()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
        End Using
    End Sub

    Private Sub btnSearchClassID_Click(sender As Object, e As EventArgs) Handles btnSearchClassID.Click
        Dim connect As String = "Provider=Microsoft.JET.OLEDB.4.0;" & "Data Source=|DataDirectory|ISWE.mdb"
        Dim SqlString As String = "Select * From Class Where ClassID = ?"
        Using conn As New OleDbConnection(connect)
            conn.Open()
            Using cmd As New OleDbCommand(SqlString, conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("ClassID", TextBox1.Text)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim SqlString1 As String = "Select * From Class Where ClassroomID = ?, ClassroomName = ?, Subject = ?"
                            TextBox2.Text = reader("ClassroomID").ToString()
                            TextBox3.Text = reader("ClassroomName").ToString()
                            TextBox4.Text = reader("Subject").ToString()
                        End While
                    Else
                        MsgBox("Class ID does not exists!")
                    End If
                End Using

            End Using
            conn.Close()
        End Using
    End Sub
End Class